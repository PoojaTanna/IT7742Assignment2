namespace Bank_App2
{
    partial class Form1
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
            System.Windows.Forms.Label label6;
            this.txtFirstName = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnRemoveCustomer = new System.Windows.Forms.Button();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.cmbAccountType = new System.Windows.Forms.ComboBox();
            this.chkStaff = new System.Windows.Forms.CheckBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAccountId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCreateAcc = new System.Windows.Forms.Button();
            this.Message = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.AutoSize = true;
            this.txtFirstName.Location = new System.Drawing.Point(690, 128);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(80, 20);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.Text = "Full Name";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.SystemColors.Info;
            this.btnAddCustomer.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddCustomer.Location = new System.Drawing.Point(489, 217);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(145, 45);
            this.btnAddCustomer.TabIndex = 4;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.BackColor = System.Drawing.SystemColors.Info;
            this.btnUpdateCustomer.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnUpdateCustomer.Location = new System.Drawing.Point(664, 217);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(150, 45);
            this.btnUpdateCustomer.TabIndex = 5;
            this.btnUpdateCustomer.Text = "Update Customer";
            this.btnUpdateCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateCustomer.UseVisualStyleBackColor = false;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnRemoveCustomer
            // 
            this.btnRemoveCustomer.BackColor = System.Drawing.SystemColors.Info;
            this.btnRemoveCustomer.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnRemoveCustomer.Location = new System.Drawing.Point(848, 216);
            this.btnRemoveCustomer.Name = "btnRemoveCustomer";
            this.btnRemoveCustomer.Size = new System.Drawing.Size(150, 46);
            this.btnRemoveCustomer.TabIndex = 6;
            this.btnRemoveCustomer.Text = "Remove";
            this.btnRemoveCustomer.UseVisualStyleBackColor = false;
            this.btnRemoveCustomer.Click += new System.EventHandler(this.btnRemoveCustomer_Click);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(810, 122);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(175, 26);
            this.txtFullName.TabIndex = 8;
            this.txtFullName.TextChanged += new System.EventHandler(this.txtFullName_TextChanged);
            // 
            // cmbAccountType
            // 
            this.cmbAccountType.FormattingEnabled = true;
            this.cmbAccountType.Items.AddRange(new object[] {
            "Everyday",
            "Investment",
            "Omni"});
            this.cmbAccountType.Location = new System.Drawing.Point(203, 198);
            this.cmbAccountType.Name = "cmbAccountType";
            this.cmbAccountType.Size = new System.Drawing.Size(213, 28);
            this.cmbAccountType.TabIndex = 10;
            this.cmbAccountType.SelectedIndexChanged += new System.EventHandler(this.cmbAccountType_SelectedIndexChanged);
            // 
            // chkStaff
            // 
            this.chkStaff.AutoSize = true;
            this.chkStaff.Location = new System.Drawing.Point(217, 285);
            this.chkStaff.Name = "chkStaff";
            this.chkStaff.Size = new System.Drawing.Size(175, 24);
            this.chkStaff.TabIndex = 11;
            this.chkStaff.Text = "If yes then tick on it.";
            this.chkStaff.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(810, 169);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(175, 26);
            this.txtEmail.TabIndex = 13;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(679, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Email Address";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Are you a bank Staff?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Select Account Type";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Account ID";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtAccountId
            // 
            this.txtAccountId.Location = new System.Drawing.Point(203, 112);
            this.txtAccountId.Name = "txtAccountId";
            this.txtAccountId.Size = new System.Drawing.Size(213, 26);
            this.txtAccountId.TabIndex = 18;
            this.txtAccountId.TextChanged += new System.EventHandler(this.btnCreateAccount_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(569, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(371, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Customer details are required to create an account.";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnCreateAcc
            // 
            this.btnCreateAcc.BackColor = System.Drawing.SystemColors.Info;
            this.btnCreateAcc.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCreateAcc.Location = new System.Drawing.Point(99, 365);
            this.btnCreateAcc.Name = "btnCreateAcc";
            this.btnCreateAcc.Size = new System.Drawing.Size(213, 43);
            this.btnCreateAcc.TabIndex = 20;
            this.btnCreateAcc.Text = "Create Account";
            this.btnCreateAcc.UseVisualStyleBackColor = false;
            this.btnCreateAcc.Click += new System.EventHandler(this.btnCreateAcc_Click);
            // 
            // Message
            // 
            this.Message.FormattingEnabled = true;
            this.Message.ItemHeight = 20;
            this.Message.Location = new System.Drawing.Point(3, 485);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(1097, 104);
            this.Message.TabIndex = 21;
            this.Message.SelectedIndexChanged += new System.EventHandler(this.lstOutput_SelectedIndexChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(542, 286);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(410, 45);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.SystemColors.Info;
            label6.ForeColor = System.Drawing.Color.Maroon;
            label6.Location = new System.Drawing.Point(278, 24);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(103, 20);
            label6.TabIndex = 23;
            label6.Text = "Bank System";
            label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.SystemColors.Info;
            this.btnDeposit.ForeColor = System.Drawing.Color.Brown;
            this.btnDeposit.Location = new System.Drawing.Point(573, 415);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(142, 38);
            this.btnDeposit.TabIndex = 28;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.SystemColors.Info;
            this.btnWithdraw.ForeColor = System.Drawing.Color.Brown;
            this.btnWithdraw.Location = new System.Drawing.Point(757, 415);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(139, 38);
            this.btnWithdraw.TabIndex = 29;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(569, 365);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(65, 20);
            this.lblAmount.TabIndex = 31;
            this.lblAmount.Text = "Amount";
            this.lblAmount.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(683, 362);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(213, 26);
            this.txtAmount.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 615);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(label6);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.btnCreateAcc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAccountId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.chkStaff);
            this.Controls.Add(this.cmbAccountType);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.btnRemoveCustomer);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.txtFirstName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtFirstName;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnRemoveCustomer;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.ComboBox cmbAccountType;
        private System.Windows.Forms.CheckBox chkStaff;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAccountId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCreateAcc;
        private System.Windows.Forms.ListBox Message;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
    }
}

