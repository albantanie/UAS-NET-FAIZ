using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace UAS_FAIZ
{
    public partial class Mahasiswa : Form
    {
        private SqlConnection connection;
        private string connectionString = "Data Source=LAPTOP-EH0JIO4F\\SQLEXPRESS;Initial Catalog=siakad_itts;Integrated Security=True;";

        public Mahasiswa()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
        }

        private void btnMasuk_Click_1(object sender, EventArgs e)
        {
            string nim = textBoxMahasiswa.Text;
            string password = textBoxPwMahasiswa.Text;

            if (string.IsNullOrEmpty(nim) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("NIM dan Password harus diisi.");
                return;
            }

            if (IsValidCredentials(nim, password))
            {
                MessageBox.Show("Login berhasil!");
                Portal_Mahasiwa mhs = new Portal_Mahasiwa();
                mhs.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("NIM atau Password salah atau terjadi kesalahan saat validasi.");
            }
        }

        private bool IsValidCredentials(string nim, string password)
        {
            try
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM mahasiswa WHERE nim = @nim AND Password = @password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nim", nim);
                command.Parameters.AddWithValue("@password", password);

                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during validation: " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            // Reset all textboxes to empty strings
            textBoxMahasiswa.Text = string.Empty;
            textBoxPwMahasiswa.Text = string.Empty;
        }
    }
}
