using AutoCare.models;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class ucSuppliers : DevExpress.XtraEditors.XtraUserControl
    {
        CenterContext ctx = new CenterContext();

        private static ucSuppliers _instance;

        public static ucSuppliers Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucSuppliers();
                return _instance;
            }
        }

        public ucSuppliers()
        {
            InitializeComponent();
        }

        private void ucSuppliers_Load(object sender, EventArgs e)
        {
            supplierBindingSource.DataSource = ctx.Suppliers.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblName.Visible = true;
            lblPhoneNumber.Visible = true;
            lblAddress.Visible = true;
            txtName.Visible = true;
            txtPhoneNumber.Visible = true;
            txtAddress.Visible = true;
            btnSave.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier() { supplierName = txtName.Text, supplierPhoneNumber = txtPhoneNumber.Text, supplierAddress = txtAddress.Text };

            if (supplier != null)
            {
                ctx.Suppliers.Add(supplier);
                try
                {
                    ctx.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("من فضلك اضف بيانات صحيحة");
                }
                supplierBindingSource.DataSource = null;
                supplierBindingSource.DataSource = ctx.Suppliers.ToList();
                txtPhoneNumber.Text = "";
                txtName.Text = "";
                txtAddress.Text = "";
                lblName.Visible = false;
                lblPhoneNumber.Visible = false;
                lblAddress.Visible = false;
                txtName.Visible = false;
                txtPhoneNumber.Visible = false;
                txtAddress.Visible = false;
                btnSave.Visible = false;
            }
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            btnEdit2.Visible = true;
            btnDelte2.Visible = true;

            //GridView gridView = gridControl1.FocusedView as GridView;
            //object row = gridView.GetRow(gridView.FocusedRowHandle);

            //Supplier supplier = (Supplier)row;

            //lblEdit.Visible = true;
            //lblNameEdit.Visible = true;
            //lblPhoneNumberEdit.Visible = true;
            //lblAddressEdit.Visible = true;
            //txtNameEdit.Visible = true;
            //txtPhoneNumberEdit.Visible = true;
            //txtAddressEdit.Visible = true;
            //btnSaveEdit.Visible = true;
            //if (row != null)
            //{
            //    lblSupplierID.Text = supplier.supplierID.ToString();
            //    txtNameEdit.Text = supplier.supplierName.ToString();
            //    txtPhoneNumberEdit.Text = supplier.supplierPhoneNumber.ToString();
            //    txtAddressEdit.Text = supplier.supplierAddress.ToString();
            //}
        }


        private void btnSaveEdit_Click_1(object sender, EventArgs e)
        {
            Supplier EditedSupplier = (from s in ctx.Suppliers
                                       where lblSupplierID.Text == s.supplierID.ToString()
                                       select s).FirstOrDefault();

            EditedSupplier.supplierName = txtNameEdit.Text;
            EditedSupplier.supplierPhoneNumber = txtPhoneNumberEdit.Text;
            EditedSupplier.supplierAddress = txtAddressEdit.Text;
            try
            {
                ctx.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("من فضلك اضف بيانات صحيحة");
            }

            supplierBindingSource.DataSource = null;
            supplierBindingSource.DataSource = ctx.Suppliers.ToList();
            
            txtNameEdit.Text = "";
            txtPhoneNumberEdit.Text = "";
            txtAddressEdit.Text = "";
            txtNameEdit.Visible = false;
            txtPhoneNumberEdit.Visible = false;
            txtAddressEdit.Visible = false;
            lblNameEdit.Visible = false;
            lblPhoneNumberEdit.Visible = false;
            lblAddressEdit.Visible = false;
            lblEdit.Visible = false;
            btnSaveEdit.Visible = false;
            btnCancel.Visible = false;
        }

        private void btnEdit2_Click(object sender, EventArgs e)
        {
            GridView gridView = gridControl1.FocusedView as GridView;
            object row = gridView.GetRow(gridView.FocusedRowHandle);

            Supplier supplier = (Supplier)row;

            lblEdit.Visible = true;
            lblNameEdit.Visible = true;
            lblPhoneNumberEdit.Visible = true;
            lblAddressEdit.Visible = true;
            txtNameEdit.Visible = true;
            txtPhoneNumberEdit.Visible = true;
            txtAddressEdit.Visible = true;
            btnSaveEdit.Visible = true;
            btnDelte2.Visible = false;
            btnEdit2.Visible = false;
            btnCancel.Visible = true;
            if (row != null)
            {
                lblSupplierID.Text = supplier.supplierID.ToString();
                txtNameEdit.Text = supplier.supplierName.ToString();
                txtPhoneNumberEdit.Text = supplier.supplierPhoneNumber.ToString();
                txtAddressEdit.Text = supplier.supplierAddress.ToString();
            }
        }

        private void btnDelte2_Click(object sender, EventArgs e)
        {
            Supplier row = gridView1.GetRow(gridView1.FocusedRowHandle) as Supplier;

            btnEdit2.Visible = false;
            btnDelte2.Visible = false;
            if (XtraMessageBox.Show($"هل انت متأكد من حذف المورد رقم {row.supplierID} ؟ ", "تأكيد", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (row != null)
                {
                    ctx.Suppliers.Remove(row);
                    try
                    {
                        ctx.SaveChanges();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("من فضلك اضف بيانات صحيحة");
                    }
                    supplierBindingSource.DataSource = null;
                    supplierBindingSource.DataSource = ctx.Suppliers.ToList();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lblSupplierID.Visible = false;
            lblEdit.Visible = false;
            lblNameEdit.Visible = false;
            txtNameEdit.Visible = false;
            txtPhoneNumberEdit.Visible = false;
            lblPhoneNumberEdit.Visible = false;
            btnSaveEdit.Visible = false;
            lblAddressEdit.Visible = false;
            txtAddressEdit.Visible = false;
            btnEdit2.Visible = false;
            btnDelte2.Visible = false;
            btnCancel.Visible = false;
        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
