using Npgsql;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ContactsManager
{
    public partial class Form1 : Form
    {
        private string _connectionString;

        public Form1(string connectionString)
        {
            InitializeComponent();
            _connectionString = connectionString!;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {

                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                string phoneNumber = txtPhoneNumber.Text;

                await using var connection = new NpgsqlConnection(_connectionString);

                await connection.OpenAsync();

                await using var command = new NpgsqlCommand("INSERT INTO data (FirstName, LastName, PhoneNumber) VALUES (@firstName, @lastName, @phoneNumber)", connection);

                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@lastName", lastName);
                command.Parameters.AddWithValue("@phoneNumber", phoneNumber);

                await command.ExecuteNonQueryAsync();

                MessageBox.Show("Record added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please fix the errors before submitting.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        // Validating
        private void txtPhoneNumber_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string errorMsg;

            if(!ValidateHelpers.ValidateNotEmpty(txtPhoneNumber.Text, out errorMsg))
            {
                e.Cancel = true;
                txtPhoneNumber.Select(0, txtPhoneNumber.Text.Length);
            }

            this.errorProvider1.SetError(txtPhoneNumber, errorMsg);
        }

        private void txtFirstName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string errorMsg;

            if (!ValidateHelpers.ValidateNotEmpty(txtFirstName.Text, out errorMsg))
            {
                e.Cancel = true;
                txtFirstName.Select(0, txtFirstName.Text.Length);
            }

            this.errorProvider1.SetError(txtPhoneNumber, errorMsg);
        }

        private void txtLastName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string errorMsg;

            if(!ValidateHelpers.ValidateNotEmpty(txtLastName.Text, out errorMsg))
            {
                e.Cancel = true;
                txtLastName.Select(0, txtLastName.Text.Length);
            }

            this.errorProvider1.SetError(txtLastName, errorMsg);
        }

        // Validated

        private void txtPhoneNumber_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtPhoneNumber, "");
        }

        private void txtFirstName_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtFirstName, "");

        }

        private void txtLastName_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtLastName, "");

        }
    }
}
