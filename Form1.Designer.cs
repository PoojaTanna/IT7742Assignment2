namespace Assignment3_Bank_App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMain = new System.Windows.Forms.Panel();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.panelCustomer = new System.Windows.Forms.Panel();
            this.btnRemoveAccount = new System.Windows.Forms.Button();
            this.btnClear_Click = new System.Windows.Forms.Button();
            this.txtCusEmail = new System.Windows.Forms.TextBox();
            this.txtCusNumber = new System.Windows.Forms.TextBox();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.chkStaff = new System.Windows.Forms.CheckBox();
            this.txtCustomerEmail = new System.Windows.Forms.Label();
            this.txtCustomerNumber = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.Label();
            this.panelTransfer = new System.Windows.Forms.Panel();
            this.lblTransferTitle = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.txtTransferAmount = new System.Windows.Forms.TextBox();
            this.lblTransferAmount = new System.Windows.Forms.Label();
            this.cmbToAcc = new System.Windows.Forms.ComboBox();
            this.lblToAcc = new System.Windows.Forms.Label();
            this.cmbFromAcc = new System.Windows.Forms.ComboBox();
            this.lblFromAcc = new System.Windows.Forms.Label();
            this.panelAccount = new System.Windows.Forms.Panel();
            this.btnViewAccount = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.txtAccID = new System.Windows.Forms.TextBox();
            this.lblAccID = new System.Windows.Forms.Label();
            this.cmbAccType = new System.Windows.Forms.ComboBox();
            this.lblAccType = new System.Windows.Forms.Label();
            this.rbtnCustomer = new System.Windows.Forms.RadioButton();
            this.rbtnAccount = new System.Windows.Forms.RadioButton();
            this.rbtnTransfer = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMain.SuspendLayout();
            this.panelCustomer.SuspendLayout();
            this.panelTransfer.SuspendLayout();
            this.panelAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.SteelBlue;
            this.panelMain.Controls.Add(this.lstOutput);
            this.panelMain.Controls.Add(this.panelCustomer);
            this.panelMain.Controls.Add(this.panelTransfer);
            this.panelMain.Controls.Add(this.panelAccount);
            this.panelMain.Location = new System.Drawing.Point(300, 25);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(982, 615);
            this.panelMain.TabIndex = 0;
            // 
            // lstOutput
            // 
            this.lstOutput.BackColor = System.Drawing.Color.Gainsboro;
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 20;
            this.lstOutput.Location = new System.Drawing.Point(42, 429);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(879, 164);
            this.lstOutput.TabIndex = 8;
            // 
            // panelCustomer
            // 
            this.panelCustomer.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelCustomer.Controls.Add(this.btnRemoveAccount);
            this.panelCustomer.Controls.Add(this.btnClear_Click);
            this.panelCustomer.Controls.Add(this.txtCusEmail);
            this.panelCustomer.Controls.Add(this.txtCusNumber);
            this.panelCustomer.Controls.Add(this.txtCusName);
            this.panelCustomer.Controls.Add(this.btnUpdateCustomer);
            this.panelCustomer.Controls.Add(this.btnAddCustomer);
            this.panelCustomer.Controls.Add(this.chkStaff);
            this.panelCustomer.Controls.Add(this.txtCustomerEmail);
            this.panelCustomer.Controls.Add(this.txtCustomerNumber);
            this.panelCustomer.Controls.Add(this.txtCustomerName);
            this.panelCustomer.Location = new System.Drawing.Point(0, 0);
            this.panelCustomer.Name = "panelCustomer";
            this.panelCustomer.Size = new System.Drawing.Size(984, 625);
            this.panelCustomer.TabIndex = 0;
            this.panelCustomer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCustomer_Paint);
            // 
            // btnRemoveAccount
            // 
            this.btnRemoveAccount.Location = new System.Drawing.Point(460, 305);
            this.btnRemoveAccount.Name = "btnRemoveAccount";
            this.btnRemoveAccount.Size = new System.Drawing.Size(160, 45);
            this.btnRemoveAccount.TabIndex = 13;
            this.btnRemoveAccount.Text = "Remove Account";
            this.btnRemoveAccount.UseVisualStyleBackColor = true;
            this.btnRemoveAccount.Click += new System.EventHandler(this.btnRemoveAccount_Click);
            // 
            // btnClear_Click
            // 
            this.btnClear_Click.Location = new System.Drawing.Point(544, 145);
            this.btnClear_Click.Name = "btnClear_Click";
            this.btnClear_Click.Size = new System.Drawing.Size(321, 45);
            this.btnClear_Click.TabIndex = 12;
            this.btnClear_Click.Text = "Clear Form";
            this.btnClear_Click.UseVisualStyleBackColor = true;
            this.btnClear_Click.Click += new System.EventHandler(this.btnClear_Click_Click);
            // 
            // txtCusEmail
            // 
            this.txtCusEmail.Location = new System.Drawing.Point(246, 154);
            this.txtCusEmail.Name = "txtCusEmail";
            this.txtCusEmail.Size = new System.Drawing.Size(254, 26);
            this.txtCusEmail.TabIndex = 10;
            // 
            // txtCusNumber
            // 
            this.txtCusNumber.Location = new System.Drawing.Point(249, 97);
            this.txtCusNumber.Name = "txtCusNumber";
            this.txtCusNumber.Size = new System.Drawing.Size(250, 26);
            this.txtCusNumber.TabIndex = 9;
            this.txtCusNumber.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtCusName
            // 
            this.txtCusName.Location = new System.Drawing.Point(246, 38);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(254, 26);
            this.txtCusName.TabIndex = 8;
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(232, 305);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(165, 45);
            this.btnUpdateCustomer.TabIndex = 5;
            this.btnUpdateCustomer.Text = "Update";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(42, 305);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(165, 45);
            this.btnAddCustomer.TabIndex = 4;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // chkStaff
            // 
            this.chkStaff.AutoSize = true;
            this.chkStaff.Location = new System.Drawing.Point(63, 225);
            this.chkStaff.Name = "chkStaff";
            this.chkStaff.Size = new System.Drawing.Size(264, 24);
            this.chkStaff.TabIndex = 3;
            this.chkStaff.Text = "Are you a bank staff? (tick if yes)";
            this.chkStaff.UseVisualStyleBackColor = true;
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.AutoSize = true;
            this.txtCustomerEmail.Location = new System.Drawing.Point(58, 162);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(111, 20);
            this.txtCustomerEmail.TabIndex = 2;
            this.txtCustomerEmail.Text = "Email Address";
            // 
            // txtCustomerNumber
            // 
            this.txtCustomerNumber.AutoSize = true;
            this.txtCustomerNumber.Location = new System.Drawing.Point(56, 100);
            this.txtCustomerNumber.Name = "txtCustomerNumber";
            this.txtCustomerNumber.Size = new System.Drawing.Size(138, 20);
            this.txtCustomerNumber.TabIndex = 1;
            this.txtCustomerNumber.Text = "Customer Number";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.AutoSize = true;
            this.txtCustomerName.Location = new System.Drawing.Point(56, 34);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(80, 20);
            this.txtCustomerName.TabIndex = 0;
            this.txtCustomerName.Text = "Full Name";
            // 
            // panelTransfer
            // 
            this.panelTransfer.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelTransfer.Controls.Add(this.lblTransferTitle);
            this.panelTransfer.Controls.Add(this.btnTransfer);
            this.panelTransfer.Controls.Add(this.txtTransferAmount);
            this.panelTransfer.Controls.Add(this.lblTransferAmount);
            this.panelTransfer.Controls.Add(this.cmbToAcc);
            this.panelTransfer.Controls.Add(this.lblToAcc);
            this.panelTransfer.Controls.Add(this.cmbFromAcc);
            this.panelTransfer.Controls.Add(this.lblFromAcc);
            this.panelTransfer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTransfer.Location = new System.Drawing.Point(0, 0);
            this.panelTransfer.Name = "panelTransfer";
            this.panelTransfer.Size = new System.Drawing.Size(982, 615);
            this.panelTransfer.TabIndex = 2;
            this.panelTransfer.Visible = false;
            this.panelTransfer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTransfer_Paint);
            // 
            // lblTransferTitle
            // 
            this.lblTransferTitle.AutoSize = true;
            this.lblTransferTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTransferTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTransferTitle.Location = new System.Drawing.Point(46, 45);
            this.lblTransferTitle.Name = "lblTransferTitle";
            this.lblTransferTitle.Size = new System.Drawing.Size(217, 22);
            this.lblTransferTitle.TabIndex = 7;
            this.lblTransferTitle.Text = "Transfer to Different Account";
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(200, 358);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(184, 60);
            this.btnTransfer.TabIndex = 6;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // txtTransferAmount
            // 
            this.txtTransferAmount.Location = new System.Drawing.Point(190, 292);
            this.txtTransferAmount.Name = "txtTransferAmount";
            this.txtTransferAmount.Size = new System.Drawing.Size(204, 26);
            this.txtTransferAmount.TabIndex = 5;
            // 
            // lblTransferAmount
            // 
            this.lblTransferAmount.AutoSize = true;
            this.lblTransferAmount.Location = new System.Drawing.Point(45, 295);
            this.lblTransferAmount.Name = "lblTransferAmount";
            this.lblTransferAmount.Size = new System.Drawing.Size(108, 20);
            this.lblTransferAmount.TabIndex = 4;
            this.lblTransferAmount.Text = "Enter Amount";
            // 
            // cmbToAcc
            // 
            this.cmbToAcc.FormattingEnabled = true;
            this.cmbToAcc.Location = new System.Drawing.Point(190, 208);
            this.cmbToAcc.Name = "cmbToAcc";
            this.cmbToAcc.Size = new System.Drawing.Size(204, 28);
            this.cmbToAcc.TabIndex = 3;
            // 
            // lblToAcc
            // 
            this.lblToAcc.AutoSize = true;
            this.lblToAcc.Location = new System.Drawing.Point(45, 211);
            this.lblToAcc.Name = "lblToAcc";
            this.lblToAcc.Size = new System.Drawing.Size(90, 20);
            this.lblToAcc.TabIndex = 2;
            this.lblToAcc.Text = "To Account";
            // 
            // cmbFromAcc
            // 
            this.cmbFromAcc.FormattingEnabled = true;
            this.cmbFromAcc.Location = new System.Drawing.Point(190, 120);
            this.cmbFromAcc.Name = "cmbFromAcc";
            this.cmbFromAcc.Size = new System.Drawing.Size(204, 28);
            this.cmbFromAcc.TabIndex = 1;
            // 
            // lblFromAcc
            // 
            this.lblFromAcc.AutoSize = true;
            this.lblFromAcc.Location = new System.Drawing.Point(40, 120);
            this.lblFromAcc.Name = "lblFromAcc";
            this.lblFromAcc.Size = new System.Drawing.Size(109, 20);
            this.lblFromAcc.TabIndex = 0;
            this.lblFromAcc.Text = "From Account";
            // 
            // panelAccount
            // 
            this.panelAccount.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelAccount.Controls.Add(this.btnViewAccount);
            this.panelAccount.Controls.Add(this.btnCalculate);
            this.panelAccount.Controls.Add(this.btnWithdraw);
            this.panelAccount.Controls.Add(this.btnDeposit);
            this.panelAccount.Controls.Add(this.txtAmount);
            this.panelAccount.Controls.Add(this.lblAmount);
            this.panelAccount.Controls.Add(this.btnCreateAccount);
            this.panelAccount.Controls.Add(this.txtAccID);
            this.panelAccount.Controls.Add(this.lblAccID);
            this.panelAccount.Controls.Add(this.cmbAccType);
            this.panelAccount.Controls.Add(this.lblAccType);
            this.panelAccount.Location = new System.Drawing.Point(0, 0);
            this.panelAccount.Name = "panelAccount";
            this.panelAccount.Size = new System.Drawing.Size(984, 622);
            this.panelAccount.TabIndex = 1;
            this.panelAccount.Visible = false;
            this.panelAccount.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAccount_Paint);
            // 
            // btnViewAccount
            // 
            this.btnViewAccount.Location = new System.Drawing.Point(400, 121);
            this.btnViewAccount.Name = "btnViewAccount";
            this.btnViewAccount.Size = new System.Drawing.Size(254, 45);
            this.btnViewAccount.TabIndex = 12;
            this.btnViewAccount.Text = "View Account";
            this.btnViewAccount.UseVisualStyleBackColor = true;
            this.btnViewAccount.Click += new System.EventHandler(this.btnViewAccount_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(386, 325);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(146, 45);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(200, 325);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(146, 45);
            this.btnWithdraw.TabIndex = 8;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(24, 325);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(146, 45);
            this.btnDeposit.TabIndex = 7;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(170, 229);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(192, 26);
            this.txtAmount.TabIndex = 6;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(20, 229);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(108, 20);
            this.lblAmount.TabIndex = 5;
            this.lblAmount.Text = "Enter Amount";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(122, 122);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(240, 43);
            this.btnCreateAccount.TabIndex = 4;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // txtAccID
            // 
            this.txtAccID.Location = new System.Drawing.Point(460, 35);
            this.txtAccID.Name = "txtAccID";
            this.txtAccID.Size = new System.Drawing.Size(139, 26);
            this.txtAccID.TabIndex = 3;
            // 
            // lblAccID
            // 
            this.lblAccID.AutoSize = true;
            this.lblAccID.Location = new System.Drawing.Point(348, 35);
            this.lblAccID.Name = "lblAccID";
            this.lblAccID.Size = new System.Drawing.Size(89, 20);
            this.lblAccID.TabIndex = 2;
            this.lblAccID.Text = "Account ID";
            // 
            // cmbAccType
            // 
            this.cmbAccType.FormattingEnabled = true;
            this.cmbAccType.Items.AddRange(new object[] {
            "Everyday",
            "Investment",
            "Omni"});
            this.cmbAccType.Location = new System.Drawing.Point(156, 32);
            this.cmbAccType.Name = "cmbAccType";
            this.cmbAccType.Size = new System.Drawing.Size(158, 28);
            this.cmbAccType.TabIndex = 1;
            // 
            // lblAccType
            // 
            this.lblAccType.AutoSize = true;
            this.lblAccType.Location = new System.Drawing.Point(28, 32);
            this.lblAccType.Name = "lblAccType";
            this.lblAccType.Size = new System.Drawing.Size(106, 20);
            this.lblAccType.TabIndex = 0;
            this.lblAccType.Text = "Account Type";
            // 
            // rbtnCustomer
            // 
            this.rbtnCustomer.AutoSize = true;
            this.rbtnCustomer.BackColor = System.Drawing.Color.LightCyan;
            this.rbtnCustomer.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.rbtnCustomer.Location = new System.Drawing.Point(14, 288);
            this.rbtnCustomer.Name = "rbtnCustomer";
            this.rbtnCustomer.Size = new System.Drawing.Size(254, 24);
            this.rbtnCustomer.TabIndex = 1;
            this.rbtnCustomer.TabStop = true;
            this.rbtnCustomer.Text = "Customer Details Management";
            this.rbtnCustomer.UseVisualStyleBackColor = false;
            this.rbtnCustomer.CheckedChanged += new System.EventHandler(this.rbtnCustomer_CheckedChanged);
            // 
            // rbtnAccount
            // 
            this.rbtnAccount.AutoSize = true;
            this.rbtnAccount.BackColor = System.Drawing.Color.Azure;
            this.rbtnAccount.ForeColor = System.Drawing.Color.DarkCyan;
            this.rbtnAccount.Location = new System.Drawing.Point(14, 351);
            this.rbtnAccount.Name = "rbtnAccount";
            this.rbtnAccount.Size = new System.Drawing.Size(255, 24);
            this.rbtnAccount.TabIndex = 2;
            this.rbtnAccount.TabStop = true;
            this.rbtnAccount.Text = "Account Creation Management";
            this.rbtnAccount.UseVisualStyleBackColor = false;
            this.rbtnAccount.CheckedChanged += new System.EventHandler(this.rbtnAccount_CheckedChanged);
            // 
            // rbtnTransfer
            // 
            this.rbtnTransfer.AutoSize = true;
            this.rbtnTransfer.BackColor = System.Drawing.Color.Azure;
            this.rbtnTransfer.ForeColor = System.Drawing.Color.DarkCyan;
            this.rbtnTransfer.Location = new System.Drawing.Point(15, 408);
            this.rbtnTransfer.Name = "rbtnTransfer";
            this.rbtnTransfer.Size = new System.Drawing.Size(265, 24);
            this.rbtnTransfer.TabIndex = 3;
            this.rbtnTransfer.TabStop = true;
            this.rbtnTransfer.Text = "Intra ACC Transfer Management";
            this.rbtnTransfer.UseVisualStyleBackColor = false;
            this.rbtnTransfer.CheckedChanged += new System.EventHandler(this.rbtnTransfer_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(35, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Size = new System.Drawing.Size(199, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1298, 672);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rbtnTransfer);
            this.Controls.Add(this.rbtnAccount);
            this.Controls.Add(this.rbtnCustomer);
            this.Controls.Add(this.panelMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMain.ResumeLayout(false);
            this.panelCustomer.ResumeLayout(false);
            this.panelCustomer.PerformLayout();
            this.panelTransfer.ResumeLayout(false);
            this.panelTransfer.PerformLayout();
            this.panelAccount.ResumeLayout(false);
            this.panelAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelTransfer;
        private System.Windows.Forms.Panel panelAccount;
        private System.Windows.Forms.Panel panelCustomer;
        private System.Windows.Forms.RadioButton rbtnCustomer;
        private System.Windows.Forms.RadioButton rbtnAccount;
        private System.Windows.Forms.RadioButton rbtnTransfer;
        private System.Windows.Forms.Label txtCustomerName;
        private System.Windows.Forms.CheckBox chkStaff;
        private System.Windows.Forms.Label txtCustomerEmail;
        private System.Windows.Forms.Label txtCustomerNumber;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.TextBox txtCusEmail;
        private System.Windows.Forms.TextBox txtCusNumber;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.Label lblAccType;
        private System.Windows.Forms.Label lblAccID;
        private System.Windows.Forms.ComboBox cmbAccType;
        private System.Windows.Forms.TextBox txtAccID;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblTransferAmount;
        private System.Windows.Forms.ComboBox cmbToAcc;
        private System.Windows.Forms.Label lblToAcc;
        private System.Windows.Forms.ComboBox cmbFromAcc;
        private System.Windows.Forms.Label lblFromAcc;
        private System.Windows.Forms.Label lblTransferTitle;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.TextBox txtTransferAmount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClear_Click;
        private System.Windows.Forms.Button btnViewAccount;
        private System.Windows.Forms.Button btnRemoveAccount;
    }
}

