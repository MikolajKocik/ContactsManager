namespace ContactsManager
{
    partial class EditForm
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
            btnSubmit = new Button();
            chkLastName = new CheckBox();
            chkFirstName = new CheckBox();
            txtPhoneNumber = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            labelLastName = new Label();
            lblPhoneNumber = new Label();
            labelFirstName = new Label();
            errorProvider1 = new ErrorProvider(components);
            panel2 = new Panel();
            btnLoadCurrentData = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            splitContainer1 = new SplitContainer();
            lblFirstName = new Label();
            txtActualPhoneNumber = new TextBox();
            lblLastName = new Label();
            label3 = new Label();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = SystemColors.GradientActiveCaption;
            btnSubmit.Cursor = Cursors.Hand;
            btnSubmit.FlatAppearance.MouseOverBackColor = Color.Orange;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnSubmit.ForeColor = Color.Black;
            btnSubmit.Location = new Point(71, 325);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(80, 41);
            btnSubmit.TabIndex = 9;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // chkLastName
            // 
            chkLastName.AutoSize = true;
            chkLastName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            chkLastName.ForeColor = Color.FromArgb(192, 0, 0);
            chkLastName.Location = new Point(72, 323);
            chkLastName.Name = "chkLastName";
            chkLastName.Size = new Size(85, 19);
            chkLastName.TabIndex = 8;
            chkLastName.Text = "No change";
            chkLastName.UseVisualStyleBackColor = true;
            chkLastName.CheckedChanged += chkLastName_CheckedChanged;
            // 
            // chkFirstName
            // 
            chkFirstName.AutoSize = true;
            chkFirstName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            chkFirstName.ForeColor = Color.FromArgb(192, 0, 0);
            chkFirstName.Location = new Point(71, 201);
            chkFirstName.Name = "chkFirstName";
            chkFirstName.Size = new Size(85, 19);
            chkFirstName.TabIndex = 7;
            chkFirstName.Text = "No change";
            chkFirstName.UseVisualStyleBackColor = true;
            chkFirstName.CheckedChanged += chkFirstName_CheckedChanged;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(47, 69);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(132, 23);
            txtPhoneNumber.TabIndex = 5;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(47, 281);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(132, 23);
            txtLastName.TabIndex = 4;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(46, 160);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(132, 23);
            txtFirstName.TabIndex = 3;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelLastName.ForeColor = Color.Black;
            labelLastName.Location = new Point(66, 244);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(90, 21);
            labelLastName.TabIndex = 1;
            labelLastName.Text = "Last Name";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblPhoneNumber.ForeColor = Color.Black;
            lblPhoneNumber.Location = new Point(28, 30);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(169, 20);
            lblPhoneNumber.TabIndex = 2;
            lblPhoneNumber.Text = "Provide phone number";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelFirstName.ForeColor = Color.Black;
            labelFirstName.Location = new Point(66, 125);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(92, 21);
            labelFirstName.TabIndex = 0;
            labelFirstName.Text = "First Name";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnLoadCurrentData);
            panel2.Controls.Add(btnSubmit);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(222, 387);
            panel2.TabIndex = 2;
            // 
            // btnLoadCurrentData
            // 
            btnLoadCurrentData.BackColor = SystemColors.GradientActiveCaption;
            btnLoadCurrentData.Cursor = Cursors.Hand;
            btnLoadCurrentData.FlatAppearance.MouseOverBackColor = Color.Orange;
            btnLoadCurrentData.FlatStyle = FlatStyle.Flat;
            btnLoadCurrentData.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnLoadCurrentData.ForeColor = Color.Black;
            btnLoadCurrentData.Location = new Point(61, 238);
            btnLoadCurrentData.Name = "btnLoadCurrentData";
            btnLoadCurrentData.Size = new Size(98, 65);
            btnLoadCurrentData.TabIndex = 10;
            btnLoadCurrentData.Text = "Load current data";
            btnLoadCurrentData.UseVisualStyleBackColor = false;
            btnLoadCurrentData.Click += btnLoadCurrentData_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.toolbox;
            pictureBox1.Location = new Point(10, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(64, 6);
            label1.Name = "label1";
            label1.Size = new Size(96, 17);
            label1.TabIndex = 0;
            label1.Text = "Before change";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(291, 6);
            label2.Name = "label2";
            label2.Size = new Size(87, 17);
            label2.TabIndex = 1;
            label2.Text = "After change";
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(224, 29);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.LightGray;
            splitContainer1.Panel1.Controls.Add(lblFirstName);
            splitContainer1.Panel1.Controls.Add(txtActualPhoneNumber);
            splitContainer1.Panel1.Controls.Add(lblLastName);
            splitContainer1.Panel1.Controls.Add(label3);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.LightGreen;
            splitContainer1.Panel2.Controls.Add(lblPhoneNumber);
            splitContainer1.Panel2.Controls.Add(chkLastName);
            splitContainer1.Panel2.Controls.Add(labelFirstName);
            splitContainer1.Panel2.Controls.Add(chkFirstName);
            splitContainer1.Panel2.Controls.Add(labelLastName);
            splitContainer1.Panel2.Controls.Add(txtPhoneNumber);
            splitContainer1.Panel2.Controls.Add(txtFirstName);
            splitContainer1.Panel2.Controls.Add(txtLastName);
            splitContainer1.Size = new Size(444, 358);
            splitContainer1.SplitterDistance = 216;
            splitContainer1.TabIndex = 1;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblFirstName.Location = new Point(47, 158);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(127, 21);
            lblFirstName.TabIndex = 3;
            lblFirstName.Text = "Actual first name";
            // 
            // txtActualPhoneNumber
            // 
            txtActualPhoneNumber.Location = new Point(43, 69);
            txtActualPhoneNumber.Name = "txtActualPhoneNumber";
            txtActualPhoneNumber.Size = new Size(131, 23);
            txtActualPhoneNumber.TabIndex = 2;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblLastName.Location = new Point(47, 230);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(124, 21);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Actual last name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(27, 30);
            label3.Name = "label3";
            label3.Size = new Size(161, 20);
            label3.TabIndex = 0;
            label3.Text = "Actual phone number";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(224, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(444, 27);
            panel3.TabIndex = 3;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 387);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "EditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtPhoneNumber;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label labelLastName;
        private Label lblPhoneNumber;
        private Label labelFirstName;
        private Button btnSubmit;
        private CheckBox chkLastName;
        private CheckBox chkFirstName;
        private ErrorProvider errorProvider1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private SplitContainer splitContainer1;
        private Label label1;
        private Label label2;
        private Panel panel3;
        private Label lblLastName;
        private Label label3;
        private Button btnLoadCurrentData;
        private Label lblFirstName;
        private TextBox txtActualPhoneNumber;
    }
}