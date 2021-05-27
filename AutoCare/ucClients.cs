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
    public partial class ucClients : DevExpress.XtraEditors.XtraUserControl
    {
        CenterContext ctx = new CenterContext();

        private static ucClients _instance;

        public static ucClients Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucClients();
                return _instance;
            }
        }

        public ucClients()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblName.Visible = true;
            lblPhoneNumber.Visible = true;
            txtName.Visible = true;
            txtPhoneNumber.Visible = true;
            btnSave.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Client client = new Client() { clientName = txtName.Text, clientPhoneNumber = txtPhoneNumber.Text };

            if (client != null)
            {
                ctx.Clients.Add(client);

                 try
                    {
                    ctx.SaveChanges();
                }
                    catch (Exception )
                    {
                        MessageBox.Show("من فضلك اضف بيانات صحيحة");
                    }
               
                clientBindingSource.DataSource = null;
                clientBindingSource.DataSource = ctx.Clients.ToList();
                txtPhoneNumber.Text = "";
                txtName.Text = "";
                lblName.Visible = false;
                lblPhoneNumber.Visible = false;
                txtName.Visible = false;
                txtPhoneNumber.Visible = false;
                lblEdit.Visible = false;
                btnSave.Visible = false;
            }
        }

        private void ucClients_Load_1(object sender, EventArgs e)
        {
            clientBindingSource.DataSource = ctx.Clients.ToList();
        }


        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            btnEdit2.Visible = true;
            btnDelte2.Visible = true;
        }

        private void btnSaveEdit_Click_1(object sender, EventArgs e)
        {
            Client EditedClient = (from c in ctx.Clients
                                   where lblClientID.Text == c.clientID.ToString()
                                   select c).FirstOrDefault();

            EditedClient.clientName = txtNameEdit.Text;
            EditedClient.clientPhoneNumber = txtPhoneNumberEdit.Text;

            try
            {
                ctx.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("من فضلك اضف بيانات صحيحة");
            }
            clientBindingSource.DataSource = null;
            clientBindingSource.DataSource = ctx.Clients.ToList();
            txtNameEdit.Text = "";
            txtPhoneNumberEdit.Text = "";
            txtNameEdit.Visible = false;
            txtPhoneNumberEdit.Visible = false;
            lblNameEdit.Visible = false;
            lblPhoneNumberEdit.Visible = false;
            lblEdit.Visible = false;
            btnSaveEdit.Visible = false;
            btnCancel.Visible = false;
        }

        private void btnEdit2_Click(object sender, EventArgs e)
        {
            btnEdit2.Visible = false;
            btnDelte2.Visible = false;

            GridView gridView = gridControl1.FocusedView as GridView;
            object row = gridView.GetRow(gridView.FocusedRowHandle);
            Client client = (Client)row;
            lblEdit.Visible = true;
            lblNameEdit.Visible = true;
            lblPhoneNumberEdit.Visible = true;
            txtNameEdit.Visible = true;
            txtPhoneNumberEdit.Visible = true;
            btnSaveEdit.Visible = true;
            btnCancel.Visible = true;
            if (row != null)
            {
                lblClientID.Text = client.clientID.ToString();
                txtNameEdit.Text = client.clientName.ToString();
                txtPhoneNumberEdit.Text = client.clientPhoneNumber.ToString();
            }
        }

        private void btnDelte2_Click(object sender, EventArgs e)
        {
            Client row = gridView1.GetRow(gridView1.FocusedRowHandle) as Client;
            btnEdit2.Visible = false;
            btnDelte2.Visible = false;
            if (XtraMessageBox.Show($"هل انت متأكد من حذف العميل رقم {row.clientID} ؟ ", "تأكيد ",
                MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                if (row != null)
                {
                    ctx.Clients.Remove(row);
                    try
                    {
                        ctx.SaveChanges();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("من فضلك اضف بيانات صحيحة");
                    }
                    clientBindingSource.DataSource = null;
                    clientBindingSource.DataSource = ctx.Clients.ToList();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lblClientID.Visible = false;
            lblEdit.Visible = false;
            lblNameEdit.Visible = false;
            txtNameEdit.Visible = false;
            txtPhoneNumberEdit.Visible = false;
            lblPhoneNumberEdit.Visible = false;
            btnSaveEdit.Visible = false;
            btnEdit2.Visible = false;
            btnDelte2.Visible = false;
            btnCancel.Visible = false;
        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
