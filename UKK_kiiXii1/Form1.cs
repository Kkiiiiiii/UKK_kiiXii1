using Microsoft.Data.SqlClient;

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
            string name = "";

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Silakan masukkan username dan password.", "Input Kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection Conn = new SqlConnection(@"Data Source=MYPCPRO\SQLEXPRESS;Initial Catalog=ukk_riki;Integrated Security=True;TrustServerCertificate=True"))
                {
                    Conn.Open();

                    string query = "SELECT COUNT(*) FROM [users] WHERE username = @username AND password = @password";
                    using (SqlCommand cmd = new SqlCommand(query, Conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            string queryUser = "SELECT nama FROM [users] WHERE username = @username";
                            using (SqlCommand cmd2 = new SqlCommand(queryUser, Conn))
                            {
                                cmd2.Parameters.AddWithValue("@username", username);

                                using (SqlDataReader reader = cmd2.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        name = reader.GetString(0);

                                        MessageBox.Show("Login Berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        Home f2 = new Home(name);
                                        this.Hide();
                                        f2.ShowDialog();
                                        this.Show();

                                        txtUsername.Clear();
                                        txtPass.Clear();
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Username atau password salah.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
