using ContactsManager.Validators;
using Npgsql;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ContactsManager
{
    public partial class Form1 : Form
    {
        public string ConnectionString;

        private bool nonNumberEntered = false;

        public string FirstName => txtFirstName.Text;
        public string LastName => txtLastName.Text;
        public string PhoneNumber => txtPhoneNumber.Text;

        public Form1(string connectionString)
        {
            InitializeComponent();
            ConnectionString = connectionString!;

            // This turns off the automatic validation of the entire form.
            this.AutoValidate = AutoValidate.Disable;

            // Turns off validations for buttons
            btnSearch.CausesValidation = false;
            btnAdd.CausesValidation = false;
            btnEdit.CausesValidation = false;
            btnDelete.CausesValidation = false;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {

                await using var connection = new NpgsqlConnection(ConnectionString);

                await connection.OpenAsync();

                await using var command = new NpgsqlCommand("INSERT INTO data (FirstName, LastName, PhoneNumber) VALUES (@firstName, @lastName, @phoneNumber)", connection);

                command.Parameters.AddWithValue("@firstName", FirstName);
                command.Parameters.AddWithValue("@lastName", LastName);
                command.Parameters.AddWithValue("@phoneNumber", PhoneNumber);

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

        public void btnEdit_Click(object sender, EventArgs e)
        {
            EditForm form = new EditForm(this);
            form.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        // Validating
        public void txtPhoneNumber_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBoxValidating(sender as TextBox, e);
        }

        public void txtFirstName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBoxValidating(sender as TextBox, e);

        }

        public void txtLastName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBoxValidating(sender as TextBox, e);
        }

        // Validating method

        private void TextBoxValidating(TextBox textbox, CancelEventArgs e)
        {
            string errorMsg;

            if (!PreventEmptyField.ValidateNotEmpty(textbox.Text, out errorMsg))
            {
                textbox.Select(0, textbox.Text.Length);
                errorProvider1.SetError(textbox, errorMsg);
                e.Cancel = true;
            }

            this.errorProvider1.SetError(textbox, errorMsg);
        }


        // Validated

        public void txtPhoneNumber_Validated(object sender, EventArgs e)
        {
            TextBoxValidated(txtPhoneNumber);
        }

        public void txtFirstName_Validated(object sender, EventArgs e)
        {
            TextBoxValidated(txtFirstName);
        }

        public void txtLastName_Validated(object sender, EventArgs e)
        {
            TextBoxValidated(txtLastName);
        }

        // Validated method

        private void TextBoxValidated(TextBox textBox)
        {
            errorProvider1.SetError(textBox, "");
        }

        // KeyPress

        public void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtPhoneNumber.Text.Length >= 9 && e.KeyChar != '\b')
                e.Handled = true;

            if (nonNumberEntered == true)
                e.Handled = true;
        }

        public void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextChecker(sender as TextBox, e);
        }

        public void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextChecker(sender as TextBox, e);
        }

        // Text method
        private void TextChecker(TextBox textBox, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != ' ')
            {
                e.Handled = true;
            }

            if (e.KeyChar == ' ' && textBox.Text.Contains(' '))
            {
                e.Handled = true;
            }
        }

        // KeyDown Phone Number

        public void txtPhoneNumber_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;

            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back) // backspace
                    {
                        nonNumberEntered = true;
                    }
                }
            }

            if (Control.ModifierKeys == Keys.Shift)
                nonNumberEntered = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private async void LoadData()
        {
            await using var connection = new NpgsqlConnection(ConnectionString);

            await connection.OpenAsync();

            string query = "SELECT * FROM data";

            await using var command = new NpgsqlCommand(query, connection);

            await using var reader = await command.ExecuteReaderAsync();

            var dataTable = new DataTable();
            dataTable.Load(reader);

            dvgData.DataSource = dataTable;
        }
    }
}
