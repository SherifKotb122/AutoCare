using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoCare.models;
using System.Collections.ObjectModel;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoCare
{
    public partial class ucSuppliesBill : DevExpress.XtraEditors.XtraUserControl
    {
        public static ObservableCollection<TempBillItem> billItems = new ObservableCollection<TempBillItem>();

        public static CenterContext context = new CenterContext();

        private static ucSuppliesBill _instance;

        public static ucSuppliesBill Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucSuppliesBill();

                return _instance;
            }
        }

        public ucSuppliesBill()
        {
            InitializeComponent();

            gcBillItems.DataSource = billItems;
            supplierBindingSource.DataSource = context.Suppliers.ToList();

            teGetItem.Focus();
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            // if I put a datasource like context.clients, I can change the DataRow with Client using explicit cast
            // DataRow row = gridView1.GetDataRow(e.RowHandle);
            // int id = row.Field<int>("ID");
            
            //XtraMessageBox.Show(gridView1.Columns["itemTotal"].SummaryItem.SummaryValue.ToString());
        }

        private void teGetItem_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                List<Item> items = context.Items.Where(I => I.itemName.Contains(teGetItem.Text)).ToList();
                if(items.Count == 1)
                {
                    AddOneItemToBill(items[0]);
                }
                else if(items.Count > 1)
                {
                    ItemsContainSubstring itemsContainSubstring = new ItemsContainSubstring(this);
                    itemsContainSubstring.ShowDialog();
                }
                else
                {
                    if (XtraMessageBox.Show("هذه المعدة غير موجودة بالمخزن\n هل تريد اضافة معدة جديدة؟", "جديد", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        NewItemForm newItemForm = new NewItemForm(this);
                        newItemForm.ShowDialog();
                    }
                }

                teGetItem.Text = string.Empty;
                teGetItem.Focus();
            }
        }

        public void AddOneItemToBill(Item i)
        {
            foreach (var item in billItems)
            {
                if (item.itemName == i.itemName)
                {
                    XtraMessageBox.Show("هذه المعدة مضافة بالفعل للفاتورة, يمكنك تعديل الكمية بدلا من اضافتها مرة ثانية");
                    return;
                }
            }
            
            billItems.Add(new TempBillItem() { 
                itemID = i.itemID,
                itemName = i.itemName,
                itemModel = i.itemModel,
                itemQuantity = 1,
                itemCost = i.itemCost,
                itemPrice = i.itemPrice
            });
            txtTotalBefore.Text = (double.Parse(txtTotalBefore.Text) + i.itemCost).ToString();
            txtTotalAfter.Text = txtCash.Text = (double.Parse(txtTotalBefore.Text) - double.Parse(txtTotalBefore.Text) * float.Parse(txtDiscount.Text) / 100).ToString();
        }

        private void sbAddNewItem_Click(object sender, EventArgs e)
        {
            NewItemForm newItemForm = new NewItemForm(this);
            newItemForm.ShowDialog();
        }

        private void txtDiscount_EditValueChanged(object sender, EventArgs e)
        {
            txtTotalAfter.Text = txtCash.Text = (double.Parse(txtTotalBefore.Text) - double.Parse(txtTotalBefore.Text) * float.Parse(txtDiscount.Text) / 100).ToString();
        }

        private void lookUpSuppliers_EditValueChanged(object sender, EventArgs e)
        {
            Supplier supplier = lookUpSuppliers.GetSelectedDataRow() as Supplier;
            txtMobile.Text = supplier.supplierPhoneNumber;
            txtAddress.Text = supplier.supplierAddress;
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            float oldValue = float.Parse(gridView1.ActiveEditor.OldEditValue.ToString());
            float newValue = float.Parse(gridView1.ActiveEditor.EditValue.ToString());

            if (e.Column.FieldName == "itemQuantity")
            {
                double cost = ((Item)gridView1.GetFocusedRow()).itemCost;

                txtTotalBefore.Text = (double.Parse(txtTotalBefore.Text) + (newValue - oldValue) * cost).ToString();
            }
            else
            {
                double quantity = (double)((Item)gridView1.GetFocusedRow()).itemQuantity;

                txtTotalBefore.Text = (double.Parse(txtTotalBefore.Text) + (newValue - oldValue) * quantity).ToString();
            }

            txtTotalAfter.Text = txtCash.Text = (double.Parse(txtTotalBefore.Text) - double.Parse(txtTotalBefore.Text) * float.Parse(txtDiscount.Text) / 100).ToString();
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete /*&& e.Modifiers == Keys.Control*/)
            {
                GridView view = sender as GridView;
                float deletedTotal = float.Parse(view.GetFocusedRowCellValue("itemTotal").ToString());

                txtTotalBefore.Text = (double.Parse(txtTotalBefore.Text) - deletedTotal).ToString();
                txtTotalAfter.Text = txtCash.Text = (double.Parse(txtTotalBefore.Text) - double.Parse(txtTotalBefore.Text) * float.Parse(txtDiscount.Text) / 100).ToString();
                
                view.DeleteRow(view.FocusedRowHandle);
            }
        }

        private void sbtnSaveBill_Click(object sender, EventArgs e)
        {
            if (billItems.Count == 0)
                return;

            Supplier supplier = lookUpSuppliers.GetSelectedDataRow() as Supplier;
            SupplierBill supplierBill = new SupplierBill()
            {
                Supplier = supplier,
                billDate = DateTime.Now,
                billNotes = memoNotes.Text,
                billTotablPriceBefore = double.Parse(txtTotalBefore.Text),
                billDiscount = double.Parse(txtDiscount.Text),
                billTotablPriceAfter = double.Parse(txtTotalAfter.Text),
                billCash = double.Parse(txtCash.Text)
            };

            context.SupplierBills.Add(supplierBill);
            context.SaveChanges();

            foreach (var item in billItems)
            {
                context.SupplierBillItems.Add(new SupplierBillItem()
                {
                    billID = supplierBill.billID,
                    itemID = item.itemID,
                    itemCost = item.itemCost,
                    itemQuantity = item.itemQuantity
                });
                context.SaveChanges();

                Item storeItem = context.Items.Find(item.itemID);
                storeItem.itemQuantity = storeItem.itemQuantity + item.itemQuantity;
                context.SaveChanges();
            }

            sbtnCancelBill_Click(sender, e);
        }

        private void sbtnCancelBill_Click(object sender, EventArgs e)
        {
            foreach (var item in layoutControl1.Controls.OfType<TextEdit>())
            {
                item.Text = string.Empty;
            }

            foreach (var item in tablePanel1.Controls.OfType<TextEdit>())
            {
                item.Text = string.Empty;
            }
            lookUpSuppliers.Text = string.Empty;

            foreach (var item in tablePanel2.Controls.OfType<TextEdit>())
            {
                item.Text = "0";
            }
            memoNotes.Text = string.Empty;
            txtTotalAfter.Text = "0";
            txtCash.Text = "0";
            billItems.Clear();
        }

        //private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        //{
        //    // if I put a datasource like context.clients, I can change the DataRow with Client using explicit cast
        //    // DataRow row = gridView1.GetDataRow(e.RowHandle);
        //    // int id = row.Field<int>("ID");
        //}
    }

    [NotMapped]
    public class TempBillItem : Item {}
}
