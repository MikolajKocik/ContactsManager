namespace ContactsManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            txtPhoneNumber = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            lblPhoneNumber = new Label();
            lblFirstName = new Label();
            contactBindingSource = new BindingSource(components);
            dgvData = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnDelete = new Button();
            btnEdit = new Button();
            btnSearch = new Button();
            btnAdd = new Button();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)contactBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(txtPhoneNumber);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(txtFirstName);
            panel1.Controls.Add(lblLastName);
            panel1.Controls.Add(lblPhoneNumber);
            panel1.Controls.Add(lblFirstName);
            panel1.Location = new Point(181, -6);
            panel1.Name = "panel1";
            panel1.Size = new Size(193, 357);
            panel1.TabIndex = 0;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(29, 92);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(132, 25);
            txtPhoneNumber.TabIndex = 5;
            txtPhoneNumber.KeyDown += txtPhoneNumber_KeyDown;
            txtPhoneNumber.KeyPress += txtPhoneNumber_KeyPress;
            txtPhoneNumber.Validating += txtPhoneNumber_Validating;
            txtPhoneNumber.Validated += txtPhoneNumber_Validated;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(30, 275);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(132, 25);
            txtLastName.TabIndex = 4;
            txtLastName.KeyPress += txtLastName_KeyPress;
            txtLastName.Validating += txtLastName_Validating;
            txtLastName.Validated += txtLastName_Validated;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(30, 183);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(132, 25);
            txtFirstName.TabIndex = 3;
            txtFirstName.KeyPress += txtFirstName_KeyPress;
            txtFirstName.Validating += txtFirstName_Validating;
            txtFirstName.Validated += txtFirstName_Validated;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblLastName.ForeColor = Color.White;
            lblLastName.Location = new Point(51, 240);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(90, 21);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Last Name";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblPhoneNumber.ForeColor = Color.White;
            lblPhoneNumber.Location = new Point(38, 58);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(115, 20);
            lblPhoneNumber.TabIndex = 2;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblFirstName.ForeColor = Color.White;
            lblFirstName.Location = new Point(50, 148);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(92, 21);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name";
            // 
            // contactBindingSource
            // 
            contactBindingSource.DataSource = typeof(Contact);
            // 
            // dgvData
            // 
            dgvData.AutoGenerateColumns = false;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, PhoneNumber, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn });
            dgvData.DataSource = contactBindingSource;
            dgvData.Location = new Point(371, 0);
            dgvData.Name = "dgvData";
            dgvData.Size = new Size(344, 351);
            dgvData.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // PhoneNumber
            // 
            PhoneNumber.HeaderText = "PhoneNumber";
            PhoneNumber.Name = "PhoneNumber";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnEdit);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(btnAdd);
            panel2.Location = new Point(-1, -3);
            panel2.Name = "panel2";
            panel2.Size = new Size(185, 354);
            panel2.TabIndex = 2;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.delete;
            pictureBox4.Location = new Point(13, 277);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(47, 50);
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.edit;
            pictureBox3.Location = new Point(13, 200);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(47, 50);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.add;
            pictureBox2.Location = new Point(13, 123);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.search;
            pictureBox1.Location = new Point(13, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(84, 291);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(84, 214);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(84, 58);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(84, 136);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(715, 351);
            Controls.Add(panel2);
            Controls.Add(dgvData);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ContactsManager";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)contactBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtPhoneNumber;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label lblPhoneNumber;
        private Label lblLastName;
        private Label lblFirstName;
        private BindingSource contactBindingSource;
        private DataGridView dgvData;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private Panel panel2;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnSearch;
        private Button btnAdd;
        private ErrorProvider errorProvider1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}
