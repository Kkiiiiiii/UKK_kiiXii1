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
            Id = new DataGridViewTextBoxColumn();
            NamaProduk = new DataGridViewTextBoxColumn();
            Harga = new DataGridViewTextBoxColumn();
            Stok = new DataGridViewTextBoxColumn();
            Deskripsi = new DataGridViewTextBoxColumn();
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
            openFileDialog1 = new OpenFileDialog();
            button4 = new Button();
            label8 = new Label();
            txtStok = new TextBox();
            name = new Label();
            btnLogout = new Button();
            label1 = new Label();
            txtIDProduk = new TextBox();
            dtpTanggalProduk = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, NamaProduk, Harga, Stok, Deskripsi });
            dataGridView1.Location = new Point(12, 59);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(679, 314);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Id
            // 
            Id.HeaderText = "ID Produk";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // NamaProduk
            // 
            NamaProduk.HeaderText = "Nama Produk";
            NamaProduk.MinimumWidth = 6;
            NamaProduk.Name = "NamaProduk";
            NamaProduk.Width = 125;
            // 
            // Harga
            // 
            Harga.HeaderText = "Harga";
            Harga.MinimumWidth = 6;
            Harga.Name = "Harga";
            Harga.Width = 125;
            // 
            // Stok
            // 
            Stok.HeaderText = "Stok";
            Stok.MinimumWidth = 6;
            Stok.Name = "Stok";
            Stok.Width = 125;
            // 
            // Deskripsi
            // 
            Deskripsi.HeaderText = "Deskripsi";
            Deskripsi.MinimumWidth = 6;
            Deskripsi.Name = "Deskripsi";
            Deskripsi.Width = 125;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(958, 428);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(94, 34);
            btnTambah.TabIndex = 2;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnupdate
            // 
            btnupdate.Location = new Point(1068, 428);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(94, 34);
            btnupdate.TabIndex = 3;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(1178, 428);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(94, 29);
            btnHapus.TabIndex = 4;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            // 
            // txtIDUser
            // 
            txtIDUser.Location = new Point(959, 153);
            txtIDUser.Name = "txtIDUser";
            txtIDUser.Size = new Size(305, 27);
            txtIDUser.TabIndex = 5;
            // 
            // txtNamaProduk
            // 
            txtNamaProduk.Location = new Point(956, 215);
            txtNamaProduk.Name = "txtNamaProduk";
            txtNamaProduk.Size = new Size(305, 27);
            txtNamaProduk.TabIndex = 6;
            // 
            // txtHarga
            // 
            txtHarga.Location = new Point(957, 267);
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(305, 27);
            txtHarga.TabIndex = 7;
            // 
            // txtDes
            // 
            txtDes.Location = new Point(957, 382);
            txtDes.Name = "txtDes";
            txtDes.Size = new Size(305, 27);
            txtDes.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(956, 192);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 9;
            label2.Text = "Nama Produk";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(959, 129);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 10;
            label3.Text = "ID User";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(957, 244);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 11;
            label4.Text = "Harga";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(959, 359);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 12;
            label5.Text = "deskripsi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(726, 96);
            label6.Name = "label6";
            label6.Size = new Size(112, 20);
            label6.TabIndex = 13;
            label6.Text = "Gambar Produk";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(726, 133);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 184);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button4
            // 
            button4.Location = new Point(726, 322);
            button4.Name = "button4";
            button4.Size = new Size(210, 34);
            button4.TabIndex = 17;
            button4.Text = "Unggah Gambar";
            button4.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(957, 301);
            label8.Name = "label8";
            label8.Size = new Size(38, 20);
            label8.TabIndex = 19;
            label8.Text = "Stok";
            // 
            // txtStok
            // 
            txtStok.Location = new Point(957, 324);
            txtStok.Name = "txtStok";
            txtStok.Size = new Size(305, 27);
            txtStok.TabIndex = 18;
            // 
            // name
            // 
            name.BackColor = Color.DarkBlue;
            name.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name.ForeColor = Color.GhostWhite;
            name.Location = new Point(-1, -1);
            name.Name = "name";
            name.Size = new Size(1284, 40);
            name.TabIndex = 20;
            name.Text = "Selamat Datang,";
            name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Red;
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.ForeColor = SystemColors.Control;
            btnLogout.Location = new Point(1081, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(81, 30);
            btnLogout.TabIndex = 21;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(956, 65);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 23;
            label1.Text = "ID Produk";
            // 
            // txtIDProduk
            // 
            txtIDProduk.Location = new Point(956, 89);
            txtIDProduk.Name = "txtIDProduk";
            txtIDProduk.Size = new Size(305, 27);
            txtIDProduk.TabIndex = 22;
            // 
            // dtpTanggalProduk
            // 
            dtpTanggalProduk.Location = new Point(728, 380);
            dtpTanggalProduk.Name = "dtpTanggalProduk";
            dtpTanggalProduk.Size = new Size(210, 27);
            dtpTanggalProduk.TabIndex = 24;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1283, 532);
            Controls.Add(dtpTanggalProduk);
            Controls.Add(label1);
            Controls.Add(txtIDProduk);
            Controls.Add(btnLogout);
            Controls.Add(name);
            Controls.Add(label8);
            Controls.Add(txtStok);
            Controls.Add(button4);
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
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
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
        private OpenFileDialog openFileDialog1;
        private Button button4;
        private Label label8;
        private TextBox txtStok;
        private Label name;
        private Button btnLogout;
        private Label label1;
        private TextBox txtIDProduk;
        private DateTimePicker dtpTanggalProduk;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn NamaProduk;
        private DataGridViewTextBoxColumn Harga;
        private DataGridViewTextBoxColumn Stok;
        private DataGridViewTextBoxColumn Deskripsi;
    }
}