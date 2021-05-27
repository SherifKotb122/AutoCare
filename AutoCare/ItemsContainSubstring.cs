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
    public partial class ItemsContainSubstring : DevExpress.XtraEditors.XtraForm
    {
        ucSuppliesBill ucSuppliesBill;

        public ItemsContainSubstring(ucSuppliesBill suppliesBill)
        {
            InitializeComponent();

            ucSuppliesBill = suppliesBill;
            gcBillItems.DataSource = ucSuppliesBill.context.Items.Where(I => I.itemName.Contains(ucSuppliesBill.teGetItem.Text)).ToList();
        }

        private void gcBillItems_DoubleClick(object sender, EventArgs e)
        {
            Item item = gridView1.GetRow(gridView1.FocusedRowHandle) as Item;

            ucSuppliesBill.AddOneItemToBill(item);

            Close();
        }
    }
}