namespace TugasP8
{
    partial class AdminForm
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
            saveButton = new Button();
            deleteButton = new Button();
            addButton = new Button();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            passwordTextBox = new TextBox();
            usernameTextBox = new TextBox();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.PaleGreen;
            saveButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            saveButton.Location = new Point(592, 381);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(177, 48);
            saveButton.TabIndex = 49;
            saveButton.Text = "SAVE CHANGES";
            saveButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Plum;
            deleteButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            deleteButton.Location = new Point(238, 315);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(94, 29);
            deleteButton.TabIndex = 48;
            deleteButton.Text = "DELETE";
            deleteButton.UseVisualStyleBackColor = false;
            // 
            // addButton
            // 
            addButton.BackColor = Color.Plum;
            addButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addButton.Location = new Point(539, 283);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 29);
            addButton.TabIndex = 47;
            addButton.Text = "ADD";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "manager", "kasir" });
            comboBox1.Location = new Point(508, 230);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(125, 28);
            comboBox1.TabIndex = 46;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(409, 230);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 45;
            label3.Text = "Level";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(403, 105);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 44;
            label5.Text = "ADD USER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(409, 190);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 43;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(408, 146);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 42;
            label1.Text = "Username";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(508, 183);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(125, 27);
            passwordTextBox.TabIndex = 41;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(508, 140);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(125, 27);
            usernameTextBox.TabIndex = 40;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 105);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 39;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(224, 21);
            label4.Name = "label4";
            label4.Size = new Size(392, 50);
            label4.TabIndex = 38;
            label4.Text = "User Management System";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(saveButton);
            Controls.Add(deleteButton);
            Controls.Add(addButton);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Name = "AdminForm";
            Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveButton;
        private Button deleteButton;
        private Button addButton;
        private ComboBox comboBox1;
        private Label label3;
        private Label label5;
        private Label label2;
        private Label label1;
        private TextBox passwordTextBox;
        private TextBox usernameTextBox;
        private DataGridView dataGridView1;
        private Label label4;
    }
}