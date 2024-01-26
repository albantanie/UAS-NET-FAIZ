namespace UAS_FAIZ
{
    partial class SIAKAD
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAkademik = new Button();
            btnMahasiswa = new Button();
            btnDosen = new Button();
            labelWelcome = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAkademik
            // 
            btnAkademik.Location = new Point(33, 273);
            btnAkademik.Name = "btnAkademik";
            btnAkademik.Size = new Size(191, 165);
            btnAkademik.TabIndex = 0;
            btnAkademik.Text = "Akademik";
            btnAkademik.UseVisualStyleBackColor = true;
            btnAkademik.Click += btnAkademik_Click;
            // 
            // btnMahasiswa
            // 
            btnMahasiswa.Location = new Point(301, 273);
            btnMahasiswa.Name = "btnMahasiswa";
            btnMahasiswa.Size = new Size(191, 165);
            btnMahasiswa.TabIndex = 1;
            btnMahasiswa.Text = "Mahasiswa";
            btnMahasiswa.UseVisualStyleBackColor = true;
            btnMahasiswa.Click += btnMahasiswa_Click;
            // 
            // btnDosen
            // 
            btnDosen.Location = new Point(562, 273);
            btnDosen.Name = "btnDosen";
            btnDosen.Size = new Size(191, 165);
            btnDosen.TabIndex = 2;
            btnDosen.Text = "Dosen";
            btnDosen.UseVisualStyleBackColor = true;
            btnDosen.Click += btnDosen_Click;
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelWelcome.Location = new Point(187, 9);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(405, 38);
            labelWelcome.TabIndex = 4;
            labelWelcome.Text = "Selamat Datang di SIAKAD ITTS";
            labelWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(343, 228);
            label1.Name = "label1";
            label1.Size = new Size(101, 28);
            label1.TabIndex = 5;
            label1.Text = "Pilih Role :";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_login;
            pictureBox1.Location = new Point(303, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // SIAKAD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(labelWelcome);
            Controls.Add(btnDosen);
            Controls.Add(btnMahasiswa);
            Controls.Add(btnAkademik);
            Name = "SIAKAD";
            Text = "SIAKAD ITTS";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAkademik;
        private Button btnMahasiswa;
        private Button btnDosen;
        private Label labelWelcome;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
