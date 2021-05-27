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

namespace AutoCare
{
    public partial class NewItemForm : DevExpress.XtraEditors.XtraForm
    {
        ucSuppliesBill ucSuppliesBill;

        public NewItemForm(ucSuppliesBill suppliesBill)
        {
            InitializeComponent();

            ucSuppliesBill = suppliesBill;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            foreach (var item in layoutControl1.Controls.OfType<TextEdit>())
            {
                if (string.IsNullOrWhiteSpace(item.Text))
                {
                    XtraMessageBox.Show("يجب استكمال باقي الخانات");
                    return;
                }
            }

                if(ucSuppliesBill.context.Items.FirstOrDefault(I=>I.itemName == txtName.Text) != null)
                {
                    XtraMessageBox.Show("هذه المعدة موجودة بالفعل في المخزن, لايمكن اضافتها مرة ثانية");
                    return;
                }

                foreach (var it in ucSuppliesBill.billItems)
                {
                    if (it.itemName == txtName.Text)
                    {
                        XtraMessageBox.Show("هذه المعدة مضافة بالفعل للفاتورة, يمكنك تعديل الكمية بدلا من اضافتها مرة ثانية");
                        return;
                    }
                }

                ucSuppliesBill.context.Items.Add(new models.Item()
                {
                    itemName = txtName.Text,
                    itemQuantity = 0,
                    itemModel = txtModel.Text,
                    itemCost = double.Parse(txtCost.Text),
                    itemPrice = double.Parse(txtPrice.Text)
                });

                ucSuppliesBill.context.SaveChanges();
                ucSuppliesBill.AddOneItemToBill(ucSuppliesBill.context.Items.First(I=>I.itemName == txtName.Text));

                Close();
            
        }
    }
}