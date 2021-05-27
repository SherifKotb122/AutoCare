using DevExpress.XtraBars;
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
    public partial class Form1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Form1()
        {
            InitializeComponent();

            Container.Controls.Add(ucMaintenanceBill.Instance);
            ucMaintenanceBill.Instance.Dock = DockStyle.Fill;
            ucMaintenanceBill.Instance.BringToFront();
        }

        private void acMaintenanceBill_Click(object sender, EventArgs e)
        {
            if (!Container.Controls.Contains(ucMaintenanceBill.Instance))
            {
                Container.Controls.Add(ucMaintenanceBill.Instance);
                ucMaintenanceBill.Instance.Dock = DockStyle.Fill;
            }
            ucMaintenanceBill.Instance.BringToFront();
        }

        private void acSuppliesBill_Click(object sender, EventArgs e)
        {
            if (!Container.Controls.Contains(ucSuppliesBill.Instance))
            {
                Container.Controls.Add(ucSuppliesBill.Instance);
                ucSuppliesBill.Instance.Dock = DockStyle.Fill;
            }
            ucSuppliesBill.Instance.BringToFront();
        }

        private void acDisplayBills_Click(object sender, EventArgs e)
        {
            if (!Container.Controls.Contains(ucDisplayBills.Instance))
            {
                Container.Controls.Add(ucDisplayBills.Instance);
                ucDisplayBills.Instance.Dock = DockStyle.Fill;
            }
            ucDisplayBills.Instance.BringToFront();
        }

        private void acRepository_Click(object sender, EventArgs e)
        {
            //if (!Container.Controls.Contains(ucRepository.Instance))
            //{
            //    Container.Controls.Add(ucRepository.Instance);
            //    ucRepository.Instance.Dock = DockStyle.Fill;
            //}
            //ucRepository.Instance.BringToFront();
            ucRepository repository = new ucRepository();
            Container.Controls.Add(repository);
            repository.Dock = DockStyle.Fill;
            repository.BringToFront();
        }

        private void acClients_Click(object sender, EventArgs e)
        {
            if (!Container.Controls.Contains(ucClients.Instance))
            {
                Container.Controls.Add(ucClients.Instance);
                ucClients.Instance.Dock = DockStyle.Fill;
            }
            ucClients.Instance.BringToFront();
        }

        private void acSuppliers_Click(object sender, EventArgs e)
        {
            if (!Container.Controls.Contains(ucSuppliers.Instance))
            {
                Container.Controls.Add(ucSuppliers.Instance);
                ucSuppliers.Instance.Dock = DockStyle.Fill;
            }
            ucSuppliers.Instance.BringToFront();
        }

        private void acWorkers_Click(object sender, EventArgs e)
        {
            if (!Container.Controls.Contains(ucWorkers.Instance))
            {
                Container.Controls.Add(ucWorkers.Instance);
                ucWorkers.Instance.Dock = DockStyle.Fill;
            }
            ucWorkers.Instance.BringToFront();
        }

        private void Container_Click(object sender, EventArgs e)
        {

        }
    }
}
