using AutoCare.models;
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
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;


namespace AutoCare
{
    public partial class BillItems : DevExpress.XtraEditors.XtraForm
    {
        CenterContext context = new CenterContext();
        public BillItems()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
        int z = int.Parse(ucDisplayBills.SetValueForText1);
        private void BillItems_Load(object sender, EventArgs e)
        {
            labelControl5.Text = ucDisplayBills.SetValueForText1;
         //SupplierBill  x = context.SupplierBills.Where(d => d.billID == int.Parse(ucDisplayBills.SetValueForText1)).FirstOrDefault();
            SupplierBill xc = context.SupplierBills.Find(z);

            labelControl6.Text = (xc.billDate.ToString()).Substring(0,10);
            labelControl11.Text = xc.Supplier.supplierName;
            labelControl12.Text = xc.Supplier.supplierAddress;
            labelControl13.Text = xc.Supplier.supplierPhoneNumber;

            supplierBillItemBindingSource.DataSource = context.SupplierBillItems.Where(v => v.billID == z).ToList();
            itemBindingSource.DataSource = context.Items.ToList();
          
          
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl8_Click(object sender, EventArgs e)
        {

        }
    }
}