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
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter dataAdapter;
        private Conn conn;
        public Home(string nama)
        {
            InitializeComponent();
            username = nama;
            this.name.Text = "Selamat Datang, " + nama;
            conn = new Conn();

            LoadData();
        }

        private void LoadData()
        {
            SqlConnection sqlConnection = conn.GetConn();

            try
            {
                sqlConnection.Open();

                string query = "SELECT id_produk, id_user, nama_produk, harga, stok, deskripsi, gambar_produk, tanggal_upload FROM products";
                cmd = new SqlCommand(query, sqlConnection);

                ds = new DataSet();
                dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(ds, "products");

                dataGridView1.DataSource = ds.Tables["products"];

                dataGridView1.Columns["id_produk"].Visible = false;
                dataGridView1.Columns["id_user"].Visible  = false;
                dataGridView1.Columns["nama_produk"].HeaderText = "Nama_Produk";
                dataGridView1.Columns["harga"].HeaderText = "Harga";
                dataGridView1.Columns["stok"].HeaderText = "Stok";
                dataGridView1.Columns["deskripsi"].HeaderText = "Deskripsi";
                dataGridView1.Columns["tanggal_upload"].HeaderText = "Tanggal Upload";
                dataGridView1.Columns["gambar_produk"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            LoadData();
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

                    string sql = "INSERT INTO products (id_user, nama_produk, harga, stok, deskripsi, gambar_produk, tanggal_upload) " +
                                 "VALUES (@id_user, @nama_produk, @harga, @stok, @deskripsi, @gambar_produk, @tanggal_upload);" +
                                 "SELECT SCOPE_IDENTITY();";  // Ambil ID produk yang baru dimasukkan

                    using (SqlCommand cmd = new SqlCommand(sql, Conn))
                    {
                        cmd.Parameters.AddWithValue("@id_user", UserSession.UserID);
                        cmd.Parameters.AddWithValue("@nama_produk", txtNamaProduk.Text);
                        cmd.Parameters.AddWithValue("@harga", decimal.Parse(txtHarga.Text));
                        cmd.Parameters.AddWithValue("@stok", int.Parse(txtStok.Text));
                        cmd.Parameters.AddWithValue("@deskripsi", txtDes.Text);
                        cmd.Parameters.AddWithValue("@tanggal_upload", DateTime.Now);

                        // Simpan gambar jika ada
                        string imagesFolder = Path.Combine(Application.StartupPath, "images");
                        if (!Directory.Exists(imagesFolder))
                        {
                            Directory.CreateDirectory(imagesFolder);
                        }

                        string imagePath = null;
                        if (pictureBox1.Image != null)
                        {
                            string imageFileName = Guid.NewGuid().ToString() + ".jpg";
                            imagePath = Path.Combine(imagesFolder, imageFileName);
                            pictureBox1.Image.Save(imagePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                            cmd.Parameters.AddWithValue("@gambar_produk", imagePath);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@gambar_produk", DBNull.Value);
                        }

                        // Eksekusi query dan ambil ID produk yang baru ditambahkan
                        var result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            int idProdukBaru = Convert.ToInt32(result);  // Ambil ID yang baru dimasukkan
                            MessageBox.Show($"Produk berhasil ditambahkan dengan ID: {idProdukBaru}", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Gagal mengambil ID produk baru.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        // Reset form setelah menambah produk
                        txtNamaProduk.Clear();
                        txtHarga.Clear();
                        txtStok.Clear();
                        txtDes.Clear();
                        pictureBox1.Image = null;

                        // Refresh data grid view
                        LoadData();
                    }
                }
            }
            catch (Exception ex)
            {
                // Tampilkan pesan error jika terjadi masalah
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                txtNamaProduk.Text = row.Cells["nama_produk"].Value.ToString();
                txtHarga.Text = row.Cells["harga"].Value.ToString();
                txtStok.Text = row.Cells["stok"].Value.ToString();
                txtDes.Text = row.Cells["deskripsi"].Value.ToString();

                // Tampilkan tanggal di DateTimePicker
                if (row.Cells["tanggal_upload"].Value != DBNull.Value)
                {
                    dtpTanggalProduk.Value = Convert.ToDateTime(row.Cells["tanggal_upload"].Value);
                }
                else
                {
                    dtpTanggalProduk.Value = DateTime.Now;
                }


                if (row.Cells["gambar_produk"].Value != DBNull.Value)
                {
                    string imageName = row.Cells["gambar_produk"].Value.ToString();
                    string imagePath = Path.Combine(Application.StartupPath, "images", imageName);

                    if (File.Exists(imagePath))
                    {
                        pictureBox1.Image = Image.FromFile(imagePath);
                    }
                    else
                    {
                        pictureBox1.Image = null;
                    }
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                // Unutk cek apakah ada baris yang dipilih di DataGridView
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Pilih produk yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Mnegambil ID Produk dari baris yang dipilih
                int itemId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id_produk"].Value);

                // Konfirmasi hapus
                DialogResult dr = MessageBox.Show(
                    "Apakah Anda yakin ingin menghapus produk ini?",
                    "Konfirmasi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (dr == DialogResult.No)
                    return;

                SqlConnection sqlConnection = conn.GetConn();
                sqlConnection.Open();

                // Ambil path gambar produk sebelum dihapus
                string getImgQuery = "SELECT gambar_produk FROM products WHERE id_produk = @id";
                string imagePath = null;

                using (SqlCommand getImgCmd = new SqlCommand(getImgQuery, sqlConnection))
                {
                    getImgCmd.Parameters.AddWithValue("@id", itemId);
                    object result = getImgCmd.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                        imagePath = result.ToString();
                }

                // Hapus produk dari database berdasarkan id_produk
                string deleteQuery = "DELETE FROM products WHERE id_produk = @id_produk";
                using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, sqlConnection))
                {
                    deleteCmd.Parameters.AddWithValue("@id_produk", itemId);
                    deleteCmd.ExecuteNonQuery();
                }

                sqlConnection.Close();

                // Hapus gambar fisik jika ada
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    File.Delete(imagePath); // Menghapus gambar dari folder
                }

                MessageBox.Show("Produk berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();

                // Reset form
                txtNamaProduk.Clear();
                txtHarga.Clear();
                txtStok.Clear();
                txtDes.Clear();
                pictureBox1.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnupdate_Click(object sender, EventArgs e)
        {
            // Cek apakah ada baris yang dipilih di DataGridView
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih produk yang akan diupdate.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ambil ID Produk dari baris yang dipilih
            int idProduk = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id_produk"].Value);

            // Ambil data lain yang perlu diupdate
            string nama = txtNamaProduk.Text.Trim();
            string harga = txtHarga.Text.Trim();
            string stok = txtStok.Text.Trim();
            string deskripsi = txtDes.Text.Trim();

            // Validasi harga & stok
            if (string.IsNullOrEmpty(nama) || string.IsNullOrEmpty(harga) || string.IsNullOrEmpty(stok))
            {
                MessageBox.Show("Nama produk, harga, dan stok tidak boleh kosong.", "Input Kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(harga, out decimal hargaProduk))
            {
                MessageBox.Show("Harga tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(stok, out int stokProduk))
            {
                MessageBox.Show("Stok tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cek gambar baru (jika ada)
            string gambarPath = ""; // Path gambar untuk database

            if (pictureBox1.Image != null)
            {
                string ext = ".jpg";
                string namaFileBaru = $"{idProduk}_{DateTime.Now:yyyyMMddHHmmss}{ext}";
                string folderGambar = Path.Combine(Application.StartupPath, "images");
                string tempPath = Path.Combine(folderGambar, namaFileBaru);

                // Simpan gambar baru
                pictureBox1.Image.Save(tempPath, System.Drawing.Imaging.ImageFormat.Jpeg);
                gambarPath = tempPath;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=MYPCPRO\SQLEXPRESS;Initial Catalog=ukk_riki;Integrated Security=True;TrustServerCertificate=True"))
                {
                    conn.Open();

                    // Query untuk update produk berdasarkan id_produk
                    string updateQuery = @"UPDATE products 
                                   SET nama_produk=@nama, harga=@harga, stok=@stok, deskripsi=@deskripsi, 
                                       gambar_produk=@gambar_produk, tanggal_upload=@tanggal
                                   WHERE id_produk=@id";

                    using (SqlCommand cmdUpdate = new SqlCommand(updateQuery, conn))
                    {
                        cmdUpdate.Parameters.AddWithValue("@id", idProduk);
                        cmdUpdate.Parameters.AddWithValue("@nama", nama);
                        cmdUpdate.Parameters.AddWithValue("@harga", hargaProduk);
                        cmdUpdate.Parameters.AddWithValue("@stok", stokProduk);
                        cmdUpdate.Parameters.AddWithValue("@deskripsi", deskripsi);
                        cmdUpdate.Parameters.AddWithValue("@gambar_produk", string.IsNullOrEmpty(gambarPath) ? (object)DBNull.Value : gambarPath);
                        cmdUpdate.Parameters.AddWithValue("@tanggal", DateTime.Now);

                        cmdUpdate.ExecuteNonQuery();
                    }

                    MessageBox.Show("Data berhasil diubah!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reset form dan refresh data grid view
                    txtNamaProduk.Clear();
                    txtHarga.Clear();
                    txtStok.Clear();
                    txtDes.Clear();
                    pictureBox1.Image = null;

                    // Memuat ulang data
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchData(txtSearch.Text.Trim());
        }
        private void SearchData(string keyword)
        {
            SqlConnection sqlConnection = conn.GetConn();

            try
            {
                sqlConnection.Open();

                string query = "SELECT id_produk, id_user, nama_produk, harga, stok, deskripsi, gambar_produk, tanggal_upload " +
                               "FROM products WHERE nama_produk LIKE @keyword";
                cmd = new SqlCommand(query, sqlConnection);
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                ds = new DataSet();
                dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(ds, "products");

                dataGridView1.DataSource = ds.Tables["products"];

                //dataGridView1.Columns["id_produk"].HeaderText = "ID_Produk";
                //dataGridView1.Columns["id_user"].HeaderText = "ID_User";
                dataGridView1.Columns["nama_produk"].HeaderText = "Nama_Produk";
                dataGridView1.Columns["harga"].HeaderText = "Harga";
                dataGridView1.Columns["stok"].HeaderText = "Stok";
                dataGridView1.Columns["deskripsi"].HeaderText = "Deskripsi";
                dataGridView1.Columns["tanggal_upload"].HeaderText = "Tanggal Upload";
                dataGridView1.Columns["gambar_produk"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }

        }
      }
}
