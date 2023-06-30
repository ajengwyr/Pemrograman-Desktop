using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using CsvHelper.Configuration;
using QRCoder;
using SendGrid.Helpers.Mail;
using SendGrid;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TugasP8
{
    public partial class KasirForm : Form
    {
        public KasirForm()
        {
            InitializeComponent();
            checkedListBox1.CheckOnClick = true;
        }
        private int harga = 0;
        private int hargatopping = 0;
        private int hargakopi = 0;
        private int hargaukuran = 0;
        private String kopi = "";
        private String ukuran = "";
        private String gula = "";
        private String cetakan = "";
        private String receipt = "";

        private void orderButton_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                harga = 10000;
                kopi = radioButton1.Text;
                hargakopi = 10000;
            }
            else if (radioButton2.Checked == true)
            {
                harga = 15000;
                kopi = radioButton2.Text;
                hargakopi = 15000;
            }
            else if (radioButton3.Checked == true)
            {
                harga = 12000;
                kopi = radioButton3.Text;
                hargakopi = 12000;
            }

            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Size and Sugar Level must be chosen!");
            }
            else
            {

                if (comboBox1.SelectedItem.ToString() == "Large")
                {
                    harga += 3000;
                    ukuran = comboBox1.Text;
                    hargaukuran = 3000;
                }
                else if (comboBox1.SelectedItem.ToString() == "Medium")
                {
                    ukuran = comboBox1.Text;
                    hargaukuran = 0;
                }

                gula = comboBox2.Text;

                int i;
                String s, ss, sr;
                s = "";
                ss = "";
                sr = "TOPPING\n";
                for (i = 0; i <= (checkedListBox1.Items.Count - 1); i++)
                {
                    if (checkedListBox1.GetItemChecked(i))
                    {
                        if (checkedListBox1.Items[i].ToString() == "Bubble")
                        {
                            harga += 3000;
                            hargatopping = 3000;
                        }
                        else if (checkedListBox1.Items[i].ToString() == "Grass Jelly")
                        {
                            harga += 3500;
                            hargatopping = 3500;
                        }
                        else if (checkedListBox1.Items[i].ToString() == "Nata de coco")
                        {
                            harga += 2500;
                            hargatopping = 2500;
                        }
                        else if (checkedListBox1.Items[i].ToString() == "Whipped cream")
                        {
                            harga += 1000;
                            hargatopping = 1000;
                        }
                        else if (checkedListBox1.Items[i].ToString() == "Choco chip")
                        {
                            harga += 1500;
                            hargatopping = 1500;
                        }
                        else if (checkedListBox1.Items[i].ToString() == "Oreo")
                        {
                            harga += 2000;
                            hargatopping = 2000;
                        }

                        s = s + checkedListBox1.Items[i].ToString() + "\n";
                        ss = ss + checkedListBox1.Items[i].ToString() + ",";
                        sr = sr + checkedListBox1.Items[i].ToString() + "\t\tRp" + hargatopping + "\n";
                    }
                }

                cetakan = "============== CAFE SANAPATI ==============\n\n" +
                    "ORDER SUMMARY : \n" + kopi + "\n" + ukuran + "\nSugar : " + gula + "\nTopping: \n" + s +
                    "\nTOTAL PRICE: Rp" + harga + "\n\nEnjoy your coffee!^^";

                receipt = "============== STRUK PESANAN ==============\n" +
                    "============== CAFE SANAPATI ==============\n\n" +
                    "ORDER SUMMARY : \n\nCOFFEE\n" + kopi + "\t\tRp" + hargakopi + "\n\nSIZE\n" + ukuran + "\n\nSUGAR\n" + gula + "\t\tRp" + hargaukuran + "\n\n" + sr +
                    "\nTOTAL PRICE:\t\tRp" + harga + "\n\nTHANKS FOR COMING!^^";

                DateTime waktu1 = DateTime.Now;
                var guid = Guid.NewGuid();
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    HasHeaderRecord = false
                };
                var records = new List<Order>
                {
                    new Order {Id=guid, Kopi = kopi, Gula = gula, Topping = ss , Harga = harga, Waktu=waktu1 },
                };

                if (MessageBox.Show(cetakan + "\n\nPrint receipt?", "Konfirmasi Pesanan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    printPreviewDialog1.ShowDialog();

                    using var writer = new StreamWriter("Order.csv", append: true);
                    using var csv = new CsvWriter(writer, config);
                    csv.WriteRecords(records);

                    QRCodeGenerator qrGenerator = new();
                    QRCodeData qrCodeData = qrGenerator.CreateQrCode(guid.ToString(), QRCodeGenerator.ECCLevel.Q);
                    QRCode qrCode = new(qrCodeData);
                    Bitmap qrCodeImage = qrCode.GetGraphic(20);
                    pictureBox4.Image = qrCodeImage;

                    MessageBox.Show("Transaksi berhasil ditambahkan.");

                    string email = Microsoft.VisualBasic.Interaction.InputBox("Masukkan email Anda:", "Input Email", "");
                    if (!string.IsNullOrEmpty(email))
                    {
                        string tempFilePath = Path.GetTempFileName() + ".png";
                        qrCodeImage.Save(tempFilePath);
                        SendEmail(tempFilePath, email);
                    }
                    else
                    {
                        MessageBox.Show("Email tidak valid!");
                    }
                }
                else
                {
                    // user clicked no
                }
            }
        }

        private void SendEmail(string imagePath, string emailTo)
        {
            var client = new SendGridClient("YOUR_SENDGRID_API_KEY");
            var msg = new SendGridMessage();
            byte[] imageBytes = File.ReadAllBytes(imagePath);

            // Menambahkan informasi pengirim, penerima, subjek, dan isi email
            msg.SetFrom(new EmailAddress("wiyarwilujengnings@gmail.com", "Sanapati Cafe"));
            msg.AddTo(new EmailAddress(emailTo));
            msg.SetSubject("QR Code Anda");
            msg.AddContent(MimeType.Text, "Terlampir adalah QR Code untuk teks yang Anda masukkan.");

            // Menambahkan attachment (QR Code) ke email
            msg.AddAttachment("qrcode.png", Convert.ToBase64String(imageBytes));

            // Mengirim email menggunakan SendGrid
            var response = client.SendEmailAsync(msg).Result;

            // Menampilkan pesan hasil pengiriman
            if (response.StatusCode == System.Net.HttpStatusCode.Accepted)
            {
                MessageBox.Show("Email telah berhasil dikirim!");
            }
            else
            {
                MessageBox.Show("Gagal mengirim email. Error: " + response.StatusCode.ToString());
            }

        }
        private void LogoutButton_Click_1(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(receipt, new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new PointF(10, 10));
        }

        private void KasirForm_Load(object sender, EventArgs e)
        {

        }
    }
}
