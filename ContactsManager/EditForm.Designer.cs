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
            panel1 = new Panel();
            txtPhoneNumber = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            lblPhoneNumber = new Label();
            lblFirstName = new Label();
            chkPhoneNumber = new CheckBox();
            chkFirstName = new CheckBox();
            chkLastName = new CheckBox();
            btnSubmit = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(btnSubmit);
            panel1.Controls.Add(chkLastName);
            panel1.Controls.Add(chkFirstName);
            panel1.Controls.Add(chkPhoneNumber);
            panel1.Controls.Add(txtPhoneNumber);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(txtFirstName);
            panel1.Controls.Add(lblLastName);
            panel1.Controls.Add(lblPhoneNumber);
            panel1.Controls.Add(lblFirstName);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(208, 471);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(41, 62);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(132, 23);
            txtPhoneNumber.TabIndex = 5;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(39, 325);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(132, 23);
            txtLastName.TabIndex = 4;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(39, 189);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(132, 23);
            txtFirstName.TabIndex = 3;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblLastName.ForeColor = Color.White;
            lblLastName.Location = new Point(61, 290);
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
            lblPhoneNumber.Location = new Point(49, 27);
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
            lblFirstName.Location = new Point(59, 154);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(92, 21);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name";
            // 
            // chkPhoneNumber
            // 
            chkPhoneNumber.AutoSize = true;
            chkPhoneNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            chkPhoneNumber.ForeColor = Color.Orange;
            chkPhoneNumber.Location = new Point(64, 100);
            chkPhoneNumber.Name = "chkPhoneNumber";
            chkPhoneNumber.Size = new Size(85, 19);
            chkPhoneNumber.TabIndex = 6;
            chkPhoneNumber.Text = "No change";
            chkPhoneNumber.UseVisualStyleBackColor = true;
            // 
            // chkFirstName
            // 
            chkFirstName.AutoSize = true;
            chkFirstName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            chkFirstName.ForeColor = Color.Orange;
            chkFirstName.Location = new Point(64, 230);
            chkFirstName.Name = "chkFirstName";
            chkFirstName.Size = new Size(85, 19);
            chkFirstName.TabIndex = 7;
            chkFirstName.Text = "No change";
            chkFirstName.UseVisualStyleBackColor = true;
            // 
            // chkLastName
            // 
            chkLastName.AutoSize = true;
            chkLastName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            chkLastName.ForeColor = Color.Orange;
            chkLastName.Location = new Point(64, 367);
            chkLastName.Name = "chkLastName";
            chkLastName.Size = new Size(85, 19);
            chkLastName.TabIndex = 8;
            chkLastName.Text = "No change";
            chkLastName.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(67, 417);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 9;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(209, 472);
            Controls.Add(panel1);
            Name = "EditForm";
            Text = "EditForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private CheckBox chkPhoneNumber;
    }
}