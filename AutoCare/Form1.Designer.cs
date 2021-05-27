
namespace AutoCare
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Container = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acMaintenanceBill = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acSuppliesBill = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator1 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.acDisplayBills = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acRepository = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acClients = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acSuppliers = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acWorkers = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acFinance = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // Container
            // 
            this.Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container.Location = new System.Drawing.Point(0, 33);
            this.Container.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Container.Name = "Container";
            this.Container.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Container.Size = new System.Drawing.Size(1113, 744);
            this.Container.TabIndex = 0;
            this.Container.Click += new System.EventHandler(this.Container_Click);
            // 
            // accordionControl1
            // 
            this.accordionControl1.Appearance.AccordionControl.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.AccordionControl.Options.UseFont = true;
            this.accordionControl1.Appearance.Group.Normal.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.Group.Normal.Options.UseFont = true;
            this.accordionControl1.Appearance.Item.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.Item.Normal.Options.UseFont = true;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1,
            this.acRepository,
            this.acClients,
            this.acSuppliers,
            this.acWorkers,
            this.acFinance});
            this.accordionControl1.Location = new System.Drawing.Point(1113, 33);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(375, 744);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.acMaintenanceBill,
            this.acSuppliesBill,
            this.accordionControlSeparator1,
            this.acDisplayBills});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "الفواتير";
            // 
            // acMaintenanceBill
            // 
            this.acMaintenanceBill.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("acMaintenanceBill.ImageOptions.Image")));
            this.acMaintenanceBill.Name = "acMaintenanceBill";
            this.acMaintenanceBill.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acMaintenanceBill.Text = "فاتورة صيانة";
            this.acMaintenanceBill.Click += new System.EventHandler(this.acMaintenanceBill_Click);
            // 
            // acSuppliesBill
            // 
            this.acSuppliesBill.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("acSuppliesBill.ImageOptions.Image")));
            this.acSuppliesBill.Name = "acSuppliesBill";
            this.acSuppliesBill.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acSuppliesBill.Text = "فاتورة طلبيات";
            this.acSuppliesBill.Click += new System.EventHandler(this.acSuppliesBill_Click);
            // 
            // accordionControlSeparator1
            // 
            this.accordionControlSeparator1.Name = "accordionControlSeparator1";
            // 
            // acDisplayBills
            // 
            this.acDisplayBills.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("acDisplayBills.ImageOptions.Image")));
            this.acDisplayBills.Name = "acDisplayBills";
            this.acDisplayBills.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acDisplayBills.Text = "عرض الفواتير";
            this.acDisplayBills.Click += new System.EventHandler(this.acDisplayBills_Click);
            // 
            // acRepository
            // 
            this.acRepository.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("acRepository.ImageOptions.Image")));
            this.acRepository.Name = "acRepository";
            this.acRepository.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acRepository.Text = "المخزن";
            this.acRepository.Click += new System.EventHandler(this.acRepository_Click);
            // 
            // acClients
            // 
            this.acClients.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("acClients.ImageOptions.Image")));
            this.acClients.Name = "acClients";
            this.acClients.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acClients.Text = "العملاء";
            this.acClients.Click += new System.EventHandler(this.acClients_Click);
            // 
            // acSuppliers
            // 
            this.acSuppliers.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("acSuppliers.ImageOptions.Image")));
            this.acSuppliers.Name = "acSuppliers";
            this.acSuppliers.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acSuppliers.Text = "الموردين";
            this.acSuppliers.Click += new System.EventHandler(this.acSuppliers_Click);
            // 
            // acWorkers
            // 
            this.acWorkers.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("acWorkers.ImageOptions.Image")));
            this.acWorkers.Name = "acWorkers";
            this.acWorkers.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acWorkers.Text = "العمالة";
            this.acWorkers.Click += new System.EventHandler(this.acWorkers_Click);
            // 
            // acFinance
            // 
            this.acFinance.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("acFinance.ImageOptions.Image")));
            this.acFinance.Name = "acFinance";
            this.acFinance.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acFinance.Text = "الحسابات";
            this.acFinance.Visible = false;
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1488, 33);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.DockingEnabled = false;
            this.fluentFormDefaultManager1.Form = this;
            // 
            // Form1
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 777);
            this.ControlContainer = this.Container;
            this.Controls.Add(this.Container);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.NavigationControl = this.accordionControl1;
            this.Text = "180AutoCare";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer Container;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acSuppliesBill;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acDisplayBills;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acRepository;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acClients;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acSuppliers;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acWorkers;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acFinance;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acMaintenanceBill;
    }
}

