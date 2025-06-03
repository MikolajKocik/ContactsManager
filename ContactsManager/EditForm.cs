using Npgsql;

namespace ContactsManager
{
    public partial class EditForm : Form
    {
        private Form1 _formMain;
        private string _connectionString;

        public EditForm(Form1 formMain)
        {
            if (formMain == null) throw new ArgumentNullException(nameof(formMain));

            InitializeComponent();

            _formMain = formMain;

            this.AutoValidate = AutoValidate.Disable;

            // events

            txtFirstName.KeyPress += _formMain.txtFirstName_KeyPress;
            txtLastName.KeyPress += _formMain.txtLastName_KeyPress;
            txtPhoneNumber.KeyPress += _formMain.txtPhoneNumber_KeyPress;

            txtPhoneNumber.KeyDown += _formMain.txtPhoneNumber_KeyDown;

            txtFirstName.Validating += _formMain.txtFirstName_Validating;
            txtLastName.Validating += _formMain.txtLastName_Validating;
            txtPhoneNumber.Validating += _formMain.txtPhoneNumber_Validating;

            txtFirstName.Validated += _formMain.txtFirstName_Validated;
            txtLastName.Validated += _formMain.txtLastName_Validated;
            txtPhoneNumber.Validated += _formMain.txtPhoneNumber_Validated;

            _connectionString = formMain.ConnectionString;
        }

        private void chkLastName_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLastName.Checked)
            {
                txtLastName.CausesValidation = false;
                txtLastName.Validating -= _formMain.txtLastName_Validating;
                txtLastName.Validated -= _formMain.txtLastName_Validated;
                errorProvider1.SetError(txtLastName, "");
            }
            else
            {
                txtLastName.CausesValidation = true;
                txtLastName.Validating += _formMain.txtLastName_Validating;
                txtLastName.Validated += _formMain.txtLastName_Validated;
            }
        }

        private void chkFirstName_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFirstName.Checked)
            {
                txtFirstName.CausesValidation = false;
                txtFirstName.Validating -= _formMain.txtFirstName_Validating;
                txtFirstName.Validated -= _formMain.txtFirstName_Validated;
                errorProvider1.SetError(txtFirstName, "");
            }
            else
            {
                txtFirstName.CausesValidation = true;
                txtFirstName.Validating += _formMain.txtFirstName_Validating;
                txtFirstName.Validated += _formMain.txtFirstName_Validated;
            }
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                string phoneNumber = txtPhoneNumber.Text;
                string firstName = chkFirstName.Checked || string.IsNullOrWhiteSpace(txtFirstName.Text) ? await LoadDataFromDatabase("FirstName", phoneNumber) :  txtFirstName.Text;
                string lastName = chkLastName.Checked || string.IsNullOrWhiteSpace(txtLastName.Text) ? await LoadDataFromDatabase("LastName", phoneNumber) :  txtLastName.Text;

                await using var connection = new NpgsqlConnection(_connectionString);

                await connection.OpenAsync();

                await using var searchCommand = new NpgsqlCommand("SELECT id FROM data WHERE PhoneNumber = @phoneNumber", connection);

                searchCommand.Parameters.AddWithValue("@phoneNumber", phoneNumber);

                var id = (int?)await searchCommand.ExecuteScalarAsync();

                if (id.HasValue)
                {
                    await using var updateCommand = new NpgsqlCommand("UPDATE data SET FirstName = @firstName, LastName = @lastName, PhoneNumber = @phoneNumber WHERE id = @id", connection);

                    updateCommand.Parameters.AddWithValue("@firstName", firstName);
                    updateCommand.Parameters.AddWithValue("@lastName", lastName);
                    updateCommand.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                    updateCommand.Parameters.AddWithValue("@id", id.Value);

                    try
                    {
                        await updateCommand.ExecuteNonQueryAsync();
                        MessageBox.Show("Record updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Npgsql.PostgresException ex)
                    {
                        MessageBox.Show(string.Join(", ", ex.Message, ex.Detail), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("User with provided phone number not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async Task<string> LoadDataFromDatabase(string column, string phoneNumber)
        {
            await using var connection = new NpgsqlConnection(_connectionString);

            await connection.OpenAsync();

            await using var command = new NpgsqlCommand($"SELECT {column} FROM data WHERE PhoneNumber = @phoneNumber", connection);

            command.Parameters.AddWithValue("@phoneNumber", phoneNumber);

            var result = await command.ExecuteScalarAsync();

            return result?.ToString() ?? throw new ArgumentNullException($"{column} not found"); 
        }
    }
}