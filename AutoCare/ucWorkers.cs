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
    public partial class ucWorkers : DevExpress.XtraEditors.XtraUserControl
    {
        CenterContext context = new CenterContext();
        private static ucWorkers _instance;

        public static ucWorkers Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucWorkers();
                return _instance;
            }
        }

        public ucWorkers()
        {
            InitializeComponent();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Worker worker = new Worker()
                {
                    workerName = txtboxname.Text,
                    workerPhoneNumber = txtPhoneNumber.Text,
                    workerSalary = int.Parse(txtSal.Text),
                    workerStartDate = Convert.ToDateTime(txtStart.Text),
                    workerEndDate = Convert.ToDateTime(txtEnd.Text)
                };
                                if (worker != null)
                {
                    context.Workers.Add(worker);
                    context.SaveChanges();

                    workerBindingSource.DataSource = null;
                    workerBindingSource.DataSource = context.Workers.ToList();

                    txtboxname.Text = "";
                    txtPhoneNumber.Text = "";
                    txtSal.Text = "";
                    txtStart.Text = "";
                    txtEnd.Text = "";
                }

            }
            catch(Exception)
            {
                MessageBox.Show("من فضلك اضف بياناالعامل كاملة ");
            }


            txtboxname.Visible = false;
            txtPhoneNumber.Visible = false;
            txtSal.Visible = false;
            txtStart.Visible = false;
            txtEnd.Visible = false;

            lname.Visible = false;
            lSalary.Visible = false;
            lPhone.Visible = false;
            lblStart.Visible = false;
            lblEnd.Visible = false;

            btnAdd.Visible = false;

        }

        private void ucWorkers_Load(object sender, EventArgs e)
        {
            CenterContext context = new CenterContext();
            workerBindingSource.DataSource = context.Workers.ToList();
            workerBindingSource.DataSource = context.Workers.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Worker workerUpdate = (from w in context.Workers
                                       where lblId.Text == w.workerID.ToString()
                                       select w).FirstOrDefault();

            workerUpdate.workerName = txtName.Text;
            workerUpdate.workerPhoneNumber = txtPhone.Text;
            workerUpdate.workerSalary = double.Parse(txtSalary.Text);
            workerUpdate.workerStartDate = Convert.ToDateTime(txtStartdate.Text);
            workerUpdate.workerEndDate = Convert.ToDateTime(txtEnddate.Text);

            try
            {
                context.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("من فضلك اضف بيانات صحيحة");
            }
            workerBindingSource.DataSource = null;
            workerBindingSource.DataSource = context.Workers.ToList();

            txtName.Text = "";
            txtPhone.Text = "";


            txtName.Visible = false;
            txtPhone.Visible = false;
            txtSalary.Visible = false;
            txtStartdate.Visible = false;
            txtEnddate.Visible = false;

            lblName.Visible = false;
            lblSalary.Visible = false;
            lblPhone.Visible = false;
            LblStartdate.Visible = false;
            lblEnddate.Visible = false;
            lblWorker.Visible = false;
            btnSaveUpdate.Visible = false;

        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {

            

            btnDelete.Visible = true;
            btnUpdate.Visible = true;

            btnSaveUpdate.Visible = false;

            txtName.Visible = false;
            txtPhone.Visible = false;
            txtSalary.Visible = false;
            txtStartdate.Visible = false;
            txtEnddate.Visible = false;


            lblName.Visible = false;
            lblPhone.Visible = false;
            lblSalary.Visible = false;
            LblStartdate.Visible = false;
            lblEnddate.Visible = false;
            lblWorker.Visible = false;



        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtboxname.Visible = true;
            txtPhoneNumber.Visible = true;
            txtSal.Visible = true;
            txtStart.Visible = true;
            txtEnd.Visible = true;

            lname.Visible = true;
            lSalary.Visible = true;
            lPhone.Visible = true;
            lblStart.Visible = true;
            lblEnd.Visible = true;

            btnAdd.Visible = true;


        }

        private void gridControl1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Worker row = gridView1.GetRow(gridView1.FocusedRowHandle) as Worker;

            btnUpdate.Visible = false;
            btnDelete.Visible = false;

            if (XtraMessageBox.Show($"هل انت متاكد من حذف العامل رقم {row.workerID}؟ ", "تاكيد",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (row != null)
                {
                    context.Workers.Remove(row);
                    context.SaveChanges();
                    workerBindingSource.DataSource = null;
                    workerBindingSource.DataSource = context.Workers.ToList();
                
                }
            
               
            
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            GridView gridView = gridControl1.FocusedView as GridView;
            object row = gridView.GetRow(gridView.FocusedRowHandle);
            Worker worker = (Worker)row;

            btnUpdate.Visible = false;
            btnDelete.Visible = false;

            btnSaveUpdate.Visible = true;

            txtName.Visible = true;
            txtPhone.Visible = true;
            txtSalary.Visible = true;
            txtStartdate.Visible = true;
            txtEnddate.Visible = true;


            lblName.Visible = true;
            lblPhone.Visible = true;
            lblSalary.Visible = true;
            LblStartdate.Visible = true;
            lblEnddate.Visible = true;
            lblWorker.Visible = true;


            if (row != null)
            {
                lblId.Text = worker.workerID.ToString();
                txtName.Text = worker.workerName.ToString();
                txtPhone.Text = worker.workerPhoneNumber.ToString();
                txtSalary.Text = worker.workerSalary.ToString();
                txtStartdate.Text = worker.workerStartDate.ToString();
                txtEnddate.Text = worker.workerEndDate.ToString();

            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void panelControl3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
