﻿namespace HeinHtetNaing_ADI.Views.ClientViews
{
    partial class ClientSignUpForm
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
            signupButton = new Button();
            confirmPasswordLabel = new Label();
            passwordLabel = new Label();
            phoneNumberLabel = new Label();
            addressLabel = new Label();
            emailLabel = new Label();
            lastNameLabel = new Label();
            firstNameLabel = new Label();
            confirmPasswordTextBox = new TextBox();
            phoneNumberTextBox = new TextBox();
            passwordTextBox = new TextBox();
            addressTextBox = new TextBox();
            emailTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            panel1 = new Panel();
            clientSignupLabel = new Label();
            panel6 = new Panel();
            panel11 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel8 = new Panel();
            panel7 = new Panel();
            panel10 = new Panel();
            panel9 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel12 = new Panel();
            clientSignupPanel.SuspendLayout();
            SuspendLayout();
            // 
            // clientSignupPanel
            // 
            clientSignupPanel.BackColor = Color.White;
            clientSignupPanel.Controls.Add(backButton);
            clientSignupPanel.Controls.Add(signupButton);
            clientSignupPanel.Controls.Add(confirmPasswordLabel);
            clientSignupPanel.Controls.Add(passwordLabel);
            clientSignupPanel.Controls.Add(phoneNumberLabel);
            clientSignupPanel.Controls.Add(addressLabel);
            clientSignupPanel.Controls.Add(emailLabel);
            clientSignupPanel.Controls.Add(lastNameLabel);
            clientSignupPanel.Controls.Add(firstNameLabel);
            clientSignupPanel.Controls.Add(confirmPasswordTextBox);
            clientSignupPanel.Controls.Add(phoneNumberTextBox);
            clientSignupPanel.Controls.Add(passwordTextBox);
            clientSignupPanel.Controls.Add(addressTextBox);
            clientSignupPanel.Controls.Add(emailTextBox);
            clientSignupPanel.Controls.Add(lastNameTextBox);
            clientSignupPanel.Controls.Add(firstNameTextBox);
            clientSignupPanel.Controls.Add(panel1);
            clientSignupPanel.Controls.Add(clientSignupLabel);
            clientSignupPanel.Location = new Point(344, 12);
            clientSignupPanel.Name = "clientSignupPanel";
            clientSignupPanel.Size = new Size(503, 643);
            clientSignupPanel.TabIndex = 0;
            // 
            // backButton
            // 
            backButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backButton.Location = new Point(28, 581);
            backButton.Name = "backButton";
            backButton.Size = new Size(439, 38);
            backButton.TabIndex = 5;
            backButton.Text = "Back to Sign in";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // signupButton
            // 
            signupButton.BackColor = Color.DarkRed;
            signupButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signupButton.ForeColor = Color.White;
            signupButton.Location = new Point(28, 534);
            signupButton.Name = "signupButton";
            signupButton.Size = new Size(439, 41);
            signupButton.TabIndex = 4;
            signupButton.Text = "Sign Up";
            signupButton.UseVisualStyleBackColor = false;
            signupButton.Click += signupButton_Click;
            // 
            // confirmPasswordLabel
            // 
            confirmPasswordLabel.AutoSize = true;
            confirmPasswordLabel.Location = new Point(46, 461);
            confirmPasswordLabel.Name = "confirmPasswordLabel";
            confirmPasswordLabel.Size = new Size(104, 15);
            confirmPasswordLabel.TabIndex = 3;
            confirmPasswordLabel.Text = "Confirm Password";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(46, 399);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(57, 15);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Password";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(46, 335);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(69, 15);
            phoneNumberLabel.TabIndex = 3;
            phoneNumberLabel.Text = "Phone No : ";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(46, 273);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(101, 15);
            addressLabel.TabIndex = 3;
            addressLabel.Text = "Current Address : ";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(46, 212);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(90, 15);
            emailLabel.TabIndex = 3;
            emailLabel.Text = "Email Address : ";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(46, 147);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(72, 15);
            lastNameLabel.TabIndex = 3;
            lastNameLabel.Text = "Last Name : ";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(46, 88);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(73, 15);
            firstNameLabel.TabIndex = 3;
            firstNameLabel.Text = "First Name : ";
            // 
            // confirmPasswordTextBox
            // 
            confirmPasswordTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmPasswordTextBox.ForeColor = Color.DarkRed;
            confirmPasswordTextBox.Location = new Point(46, 479);
            confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            confirmPasswordTextBox.PasswordChar = '*';
            confirmPasswordTextBox.Size = new Size(421, 29);
            confirmPasswordTextBox.TabIndex = 2;
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneNumberTextBox.ForeColor = Color.DarkRed;
            phoneNumberTextBox.Location = new Point(46, 353);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(421, 29);
            phoneNumberTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.ForeColor = Color.DarkRed;
            passwordTextBox.Location = new Point(46, 417);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(421, 29);
            passwordTextBox.TabIndex = 2;
            // 
            // addressTextBox
            // 
            addressTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressTextBox.ForeColor = Color.DarkRed;
            addressTextBox.Location = new Point(46, 291);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(421, 29);
            addressTextBox.TabIndex = 2;
            // 
            // emailTextBox
            // 
            emailTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTextBox.ForeColor = Color.DarkRed;
            emailTextBox.Location = new Point(46, 230);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(421, 29);
            emailTextBox.TabIndex = 2;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameTextBox.ForeColor = Color.DarkRed;
            lastNameTextBox.Location = new Point(46, 165);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(421, 29);
            lastNameTextBox.TabIndex = 2;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNameTextBox.ForeColor = Color.DarkRed;
            firstNameTextBox.Location = new Point(46, 106);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(421, 29);
            firstNameTextBox.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkRed;
            panel1.Location = new Point(26, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 447);
            panel1.TabIndex = 1;
            // 
            // clientSignupLabel
            // 
            clientSignupLabel.AutoSize = true;
            clientSignupLabel.BackColor = Color.Transparent;
            clientSignupLabel.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clientSignupLabel.ForeColor = Color.DarkRed;
            clientSignupLabel.Location = new Point(21, 16);
            clientSignupLabel.Name = "clientSignupLabel";
            clientSignupLabel.Size = new Size(345, 47);
            clientSignupLabel.TabIndex = 0;
            clientSignupLabel.Text = "Set up client account";
            // 
            // panel6
            // 
            panel6.BackColor = Color.DarkRed;
            panel6.Location = new Point(1037, 347);
            panel6.Name = "panel6";
            panel6.Size = new Size(27, 335);
            panel6.TabIndex = 2;
            // 
            // panel11
            // 
            panel11.BackColor = Color.DarkRed;
            panel11.Location = new Point(898, 191);
            panel11.Name = "panel11";
            panel11.Size = new Size(10, 335);
            panel11.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkRed;
            panel5.Location = new Point(1144, 123);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 239);
            panel5.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkRed;
            panel4.Location = new Point(973, -76);
            panel4.Name = "panel4";
            panel4.Size = new Size(48, 125);
            panel4.TabIndex = 5;
            // 
            // panel8
            // 
            panel8.BackColor = Color.DarkRed;
            panel8.Location = new Point(999, 224);
            panel8.Name = "panel8";
            panel8.Size = new Size(10, 30);
            panel8.TabIndex = 6;
            // 
            // panel7
            // 
            panel7.BackColor = Color.DarkRed;
            panel7.Location = new Point(265, -65);
            panel7.Name = "panel7";
            panel7.Size = new Size(10, 30);
            panel7.TabIndex = 7;
            // 
            // panel10
            // 
            panel10.BackColor = Color.DarkRed;
            panel10.Location = new Point(107, 12);
            panel10.Name = "panel10";
            panel10.Size = new Size(30, 132);
            panel10.TabIndex = 8;
            // 
            // panel9
            // 
            panel9.BackColor = Color.DarkRed;
            panel9.Location = new Point(275, 159);
            panel9.Name = "panel9";
            panel9.Size = new Size(10, 558);
            panel9.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkRed;
            panel3.Location = new Point(59, 563);
            panel3.Name = "panel3";
            panel3.Size = new Size(18, 54);
            panel3.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkRed;
            panel2.Location = new Point(41, -76);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 242);
            panel2.TabIndex = 11;
            // 
            // panel12
            // 
            panel12.BackColor = Color.DarkRed;
            panel12.Location = new Point(163, 338);
            panel12.Name = "panel12";
            panel12.Size = new Size(10, 171);
            panel12.TabIndex = 9;
            // 
            // ClientSignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 661);
            Controls.Add(panel6);
            Controls.Add(panel11);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel10);
            Controls.Add(panel12);
            Controls.Add(panel9);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(clientSignupPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ClientSignUpForm";
            Text = "ClientSignUpForm";
            FormClosed += ClientSignUpForm_FormClosed;
            Load += ClientSignUpForm_Load;
            KeyDown += ClientSignUpForm_KeyDown;
            clientSignupPanel.ResumeLayout(false);
            clientSignupPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel clientSignupPanel;
        private Label clientSignupLabel;
        private Label lastNameLabel;
        private Label firstNameLabel;
        private TextBox lastNameTextBox;
        private TextBox firstNameTextBox;
        private Label emailLabel;
        private TextBox emailTextBox;
        private Panel panel1;
        private Label passwordLabel;
        private TextBox passwordTextBox;
        private Button signupButton;
        private Label confirmPasswordLabel;
        private Label phoneNumberLabel;
        private Label addressLabel;
        private TextBox confirmPasswordTextBox;
        private TextBox phoneNumberTextBox;
        private TextBox addressTextBox;
        private Button backButton;
        private Panel panel6;
        private Panel panel11;
        private Panel panel5;
        private Panel panel4;
        private Panel panel8;
        private Panel panel7;
        private Panel panel10;
        private Panel panel9;
        private Panel panel3;
        private Panel panel2;
        private Panel panel12;
    }
}