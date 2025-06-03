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
            panel1 = new Panel();
            btnSubmit = new Button();
            chkLastName = new CheckBox();
            chkFirstName = new CheckBox();
            txtPhoneNumber = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            lblPhoneNumber = new Label();
            lblFirstName = new Label();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(btnSubmit);
            panel1.Controls.Add(chkLastName);
            panel1.Controls.Add(chkFirstName);
            panel1.Controls.Add(txtPhoneNumber);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(txtFirstName);
            panel1.Controls.Add(lblLastName);
            panel1.Controls.Add(lblPhoneNumber);
            panel1.Controls.Add(lblFirstName);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(209, 471);
            panel1.TabIndex = 1;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(67, 413);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 9;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // chkLastName
            // 
            chkLastName.AutoSize = true;
            chkLastName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            chkLastName.ForeColor = Color.Orange;
            chkLastName.Location = new Point(64, 363);
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
            chkFirstName.ForeColor = Color.Orange;
            chkFirstName.Location = new Point(64, 226);
            chkFirstName.Name = "chkFirstName";
            chkFirstName.Size = new Size(85, 19);
            chkFirstName.TabIndex = 7;
            chkFirstName.Text = "No change";
            chkFirstName.UseVisualStyleBackColor = true;
            chkFirstName.CheckedChanged += chkFirstName_CheckedChanged;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(39, 76);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(132, 23);
            txtPhoneNumber.TabIndex = 5;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(39, 321);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(132, 23);
            txtLastName.TabIndex = 4;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(39, 185);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(132, 23);
            txtFirstName.TabIndex = 3;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblLastName.ForeColor = Color.White;
            lblLastName.Location = new Point(61, 286);
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
            lblPhoneNumber.Location = new Point(20, 37);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(169, 20);
            lblPhoneNumber.TabIndex = 2;
            lblPhoneNumber.Text = "Provide phone number";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblFirstName.ForeColor = Color.White;
            lblFirstName.Location = new Point(59, 150);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(92, 21);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(209, 472);
            Controls.Add(panel1);
            Name = "EditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtPhoneNumber;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private Label lblPhoneNumber;
        private Label lblFirstName;
        private Button btnSubmit;
        private CheckBox chkLastName;
        private CheckBox chkFirstName;
        private ErrorProvider errorProvider1;
    }
}