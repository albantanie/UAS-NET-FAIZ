namespace UAS_FAIZ
{
    partial class Mahasiswa
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
            label1 = new Label();
            label2 = new Label();
            textBoxMahasiswa = new TextBox();
            textBoxPwMahasiswa = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnMasuk = new Button();
            btnReset = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(250, 9);
            label1.Name = "label1";
            label1.Size = new Size(290, 31);
            label1.TabIndex = 0;
            label1.Text = "Sistem Informasi Akademik";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(335, 40);
            label2.Name = "label2";
            label2.Size = new Size(127, 31);
            label2.TabIndex = 1;
            label2.Text = "Mahasiswa";
            // 
            // textBoxMahasiswa
            // 
            textBoxMahasiswa.Location = new Point(250, 265);
            textBoxMahasiswa.Name = "textBoxMahasiswa";
            textBoxMahasiswa.Size = new Size(290, 27);
            textBoxMahasiswa.TabIndex = 2;
            // 
            // textBoxPwMahasiswa
            // 
            textBoxPwMahasiswa.Location = new Point(250, 336);
            textBoxPwMahasiswa.Name = "textBoxPwMahasiswa";
            textBoxPwMahasiswa.Size = new Size(290, 27);
            textBoxPwMahasiswa.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(250, 242);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 4;
            label3.Text = "NIM";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(250, 313);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 5;
            label4.Text = "Password";
            // 
            // btnMasuk
            // 
            btnMasuk.Location = new Point(250, 389);
            btnMasuk.Name = "btnMasuk";
            btnMasuk.Size = new Size(138, 37);
            btnMasuk.TabIndex = 6;
            btnMasuk.Text = "Masuk";
            btnMasuk.UseVisualStyleBackColor = true;
            btnMasuk.Click += btnMasuk_Click_1;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(394, 389);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(146, 37);
            btnReset.TabIndex = 7;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_login;
            pictureBox1.Location = new Point(299, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Mahasiswa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnReset);
            Controls.Add(btnMasuk);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxPwMahasiswa);
            Controls.Add(textBoxMahasiswa);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Mahasiswa";
            Text = "Mahasiswa";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxMahasiswa;
        private TextBox textBoxPwMahasiswa;
        private Label label3;
        private Label label4;
        private Button btnMasuk;
        private Button btnReset;
        private PictureBox pictureBox1;
    }
}