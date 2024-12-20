namespace HeinHtetNaing_ADI.Views.FreelancerViews
{
    partial class FreelancerSignupForm
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
            dataGridView1 = new DataGridView();
            skill_name = new DataGridViewTextBoxColumn();
            skill_level = new DataGridViewComboBoxColumn();
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
            freelancerSignupLabel = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            clientSignupPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // clientSignupPanel
            // 
            clientSignupPanel.BackColor = Color.Tomato;
            clientSignupPanel.Controls.Add(dataGridView1);
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
            clientSignupPanel.Controls.Add(freelancerSignupLabel);
            clientSignupPanel.Location = new Point(165, 9);
            clientSignupPanel.Name = "clientSignupPanel";
            clientSignupPanel.Size = new Size(884, 643);
            clientSignupPanel.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.RosyBrown;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { skill_name, skill_level });
            dataGridView1.GridColor = Color.Salmon;
            dataGridView1.ForeColor = Color.Tomato;
            dataGridView1.Location = new Point(474, 302);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(362, 150);
            dataGridView1.TabIndex = 6;
            // 
            // skill_name
            // 
            skill_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            skill_name.HeaderText = "Skill Name";
            skill_name.Name = "skill_name";
            skill_name.Width = 150;
            // 
            // skill_level
            // 
            skill_level.HeaderText = "Skill Level";
            skill_level.Items.AddRange(new object[] { "INTERMEDIATE", "ADVANCED", "EXPERT" });
            skill_level.Name = "skill_level";
            skill_level.Width = 150;
            // 
            // backButton
            // 
            backButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backButton.ForeColor = Color.Tomato;
            backButton.Location = new Point(643, 554);
            backButton.Name = "backButton";
            backButton.Size = new Size(193, 38);
            backButton.TabIndex = 5;
            backButton.Text = "Back to Sign in";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // signupButton
            // 
            signupButton.BackColor = Color.Tomato;
            signupButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signupButton.ForeColor = Color.White;
            signupButton.Location = new Point(281, 500);
            signupButton.Name = "signupButton";
            signupButton.Size = new Size(555, 38);
            signupButton.TabIndex = 4;
            signupButton.Text = "Sign Up";
            signupButton.UseVisualStyleBackColor = false;
            signupButton.Click += signupButton_Click;
            // 
            // confirmPasswordLabel
            // 
            confirmPasswordLabel.AutoSize = true;
            confirmPasswordLabel.Font = new Font("Segoe UI", 9.75F);
            confirmPasswordLabel.ForeColor = Color.White;
            confirmPasswordLabel.Location = new Point(474, 220);
            confirmPasswordLabel.Name = "confirmPasswordLabel";
            confirmPasswordLabel.Size = new Size(114, 17);
            confirmPasswordLabel.TabIndex = 3;
            confirmPasswordLabel.Text = "Confirm Password";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 9.75F);
            passwordLabel.ForeColor = Color.White;
            passwordLabel.Location = new Point(474, 158);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(64, 17);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Password";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Font = new Font("Segoe UI", 9.75F);
            phoneNumberLabel.ForeColor = Color.White;
            phoneNumberLabel.Location = new Point(82, 405);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(77, 17);
            phoneNumberLabel.TabIndex = 3;
            phoneNumberLabel.Text = "Phone No : ";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new Font("Segoe UI", 9.75F);
            addressLabel.ForeColor = Color.White;
            addressLabel.Location = new Point(82, 343);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(114, 17);
            addressLabel.TabIndex = 3;
            addressLabel.Text = "Current Address : ";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 9.75F);
            emailLabel.ForeColor = Color.White;
            emailLabel.Location = new Point(82, 282);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(102, 17);
            emailLabel.TabIndex = 3;
            emailLabel.Text = "Email Address : ";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 9.75F);
            lastNameLabel.ForeColor = Color.White;
            lastNameLabel.Location = new Point(82, 217);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(81, 17);
            lastNameLabel.TabIndex = 3;
            lastNameLabel.Text = "Last Name : ";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 9.75F);
            firstNameLabel.ForeColor = Color.White;
            firstNameLabel.Location = new Point(82, 158);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(82, 17);
            firstNameLabel.TabIndex = 3;
            firstNameLabel.Text = "First Name : ";
            // 
            // confirmPasswordTextBox
            // 
            confirmPasswordTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmPasswordTextBox.ForeColor = Color.DarkRed;
            confirmPasswordTextBox.Location = new Point(474, 238);
            confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            confirmPasswordTextBox.PasswordChar = '*';
            confirmPasswordTextBox.Size = new Size(362, 29);
            confirmPasswordTextBox.TabIndex = 2;
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneNumberTextBox.ForeColor = Color.DarkRed;
            phoneNumberTextBox.Location = new Point(82, 423);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(362, 29);
            phoneNumberTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.ForeColor = Color.DarkRed;
            passwordTextBox.Location = new Point(474, 176);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(362, 29);
            passwordTextBox.TabIndex = 2;
            // 
            // addressTextBox
            // 
            addressTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressTextBox.ForeColor = Color.DarkRed;
            addressTextBox.Location = new Point(82, 361);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(362, 29);
            addressTextBox.TabIndex = 2;
            // 
            // emailTextBox
            // 
            emailTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTextBox.ForeColor = Color.DarkRed;
            emailTextBox.Location = new Point(82, 300);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(362, 29);
            emailTextBox.TabIndex = 2;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameTextBox.ForeColor = Color.DarkRed;
            lastNameTextBox.Location = new Point(82, 235);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(362, 29);
            lastNameTextBox.TabIndex = 2;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNameTextBox.ForeColor = Color.DarkRed;
            firstNameTextBox.Location = new Point(82, 176);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(362, 29);
            firstNameTextBox.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(37, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 447);
            panel1.TabIndex = 1;
            // 
            // freelancerSignupLabel
            // 
            freelancerSignupLabel.AutoSize = true;
            freelancerSignupLabel.BackColor = Color.Transparent;
            freelancerSignupLabel.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            freelancerSignupLabel.ForeColor = Color.White;
            freelancerSignupLabel.Location = new Point(82, 64);
            freelancerSignupLabel.Name = "freelancerSignupLabel";
            freelancerSignupLabel.Size = new Size(441, 47);
            freelancerSignupLabel.TabIndex = 0;
            freelancerSignupLabel.Text = "Set up freelancer account";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Tomato;
            panel2.Location = new Point(12, 9);
            panel2.Name = "panel2";
            panel2.Size = new Size(37, 100);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Tomato;
            panel3.Location = new Point(37, 176);
            panel3.Name = "panel3";
            panel3.Size = new Size(12, 371);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Tomato;
            panel4.Location = new Point(103, -2);
            panel4.Name = "panel4";
            panel4.Size = new Size(12, 275);
            panel4.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Tomato;
            panel5.Location = new Point(78, 563);
            panel5.Name = "panel5";
            panel5.Size = new Size(37, 100);
            panel5.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Tomato;
            panel6.Location = new Point(1123, 501);
            panel6.Name = "panel6";
            panel6.Size = new Size(37, 100);
            panel6.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Tomato;
            panel7.Location = new Point(1082, 114);
            panel7.Name = "panel7";
            panel7.Size = new Size(12, 371);
            panel7.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Tomato;
            panel8.Location = new Point(1135, 12);
            panel8.Name = "panel8";
            panel8.Size = new Size(37, 100);
            panel8.TabIndex = 2;
            // 
            // FreelancerSignupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(1184, 661);
            Controls.Add(clientSignupPanel);
            Controls.Add(panel4);
            Controls.Add(panel7);
            Controls.Add(panel3);
            Controls.Add(panel8);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FreelancerSignupForm";
            Text = "FreelancerSignupForm";
            FormClosed += FreelancerSignupForm_FormClosed;
            clientSignupPanel.ResumeLayout(false);
            clientSignupPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel clientSignupPanel;
        private Button backButton;
        private Button signupButton;
        private Label confirmPasswordLabel;
        private Label passwordLabel;
        private Label phoneNumberLabel;
        private Label addressLabel;
        private Label emailLabel;
        private Label lastNameLabel;
        private Label firstNameLabel;
        private TextBox confirmPasswordTextBox;
        private TextBox phoneNumberTextBox;
        private TextBox passwordTextBox;
        private TextBox addressTextBox;
        private TextBox emailTextBox;
        private TextBox lastNameTextBox;
        private TextBox firstNameTextBox;
        private Panel panel1;
        private Label freelancerSignupLabel;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn skill_name;
        private DataGridViewComboBoxColumn skill_level;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
    }
}