using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UKK_kiiXii1
{
    public partial class Home : Form
    {
        private string username;
        public Home(string nama)
        {
            InitializeComponent();
            username = nama;
            this.name.Text = "Selamat Datang, " + nama;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNamaProduk.Text) || string.IsNullOrEmpty(txtHarga.Text))
            {
                MessageBox.Show("Silakan masukkan nama produk dan harga.", "Input Kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection Conn = new SqlConnection(@"Data Source=MYPCPRO\SQLEXPRESS;Initial Catalog=ukk_riki;Integrated Security=True;TrustServerCertificate=True"))
                {
                    Conn.Open();

                    string sql = "INSERT INTO products (id_produk, id_user, nama_produk, harga, stok, deskripsi, gambar_produk) " +
                                 "VALUES (@id_produk, @id_user, @nama_produk, @harga, @stok, @deskripsi, @gambar_produk)";

                    using (SqlCommand cmd = new SqlCommand(sql, Conn))
                    {
                        cmd.Parameters.AddWithValue("@id_produk", int.Parse(txtIDProduk.Text));
                        cmd.Parameters.AddWithValue("@id_user", int.Parse(txtIDUser.Text));
                        cmd.Parameters.AddWithValue("@nama_produk", txtNamaProduk.Text);
                        cmd.Parameters.AddWithValue("@harga", decimal.Parse(txtHarga.Text));
                        cmd.Parameters.AddWithValue("@stok", int.Parse(txtStok.Text));
                        cmd.Parameters.AddWithValue("@deskripsi", txtDes.Text);

                        // gambar_produk
                        if (pictureBox1.Image != null)
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                                cmd.Parameters.AddWithValue("@gambar_produk", ms.ToArray());
                            }
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@gambar_produk", DBNull.Value);
                        }

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Produk berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            txtNamaProduk.Clear();
                            txtHarga.Clear();
                            txtStok.Clear();
                            txtDes.Clear();
                            pictureBox1.Image = null;
                        }
                        else
                        {
                            MessageBox.Show("Gagal menambahkan produk.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Harga dan stok harus berupa angka.", "Input Salah", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtIDProduk.Text = row.Cells["id_produk"].Value.ToString();
                txtIDUser.Text = row.Cells["id_user"].Value.ToString();
                txtNamaProduk.Text = row.Cells["nama_produk"].Value.ToString();
                txtHarga.Text = row.Cells["harga"].Value.ToString();
                txtStok.Text = row.Cells["stok"].Value.ToString();
                txtDes.Text = row.Cells["deskripsi"].Value.ToString();

                // Tampilkan tanggal di DateTimePicker
                if (row.Cells["tanggal_produk"].Value != DBNull.Value)
                {
                    dtpTanggalProduk.Value = Convert.ToDateTime(row.Cells["tanggal_produk"].Value);
                }
                else
                {
                    dtpTanggalProduk.Value = DateTime.Now;
                }

                // Tampilkan gambar
                if (row.Cells["gambar_produk"].Value != DBNull.Value)
                {
                    byte[] img = (byte[])row.Cells["gambar_produk"].Value;
                    using (MemoryStream ms = new MemoryStream(img))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
        }
    }
}
