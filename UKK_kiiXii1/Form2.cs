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
            this.name.Text = "Selamat Datang," + nama;
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
                using (SqlConnection Conn = new SqlConnection(@"Data Source=DESKTOP-MOUI7DH\SQLEXPRESS;Initial Catalog=ukk_riki;Integrated Security=True;Trust Server Certificate=True"))
                {
                    Conn.Open();

                    string sql = "INSERT INTO Product (ProductName, Price, Image) VALUES (@name, @price, @image)";
                    using (SqlCommand cmd = new SqlCommand(sql, Conn))
                    {
                        cmd.Parameters.AddWithValue("@name", txtNamaProduk.Text);
                        cmd.Parameters.AddWithValue("@price", decimal.Parse(txtHarga.Text));

                        if (pictureBox1.Image != null)
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                                cmd.Parameters.AddWithValue("@image", ms.ToArray());
                            }
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@image", DBNull.Value);
                        }

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Produk berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtNamaProduk.Clear();
                            txtHarga.Clear();
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
                MessageBox.Show("Harga harus berupa angka.", "Input Salah", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                if (row.Cells["Image"].Value != DBNull.Value)
                {
                    byte[] img = (byte[])row.Cells["Image"].Value;
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
