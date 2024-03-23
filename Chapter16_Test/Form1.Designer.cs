namespace Chapter16_Test
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.radButtonShort = new System.Windows.Forms.RadioButton();
            this.radButtonLong = new System.Windows.Forms.RadioButton();
            this.groupBoxCreate = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.groupBoxManage = new System.Windows.Forms.GroupBox();
            this.lblAfterInterest = new System.Windows.Forms.Label();
            this.lblBeforeInterest = new System.Windows.Forms.Label();
            this.lblAmountOutput = new System.Windows.Forms.Label();
            this.lblNameOutput = new System.Windows.Forms.Label();
            this.btnPayment = new System.Windows.Forms.Button();
            this.groupBoxCreate.SuspendLayout();
            this.groupBoxManage.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(6, 58);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(52, 16);
            this.lblAmount.TabIndex = 1;
            this.lblAmount.Text = "Amount";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(6, 91);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(39, 16);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(90, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(343, 22);
            this.txtName.TabIndex = 1;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(90, 58);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(343, 22);
            this.txtAmount.TabIndex = 2;
            // 
            // radButtonShort
            // 
            this.radButtonShort.AutoSize = true;
            this.radButtonShort.Location = new System.Drawing.Point(90, 91);
            this.radButtonShort.Name = "radButtonShort";
            this.radButtonShort.Size = new System.Drawing.Size(128, 20);
            this.radButtonShort.TabIndex = 5;
            this.radButtonShort.TabStop = true;
            this.radButtonShort.Text = "Short-Term Loan";
            this.radButtonShort.UseVisualStyleBackColor = true;
            // 
            // radButtonLong
            // 
            this.radButtonLong.AutoSize = true;
            this.radButtonLong.Location = new System.Drawing.Point(90, 117);
            this.radButtonLong.Name = "radButtonLong";
            this.radButtonLong.Size = new System.Drawing.Size(127, 20);
            this.radButtonLong.TabIndex = 6;
            this.radButtonLong.TabStop = true;
            this.radButtonLong.Text = "Long-Term Loan";
            this.radButtonLong.UseVisualStyleBackColor = true;
            // 
            // groupBoxCreate
            // 
            this.groupBoxCreate.Controls.Add(this.btnClear);
            this.groupBoxCreate.Controls.Add(this.btnExit);
            this.groupBoxCreate.Controls.Add(this.btnCreate);
            this.groupBoxCreate.Controls.Add(this.lblName);
            this.groupBoxCreate.Controls.Add(this.radButtonLong);
            this.groupBoxCreate.Controls.Add(this.lblAmount);
            this.groupBoxCreate.Controls.Add(this.radButtonShort);
            this.groupBoxCreate.Controls.Add(this.lblType);
            this.groupBoxCreate.Controls.Add(this.txtAmount);
            this.groupBoxCreate.Controls.Add(this.txtName);
            this.groupBoxCreate.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCreate.Name = "groupBoxCreate";
            this.groupBoxCreate.Size = new System.Drawing.Size(458, 192);
            this.groupBoxCreate.TabIndex = 7;
            this.groupBoxCreate.TabStop = false;
            this.groupBoxCreate.Text = "Create Loan";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(193, 152);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(358, 152);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(9, 152);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(119, 23);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Create Loan";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // groupBoxManage
            // 
            this.groupBoxManage.Controls.Add(this.lblAfterInterest);
            this.groupBoxManage.Controls.Add(this.lblBeforeInterest);
            this.groupBoxManage.Controls.Add(this.lblAmountOutput);
            this.groupBoxManage.Controls.Add(this.lblNameOutput);
            this.groupBoxManage.Controls.Add(this.btnPayment);
            this.groupBoxManage.Location = new System.Drawing.Point(12, 238);
            this.groupBoxManage.Name = "groupBoxManage";
            this.groupBoxManage.Size = new System.Drawing.Size(458, 214);
            this.groupBoxManage.TabIndex = 7;
            this.groupBoxManage.TabStop = false;
            this.groupBoxManage.Text = "Manage Loan";
            // 
            // lblAfterInterest
            // 
            this.lblAfterInterest.AutoSize = true;
            this.lblAfterInterest.Location = new System.Drawing.Point(6, 163);
            this.lblAfterInterest.Name = "lblAfterInterest";
            this.lblAfterInterest.Size = new System.Drawing.Size(0, 20);
            this.lblAfterInterest.TabIndex = 13;
            // 
            // lblBeforeInterest
            // 
            this.lblBeforeInterest.AutoSize = true;
            this.lblBeforeInterest.Location = new System.Drawing.Point(6, 125);
            this.lblBeforeInterest.Name = "lblBeforeInterest";
            this.lblBeforeInterest.Size = new System.Drawing.Size(0, 20);
            this.lblBeforeInterest.TabIndex = 12;
            // 
            // lblAmountOutput
            // 
            this.lblAmountOutput.AutoSize = true;
            this.lblAmountOutput.Location = new System.Drawing.Point(14, 60);
            this.lblAmountOutput.Name = "lblAmountOutput";
            this.lblAmountOutput.Size = new System.Drawing.Size(0, 20);
            this.lblAmountOutput.TabIndex = 11;
            // 
            // lblNameOutput
            // 
            this.lblNameOutput.AutoSize = true;
            this.lblNameOutput.Location = new System.Drawing.Point(14, 30);
            this.lblNameOutput.Name = "lblNameOutput";
            this.lblNameOutput.Size = new System.Drawing.Size(0, 20);
            this.lblNameOutput.TabIndex = 10;
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(9, 88);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(119, 23);
            this.btnPayment.TabIndex = 0;
            this.btnPayment.Text = "Make Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 487);
            this.Controls.Add(this.groupBoxManage);
            this.Controls.Add(this.groupBoxCreate);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBoxCreate.ResumeLayout(false);
            this.groupBoxCreate.PerformLayout();
            this.groupBoxManage.ResumeLayout(false);
            this.groupBoxManage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.RadioButton radButtonShort;
        private System.Windows.Forms.RadioButton radButtonLong;
        private System.Windows.Forms.GroupBox groupBoxCreate;
        private System.Windows.Forms.GroupBox groupBoxManage;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblAfterInterest;
        private System.Windows.Forms.Label lblBeforeInterest;
        private System.Windows.Forms.Label lblAmountOutput;
        private System.Windows.Forms.Label lblNameOutput;
        private System.Windows.Forms.Button btnPayment;
    }
}

