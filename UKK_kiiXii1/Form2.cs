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

                dataGridView1.Columns["id_produk"].HeaderText = "ID_Produk";
                dataGridView1.Columns["id_user"].HeaderText = "ID_User";
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

                    string sql = "INSERT INTO products (id_produk, id_user, nama_produk, harga, stok, deskripsi, gambar_produk, tanggal_upload) " +
                                 "VALUES (@id_produk, @id_user, @nama_produk, @harga, @stok, @deskripsi, @gambar_produk, @tanggal_upload)";

                    using (SqlCommand cmd = new SqlCommand(sql, Conn))
                    {
                        cmd.Parameters.AddWithValue("@id_produk", int.Parse(txtIDProduk.Text));
                        cmd.Parameters.AddWithValue("@id_user", UserSession.UserID);
                        cmd.Parameters.AddWithValue("@nama_produk", txtNamaProduk.Text);
                        cmd.Parameters.AddWithValue("@harga", decimal.Parse(txtHarga.Text));
                        cmd.Parameters.AddWithValue("@stok", int.Parse(txtStok.Text));
                        cmd.Parameters.AddWithValue("@deskripsi", txtDes.Text);
                        cmd.Parameters.AddWithValue("@tanggal_upload", DateTime.Now);

                        // Simpan gambar ke folder images di folder project saat ini
                        string imagesFolder = Path.Combine(Application.StartupPath, "images");
                        if (!Directory.Exists(imagesFolder))
                        {
                            Directory.CreateDirectory(imagesFolder);
                        }

                        if (pictureBox1.Image != null)
                        {
                            string imagePath = Path.Combine(imagesFolder, txtIDProduk.Text + ".jpg");
                            pictureBox1.Image.Save(imagePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                            cmd.Parameters.AddWithValue("@gambar_produk", imagePath);
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

                            //Form2_Load(sender, e);
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Gagal menambahkan produk.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
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
                txtIDProduk.Text = row.Cells["id_produk"].Value.ToString();
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
                if (string.IsNullOrEmpty(txtIDProduk.Text))
                {
                    MessageBox.Show("Pilih produk yang ingin dihapus!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtIDProduk.Text, out int itemId))
                {
                    MessageBox.Show("ID produk tidak valid!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

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

                // Ambil path gambar dulu
                string getImgQuery = "SELECT gambar_produk FROM products WHERE id_produk = @id";
                string imagePath = null;

                using (SqlCommand getImgCmd = new SqlCommand(getImgQuery, sqlConnection))
                {
                    getImgCmd.Parameters.AddWithValue("@id", itemId);
                    object result = getImgCmd.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                        imagePath = result.ToString();
                }

                string deleteQuery = "DELETE FROM products WHERE id_produk = @id_produk";
                using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, sqlConnection))
                {
                    deleteCmd.Parameters.AddWithValue("@id_produk", itemId);
                    deleteCmd.ExecuteNonQuery();
                }

                sqlConnection.Close();

                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();   // lepas memori
                    pictureBox1.Image = null;  
                }

                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    File.Delete(imagePath);
                }

                MessageBox.Show("Produk berhasil dihapus!", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // merefresh datagrid
                LoadData();

                txtNamaProduk.Clear();
                txtIDProduk.Clear();
                txtHarga.Clear();
                txtStok.Clear();
                txtDes.Clear();
                pictureBox1.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string id = txtIDProduk.Text.Trim();
            string nama = txtNamaProduk.Text.Trim();
            string harga = txtHarga.Text.Trim();
            string stok = txtStok.Text.Trim();
            string deskripsi = txtDes.Text.Trim();

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Pilih produk yang akan diupdate.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi harga & stok
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

            // Folder gambar
            string folderGambar = Path.Combine(Application.StartupPath, "images");
            if (!Directory.Exists(folderGambar))
            {
                Directory.CreateDirectory(folderGambar);
            }

            string gambarPath = ""; // path gambar untuk DB

            Conn koneksi = new Conn();
            using (SqlConnection conn = koneksi.GetConn())
            {
                try
                {
                    conn.Open();

                    // Ambil gambar lama dari DB
                    string queryGetImage = "SELECT gambar_produk FROM products WHERE id_produk = @id";
                    string gambarLama;
                    using (SqlCommand cmd = new SqlCommand(queryGetImage, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        gambarLama = cmd.ExecuteScalar()?.ToString() ?? string.Empty;
                    }

                    // Jika user memilih gambar baru
                    if (pictureBox1.Image != null)
                    {
                        // Buat nama file baru agar tidak overwrite file lama
                        string ext = ".jpg";
                        string namaFileBaru = $"{id}_{DateTime.Now:yyyyMMddHHmmss}{ext}";
                        string tempPath = Path.Combine(folderGambar, namaFileBaru);

                        using (Bitmap bmp = new Bitmap(pictureBox1.Image))
                        {
                            bmp.Save(tempPath, System.Drawing.Imaging.ImageFormat.Jpeg);
                        }

                        gambarPath = tempPath; // simpan path baru ke DB
                    }
                    else
                    {
                        // Jika tidak memilih gambar baru, tetap pakai gambar lama
                        gambarPath = string.IsNullOrEmpty(gambarLama) ? null : gambarLama;
                    }

                    // UPDATE produk
                    string updateQuery = @"UPDATE products 
                                   SET nama_produk=@nama, harga=@harga, stok=@stok, deskripsi=@deskripsi, 
                                       gambar_produk=@gambar_produk, tanggal_upload=@tanggal
                                   WHERE id_produk=@id";

                    using (SqlCommand cmdUpdate = new SqlCommand(updateQuery, conn))
                    {
                        cmdUpdate.Parameters.AddWithValue("@id", id);
                        cmdUpdate.Parameters.AddWithValue("@nama", nama);
                        cmdUpdate.Parameters.AddWithValue("@harga", hargaProduk);
                        cmdUpdate.Parameters.AddWithValue("@stok", stokProduk);
                        cmdUpdate.Parameters.AddWithValue("@deskripsi", deskripsi);
                        cmdUpdate.Parameters.AddWithValue("@gambar_produk", string.IsNullOrEmpty(gambarPath) ? (object)DBNull.Value : gambarPath);
                        cmdUpdate.Parameters.AddWithValue("@tanggal", DateTime.Now);

                        cmdUpdate.ExecuteNonQuery();
                    }

                    MessageBox.Show("Data berhasil diubah!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear form
                    txtIDProduk.Clear();
                    txtNamaProduk.Clear();
                    txtHarga.Clear();
                    txtStok.Clear();
                    txtDes.Clear();

                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose();
                        pictureBox1.Image = null;
                    }

                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
