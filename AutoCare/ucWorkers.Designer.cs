
namespace AutoCare
{
    partial class ucWorkers
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.txtEnd = new System.Windows.Forms.DateTimePicker();
            this.txtStart = new System.Windows.Forms.DateTimePicker();
            this.btnAddWorher = new System.Windows.Forms.Button();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lSalary = new System.Windows.Forms.Label();
            this.txtSal = new System.Windows.Forms.TextBox();
            this.lPhone = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.Label();
            this.txtboxname = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtEnddate = new System.Windows.Forms.DateTimePicker();
            this.txtStartdate = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblWorker = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnSaveUpdate = new System.Windows.Forms.Button();
            this.LblStartdate = new System.Windows.Forms.Label();
            this.lblEnddate = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colworkerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colworkerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colworkerPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colworkerSalary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colworkerStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colworkerEndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWorkerAdvancePayments = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1272, 718);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.txtEnd);
            this.panelControl3.Controls.Add(this.txtStart);
            this.panelControl3.Controls.Add(this.btnAddWorher);
            this.panelControl3.Controls.Add(this.lblStart);
            this.panelControl3.Controls.Add(this.lblEnd);
            this.panelControl3.Controls.Add(this.lSalary);
            this.panelControl3.Controls.Add(this.txtSal);
            this.panelControl3.Controls.Add(this.lPhone);
            this.panelControl3.Controls.Add(this.lname);
            this.panelControl3.Controls.Add(this.txtboxname);
            this.panelControl3.Controls.Add(this.txtPhoneNumber);
            this.panelControl3.Controls.Add(this.btnAdd);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(2, 2);
            this.panelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1268, 176);
            this.panelControl3.TabIndex = 3;
            this.panelControl3.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl3_Paint);
            // 
            // txtEnd
            // 
            this.txtEnd.CalendarFont = new System.Drawing.Font("Tahoma", 12F);
            this.txtEnd.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtEnd.Location = new System.Drawing.Point(318, 128);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(221, 32);
            this.txtEnd.TabIndex = 62;
            this.txtEnd.Visible = false;
            // 
            // txtStart
            // 
            this.txtStart.CalendarFont = new System.Drawing.Font("Tahoma", 12F);
            this.txtStart.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtStart.Location = new System.Drawing.Point(318, 60);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(221, 32);
            this.txtStart.TabIndex = 61;
            this.txtStart.Visible = false;
            // 
            // btnAddWorher
            // 
            this.btnAddWorher.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddWorher.Location = new System.Drawing.Point(1040, 19);
            this.btnAddWorher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddWorher.Name = "btnAddWorher";
            this.btnAddWorher.Size = new System.Drawing.Size(143, 50);
            this.btnAddWorher.TabIndex = 60;
            this.btnAddWorher.Text = "اضافة عامل جديد";
            this.btnAddWorher.UseVisualStyleBackColor = true;
            this.btnAddWorher.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(558, 63);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(97, 29);
            this.lblStart.TabIndex = 57;
            this.lblStart.Text = "بداية الشغل";
            this.lblStart.Visible = false;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.Location = new System.Drawing.Point(558, 122);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(99, 29);
            this.lblEnd.TabIndex = 56;
            this.lblEnd.Text = "نهاية الشغل";
            this.lblEnd.Visible = false;
            // 
            // lSalary
            // 
            this.lSalary.AutoSize = true;
            this.lSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSalary.Location = new System.Drawing.Point(939, 130);
            this.lSalary.Name = "lSalary";
            this.lSalary.Size = new System.Drawing.Size(63, 29);
            this.lSalary.TabIndex = 55;
            this.lSalary.Text = "الراتب";
            this.lSalary.Visible = false;
            // 
            // txtSal
            // 
            this.txtSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSal.Location = new System.Drawing.Point(678, 128);
            this.txtSal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSal.Name = "txtSal";
            this.txtSal.Size = new System.Drawing.Size(227, 34);
            this.txtSal.TabIndex = 54;
            this.txtSal.Visible = false;
            // 
            // lPhone
            // 
            this.lPhone.AutoSize = true;
            this.lPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPhone.Location = new System.Drawing.Point(922, 90);
            this.lPhone.Name = "lPhone";
            this.lPhone.Size = new System.Drawing.Size(101, 29);
            this.lPhone.TabIndex = 51;
            this.lPhone.Text = "رقم التليفون";
            this.lPhone.Visible = false;
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.Location = new System.Drawing.Point(936, 54);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(52, 29);
            this.lname.TabIndex = 50;
            this.lname.Text = "الاسم";
            this.lname.Visible = false;
            // 
            // txtboxname
            // 
            this.txtboxname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxname.Location = new System.Drawing.Point(678, 45);
            this.txtboxname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtboxname.Name = "txtboxname";
            this.txtboxname.Size = new System.Drawing.Size(227, 34);
            this.txtboxname.TabIndex = 49;
            this.txtboxname.Visible = false;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(678, 86);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(227, 34);
            this.txtPhoneNumber.TabIndex = 48;
            this.txtPhoneNumber.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(155, 90);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 57);
            this.btnAdd.TabIndex = 46;
            this.btnAdd.Text = "حفظ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.txtEnddate);
            this.panelControl2.Controls.Add(this.txtStartdate);
            this.panelControl2.Controls.Add(this.btnCancel);
            this.panelControl2.Controls.Add(this.btnDelete);
            this.panelControl2.Controls.Add(this.button2);
            this.panelControl2.Controls.Add(this.btnUpdate);
            this.panelControl2.Controls.Add(this.lblWorker);
            this.panelControl2.Controls.Add(this.lblId);
            this.panelControl2.Controls.Add(this.btnSaveUpdate);
            this.panelControl2.Controls.Add(this.LblStartdate);
            this.panelControl2.Controls.Add(this.lblEnddate);
            this.panelControl2.Controls.Add(this.lblSalary);
            this.panelControl2.Controls.Add(this.txtSalary);
            this.panelControl2.Controls.Add(this.lblPhone);
            this.panelControl2.Controls.Add(this.lblName);
            this.panelControl2.Controls.Add(this.txtName);
            this.panelControl2.Controls.Add(this.txtPhone);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(2, 552);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1268, 164);
            this.panelControl2.TabIndex = 2;
            this.panelControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl2_Paint);
            // 
            // txtEnddate
            // 
            this.txtEnddate.CalendarFont = new System.Drawing.Font("Tahoma", 12F);
            this.txtEnddate.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtEnddate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtEnddate.Location = new System.Drawing.Point(281, 95);
            this.txtEnddate.Name = "txtEnddate";
            this.txtEnddate.Size = new System.Drawing.Size(221, 32);
            this.txtEnddate.TabIndex = 65;
            this.txtEnddate.Visible = false;
            // 
            // txtStartdate
            // 
            this.txtStartdate.CalendarFont = new System.Drawing.Font("Tahoma", 12F);
            this.txtStartdate.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtStartdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtStartdate.Location = new System.Drawing.Point(281, 40);
            this.txtStartdate.Name = "txtStartdate";
            this.txtStartdate.Size = new System.Drawing.Size(221, 32);
            this.txtStartdate.TabIndex = 64;
            this.txtStartdate.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(207, 87);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 46);
            this.btnCancel.TabIndex = 54;
            this.btnCancel.Text = "الغاء";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(134, 52);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(323, 58);
            this.btnDelete.TabIndex = 53;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1368, 160);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 28);
            this.button2.TabIndex = 52;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(633, 41);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(359, 60);
            this.btnUpdate.TabIndex = 51;
            this.btnUpdate.Text = "تعديل";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblWorker
            // 
            this.lblWorker.AutoSize = true;
            this.lblWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorker.Location = new System.Drawing.Point(1051, 64);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(123, 29);
            this.lblWorker.TabIndex = 50;
            this.lblWorker.Text = "تعديل البيانات ";
            this.lblWorker.Visible = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(66, 126);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 29);
            this.lblId.TabIndex = 49;
            this.lblId.Visible = false;
            // 
            // btnSaveUpdate
            // 
            this.btnSaveUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveUpdate.Location = new System.Drawing.Point(50, 87);
            this.btnSaveUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveUpdate.Name = "btnSaveUpdate";
            this.btnSaveUpdate.Size = new System.Drawing.Size(78, 46);
            this.btnSaveUpdate.TabIndex = 48;
            this.btnSaveUpdate.Text = "حفظ التعديل";
            this.btnSaveUpdate.UseVisualStyleBackColor = true;
            this.btnSaveUpdate.Visible = false;
            this.btnSaveUpdate.Click += new System.EventHandler(this.button4_Click);
            // 
            // LblStartdate
            // 
            this.LblStartdate.AutoSize = true;
            this.LblStartdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStartdate.Location = new System.Drawing.Point(515, 41);
            this.LblStartdate.Name = "LblStartdate";
            this.LblStartdate.Size = new System.Drawing.Size(97, 29);
            this.LblStartdate.TabIndex = 43;
            this.LblStartdate.Text = "بداية الشغل";
            this.LblStartdate.Visible = false;
            // 
            // lblEnddate
            // 
            this.lblEnddate.AutoSize = true;
            this.lblEnddate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnddate.Location = new System.Drawing.Point(515, 100);
            this.lblEnddate.Name = "lblEnddate";
            this.lblEnddate.Size = new System.Drawing.Size(99, 29);
            this.lblEnddate.TabIndex = 42;
            this.lblEnddate.Text = "نهاية الشغل";
            this.lblEnddate.Visible = false;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(929, 114);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(63, 29);
            this.lblSalary.TabIndex = 41;
            this.lblSalary.Text = "الراتب";
            this.lblSalary.Visible = false;
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(667, 106);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(227, 34);
            this.txtSalary.TabIndex = 40;
            this.txtSalary.Visible = false;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(910, 64);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(101, 29);
            this.lblPhone.TabIndex = 36;
            this.lblPhone.Text = "رقم التليفون";
            this.lblPhone.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(930, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 29);
            this.lblName.TabIndex = 35;
            this.lblName.Text = "الاسم";
            this.lblName.Visible = false;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(667, 20);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(227, 34);
            this.txtName.TabIndex = 34;
            this.txtName.Visible = false;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(667, 64);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(227, 34);
            this.txtPhone.TabIndex = 33;
            this.txtPhone.Visible = false;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.workerBindingSource;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Location = new System.Drawing.Point(2, 186);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1270, 369);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click_1);
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // workerBindingSource
            // 
            this.workerBindingSource.DataSource = typeof(AutoCare.models.Worker);
            // 
            // gridView1
            // 
            this.gridView1.ColumnPanelRowHeight = 50;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colworkerID,
            this.colworkerName,
            this.colworkerPhoneNumber,
            this.colworkerSalary,
            this.colworkerStartDate,
            this.colworkerEndDate,
            this.colWorkerAdvancePayments});
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupRowHeight = 50;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowHeight = 35;
            // 
            // colworkerID
            // 
            this.colworkerID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.colworkerID.AppearanceCell.Options.UseFont = true;
            this.colworkerID.AppearanceCell.Options.UseTextOptions = true;
            this.colworkerID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colworkerID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colworkerID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F);
            this.colworkerID.AppearanceHeader.Options.UseFont = true;
            this.colworkerID.Caption = "رقم العامل";
            this.colworkerID.FieldName = "workerID";
            this.colworkerID.MinWidth = 23;
            this.colworkerID.Name = "colworkerID";
            this.colworkerID.Visible = true;
            this.colworkerID.VisibleIndex = 0;
            this.colworkerID.Width = 87;
            // 
            // colworkerName
            // 
            this.colworkerName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.colworkerName.AppearanceCell.Options.UseFont = true;
            this.colworkerName.AppearanceCell.Options.UseTextOptions = true;
            this.colworkerName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colworkerName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colworkerName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F);
            this.colworkerName.AppearanceHeader.Options.UseFont = true;
            this.colworkerName.Caption = " اسم العامل";
            this.colworkerName.FieldName = "workerName";
            this.colworkerName.MinWidth = 23;
            this.colworkerName.Name = "colworkerName";
            this.colworkerName.Visible = true;
            this.colworkerName.VisibleIndex = 1;
            this.colworkerName.Width = 87;
            // 
            // colworkerPhoneNumber
            // 
            this.colworkerPhoneNumber.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.colworkerPhoneNumber.AppearanceCell.Options.UseFont = true;
            this.colworkerPhoneNumber.AppearanceCell.Options.UseTextOptions = true;
            this.colworkerPhoneNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colworkerPhoneNumber.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colworkerPhoneNumber.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F);
            this.colworkerPhoneNumber.AppearanceHeader.Options.UseFont = true;
            this.colworkerPhoneNumber.Caption = "رقم تليفون العامل";
            this.colworkerPhoneNumber.FieldName = "workerPhoneNumber";
            this.colworkerPhoneNumber.MinWidth = 23;
            this.colworkerPhoneNumber.Name = "colworkerPhoneNumber";
            this.colworkerPhoneNumber.Visible = true;
            this.colworkerPhoneNumber.VisibleIndex = 2;
            this.colworkerPhoneNumber.Width = 87;
            // 
            // colworkerSalary
            // 
            this.colworkerSalary.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.colworkerSalary.AppearanceCell.Options.UseFont = true;
            this.colworkerSalary.AppearanceCell.Options.UseTextOptions = true;
            this.colworkerSalary.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colworkerSalary.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colworkerSalary.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F);
            this.colworkerSalary.AppearanceHeader.Options.UseFont = true;
            this.colworkerSalary.Caption = "راتب العامل";
            this.colworkerSalary.FieldName = "workerSalary";
            this.colworkerSalary.MinWidth = 23;
            this.colworkerSalary.Name = "colworkerSalary";
            this.colworkerSalary.Visible = true;
            this.colworkerSalary.VisibleIndex = 3;
            this.colworkerSalary.Width = 87;
            // 
            // colworkerStartDate
            // 
            this.colworkerStartDate.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.colworkerStartDate.AppearanceCell.Options.UseFont = true;
            this.colworkerStartDate.AppearanceCell.Options.UseTextOptions = true;
            this.colworkerStartDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colworkerStartDate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colworkerStartDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F);
            this.colworkerStartDate.AppearanceHeader.Options.UseFont = true;
            this.colworkerStartDate.Caption = "بداية العمل";
            this.colworkerStartDate.FieldName = "workerStartDate";
            this.colworkerStartDate.MinWidth = 23;
            this.colworkerStartDate.Name = "colworkerStartDate";
            this.colworkerStartDate.Visible = true;
            this.colworkerStartDate.VisibleIndex = 4;
            this.colworkerStartDate.Width = 87;
            // 
            // colworkerEndDate
            // 
            this.colworkerEndDate.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.colworkerEndDate.AppearanceCell.Options.UseFont = true;
            this.colworkerEndDate.AppearanceCell.Options.UseTextOptions = true;
            this.colworkerEndDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colworkerEndDate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colworkerEndDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F);
            this.colworkerEndDate.AppearanceHeader.Options.UseFont = true;
            this.colworkerEndDate.Caption = "نهاية العمل ";
            this.colworkerEndDate.FieldName = "workerEndDate";
            this.colworkerEndDate.MinWidth = 23;
            this.colworkerEndDate.Name = "colworkerEndDate";
            this.colworkerEndDate.Visible = true;
            this.colworkerEndDate.VisibleIndex = 5;
            this.colworkerEndDate.Width = 87;
            // 
            // colWorkerAdvancePayments
            // 
            this.colWorkerAdvancePayments.AppearanceCell.Options.UseTextOptions = true;
            this.colWorkerAdvancePayments.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWorkerAdvancePayments.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colWorkerAdvancePayments.FieldName = "WorkerAdvancePayments";
            this.colWorkerAdvancePayments.MinWidth = 23;
            this.colWorkerAdvancePayments.Name = "colWorkerAdvancePayments";
            this.colWorkerAdvancePayments.Width = 87;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DisplayMember = "workerName";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.PopupView = this.gridView2;
            this.repositoryItemGridLookUpEdit1.ValueMember = "workerID";
            // 
            // gridView2
            // 
            this.gridView2.DetailHeight = 431;
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // ucWorkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucWorkers";
            this.Size = new System.Drawing.Size(1272, 718);
            this.Load += new System.EventHandler(this.ucWorkers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Button btnSaveUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label LblStartdate;
        private System.Windows.Forms.Label lblEnddate;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource workerBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colworkerID;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colworkerName;
        private DevExpress.XtraGrid.Columns.GridColumn colworkerPhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colworkerSalary;
        private DevExpress.XtraGrid.Columns.GridColumn colworkerStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colworkerEndDate;
        private DevExpress.XtraGrid.Columns.GridColumn colWorkerAdvancePayments;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblWorker;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lSalary;
        private System.Windows.Forms.TextBox txtSal;
        private System.Windows.Forms.Label lPhone;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.TextBox txtboxname;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button btnAddWorher;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker txtEnd;
        private System.Windows.Forms.DateTimePicker txtStart;
        private System.Windows.Forms.DateTimePicker txtEnddate;
        private System.Windows.Forms.DateTimePicker txtStartdate;
    }
}
