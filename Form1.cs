namespace ContactsManager
{
    public partial class Form1 : Form
    {
        private string _connectionString;
        public Form1(string connectionString)
        {
            InitializeComponent();
            connectionString = _connectionString!;
        }
    }
}
