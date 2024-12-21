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
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            panel10 = new Panel();
            panel11 = new Panel();
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
            // panel2
            // 
            panel2.BackColor = Color.DarkRed;
            panel2.Location = new Point(32, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 242);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkRed;
            panel3.Location = new Point(68, 363);
            panel3.Name = "panel3";
            panel3.Size = new Size(27, 229);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkRed;
            panel4.Location = new Point(964, 1);
            panel4.Name = "panel4";
            panel4.Size = new Size(23, 125);
            panel4.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkRed;
            panel5.Location = new Point(1134, 117);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 335);
            panel5.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DarkRed;
            panel6.Location = new Point(1051, 330);
            panel6.Name = "panel6";
            panel6.Size = new Size(10, 335);
            panel6.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.BackColor = Color.DarkRed;
            panel7.Location = new Point(256, 12);
            panel7.Name = "panel7";
            panel7.Size = new Size(16, 30);
            panel7.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.BackColor = Color.DarkRed;
            panel8.Location = new Point(995, 295);
            panel8.Name = "panel8";
            panel8.Size = new Size(10, 30);
            panel8.TabIndex = 1;
            // 
            // panel9
            // 
            panel9.BackColor = Color.DarkRed;
            panel9.Location = new Point(219, 128);
            panel9.Name = "panel9";
            panel9.Size = new Size(10, 558);
            panel9.TabIndex = 1;
            // 
            // panel10
            // 
            panel10.BackColor = Color.DarkRed;
            panel10.Location = new Point(147, 62);
            panel10.Name = "panel10";
            panel10.Size = new Size(10, 44);
            panel10.TabIndex = 1;
            // 
            // panel11
            // 
            panel11.BackColor = Color.DarkRed;
            panel11.Location = new Point(883, 388);
            panel11.Name = "panel11";
            panel11.Size = new Size(10, 184);
            panel11.TabIndex = 1;
            // 
            // ClientSigninForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 661);
            Controls.Add(clientSignupPanel);
            Controls.Add(panel6);
            Controls.Add(panel11);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel10);
            Controls.Add(panel9);
            Controls.Add(panel3);
            Controls.Add(panel2);
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
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private Panel panel11;
    }
}