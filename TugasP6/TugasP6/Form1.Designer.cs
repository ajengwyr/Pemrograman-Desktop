namespace TugasP6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.PaleGreen;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(241, 325);
            button1.Name = "button1";
            button1.Size = new Size(141, 39);
            button1.TabIndex = 11;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(214, 263);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(199, 27);
            textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(214, 191);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(199, 27);
            textBox1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(214, 240);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 8;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(214, 159);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 7;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Castellar", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(254, 79);
            label1.Name = "label1";
            label1.Size = new Size(128, 36);
            label1.TabIndex = 6;
            label1.Text = "LOGIN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(657, 450);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}