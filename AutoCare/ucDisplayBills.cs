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
    public partial class ucDisplayBills : DevExpress.XtraEditors.XtraUserControl
    {
        CenterContext x = new CenterContext();
        
        private static ucDisplayBills _instance;

        public static ucDisplayBills Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucDisplayBills();
                return _instance;
            }
        }

        public static string SetValueForText1 { get; set; }

        public ucDisplayBills()
        {
            InitializeComponent();
        }

        private void ucDisplayBills_Load(object sender, EventArgs e)
        {
            clientBillBindingSource.DataSource = x.ClientBills.ToList();
            supplierBillBindingSource.DataSource = x.SupplierBills.ToList();
            gridControl1.Visible = true;
            gridControl2.Visible = false;
        }
       
        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEdit1.SelectedIndex == 0)
            {
                gridControl1.Visible = true;
                gridControl2.Visible = false;

            }
            else
            {
                gridControl1.Visible = false;
                gridControl2.Visible = true;

            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
        

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }

        private void gridControl2_DoubleClick(object sender, EventArgs e)
        {

            GridView gridView = gridControl2.FocusedView as GridView;
            object row = gridView.GetRow(gridView.FocusedRowHandle);
            SupplierBill x = (SupplierBill)row;
            //MessageBox.Show(x.billID.ToString());
     
            SetValueForText1 = x.billID.ToString();
            BillItems b = new BillItems();
            b.Show();

        }
   

        private void gridControl1_DoubleClick_1(object sender, EventArgs e)
        {
            GridView gridView = gridControl1.FocusedView as GridView;
            object row = gridView.GetRow(gridView.FocusedRowHandle);
            ClientBill x = (ClientBill)row;
            //MessageBox.Show(x.billID.ToString());

            SetValueForText1 = x.billID.ToString();
            customerItem b = new customerItem();
            b.Show();
        }
    }
}
