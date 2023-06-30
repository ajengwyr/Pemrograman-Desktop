using Microsoft.VisualBasic.ApplicationServices;

namespace TugasP8
{
    public partial class LoginForm : Form
    {
        private string filePath = @"user.txt";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            User user = ValidateLogin(username, password);
            if (user != null)
            {
                switch (user.Level)
                {
                    case "admin":
                        AdminForm adminForm = new AdminForm();
                        adminForm.Show();
                        adminForm.Closed += (s, args) => this.Close();
                        break;
                    case "kasir":
                        KasirForm kasirForm = new KasirForm();
                        kasirForm.Show();
                        kasirForm.Closed += (s, args) => this.Close();
                        break;
                    default:
                        MessageBox.Show("Level tidak valid!");
                        break;
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau password salah.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private User ValidateLogin(string username, string password)
        {
            List<User> users = ValidateUser();
            return users.FirstOrDefault(u => u.Username == username && u.Password == password);
        }

        private List<User> ValidateUser()
        {
            List<User> users = new List<User>();
            string[] lines = File.ReadAllLines(filePath);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');
                User user = new User
                {
                    Username = data[0],
                    Password = data[1],
                    Level = data[2]
                };
                users.Add(user);
            }
            return users;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }
    }
}