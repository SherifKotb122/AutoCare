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

namespace AutoCare
{
    public partial class customerItem : DevExpress.XtraEditors.XtraForm
    {
        CenterContext context = new CenterContext();
        public customerItem()
        {
            InitializeComponent();
        }
        int z = int.Parse(ucDisplayBills.SetValueForText1);
        private void customerItem_Load(object sender, EventArgs e)
        {
            labelControl5.Text = ucDisplayBills.SetValueForText1;
            //SupplierBill  x = context.SupplierBills.Where(d => d.billID == int.Parse(ucDisplayBills.SetValueForText1)).FirstOrDefault();
            ClientBill xc = context.ClientBills.Find(z);

            labelControl6.Text = (xc.billDate.ToString()).Substring(0, 10);
            labelControl16.Text = xc.Client.clientName;
            labelControl15.Text = " ";
            labelControl14.Text = xc.Client.clientPhoneNumber;

            clientBillItemBindingSource.DataSource = context.ClientBillItems.Where(v => v.billID == z).ToList();
            itemBindingSource.DataSource = context.Items.ToList();

        }
    }
}