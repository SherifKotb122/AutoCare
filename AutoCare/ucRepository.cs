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
using DevExpress.XtraGrid.Views.Grid;

namespace AutoCare
{
    public partial class ucRepository : DevExpress.XtraEditors.XtraUserControl
    {
        public CenterContext context = new CenterContext();
        private static ucRepository _instance;

        public static ucRepository Instance
        {
            get
            {
                //if (_instance == null)
                    _instance = new ucRepository();
                return _instance;
            }
        }

        public ucRepository()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void itemName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ucRepository_Load(object sender, EventArgs e)
        {
            CenterContext context = new CenterContext();
            itemBindingSource.DataSource = context.Items.ToList();

            //itemBindingSource.DataSource = context.Items.ToList();
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            Item itemUpdate = (from d in context.Items
                               where labId.Text == d.itemID.ToString()
                               select d).FirstOrDefault();

            itemUpdate.itemName = txtName.Text;
            itemUpdate.itemModel = txtModel.Text;
            itemUpdate.itemPrice = double.Parse(txtPrice.Text);
            itemUpdate.itemCost = double.Parse(txtCost.Text);
            itemUpdate.itemQuantity = double.Parse(txtQuantity.Text);

            context.SaveChanges();

            itemBindingSource.DataSource = null;
            itemBindingSource.DataSource = context.Items.ToList();


            txtName.Text = "";
            txtModel.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
            txtCost.Text = "";

            txtName.Visible = false;
            txtModel.Visible = false;
            txtPrice.Visible = false;
            txtQuantity.Visible = false;
            txtCost.Visible = false;

            labName.Visible = false;
            labPrice.Visible = false;
            labQuantity.Visible = false;
            labModel.Visible = false;
            labCost.Visible = false;
            labEditItem.Visible = false;


            btnSave.Visible = false;





        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {

            GridView gridView = gridControl1.FocusedView as GridView;
            object row = gridView.GetRow(gridView.FocusedRowHandle);

            Item item = (Item)row;

            btnSave.Visible = true;
            txtCost.Visible = true;
            txtQuantity.Visible = true;
            txtModel.Visible = true;
            txtName.Visible = true;
            txtPrice.Visible = true;

            labName.Visible = true;
            labModel.Visible = true;
            labQuantity.Visible = true;
            labPrice.Visible = true;
            labCost.Visible = true;
            labEditItem.Visible = true;

            if (row != null)
            {
                labId.Text = item.itemID.ToString();
                txtName.Text = item.itemName;
                txtPrice.Text = item.itemPrice.ToString();
                txtModel.Text = item.itemModel;
                txtCost.Text = item.itemCost.ToString();
                txtQuantity.Text = item.itemQuantity.ToString();

            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}

