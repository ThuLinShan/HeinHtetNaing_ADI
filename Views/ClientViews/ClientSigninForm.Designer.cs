namespace HeinHtetNaing_ADI.Views.ClientViews
{
    partial class ClientSigninForm
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
            clientSignupPanel = new Panel();
            backButton = new Button();
            setupLabel = new Label();
            siginUpLinkLabel = new LinkLabel();
            signinButton = new Button();
            passwordLabel = new Label();
            emailLabel = new Label();
            passwordTextBox = new TextBox();
            emailTextBox = new TextBox();
            panel1 = new Panel();
            clientSignupLabel = new Label();
            clientSignupPanel.SuspendLayout();
            SuspendLayout();
            // 
            // clientSignupPanel
            // 
            clientSignupPanel.BackColor = Color.White;
            clientSignupPanel.Controls.Add(backButton);
            clientSignupPanel.Controls.Add(setupLabel);
            clientSignupPanel.Controls.Add(siginUpLinkLabel);
            clientSignupPanel.Controls.Add(signinButton);
            clientSignupPanel.Controls.Add(passwordLabel);
            clientSignupPanel.Controls.Add(emailLabel);
            clientSignupPanel.Controls.Add(passwordTextBox);
            clientSignupPanel.Controls.Add(emailTextBox);
            clientSignupPanel.Controls.Add(panel1);
            clientSignupPanel.Controls.Add(clientSignupLabel);
            clientSignupPanel.Location = new Point(341, 12);
            clientSignupPanel.Name = "clientSignupPanel";
            clientSignupPanel.Size = new Size(503, 637);
            clientSignupPanel.TabIndex = 1;
            // 
            // backButton
            // 
            backButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backButton.Location = new Point(27, 503);
            backButton.Name = "backButton";
            backButton.Size = new Size(439, 35);
            backButton.TabIndex = 7;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // setupLabel
            // 
            setupLabel.AutoSize = true;
            setupLabel.ForeColor = SystemColors.ControlDarkDark;
            setupLabel.Location = new Point(38, 391);
            setupLabel.Name = "setupLabel";
            setupLabel.Size = new Size(142, 15);
            setupLabel.TabIndex = 6;
            setupLabel.Text = "Doesn't have an account?";
            // 
            // siginUpLinkLabel
            // 
            siginUpLinkLabel.AutoSize = true;
            siginUpLinkLabel.LinkColor = Color.Tomato;
            siginUpLinkLabel.Location = new Point(357, 391);
            siginUpLinkLabel.Name = "siginUpLinkLabel";
            siginUpLinkLabel.Size = new Size(102, 15);
            siginUpLinkLabel.TabIndex = 5;
            siginUpLinkLabel.TabStop = true;
            siginUpLinkLabel.Text = "Set up an account";
            siginUpLinkLabel.LinkClicked += siginUpLinkLabel_LinkClicked;
            // 
            // signinButton
            // 
            signinButton.BackColor = Color.DarkRed;
            signinButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signinButton.ForeColor = Color.White;
            signinButton.Location = new Point(27, 446);
            signinButton.Name = "signinButton";
            signinButton.Size = new Size(439, 41);
            signinButton.TabIndex = 4;
            signinButton.Text = "Sign In";
            signinButton.UseVisualStyleBackColor = false;
            signinButton.Click += signinButton_Click;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(45, 283);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(57, 15);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Password";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(45, 201);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(90, 15);
            emailLabel.TabIndex = 3;
            emailLabel.Text = "Email Address : ";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.ForeColor = Color.DarkRed;
            passwordTextBox.Location = new Point(45, 301);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(421, 29);
            passwordTextBox.TabIndex = 2;
            // 
            // emailTextBox
            // 
            emailTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTextBox.ForeColor = Color.DarkRed;
            emailTextBox.Location = new Point(45, 219);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(421, 29);
            emailTextBox.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkRed;
            panel1.Location = new Point(27, 148);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 273);
            panel1.TabIndex = 1;
            // 
            // clientSignupLabel
            // 
            clientSignupLabel.AutoSize = true;
            clientSignupLabel.BackColor = Color.Transparent;
            clientSignupLabel.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clientSignupLabel.ForeColor = Color.DarkRed;
            clientSignupLabel.Location = new Point(53, 105);
            clientSignupLabel.Name = "clientSignupLabel";
            clientSignupLabel.Size = new Size(127, 47);
            clientSignupLabel.TabIndex = 0;
            clientSignupLabel.Text = "Sign In";
            // 
            // ClientSigninForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 661);
            Controls.Add(clientSignupPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ClientSigninForm";
            Text = "ClientSigninForm";
            FormClosed += ClientSigninForm_FormClosed;
            Load += ClientSigninForm_Load;
            KeyDown += ClientSigninForm_KeyDown;
            clientSignupPanel.ResumeLayout(false);
            clientSignupPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel clientSignupPanel;
        private Button signinButton;
        private Label passwordLabel;
        private Label emailLabel;
        private TextBox passwordTextBox;
        private TextBox emailTextBox;
        private Panel panel1;
        private Label clientSignupLabel;
        private LinkLabel siginUpLinkLabel;
        private Label setupLabel;
        private Button backButton;
    }
}