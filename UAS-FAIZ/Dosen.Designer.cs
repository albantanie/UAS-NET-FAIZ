namespace UAS_FAIZ
{
    partial class Dosen
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
            pictureBox1 = new PictureBox();
            btnReset = new Button();
            btnMasuk = new Button();
            label4 = new Label();
            label3 = new Label();
            textBoxPwDosen = new TextBox();
            textBoxDosen = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_login;
            pictureBox1.Location = new Point(304, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(399, 397);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(146, 37);
            btnReset.TabIndex = 16;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnMasuk
            // 
            btnMasuk.Location = new Point(255, 397);
            btnMasuk.Name = "btnMasuk";
            btnMasuk.Size = new Size(138, 37);
            btnMasuk.TabIndex = 15;
            btnMasuk.Text = "Masuk";
            btnMasuk.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(255, 321);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 14;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(255, 250);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 13;
            label3.Text = "NIP";
            // 
            // textBoxPwDosen
            // 
            textBoxPwDosen.Location = new Point(255, 344);
            textBoxPwDosen.Name = "textBoxPwDosen";
            textBoxPwDosen.Size = new Size(290, 27);
            textBoxPwDosen.TabIndex = 12;
            // 
            // textBoxDosen
            // 
            textBoxDosen.Location = new Point(255, 273);
            textBoxDosen.Name = "textBoxDosen";
            textBoxDosen.Size = new Size(290, 27);
            textBoxDosen.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(359, 48);
            label2.Name = "label2";
            label2.Size = new Size(78, 31);
            label2.TabIndex = 10;
            label2.Text = "Dosen";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(255, 17);
            label1.Name = "label1";
            label1.Size = new Size(290, 31);
            label1.TabIndex = 9;
            label1.Text = "Sistem Informasi Akademik";
            // 
            // Dosen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnReset);
            Controls.Add(btnMasuk);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxPwDosen);
            Controls.Add(textBoxDosen);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Dosen";
            Text = "Dosen";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnReset;
        private Button btnMasuk;
        private Label label4;
        private Label label3;
        private TextBox textBoxPwDosen;
        private TextBox textBoxDosen;
        private Label label2;
        private Label label1;
    }
}