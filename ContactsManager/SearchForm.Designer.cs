namespace ContactsManager
{
    partial class SearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            btnSearch = new Button();
            dgvSearch = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contactBindingSource = new BindingSource(components);
            label1 = new Label();
            txtSearch = new TextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)contactBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(dgvSearch);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(354, 163);
            panel1.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.GradientActiveCaption;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.MouseOverBackColor = Color.Orange;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnSearch.Location = new Point(302, 52);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(31, 33);
            btnSearch.TabIndex = 4;
            btnSearch.Text = ">";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvSearch
            // 
            dgvSearch.AutoGenerateColumns = false;
            dgvSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSearch.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn });
            dgvSearch.DataSource = contactBindingSource;
            dgvSearch.Location = new Point(2, 102);
            dgvSearch.Name = "dgvSearch";
            dgvSearch.Size = new Size(345, 83);
            dgvSearch.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Visible = false;
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
            // phoneNumberDataGridViewTextBoxColumn
            // 
            phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // contactBindingSource
            // 
            contactBindingSource.DataSource = typeof(Contact);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(149, 27);
            label1.Name = "label1";
            label1.Size = new Size(143, 17);
            label1.TabIndex = 2;
            label1.Text = "Search phone number";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(147, 59);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(145, 23);
            txtSearch.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.search_human_image;
            pictureBox1.Location = new Point(12, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 86);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 173);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "SearchForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SearchForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)contactBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private DataGridView dgvSearch;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private BindingSource contactBindingSource;
        private Label label1;
        private TextBox txtSearch;
        private Button btnSearch;
    }
}