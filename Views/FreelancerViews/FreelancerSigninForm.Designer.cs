namespace HeinHtetNaing_ADI.Views.FreelancerViews
{
    partial class FreelancerSigninForm
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
            panel12 = new Panel();
            panel13 = new Panel();
            panel14 = new Panel();
            panel15 = new Panel();
            panel17 = new Panel();
            clientSignupPanel.SuspendLayout();
            SuspendLayout();
            // 
            // clientSignupPanel
            // 
            clientSignupPanel.BackColor = Color.Tomato;
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
            clientSignupPanel.Location = new Point(341, -6);
            clientSignupPanel.Name = "clientSignupPanel";
            clientSignupPanel.Size = new Size(503, 673);
            clientSignupPanel.TabIndex = 2;
            // 
            // backButton
            // 
            backButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backButton.ForeColor = Color.Tomato;
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
            setupLabel.Font = new Font("Segoe UI", 9.75F);
            setupLabel.ForeColor = Color.Black;
            setupLabel.Location = new Point(45, 350);
            setupLabel.Name = "setupLabel";
            setupLabel.Size = new Size(156, 17);
            setupLabel.TabIndex = 6;
            setupLabel.Text = "Doesn't have an account?";
            // 
            // siginUpLinkLabel
            // 
            siginUpLinkLabel.ActiveLinkColor = Color.DarkViolet;
            siginUpLinkLabel.AutoSize = true;
            siginUpLinkLabel.BackColor = Color.Transparent;
            siginUpLinkLabel.Font = new Font("Segoe UI", 9.75F);
            siginUpLinkLabel.LinkColor = Color.Blue;
            siginUpLinkLabel.Location = new Point(354, 350);
            siginUpLinkLabel.Name = "siginUpLinkLabel";
            siginUpLinkLabel.Size = new Size(112, 17);
            siginUpLinkLabel.TabIndex = 5;
            siginUpLinkLabel.TabStop = true;
            siginUpLinkLabel.Text = "Set up an account";
            siginUpLinkLabel.LinkClicked += siginUpLinkLabel_LinkClicked;
            // 
            // signinButton
            // 
            signinButton.BackColor = Color.Tomato;
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
            passwordLabel.BackColor = Color.Transparent;
            passwordLabel.ForeColor = SystemColors.Control;
            passwordLabel.Location = new Point(45, 283);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(57, 15);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Password";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = Color.Transparent;
            emailLabel.ForeColor = SystemColors.Control;
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
            panel1.BackColor = Color.White;
            panel1.Location = new Point(27, 148);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 273);
            panel1.TabIndex = 1;
            // 
            // clientSignupLabel
            // 
            clientSignupLabel.AutoSize = true;
            clientSignupLabel.BackColor = Color.Transparent;
            clientSignupLabel.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clientSignupLabel.ForeColor = Color.White;
            clientSignupLabel.Location = new Point(27, 98);
            clientSignupLabel.Name = "clientSignupLabel";
            clientSignupLabel.Size = new Size(135, 47);
            clientSignupLabel.TabIndex = 0;
            clientSignupLabel.Text = "Sign In";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Tomato;
            panel2.Location = new Point(27, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(91, 100);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Tomato;
            panel3.Location = new Point(27, 234);
            panel3.Name = "panel3";
            panel3.Size = new Size(14, 373);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Tomato;
            panel4.Location = new Point(275, 366);
            panel4.Name = "panel4";
            panel4.Size = new Size(51, 312);
            panel4.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Tomato;
            panel5.Location = new Point(151, 108);
            panel5.Name = "panel5";
            panel5.Size = new Size(14, 64);
            panel5.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Tomato;
            panel6.Location = new Point(249, -6);
            panel6.Name = "panel6";
            panel6.Size = new Size(14, 291);
            panel6.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Tomato;
            panel7.Location = new Point(124, 234);
            panel7.Name = "panel7";
            panel7.Size = new Size(44, 58);
            panel7.TabIndex = 3;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Tomato;
            panel8.Location = new Point(850, -6);
            panel8.Name = "panel8";
            panel8.Size = new Size(91, 100);
            panel8.TabIndex = 3;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Tomato;
            panel9.Location = new Point(956, 114);
            panel9.Name = "panel9";
            panel9.Size = new Size(44, 58);
            panel9.TabIndex = 3;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Tomato;
            panel10.Location = new Point(1085, 366);
            panel10.Name = "panel10";
            panel10.Size = new Size(51, 312);
            panel10.TabIndex = 3;
            // 
            // panel11
            // 
            panel11.BackColor = Color.Tomato;
            panel11.Location = new Point(879, 305);
            panel11.Name = "panel11";
            panel11.Size = new Size(14, 373);
            panel11.TabIndex = 3;
            // 
            // panel12
            // 
            panel12.BackColor = Color.Tomato;
            panel12.Location = new Point(997, 558);
            panel12.Name = "panel12";
            panel12.Size = new Size(14, 131);
            panel12.TabIndex = 3;
            // 
            // panel13
            // 
            panel13.BackColor = Color.Tomato;
            panel13.Location = new Point(1122, -6);
            panel13.Name = "panel13";
            panel13.Size = new Size(14, 291);
            panel13.TabIndex = 3;
            // 
            // panel14
            // 
            panel14.BackColor = Color.Tomato;
            panel14.Location = new Point(200, 430);
            panel14.Name = "panel14";
            panel14.Size = new Size(27, 312);
            panel14.TabIndex = 3;
            // 
            // panel15
            // 
            panel15.BackColor = Color.Tomato;
            panel15.Location = new Point(104, 440);
            panel15.Name = "panel15";
            panel15.Size = new Size(14, 64);
            panel15.TabIndex = 3;
            // 
            // panel17
            // 
            panel17.BackColor = Color.Tomato;
            panel17.Location = new Point(940, 384);
            panel17.Name = "panel17";
            panel17.Size = new Size(14, 131);
            panel17.TabIndex = 3;
            // 
            // FreelancerSigninForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(1184, 661);
            Controls.Add(clientSignupPanel);
            Controls.Add(panel13);
            Controls.Add(panel6);
            Controls.Add(panel17);
            Controls.Add(panel12);
            Controls.Add(panel15);
            Controls.Add(panel5);
            Controls.Add(panel11);
            Controls.Add(panel3);
            Controls.Add(panel10);
            Controls.Add(panel9);
            Controls.Add(panel7);
            Controls.Add(panel8);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel14);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FreelancerSigninForm";
            Text = "FreelancerSigninForm";
            FormClosed += FreelancerSigninForm_FormClosed;
            clientSignupPanel.ResumeLayout(false);
            clientSignupPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel clientSignupPanel;
        private Button backButton;
        private Label setupLabel;
        private LinkLabel siginUpLinkLabel;
        private Button signinButton;
        private Label passwordLabel;
        private Label emailLabel;
        private TextBox passwordTextBox;
        private TextBox emailTextBox;
        private Panel panel1;
        private Label clientSignupLabel;
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
        private Panel panel12;
        private Panel panel13;
        private Panel panel14;
        private Panel panel15;
        private Panel panel17;
    }
}