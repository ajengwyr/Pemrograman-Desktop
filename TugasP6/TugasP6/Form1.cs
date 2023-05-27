namespace TugasP6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adminuser = "admin";
            string adminpass = "1234";
            string kasiruser = "kasir";
            string kasirpass = "4321";

            string username = textBox1.Text;
            string password = textBox2.Text;

            if (username == adminuser && password == adminpass)
            {
                    var formAdmin = new FormAdmin();
                    formAdmin.Show();
                    formAdmin.Closed += (s, args) => this.Close();
                    formAdmin.Show();
            }
            else if (username == kasiruser && password == kasirpass)
            {
                MessageBox.Show("Login success!", "Welcome", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                var formKasir = new FormPesan();
                formKasir.Show();
                formKasir.Closed += (s, args) => this.Close();
                formKasir.Show();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }

}