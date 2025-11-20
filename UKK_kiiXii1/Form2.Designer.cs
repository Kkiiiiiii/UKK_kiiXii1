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
            btnTambah = new Button();
            btnupdate = new Button();
            btnHapus = new Button();
            txtIDUser = new TextBox();
            txtNamaProduk = new TextBox();
            txtHarga = new TextBox();
            txtDes = new TextBox();
            label2 = new Label();
            label3 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 44);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(594, 236);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(838, 321);
            btnTambah.Margin = new Padding(3, 2, 3, 2);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(82, 26);
            btnTambah.TabIndex = 2;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnupdate
            // 
            btnupdate.Location = new Point(934, 321);
            btnupdate.Margin = new Padding(3, 2, 3, 2);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(82, 26);
            btnupdate.TabIndex = 3;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(1031, 321);
            btnHapus.Margin = new Padding(3, 2, 3, 2);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(82, 22);
            btnHapus.TabIndex = 4;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            // 
            // txtIDUser
            // 
            txtIDUser.Location = new Point(978, 67);
            txtIDUser.Margin = new Padding(3, 2, 3, 2);
            txtIDUser.Name = "txtIDUser";
            txtIDUser.Size = new Size(124, 23);
            txtIDUser.TabIndex = 5;
            // 
            // txtNamaProduk
            // 
            txtNamaProduk.Location = new Point(838, 113);
            txtNamaProduk.Margin = new Padding(3, 2, 3, 2);
            txtNamaProduk.Name = "txtNamaProduk";
            txtNamaProduk.Size = new Size(267, 23);
            txtNamaProduk.TabIndex = 6;
            // 
            // txtHarga
            // 
            txtHarga.Location = new Point(840, 160);
            txtHarga.Margin = new Padding(3, 2, 3, 2);
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(142, 23);
            txtHarga.TabIndex = 7;
            // 
            // txtDes
            // 
            txtDes.Location = new Point(843, 205);
            txtDes.Margin = new Padding(3, 2, 3, 2);
            txtDes.Multiline = true;
            txtDes.Name = "txtDes";
            txtDes.Size = new Size(264, 110);
            txtDes.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(838, 96);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 9;
            label2.Text = "Nama Produk";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(978, 49);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 10;
            label3.Text = "ID User";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(840, 143);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 11;
            label4.Text = "Harga";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(841, 187);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 12;
            label5.Text = "Deskripsi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(635, 72);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 13;
            label6.Text = "Gambar Produk";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(635, 100);
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
            label8.Location = new Point(1001, 143);
            label8.Name = "label8";
            label8.Size = new Size(30, 15);
            label8.TabIndex = 19;
            label8.Text = "Stok";
            // 
            // txtStok
            // 
            txtStok.Location = new Point(1001, 160);
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
            name.Location = new Point(-1, -1);
            name.Name = "name";
            name.Size = new Size(1124, 30);
            name.TabIndex = 20;
            name.Text = "Selamat Datang,";
            name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Red;
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.ForeColor = SystemColors.Control;
            btnLogout.Location = new Point(946, 3);
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
            label1.Location = new Point(836, 49);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 23;
            label1.Text = "ID Produk";
            // 
            // txtIDProduk
            // 
            txtIDProduk.Location = new Point(836, 67);
            txtIDProduk.Margin = new Padding(3, 2, 3, 2);
            txtIDProduk.Name = "txtIDProduk";
            txtIDProduk.Size = new Size(127, 23);
            txtIDProduk.TabIndex = 22;
            // 
            // dtpTanggalProduk
            // 
            dtpTanggalProduk.Location = new Point(637, 285);
            dtpTanggalProduk.Margin = new Padding(3, 2, 3, 2);
            dtpTanggalProduk.Name = "dtpTanggalProduk";
            dtpTanggalProduk.Size = new Size(184, 23);
            dtpTanggalProduk.TabIndex = 24;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(637, 243);
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
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1123, 399);
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
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtDes);
            Controls.Add(txtHarga);
            Controls.Add(txtNamaProduk);
            Controls.Add(txtIDUser);
            Controls.Add(btnHapus);
            Controls.Add(btnupdate);
            Controls.Add(btnTambah);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Button btnTambah;
        private Button btnupdate;
        private Button btnHapus;
        private TextBox txtIDUser;
        private TextBox txtNamaProduk;
        private TextBox txtHarga;
        private TextBox txtDes;
        private Label label2;
        private Label label3;
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
    }
}