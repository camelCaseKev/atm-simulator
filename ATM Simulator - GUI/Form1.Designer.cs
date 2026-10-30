namespace ATM_Simulator___GUI
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
            lblAtmSimulator = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblLoginFeedback = new Label();
            SuspendLayout();
            // 
            // lblAtmSimulator
            // 
            lblAtmSimulator.AutoSize = true;
            lblAtmSimulator.BackColor = Color.SteelBlue;
            lblAtmSimulator.Font = new Font("Lucida Fax", 34.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAtmSimulator.ForeColor = SystemColors.InactiveBorder;
            lblAtmSimulator.Location = new Point(137, 22);
            lblAtmSimulator.Name = "lblAtmSimulator";
            lblAtmSimulator.Size = new Size(448, 54);
            lblAtmSimulator.TabIndex = 100;
            lblAtmSimulator.Text = "ATM SIMULATOR";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = SystemColors.ButtonFace;
            lblUsername.Location = new Point(176, 185);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(145, 29);
            lblUsername.TabIndex = 101;
            lblUsername.Text = "Username:";
            lblUsername.Click += Label1_Click;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(341, 186);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(206, 30);
            txtUsername.TabIndex = 0;
            txtUsername.TextChanged += TxtUsername_TextChanged;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = SystemColors.ButtonFace;
            lblPassword.Location = new Point(180, 234);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(137, 29);
            lblPassword.TabIndex = 102;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(341, 238);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(206, 30);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(305, 318);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(116, 34);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += BtnLogin_Click;
            // 
            // lblLoginFeedback
            // 
            lblLoginFeedback.AutoSize = true;
            lblLoginFeedback.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLoginFeedback.ForeColor = Color.DarkRed;
            lblLoginFeedback.Location = new Point(225, 283);
            lblLoginFeedback.Name = "lblLoginFeedback";
            lblLoginFeedback.Size = new Size(269, 18);
            lblLoginFeedback.TabIndex = 103;
            lblLoginFeedback.Text = "username or password incorrect";
            lblLoginFeedback.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(734, 491);
            Controls.Add(lblLoginFeedback);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblAtmSimulator);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Form1";
            Text = "ATM Simulator";
            Load += ATM_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAtmSimulator;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblLoginFeedback;
    }
}
