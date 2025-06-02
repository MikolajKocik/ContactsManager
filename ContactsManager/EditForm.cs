using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            txtLastName.Text = formMain.LastName;
            txtFirstName.Text = formMain.FirstName;
            txtPhoneNumber.Text = formMain.PhoneNumber;
        }

        private void chkLastName_CheckedChanged(object sender, EventArgs e)
        {
            if (Checked(chkLastName) == true)
            {
                errorProvider1.SetError(txtLastName, "");
            }
        }

        private void chkFirstName_CheckedChanged(object sender, EventArgs e)
        {
            if (Checked(chkFirstName) == true)
            {
                errorProvider1.SetError(txtFirstName, "");
            }
        }

        private void chkPhoneNumber_CheckedChanged(object sender, EventArgs e)
        {
            if (Checked(chkPhoneNumber) == true)
            {
                errorProvider1.SetError(txtPhoneNumber, "");
            }
        }

        private bool Checked(CheckBox checkBox)
            => checkBox.Checked;

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                string phoneNumber = txtPhoneNumber.Text;

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

                    await updateCommand.ExecuteNonQueryAsync();

                    MessageBox.Show("Record updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("User with provided phone number not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}