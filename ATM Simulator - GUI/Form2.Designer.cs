namespace ATM_Simulator___GUI
{
    partial class Form2
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
            lblLoggedIn = new Label();
            btnViewBal = new Button();
            btnDeposit = new Button();
            btnWithdraw = new Button();
            btnViewTransactions = new Button();
            btnViewAllAccountData = new Button();
            btnLogOut = new Button();
            txtOutput = new TextBox();
            txtAmount = new TextBox();
            lblDollarSign = new Label();
            SuspendLayout();
            // 
            // lblLoggedIn
            // 
            lblLoggedIn.AutoSize = true;
            lblLoggedIn.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLoggedIn.Location = new Point(12, 9);
            lblLoggedIn.Name = "lblLoggedIn";
            lblLoggedIn.Size = new Size(97, 18);
            lblLoggedIn.TabIndex = 0;
            lblLoggedIn.Text = "Logged In:";
            // 
            // btnViewBal
            // 
            btnViewBal.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnViewBal.Location = new Point(486, 87);
            btnViewBal.Name = "btnViewBal";
            btnViewBal.Size = new Size(165, 48);
            btnViewBal.TabIndex = 1;
            btnViewBal.Text = "VIEW BALANCE";
            btnViewBal.UseVisualStyleBackColor = true;
            btnViewBal.Click += BtnViewBal_Click;
            // 
            // btnDeposit
            // 
            btnDeposit.BackColor = Color.LightBlue;
            btnDeposit.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeposit.Location = new Point(282, 87);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(150, 48);
            btnDeposit.TabIndex = 2;
            btnDeposit.Text = "DEPOSIT";
            btnDeposit.UseVisualStyleBackColor = false;
            btnDeposit.Click += BtnDeposit_Click;
            // 
            // btnWithdraw
            // 
            btnWithdraw.BackColor = Color.LightBlue;
            btnWithdraw.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnWithdraw.Location = new Point(282, 146);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(150, 48);
            btnWithdraw.TabIndex = 3;
            btnWithdraw.Text = "WITHDRAW";
            btnWithdraw.UseVisualStyleBackColor = false;
            btnWithdraw.Click += BtnWithdraw_Click;
            // 
            // btnViewTransactions
            // 
            btnViewTransactions.Font = new Font("Verdana", 11F);
            btnViewTransactions.Location = new Point(486, 146);
            btnViewTransactions.Name = "btnViewTransactions";
            btnViewTransactions.Size = new Size(165, 48);
            btnViewTransactions.TabIndex = 4;
            btnViewTransactions.Text = "VIEW RECENT TRANSACTIONS";
            btnViewTransactions.UseVisualStyleBackColor = true;
            btnViewTransactions.Click += BtnViewTransactions_Click;
            // 
            // btnViewAllAccountData
            // 
            btnViewAllAccountData.Font = new Font("Verdana", 11F);
            btnViewAllAccountData.Location = new Point(486, 208);
            btnViewAllAccountData.Name = "btnViewAllAccountData";
            btnViewAllAccountData.Size = new Size(165, 46);
            btnViewAllAccountData.TabIndex = 5;
            btnViewAllAccountData.TabStop = false;
            btnViewAllAccountData.Text = "VIEW ALL ACCOUNTS' DATA";
            btnViewAllAccountData.UseVisualStyleBackColor = true;
            btnViewAllAccountData.Visible = false;
            btnViewAllAccountData.Click += BtnViewAllAccountData_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = SystemColors.ActiveBorder;
            btnLogOut.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogOut.Location = new Point(673, 10);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(88, 32);
            btnLogOut.TabIndex = 6;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += BtnLogOut_Click;
            // 
            // txtOutput
            // 
            txtOutput.BackColor = Color.Black;
            txtOutput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOutput.ForeColor = SystemColors.ButtonFace;
            txtOutput.Location = new Point(76, 270);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(628, 196);
            txtOutput.TabIndex = 7;
            txtOutput.TabStop = false;
            // 
            // txtAmount
            // 
            txtAmount.BackColor = Color.LightBlue;
            txtAmount.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAmount.Location = new Point(136, 100);
            txtAmount.Margin = new Padding(3, 2, 3, 2);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(124, 27);
            txtAmount.TabIndex = 105;
            // 
            // lblDollarSign
            // 
            lblDollarSign.AutoSize = true;
            lblDollarSign.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDollarSign.Location = new Point(113, 101);
            lblDollarSign.Name = "lblDollarSign";
            lblDollarSign.Size = new Size(18, 18);
            lblDollarSign.TabIndex = 107;
            lblDollarSign.Text = "$";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(772, 490);
            Controls.Add(lblDollarSign);
            Controls.Add(txtAmount);
            Controls.Add(txtOutput);
            Controls.Add(btnLogOut);
            Controls.Add(btnViewAllAccountData);
            Controls.Add(btnViewTransactions);
            Controls.Add(btnWithdraw);
            Controls.Add(btnDeposit);
            Controls.Add(btnViewBal);
            Controls.Add(lblLoggedIn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form2";
            Text = "ATM Simulator";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLoggedIn;
        private Button btnViewBal;
        private Button btnDeposit;
        private Button btnWithdraw;
        private Button btnViewTransactions;
        private Button btnViewAllAccountData;
        private Button btnLogOut;
        private TextBox txtOutput;
        private TextBox txtAmount;
        private Label lblDollarSign;
    }
}