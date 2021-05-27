
namespace AutoCare
{
    partial class ucClients
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colclientID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colclientName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colclientPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelte2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit2 = new DevExpress.XtraEditors.SimpleButton();
            this.lblClientID = new DevExpress.XtraEditors.LabelControl();
            this.lblEdit = new DevExpress.XtraEditors.LabelControl();
            this.btnSaveEdit = new DevExpress.XtraEditors.SimpleButton();
            this.txtPhoneNumberEdit = new DevExpress.XtraEditors.TextEdit();
            this.lblNameEdit = new DevExpress.XtraEditors.LabelControl();
            this.lblPhoneNumberEdit = new DevExpress.XtraEditors.LabelControl();
            this.txtNameEdit = new DevExpress.XtraEditors.TextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtPhoneNumber = new DevExpress.XtraEditors.TextEdit();
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.lblPhoneNumber = new DevExpress.XtraEditors.LabelControl();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumberEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelControl1.Size = new System.Drawing.Size(1115, 658);
            this.panelControl1.TabIndex = 18;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.clientBindingSource;
            this.gridControl1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridControl1.Location = new System.Drawing.Point(3, 169);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1107, 309);
            this.gridControl1.TabIndex = 36;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(AutoCare.models.Client);
            // 
            // gridView1
            // 
            this.gridView1.ColumnPanelRowHeight = 50;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colclientID,
            this.colclientName,
            this.colclientPhoneNumber});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupRowHeight = 20;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowHeight = 50;
            // 
            // colclientID
            // 
            this.colclientID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.colclientID.AppearanceCell.Options.UseFont = true;
            this.colclientID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F);
            this.colclientID.AppearanceHeader.Options.UseFont = true;
            this.colclientID.Caption = "كود العميل";
            this.colclientID.FieldName = "clientID";
            this.colclientID.MinWidth = 25;
            this.colclientID.Name = "colclientID";
            this.colclientID.Visible = true;
            this.colclientID.VisibleIndex = 0;
            this.colclientID.Width = 94;
            // 
            // colclientName
            // 
            this.colclientName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.colclientName.AppearanceCell.Options.UseFont = true;
            this.colclientName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F);
            this.colclientName.AppearanceHeader.Options.UseFont = true;
            this.colclientName.Caption = "اسم العميل";
            this.colclientName.FieldName = "clientName";
            this.colclientName.MinWidth = 25;
            this.colclientName.Name = "colclientName";
            this.colclientName.Visible = true;
            this.colclientName.VisibleIndex = 1;
            this.colclientName.Width = 94;
            // 
            // colclientPhoneNumber
            // 
            this.colclientPhoneNumber.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.colclientPhoneNumber.AppearanceCell.Options.UseFont = true;
            this.colclientPhoneNumber.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F);
            this.colclientPhoneNumber.AppearanceHeader.Options.UseFont = true;
            this.colclientPhoneNumber.Caption = "رقم الهاتف";
            this.colclientPhoneNumber.FieldName = "clientPhoneNumber";
            this.colclientPhoneNumber.MinWidth = 25;
            this.colclientPhoneNumber.Name = "colclientPhoneNumber";
            this.colclientPhoneNumber.Visible = true;
            this.colclientPhoneNumber.VisibleIndex = 2;
            this.colclientPhoneNumber.Width = 94;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btnCancel);
            this.panelControl3.Controls.Add(this.btnDelte2);
            this.panelControl3.Controls.Add(this.btnEdit2);
            this.panelControl3.Controls.Add(this.lblClientID);
            this.panelControl3.Controls.Add(this.lblEdit);
            this.panelControl3.Controls.Add(this.btnSaveEdit);
            this.panelControl3.Controls.Add(this.txtPhoneNumberEdit);
            this.panelControl3.Controls.Add(this.lblNameEdit);
            this.panelControl3.Controls.Add(this.lblPhoneNumberEdit);
            this.panelControl3.Controls.Add(this.txtNameEdit);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(2, 479);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1111, 177);
            this.panelControl3.TabIndex = 29;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Location = new System.Drawing.Point(223, 108);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(194, 43);
            this.btnCancel.TabIndex = 39;
            this.btnCancel.Text = "الغاء";
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelte2
            // 
            this.btnDelte2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelte2.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnDelte2.Appearance.Options.UseFont = true;
            this.btnDelte2.Location = new System.Drawing.Point(158, 36);
            this.btnDelte2.Name = "btnDelte2";
            this.btnDelte2.Size = new System.Drawing.Size(376, 66);
            this.btnDelte2.TabIndex = 38;
            this.btnDelte2.Text = "حذف";
            this.btnDelte2.Visible = false;
            this.btnDelte2.Click += new System.EventHandler(this.btnDelte2_Click);
            // 
            // btnEdit2
            // 
            this.btnEdit2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit2.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnEdit2.Appearance.Options.UseFont = true;
            this.btnEdit2.Location = new System.Drawing.Point(586, 36);
            this.btnEdit2.Name = "btnEdit2";
            this.btnEdit2.Size = new System.Drawing.Size(377, 66);
            this.btnEdit2.TabIndex = 37;
            this.btnEdit2.Text = "تعديل";
            this.btnEdit2.Visible = false;
            this.btnEdit2.Click += new System.EventHandler(this.btnEdit2_Click);
            // 
            // lblClientID
            // 
            this.lblClientID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClientID.Location = new System.Drawing.Point(940, 16);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(0, 16);
            this.lblClientID.TabIndex = 35;
            this.lblClientID.Visible = false;
            // 
            // lblEdit
            // 
            this.lblEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblEdit.Appearance.Options.UseFont = true;
            this.lblEdit.Location = new System.Drawing.Point(940, 16);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(160, 24);
            this.lblEdit.TabIndex = 34;
            this.lblEdit.Text = "تعديل بيانات العميل";
            this.lblEdit.Visible = false;
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnSaveEdit.Appearance.Options.UseFont = true;
            this.btnSaveEdit.Location = new System.Drawing.Point(23, 108);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(184, 43);
            this.btnSaveEdit.TabIndex = 33;
            this.btnSaveEdit.Text = "حفظ التعديل";
            this.btnSaveEdit.Visible = false;
            this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click_1);
            // 
            // txtPhoneNumberEdit
            // 
            this.txtPhoneNumberEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhoneNumberEdit.Location = new System.Drawing.Point(81, 57);
            this.txtPhoneNumberEdit.Name = "txtPhoneNumberEdit";
            this.txtPhoneNumberEdit.Size = new System.Drawing.Size(263, 23);
            this.txtPhoneNumberEdit.TabIndex = 30;
            this.txtPhoneNumberEdit.Visible = false;
            // 
            // lblNameEdit
            // 
            this.lblNameEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNameEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblNameEdit.Appearance.Options.UseFont = true;
            this.lblNameEdit.Location = new System.Drawing.Point(817, 57);
            this.lblNameEdit.Name = "lblNameEdit";
            this.lblNameEdit.Size = new System.Drawing.Size(99, 24);
            this.lblNameEdit.TabIndex = 31;
            this.lblNameEdit.Text = "اسم العميل";
            this.lblNameEdit.Visible = false;
            // 
            // lblPhoneNumberEdit
            // 
            this.lblPhoneNumberEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhoneNumberEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblPhoneNumberEdit.Appearance.Options.UseFont = true;
            this.lblPhoneNumberEdit.Location = new System.Drawing.Point(368, 57);
            this.lblPhoneNumberEdit.Name = "lblPhoneNumberEdit";
            this.lblPhoneNumberEdit.Size = new System.Drawing.Size(87, 24);
            this.lblPhoneNumberEdit.TabIndex = 32;
            this.lblPhoneNumberEdit.Text = "رقم الهاتف";
            this.lblPhoneNumberEdit.Visible = false;
            // 
            // txtNameEdit
            // 
            this.txtNameEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameEdit.Location = new System.Drawing.Point(539, 57);
            this.txtNameEdit.Name = "txtNameEdit";
            this.txtNameEdit.Size = new System.Drawing.Size(250, 23);
            this.txtNameEdit.TabIndex = 29;
            this.txtNameEdit.Visible = false;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.txtPhoneNumber);
            this.panelControl2.Controls.Add(this.lblName);
            this.panelControl2.Controls.Add(this.btnSave);
            this.panelControl2.Controls.Add(this.lblPhoneNumber);
            this.panelControl2.Controls.Add(this.btnAdd);
            this.panelControl2.Controls.Add(this.txtName);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1111, 161);
            this.panelControl2.TabIndex = 0;
            this.panelControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl2_Paint);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(71, 80);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(263, 23);
            this.txtPhoneNumber.TabIndex = 19;
            this.txtPhoneNumber.Visible = false;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblName.Appearance.Options.UseFont = true;
            this.lblName.Location = new System.Drawing.Point(807, 80);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(119, 29);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "اسم العميل";
            this.lblName.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(23, 119);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(151, 29);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "حفظ";
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhoneNumber.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblPhoneNumber.Appearance.Options.UseFont = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(358, 80);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(105, 29);
            this.lblPhoneNumber.TabIndex = 21;
            this.lblPhoneNumber.Text = "رقم الهاتف";
            this.lblPhoneNumber.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Location = new System.Drawing.Point(902, 27);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(151, 47);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "اضافة عميل";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(529, 80);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 23);
            this.txtName.TabIndex = 18;
            this.txtName.Visible = false;
            // 
            // ucClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "ucClients";
            this.Size = new System.Drawing.Size(1115, 658);
            this.Load += new System.EventHandler(this.ucClients_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumberEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.TextEdit txtPhoneNumber;
        private DevExpress.XtraEditors.LabelControl lblName;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl lblPhoneNumber;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.TextEdit txtName;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colclientID;
        private DevExpress.XtraGrid.Columns.GridColumn colclientName;
        private DevExpress.XtraGrid.Columns.GridColumn colclientPhoneNumber;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LabelControl lblClientID;
        private DevExpress.XtraEditors.LabelControl lblEdit;
        private DevExpress.XtraEditors.SimpleButton btnSaveEdit;
        private DevExpress.XtraEditors.TextEdit txtPhoneNumberEdit;
        private DevExpress.XtraEditors.LabelControl lblNameEdit;
        private DevExpress.XtraEditors.LabelControl lblPhoneNumberEdit;
        private DevExpress.XtraEditors.TextEdit txtNameEdit;
        private DevExpress.XtraEditors.SimpleButton btnEdit2;
        private DevExpress.XtraEditors.SimpleButton btnDelte2;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}
