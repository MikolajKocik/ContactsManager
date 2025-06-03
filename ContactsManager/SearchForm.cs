using Npgsql;
using System.Data;

namespace ContactsManager
{
    public partial class SearchForm : Form
    {
        private Form1 _formMain;
        private string _connectionString;
        public SearchForm(Form1 formMain)
        {
            if (formMain == null) throw new ArgumentNullException(nameof(formMain));

            InitializeComponent();

            _formMain = formMain;

            _connectionString = _formMain.ConnectionString;

            this.AutoValidate = AutoValidate.Disable;

            txtSearch.Validating += _formMain.txtPhoneNumber_Validating;
            txtSearch.Validated += _formMain.txtPhoneNumber_Validated;
            txtSearch.KeyDown += _formMain.txtPhoneNumber_KeyDown;
            txtSearch.KeyPress += _formMain.txtPhoneNumber_KeyPress;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string phoneNumber = txtSearch.Text;

            if(string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                MessageBox.Show("Provide phone number to search contact", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            await using var connection = new NpgsqlConnection(_connectionString);

            await connection.OpenAsync();

            string query = $"SELECT * FROM data WHERE PhoneNumber = @phoneNumber";

            await using var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@phoneNumber", phoneNumber);

            await using var reader = await command.ExecuteReaderAsync();

            var dataTable = new DataTable();
            dataTable.Load(reader);

            dgvSearch.DataSource = dataTable;
        }
    }
}
