namespace UKK_kiiXii1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPass.Text;

            if (username == "admin" && password == "111")
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
            else
            {

            }

        }
    }
}
