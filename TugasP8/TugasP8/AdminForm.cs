using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasP8
{
    public partial class AdminForm : Form
    {
        private string filePath = @"user.txt";
        public AdminForm()
        {
            InitializeComponent();
            LoadUsers();
        }

        private List<User> users = new List<User>();

        private void LoadUsers()
        {
            users.Clear();


            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines.Skip(1))
            {
                string[] fields = line.Split(',');

                User user = new User
                {
                    Username = fields[0],
                    Password = fields[1],
                    Level = fields[2]
                };

                users.Add(user);
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = users;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                User selectedUser = (User)selectedRow.DataBoundItem;
                users.Remove(selectedUser);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = users;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string level = comboBox1.Text;

            User user = new User
            {
                Username = username,
                Password = password,
                Level = level
            };

            users.Add(user);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = users;

            RefreshTeks();
        }

        private void RefreshTeks()
        {
            usernameTextBox.Text = string.Empty;
            passwordTextBox.Text = string.Empty;
        }



        private void saveButton_Click(object sender, EventArgs e)
        {
            File.WriteAllText(filePath, string.Empty);
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                string baris = "admin,admin123,admin";
                writer.WriteLine(baris);

                foreach (User user in users)
                {
                    string line = $"{user.Username},{user.Password},{user.Level}";
                    writer.WriteLine(line);
                }
            }
            MessageBox.Show("Perubahan berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
