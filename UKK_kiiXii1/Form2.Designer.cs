namespace UKK_kiiXii1
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            txtNamaProduk = new TextBox();
            txtHarga = new TextBox();
            txtDes = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            txtStok = new TextBox();
            name = new Label();
            btnLogout = new Button();
            label1 = new Label();
            txtIDProduk = new TextBox();
            dtpTanggalProduk = new DateTimePicker();
            btnUpload = new Button();
            openFileDialog1 = new OpenFileDialog();
            btnupdate = new Button();
            btnTambah = new Button();
            btnHapus = new Button();
            txtSearch = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.InactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(508, 104);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(753, 236);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtNamaProduk
            // 
            txtNamaProduk.Location = new Point(216, 138);
            txtNamaProduk.Margin = new Padding(3, 2, 3, 2);
            txtNamaProduk.Name = "txtNamaProduk";
            txtNamaProduk.Size = new Size(267, 23);
            txtNamaProduk.TabIndex = 6;
            // 
            // txtHarga
            // 
            txtHarga.Location = new Point(218, 185);
            txtHarga.Margin = new Padding(3, 2, 3, 2);
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(142, 23);
            txtHarga.TabIndex = 7;
            // 
            // txtDes
            // 
            txtDes.Location = new Point(221, 230);
            txtDes.Margin = new Padding(3, 2, 3, 2);
            txtDes.Multiline = true;
            txtDes.Name = "txtDes";
            txtDes.Size = new Size(264, 110);
            txtDes.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(216, 121);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 9;
            label2.Text = "Nama Produk";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(218, 168);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 11;
            label4.Text = "Harga";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(221, 213);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 12;
            label5.Text = "Deskripsi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 97);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 13;
            label6.Text = "Gambar Produk";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(13, 115);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 138);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(379, 168);
            label8.Name = "label8";
            label8.Size = new Size(30, 15);
            label8.TabIndex = 19;
            label8.Text = "Stok";
            // 
            // txtStok
            // 
            txtStok.Location = new Point(379, 185);
            txtStok.Margin = new Padding(3, 2, 3, 2);
            txtStok.Name = "txtStok";
            txtStok.Size = new Size(78, 23);
            txtStok.TabIndex = 18;
            // 
            // name
            // 
            name.BackColor = Color.DarkBlue;
            name.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name.ForeColor = Color.GhostWhite;
            name.Location = new Point(0, -9);
            name.Name = "name";
            name.Size = new Size(1261, 42);
            name.TabIndex = 20;
            name.Text = "Selamat Datang,";
            name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Red;
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.ForeColor = SystemColors.Control;
            btnLogout.Location = new Point(1037, 5);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(71, 22);
            btnLogout.TabIndex = 21;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(219, 66);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 23;
            label1.Text = "ID Produk";
            // 
            // txtIDProduk
            // 
            txtIDProduk.Location = new Point(217, 92);
            txtIDProduk.Margin = new Padding(3, 2, 3, 2);
            txtIDProduk.Name = "txtIDProduk";
            txtIDProduk.Size = new Size(127, 23);
            txtIDProduk.TabIndex = 22;
            // 
            // dtpTanggalProduk
            // 
            dtpTanggalProduk.Location = new Point(15, 310);
            dtpTanggalProduk.Margin = new Padding(3, 2, 3, 2);
            dtpTanggalProduk.Name = "dtpTanggalProduk";
            dtpTanggalProduk.Size = new Size(184, 23);
            dtpTanggalProduk.TabIndex = 24;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(15, 267);
            btnUpload.Margin = new Padding(3, 2, 3, 2);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(184, 26);
            btnUpload.TabIndex = 25;
            btnUpload.Text = "Upload Gambar";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnupdate
            // 
            btnupdate.Location = new Point(315, 356);
            btnupdate.Margin = new Padding(3, 2, 3, 2);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(82, 26);
            btnupdate.TabIndex = 3;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += btnupdate_Click;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(219, 356);
            btnTambah.Margin = new Padding(3, 2, 3, 2);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(82, 26);
            btnTambah.TabIndex = 2;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(412, 356);
            btnHapus.Margin = new Padding(3, 2, 3, 2);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(82, 26);
            btnHapus.TabIndex = 26;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(508, 66);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(316, 23);
            txtSearch.TabIndex = 27;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label3
            // 
            label3.BackColor = Color.Black;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.ForeColor = Color.White;
            label3.Location = new Point(830, 69);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 28;
            label3.Text = "Search";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1263, 419);
            Controls.Add(label3);
            Controls.Add(txtSearch);
            Controls.Add(btnHapus);
            Controls.Add(btnUpload);
            Controls.Add(dtpTanggalProduk);
            Controls.Add(label1);
            Controls.Add(txtIDProduk);
            Controls.Add(btnLogout);
            Controls.Add(name);
            Controls.Add(label8);
            Controls.Add(txtStok);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txtDes);
            Controls.Add(txtHarga);
            Controls.Add(txtNamaProduk);
            Controls.Add(btnupdate);
            Controls.Add(btnTambah);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private TextBox txtNamaProduk;
        private TextBox txtHarga;
        private TextBox txtDes;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
        private Label label8;
        private TextBox txtStok;
        private Label name;
        private Button btnLogout;
        private Label label1;
        private TextBox txtIDProduk;
        private DateTimePicker dtpTanggalProduk;
        private Button btnUpload;
        private OpenFileDialog openFileDialog1;
        private Button btnupdate;
        private Button btnTambah;
        private Button btnHapus;
        private TextBox txtSearch;
        private Label label3;
    }
}