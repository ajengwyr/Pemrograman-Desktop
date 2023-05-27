namespace TugasP6
{
    partial class FormPesan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPesan));
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
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
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(561, 89);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 85);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 46;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(380, 89);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(105, 85);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 45;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(174, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(89, 422);
            button1.Name = "button1";
            button1.Size = new Size(194, 61);
            button1.TabIndex = 43;
            button1.Text = "Order";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = Color.LavenderBlush;
            checkedListBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Bubble", "Grass Jelly", "Nata de coco", "Whipped cream", "Choco chip", "Oreo" });
            checkedListBox1.Location = new Point(351, 294);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(209, 114);
            checkedListBox1.TabIndex = 42;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DarkSalmon;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(351, 271);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 41;
            label5.Text = "Topping";
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.LavenderBlush;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "100%", "75%", "50%", "0%" });
            comboBox2.Location = new Point(91, 363);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(94, 340);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 39;
            label4.Text = "Sugar Level";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.LavenderBlush;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Medium", "Large" });
            comboBox1.Location = new Point(91, 294);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 38;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(91, 271);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 37;
            label3.Text = "Size";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(80, 233);
            label2.Name = "label2";
            label2.Size = new Size(124, 23);
            label2.TabIndex = 36;
            label2.Text = "Customization:";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            radioButton3.Location = new Point(561, 188);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(113, 24);
            radioButton3.TabIndex = 35;
            radioButton3.TabStop = true;
            radioButton3.Text = "Cappuccino";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            radioButton2.Location = new Point(398, 188);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(67, 24);
            radioButton2.TabIndex = 34;
            radioButton2.TabStop = true;
            radioButton2.Text = "Latte";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            radioButton1.Location = new Point(192, 188);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(91, 24);
            radioButton1.TabIndex = 33;
            radioButton1.TabStop = true;
            radioButton1.Text = "Espresso";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Castellar", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(323, 34);
            label1.Name = "label1";
            label1.Size = new Size(237, 27);
            label1.TabIndex = 32;
            label1.Text = "Cafe PoltekSSN";
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
            // FormPesan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(1112, 535);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
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
            Name = "FormPesan";
            Text = "FormPesan";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button button1;
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
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}