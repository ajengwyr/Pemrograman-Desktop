using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasP5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            checkedListBox1.CheckOnClick = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private int harga = 0;
        private String kopi;
        private String ukuran;
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                harga = 10000;
                kopi = radioButton1.Text;
            }
            else if (radioButton2.Checked == true)
            {
                harga = 15000;
                kopi = radioButton2.Text;
            }
            else if (radioButton3.Checked == true)
            {
                harga = 12000;
                kopi = radioButton3.Text;
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
                }
                else if (comboBox1.SelectedItem.ToString() == "Large")
                {
                    ukuran = comboBox2.Text;
                }

                int i;
                String s;
                s = "Topping: \n";
                for (i = 0; i <= (checkedListBox1.Items.Count - 1); i++)
                {
                    if (checkedListBox1.GetItemChecked(i))
                    {
                        if (checkedListBox1.Items[i].ToString() == "Bubble")
                        {
                            harga += 3000;
                        }
                        else if (checkedListBox1.Items[i].ToString() == "Grass Jelly")
                        {
                            harga += 3500;
                        }
                        else if (checkedListBox1.Items[i].ToString() == "Nata de coco")
                        {
                            harga += 2500;
                        }
                        else if (checkedListBox1.Items[i].ToString() == "Whipped cream")
                        {
                            harga += 1000;
                        }
                        else if (checkedListBox1.Items[i].ToString() == "Choco chip")
                        {
                            harga += 1500;
                        }
                        else if (checkedListBox1.Items[i].ToString() == "Oreo")
                        {
                            harga += 2000;
                        }

                        s = s + checkedListBox1.Items[i].ToString() + "\n";
                    }
                }

                MessageBox.Show("============== CAFE SANAPATI ==============\n\n" +
                    "ORDER SUMMARY : \n" + kopi + "\n" + ukuran + "\n" + s +
                    "\nTOTAL PRICE: Rp" + harga + "\n\nEnjoy your coffee!^^");
            }





        }

        
    }
}
