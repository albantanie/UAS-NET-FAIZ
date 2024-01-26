namespace UAS_FAIZ
{
    public partial class SIAKAD : Form
    {
        public SIAKAD()
        {
            InitializeComponent();


        }

        private void btnAkademik_Click(object sender, EventArgs e)
        {
            Akademik akademik = new Akademik();
            akademik.Show();
            this.Hide();
        }

        private void btnMahasiswa_Click(object sender, EventArgs e)
        {
            Mahasiswa mahasiswa = new Mahasiswa();
            mahasiswa.Show();
            this.Hide();
        }

        private void btnDosen_Click(object sender, EventArgs e)
        {
            Dosen dosen = new Dosen();
            dosen.Show();
            this.Hide();
        }
    }



}
