namespace TugasP8
{
    partial class KasirForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KasirForm));
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            orderButton = new Button();
            checkedListBox1 = new CheckedListBox();
            label5 = new Label();
            comboBox2 = new ComboBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label1 = new Label();
            LogoutButton = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(539, 87);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 85);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 61;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(358, 87);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(105, 85);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 60;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(152, 87);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 59;
            pictureBox1.TabStop = false;
            // 
            // orderButton
            // 
            orderButton.BackColor = Color.FromArgb(192, 255, 192);
            orderButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            orderButton.Location = new Point(67, 420);
            orderButton.Name = "orderButton";
            orderButton.Size = new Size(194, 61);
            orderButton.TabIndex = 58;
            orderButton.Text = "Order";
            orderButton.UseVisualStyleBackColor = false;
            orderButton.Click += orderButton_Click_1;
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = Color.LavenderBlush;
            checkedListBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Bubble", "Grass Jelly", "Nata de coco", "Whipped cream", "Choco chip", "Oreo" });
            checkedListBox1.Location = new Point(329, 292);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(209, 114);
            checkedListBox1.TabIndex = 57;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DarkSalmon;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(329, 269);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 56;
            label5.Text = "Topping";
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.LavenderBlush;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "100%", "75%", "50%", "0%" });
            comboBox2.Location = new Point(69, 361);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 55;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(72, 338);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 54;
            label4.Text = "Sugar Level";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.LavenderBlush;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Medium", "Large" });
            comboBox1.Location = new Point(69, 292);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 53;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(69, 269);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 52;
            label3.Text = "Size";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(58, 231);
            label2.Name = "label2";
            label2.Size = new Size(124, 23);
            label2.TabIndex = 51;
            label2.Text = "Customization:";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            radioButton3.Location = new Point(539, 186);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(113, 24);
            radioButton3.TabIndex = 50;
            radioButton3.TabStop = true;
            radioButton3.Text = "Cappuccino";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            radioButton2.Location = new Point(376, 186);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(67, 24);
            radioButton2.TabIndex = 49;
            radioButton2.TabStop = true;
            radioButton2.Text = "Latte";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            radioButton1.Location = new Point(170, 186);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(91, 24);
            radioButton1.TabIndex = 48;
            radioButton1.TabStop = true;
            radioButton1.Text = "Espresso";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Castellar", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(301, 32);
            label1.Name = "label1";
            label1.Size = new Size(225, 27);
            label1.TabIndex = 47;
            label1.Text = "Cafe Sanapati";
            // 
            // LogoutButton
            // 
            LogoutButton.BackColor = Color.Pink;
            LogoutButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LogoutButton.Location = new Point(684, 21);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(104, 38);
            LogoutButton.TabIndex = 75;
            LogoutButton.Text = "LOGOUT";
            LogoutButton.UseVisualStyleBackColor = false;
            LogoutButton.Click += LogoutButton_Click_1;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(585, 269);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(179, 160);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 76;
            pictureBox4.TabStop = false;
            // 
            // KasirForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 532);
            Controls.Add(pictureBox4);
            Controls.Add(LogoutButton);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(orderButton);
            Controls.Add(checkedListBox1);
            Controls.Add(label5);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label1);
            Name = "KasirForm";
            Text = "KasirForm";
            Load += KasirForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button orderButton;
        private CheckedListBox checkedListBox1;
        private Label label5;
        private ComboBox comboBox2;
        private Label label4;
        private ComboBox comboBox1;
        private Label label3;
        private Label label2;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label1;
        private Button LogoutButton;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private PictureBox pictureBox4;
    }
}