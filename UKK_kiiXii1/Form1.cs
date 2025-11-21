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

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Silakan masukkan username dan password.", "Input Kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection Conn = new SqlConnection(
                    @"Data Source=MYPCPRO\SQLEXPRESS;Initial Catalog=ukk_riki;Integrated Security=True;TrustServerCertificate=True"))
                {
                    Conn.Open();

                    // Ambil id_user + nama langsung
                    string query = @"
                        SELECT id_user, nama 
                        FROM users 
                        WHERE username = @username AND password = @password";

                    using (SqlCommand cmd = new SqlCommand(query, Conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int idUser = reader.GetInt32(0);   // ambil id_user
                                string name = reader.GetString(1); // ambil nama

                                // SIMPAN ID USER KE SESSION
                                UserSession.UserID = idUser;

                                MessageBox.Show("Login Berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Home f2 = new Home(name);
                                this.Hide();
                                f2.ShowDialog();
                                this.Show();

                                txtUsername.Clear();
                                txtPass.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Username atau password salah.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
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
