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
            dvgData = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
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
            panel3 = new Panel();
            pictureBox7 = new PictureBox();
            btnClear = new Button();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            btnRefresh = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)contactBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgData).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
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
            panel1.Location = new Point(181, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(193, 353);
            panel1.TabIndex = 0;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(31, 86);
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
            txtLastName.Location = new Point(32, 269);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(132, 25);
            txtLastName.TabIndex = 4;
            txtLastName.KeyPress += txtLastName_KeyPress;
            txtLastName.Validating += txtLastName_Validating;
            txtLastName.Validated += txtLastName_Validated;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(32, 177);
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
            lblLastName.Location = new Point(53, 234);
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
            lblPhoneNumber.Location = new Point(40, 52);
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
            lblFirstName.Location = new Point(52, 142);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(92, 21);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name";
            // 
            // contactBindingSource
            // 
            contactBindingSource.DataSource = typeof(Contact);
            // 
            // dvgData
            // 
            dvgData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dvgData.AutoGenerateColumns = false;
            dvgData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgData.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn });
            dvgData.DataSource = contactBindingSource;
            dvgData.Location = new Point(371, -2);
            dvgData.Name = "dvgData";
            dvgData.Size = new Size(344, 358);
            dvgData.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
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
            panel2.Location = new Point(-1, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(185, 353);
            panel2.TabIndex = 2;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.delete;
            pictureBox4.Location = new Point(17, 271);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(47, 50);
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.edit;
            pictureBox3.Location = new Point(17, 194);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(47, 50);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.add;
            pictureBox2.Location = new Point(17, 117);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.search;
            pictureBox1.Location = new Point(17, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.GradientActiveCaption;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderColor = Color.Black;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.Orange;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(88, 276);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 43);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.GradientActiveCaption;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderColor = Color.Black;
            btnEdit.FlatAppearance.MouseOverBackColor = Color.Orange;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Location = new Point(88, 198);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 43);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.GradientActiveCaption;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderColor = Color.Black;
            btnSearch.FlatAppearance.MouseOverBackColor = Color.Orange;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(88, 41);
            btnSearch.Name = "btnSearch";
            btnSearch.Padding = new Padding(1);
            btnSearch.Size = new Size(75, 43);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.GradientActiveCaption;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderColor = Color.Black;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.Orange;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(88, 121);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 43);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLight;
            panel3.Controls.Add(pictureBox7);
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(pictureBox6);
            panel3.Controls.Add(pictureBox5);
            panel3.Controls.Add(btnRefresh);
            panel3.Location = new Point(712, -2);
            panel3.Name = "panel3";
            panel3.Size = new Size(184, 353);
            panel3.TabIndex = 3;
            // 
            // pictureBox7
            // 
            pictureBox7.BackgroundImage = Properties.Resources.edit_clear_history_973x1024;
            pictureBox7.Location = new Point(123, 280);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(47, 50);
            pictureBox7.TabIndex = 4;
            pictureBox7.TabStop = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.GradientActiveCaption;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.MouseOverBackColor = Color.Orange;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Location = new Point(23, 283);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 47);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear fields";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.LightGray;
            pictureBox6.BackgroundImage = Properties.Resources.contact_list_address_book_icon_address_ico_icon_design_android_book_square_design;
            pictureBox6.Location = new Point(17, 18);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(150, 150);
            pictureBox6.TabIndex = 2;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = Properties.Resources.refresh_icon_2048x2048_sx32gmk1;
            pictureBox5.Location = new Point(120, 194);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(50, 50);
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.GradientActiveCaption;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.MouseOverBackColor = Color.Orange;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Location = new Point(23, 198);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 43);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(896, 351);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(dvgData);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ContactsManager";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)contactBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgData).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
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
        private DataGridView dvgData;
        private Panel panel2;
        private ErrorProvider errorProvider1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnSearch;
        private Button btnAdd;
        private Panel panel3;
        private PictureBox pictureBox5;
        private Button btnRefresh;
        private PictureBox pictureBox6;
        private Button btnClear;
        private PictureBox pictureBox7;
    }
}
