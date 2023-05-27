using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TugasP6
{
    public partial class FormPesan : Form
    {
        public FormPesan()
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
        private String cetakan = "";
        private String receipt = "";
        private void button1_Click(object sender, EventArgs e)
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
                else if (comboBox1.SelectedItem.ToString() == "Large")
                {
                    ukuran = comboBox2.Text;
                    hargaukuran = 0;
                }

                int i;
                String s;
                String sr;
                s = "Topping: \n";
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
                        sr = sr + checkedListBox1.Items[i].ToString() + "\t\tRp" +hargatopping +"\n";
                    }
                }

                cetakan = "============== CAFE SANAPATI ==============\n\n" +
                    "ORDER SUMMARY : \n" + kopi + "\n" + ukuran + "\n" + s +
                    "\nTOTAL PRICE: Rp" + harga + "\n\nEnjoy your coffee!^^";

                receipt = "============== STRUK PESANAN ==============\n" +
                    "============== CAFE SANAPATI ==============\n\n" +
                    "ORDER SUMMARY : \n\nCOFFEE\n" + kopi +"\t\tRp"+ hargakopi + "\n\nSIZE\n" + ukuran + "\t\tRp" + hargaukuran + "\n\n" + sr +
                    "\nTOTAL PRICE:\t\tRp" + harga + "\n\nTHANKS FOR COMING!^^";

                if (MessageBox.Show(cetakan + "\n\nPrint receipt?", "Konfirmasi Pesanan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    printPreviewDialog1.ShowDialog();
                }
                else
                {
                    // user clicked no
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(receipt, new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new PointF(10, 10));
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
