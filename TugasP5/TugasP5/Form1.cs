namespace TugasP5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adminuser = "adminuser";
            string adminpass = "adminpass";
            string kasiruser = "kasiruser";
            string kasirpass = "kasirpass";

            string username = textBox1.Text;
            string password = textBox2.Text;

            if(username == adminuser && password == adminpass)
            {
                var formAdmin = new Form3();
                formAdmin.Show();
                formAdmin.Closed += (s, args) => this.Close();
                formAdmin.Show();
            }
            else if (username == kasiruser && password == kasirpass)
            {
                var formKasir = new Form2();
                formKasir.Show();
                formKasir.Closed += (s, args) => this.Close();
                formKasir.Show();
            }
            else
            {
                MessageBox.Show("Username atau Password salah!");
            }
        }

        
    }
}