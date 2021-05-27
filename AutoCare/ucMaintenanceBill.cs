using AutoCare.models;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace AutoCare
{
    public partial class ucMaintenanceBill : DevExpress.XtraEditors.XtraUserControl
    {
        int BillNUM = 1;
        int clientId = 0;
        Regex regex = new Regex("^[0-9]+$");
        CenterContext centerContext = new CenterContext();
        private static ucMaintenanceBill _instance;
        Bitmap bitmap;


        public static ucMaintenanceBill Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucMaintenanceBill();
                return _instance;
            }
        }

        //public ucMaintenanceBill()
        //{
        //    InitializeComponent();
        //}
        public System.Windows.Forms.ComboBox[] price_arr = new System.Windows.Forms.ComboBox[12];
        public System.Windows.Forms.ComboBox[] items_arr = new System.Windows.Forms.ComboBox[12];

        public System.Windows.Forms.TextBox[] quantity_arr = new System.Windows.Forms.TextBox[12];
        public System.Windows.Forms.TextBox[] total_arr = new System.Windows.Forms.TextBox[12];
        public System.Windows.Forms.TextBox[] MaintenanceFees_arr = new System.Windows.Forms.TextBox[12];


        double totalPrice = 0;
        double MaintanenceFees = 0;

        private void ucMaintenanceBill_Load(object sender, EventArgs e)
        {
        }
        public ucMaintenanceBill()
        {
            InitializeComponent();
            price_arr = new System.Windows.Forms.ComboBox[]{ cbPrice1, cbPrice2, cbPrice3, cbPrice4
        , cbPrice5, cbPrice6, cbPrice7, cbPrice8, cbPrice9, cbPrice10, cbPrice11, cbPrice12};

            total_arr = new System.Windows.Forms.TextBox[]{txtTotal1,txtTotal2,txtTotal3,txtTotal4,
              txtTotal5,txtTotal6,txtTotal7,txtTotal8,txtTotal9,txtTotal10,txtTotal11,txtTotal12 };

            items_arr = new System.Windows.Forms.ComboBox[] { comboItm1, comboItm2, comboItm3, comboItm4,
            comboItm5,comboItm6,comboItm7,comboItm8,comboItm9,comboItm10,comboItm11,comboItm12 };

            quantity_arr = new System.Windows.Forms.TextBox[]{txtQuantity1,txtQuantity2,txtQuantity3,
                txtQuantity4,txtQuantity5,txtQuantity6,txtQuantity7,txtQuantity8,txtQuantity9
                ,txtQuantity10,txtQuantity11,txtQuantity12 };

            MaintenanceFees_arr = new System.Windows.Forms.TextBox[]{ txtMaintenanceFees1
                ,txtMaintenanceFees2,txtMaintenanceFees3,txtMaintenanceFees4,txtMaintenanceFees5
            ,txtMaintenanceFees6,txtMaintenanceFees7,txtMaintenanceFees8,txtMaintenanceFees9
            ,txtMaintenanceFees10,txtMaintenanceFees11,txtMaintenanceFees12};

        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            TotalCalculate();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += this.Doc_PrintPage;
            PrintDialog dlgSettings = new PrintDialog();
            dlgSettings.Document = doc;

            PrinterSettings PrinterSetting = new PrinterSettings();
            //            doc.PrinterSettings.PrinterName = "Eltron P310 Card Printer";
            doc.PrinterSettings.Copies = 10;
            doc.PrinterSettings.DefaultPageSettings.Landscape = true;



            if (dlgSettings.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }
        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;
            Bitmap bmp = new Bitmap(this.groupBox1.Width, this.groupBox1.Height);
            this.groupBox1.DrawToBitmap(bmp, new Rectangle(0, 0, this.groupBox1.Width, this.groupBox1.Height));
            e.Graphics.DrawImage((Image)bmp, x, y);
        }
        void EmptySelectedItms()
        {
            for (int i = 0; i < 12; i++)
            {
                items_arr[i].SelectedItem = null;
                price_arr[i].SelectedItem = null;
                quantity_arr[i].Text = "";
                MaintenanceFees_arr[i].Text = "";
                total_arr[i].Text = "";
            }
            cbClientName.SelectedItem = null;
            cbClientPhone.SelectedItem = null;
            txtCarBrand.Text = "";
            txtCarLicense.Text = "";
            txtCarModel.Text = null;
            txtKilometer.Text = "0";
            txtTotalPrice.Text = "";
            txtTotalPriceAfterDiscound.Text = "";
            txtDiscound.Text = "0";
        }
        void clearBill()
        {
            EmptySelectedItms();
            ClientBill c = centerContext.ClientBills.OrderByDescending(u => u.billID).FirstOrDefault();
            BillNUM = c.billID;
            txtBillNumber.Text = BillNUM.ToString();
        }
        void TotalCalculate()
        {
            totalPrice = 0;
            MaintanenceFees = 0;
            for (int i = 0; i < 12; i++)
            {

                if (price_arr[i].SelectedItem != null)
                {
                    if (quantity_arr[i].Text == "")
                    {
                        total_arr[i].Text = (Convert.ToInt32(price_arr[i].SelectedValue).ToString());
                        quantity_arr[i].Text = "1";
                        totalPrice += Convert.ToInt32(price_arr[i].SelectedValue);
                    }
                    else
                    {
                        total_arr[i].Text = (Convert.ToInt32(price_arr[i].SelectedValue.ToString())
                        * Convert.ToInt32(quantity_arr[i].Text.ToString())).ToString();
                        totalPrice += Convert.ToInt32(price_arr[i].SelectedValue.ToString())
                        * Convert.ToInt32(quantity_arr[i].Text.ToString());
                    }
                }

                if (MaintenanceFees_arr[i].Text != "")
                {
                    MaintanenceFees += Convert.ToDouble(MaintenanceFees_arr[i].Text);
                }

            }
            txtTotalPrice.Text = totalPrice.ToString();
            txtTotalPriceAfterDiscound.Text = (totalPrice - totalPrice * Convert.ToInt32(txtDiscound.Text) / 100).ToString();
        }
        void SaveBillToDatabase()
        {
            if (cbClientName.Text.Length < 4)
            {
                MessageBox.Show("من فضلك اختار عميل  اواكتب اسم عميل جديد");
            }
            else
            {
                if (Convert.ToInt32(cbClientName.SelectedValue) < 1)
                {
                    Client client = new Client
                    {
                        clientName = cbClientName.Text,
                        clientPhoneNumber = cbClientPhone.Text,
                    };
                    try
                    {
                        centerContext.Clients.Add(client);
                        centerContext.SaveChanges();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("من فضلك اضف بيانات صحيحة");
                    }


                    Client c = centerContext.Clients.OrderByDescending(u => u.clientID).FirstOrDefault();
                    clientId = c.clientID;
                }
                else
                {
                    clientId = Convert.ToInt32(cbClientName.SelectedValue);
                }

                //add new car  if not found car licence in database            
                var query1 = from v in centerContext.Cars
                             where v.carLicense == txtCarLicense.Text
                             select new { v.carID };
                if (query1.Count() == 0)
                {
                    //if (txtCarLicense.Text == "")
                    //{
                    //    txtCarLicense.Text = "0";
                    //}
                    if (txtCarModel.Text == "")
                    {
                        txtCarModel.Text = "0";
                    }
                    //if (txtCarBrand.Text == "")
                    //{
                    //    txtCarBrand.Text = "0";
                    //}



                    Car car = new Car
                    {
                        clientID = clientId,
                        carLicense = txtCarLicense.Text,
                        carModel = Convert.ToInt16(txtCarModel.Text),
                        carBrand = txtCarBrand.Text
                    };
                    try
                    {
                        centerContext.Cars.Add(car);
                        centerContext.SaveChanges();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(" احذف العناصر  المتكررة ");
                    }
                }

                ClientBill bill = new ClientBill()
                {
                    billCash = Convert.ToDouble(txtTotalPriceAfterDiscound.Text),
                    billDate = DateTime.Now,
                    billDiscount = Convert.ToDouble(txtDiscound.Text),

                    billKilometerCount = Convert.ToInt32(txtKilometer.Text),
                    billNotes = txtNotes.Text,
                    billTotablPriceAfter = Convert.ToDouble(txtTotalPriceAfterDiscound.Text),
                    billTotablPriceBefore = Convert.ToDouble(txtTotalPrice.Text),
                    billWorkerHandPrice = MaintanenceFees,
                    clientID = clientId
                };
                try
                {
                    centerContext.ClientBills.Add(bill);
                    centerContext.SaveChanges();
                }
                catch (Exception e)
                {
                    MessageBox.Show("من فضلك اضف بيانات صحيحة");
                }


                for (int i = 0; i < 12; i++)
                {
                    if (Convert.ToInt32(items_arr[i].SelectedValue) > 0)
                    {

                        ClientBillItem billItem = new ClientBillItem()
                        {
                            billID = BillNUM,
                            itemID = Convert.ToInt32(items_arr[i].SelectedValue),
                            itemPrice = Convert.ToInt32(price_arr[i].SelectedValue),
                            itemQuantity = Convert.ToInt32(quantity_arr[i].Text)
                        };
                        try
                        {
                            centerContext.ClientBillItems.Add(billItem);
                            centerContext.SaveChanges();

                            Item item = centerContext.Items.Find(billItem.itemID);
                            item.itemQuantity -= billItem.itemQuantity;
                            centerContext.SaveChanges();

                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("احذف العناصر المتكررة ");
                        }
                    }
                }
                ClientBill clientBill = centerContext.ClientBills.OrderByDescending(u => u.billID).FirstOrDefault();
                BillNUM = clientBill.billID;
                txtBillNumber.Text = BillNUM.ToString();
                //                clearBill();

            }
        }
        private void gridControl_Click(object sender, EventArgs e)
        {

        }

        private void ucMaintenanceBill_Load_1(object sender, EventArgs e)
        {
            ClientBill c = centerContext.ClientBills.OrderByDescending(u => u.billID).FirstOrDefault();
            BillNUM = c == null ? 1 : c.billID;
            txtBillNumber.Text = BillNUM.ToString();
            this.clientTableAdapter.Fill(this.autoCenterDataSet.Client);
            this.itemTableAdapter.Fill(this.autoCenterDataSet.Item);
            EmptySelectedItms();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox43_TextChanged(object sender, EventArgs e)
        {

        }

        private void ribbonControl_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cbPrice1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            TotalCalculate();
            SaveBillToDatabase();
        }

        private void txtQuantity1_TextChanged(object sender, EventArgs e)
        {
            validateNumber(sender);
            //ValidateQuantity(sender, 0);
        }

        //void ValidateQuantity(object sender, int boxnum)
        //{
        //    double quantity = float.Parse(((TextBox)sender).Text);
        //    string itemName = items_arr[boxnum].SelectedItem;

        //    if (quantity > itemQuantity)
        //    {
        //        MessageBox.Show("الكمية غير متوفرة");
        //        ((TextBox)sender).Text = itemQuantity.ToString();
        //    }
        //}

        void validateNumber(object sender)
        {
            System.Windows.Forms.TextBox s = (sender as System.Windows.Forms.TextBox);

            if (!((regex.IsMatch(s.Text)) || (s.Text == "")))
            {
                MessageBox.Show("من فضلك ادخل رقم صحيح");
                s.Text = "1";
                //                s.ForeColor = Color.Red;
            }
            else
            {

            }
        }
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            bitmap = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(bitmap);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void txtQuantity2_TextChanged(object sender, EventArgs e)
        {
            validateNumber(sender);
        }

        private void txtQuantity3_TextChanged(object sender, EventArgs e)
        {
            validateNumber(sender);
        }

        private void txtQuantity4_TextChanged(object sender, EventArgs e)
        {
            validateNumber(sender);
        }

        private void txtQuantity5_TextChanged(object sender, EventArgs e)
        {
            validateNumber(sender);
        }

        private void txtQuantity6_TextChanged(object sender, EventArgs e)
        {
            validateNumber(sender);
        }

        private void txtQuantity7_TextChanged(object sender, EventArgs e)
        {
            validateNumber(sender);
        }

        private void txtQuantity8_TextChanged(object sender, EventArgs e)
        {
            validateNumber(sender);
        }

        private void txtQuantity9_TextChanged(object sender, EventArgs e)
        {
            validateNumber(sender);
        }

        private void txtQuantity10_TextChanged(object sender, EventArgs e)
        {
            validateNumber(sender);
        }

        private void txtQuantity11_TextChanged(object sender, EventArgs e)
        {
            validateNumber(sender);
        }

        private void txtQuantity12_TextChanged(object sender, EventArgs e)
        {
            validateNumber(sender);
        }

        private void txtMaintenanceFees1_TextChanged(object sender, EventArgs e)
        {
            validateNumber(sender);
        }

        private void txtMaintenanceFees2_TextChanged(object sender, EventArgs e)
        {
            validateNumber(sender);
        }

        private void txtMaintenanceFees3_TextChanged(object sender, EventArgs e)
        {
            validateNumber(sender);
        }

        private void txtMaintenanceFees4_TextChanged(object sender, EventArgs e)
        {
            validateNumber(sender);
        }

        private void txtMaintenanceFees5_TextChanged(object sender, EventArgs e)
        {
            validateNumber(sender);
        }

        private void txtMaintenanceFees6_TextChanged(object sender, EventArgs e)
        {
            validateNumber(sender);
        }

        private void txtMaintenanceFees7_TextChanged(object sender, EventArgs e)
        {
            validateNumber(sender);
        }

        private void txtMaintenanceFees8_TextChanged(object sender, EventArgs e)
        {
            validateNumber(sender);
        }

        private void txtMaintenanceFees9_TextChanged(object sender, EventArgs e)
        {
            validateNumber(sender);
        }

        private void txtMaintenanceFees10_TextChanged(object sender, EventArgs e)
        {
            validateNumber(sender);
        }

        private void txtMaintenanceFees11_TextChanged(object sender, EventArgs e)
        {
            validateNumber(sender);
        }

        private void txtMaintenanceFees12_TextChanged(object sender, EventArgs e)
        {
            validateNumber(sender);
        }

        private void txtKilometer_TextChanged(object sender, EventArgs e)
        {
            validateNumber(sender);
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            TotalCalculate();
        }

        private void txtCarModel_TextChanged(object sender, EventArgs e)
        {
            validateNumber(sender);
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            clearBill();
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            clearBill();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}