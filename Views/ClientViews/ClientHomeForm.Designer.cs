namespace HeinHtetNaing_ADI.Views.ClientViews
{
    partial class ClientHomeForm
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
            projectContainerPanel = new Panel();
            projectPanel = new Panel();
            projectDescriptionTextBox = new TextBox();
            deleteProjectButton = new Button();
            projectDetailsButton = new Button();
            projectIdLabel = new Label();
            label1 = new Label();
            projectCurrencyLabel = new Label();
            projectBudgetLabel = new Label();
            projectDeadLineLabel = new Label();
            label2 = new Label();
            projectTitleLabel = new Label();
            noProjectLabel = new Label();
            clientProfilePanel = new Panel();
            userDetailsLabel = new Label();
            updateUserButton = new Button();
            addressTextBox = new TextBox();
            phoneNoTextBox = new TextBox();
            emailTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            addressLabel = new Label();
            phoneNoLabel = new Label();
            emailLabel = new Label();
            lastNameLabel = new Label();
            firstNameLabel = new Label();
            userNameLabel = new Label();
            panel1 = new Panel();
            searchFreelancerButton = new Button();
            postProjectButton = new Button();
            projectContainerPanel.SuspendLayout();
            projectPanel.SuspendLayout();
            clientProfilePanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // projectContainerPanel
            // 
            projectContainerPanel.AutoScroll = true;
            projectContainerPanel.BackColor = SystemColors.ControlLight;
            projectContainerPanel.BorderStyle = BorderStyle.FixedSingle;
            projectContainerPanel.Controls.Add(projectPanel);
            projectContainerPanel.Controls.Add(noProjectLabel);
            projectContainerPanel.Location = new Point(326, 65);
            projectContainerPanel.Name = "projectContainerPanel";
            projectContainerPanel.Size = new Size(846, 584);
            projectContainerPanel.TabIndex = 0;
            // 
            // projectPanel
            // 
            projectPanel.BackColor = Color.White;
            projectPanel.Controls.Add(projectDescriptionTextBox);
            projectPanel.Controls.Add(deleteProjectButton);
            projectPanel.Controls.Add(projectDetailsButton);
            projectPanel.Controls.Add(projectIdLabel);
            projectPanel.Controls.Add(label1);
            projectPanel.Controls.Add(projectCurrencyLabel);
            projectPanel.Controls.Add(projectBudgetLabel);
            projectPanel.Controls.Add(projectDeadLineLabel);
            projectPanel.Controls.Add(label2);
            projectPanel.Controls.Add(projectTitleLabel);
            projectPanel.Location = new Point(22, 22);
            projectPanel.Name = "projectPanel";
            projectPanel.Size = new Size(802, 152);
            projectPanel.TabIndex = 10;
            // 
            // projectDescriptionTextBox
            // 
            projectDescriptionTextBox.Enabled = false;
            projectDescriptionTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            projectDescriptionTextBox.Location = new Point(211, 18);
            projectDescriptionTextBox.Multiline = true;
            projectDescriptionTextBox.Name = "projectDescriptionTextBox";
            projectDescriptionTextBox.ReadOnly = true;
            projectDescriptionTextBox.Size = new Size(575, 120);
            projectDescriptionTextBox.TabIndex = 2;
            // 
            // deleteProjectButton
            // 
            deleteProjectButton.BackColor = Color.Red;
            deleteProjectButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteProjectButton.ForeColor = Color.White;
            deleteProjectButton.Location = new Point(107, 109);
            deleteProjectButton.Name = "deleteProjectButton";
            deleteProjectButton.Size = new Size(86, 29);
            deleteProjectButton.TabIndex = 1;
            deleteProjectButton.Text = "Delete";
            deleteProjectButton.UseVisualStyleBackColor = false;
            // 
            // projectDetailsButton
            // 
            projectDetailsButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            projectDetailsButton.ForeColor = Color.DarkRed;
            projectDetailsButton.Location = new Point(15, 109);
            projectDetailsButton.Name = "projectDetailsButton";
            projectDetailsButton.Size = new Size(86, 29);
            projectDetailsButton.TabIndex = 1;
            projectDetailsButton.Text = "Details";
            projectDetailsButton.UseVisualStyleBackColor = true;
            // 
            // projectIdLabel
            // 
            projectIdLabel.AutoSize = true;
            projectIdLabel.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            projectIdLabel.ForeColor = Color.DarkRed;
            projectIdLabel.Location = new Point(137, 19);
            projectIdLabel.Name = "projectIdLabel";
            projectIdLabel.Size = new Size(0, 17);
            projectIdLabel.TabIndex = 0;
            projectIdLabel.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(15, 80);
            label1.Name = "label1";
            label1.Size = new Size(58, 17);
            label1.TabIndex = 0;
            label1.Text = "Budget:";
            // 
            // projectCurrencyLabel
            // 
            projectCurrencyLabel.AutoSize = true;
            projectCurrencyLabel.BackColor = Color.DarkRed;
            projectCurrencyLabel.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            projectCurrencyLabel.ForeColor = Color.White;
            projectCurrencyLabel.Location = new Point(137, 80);
            projectCurrencyLabel.Name = "projectCurrencyLabel";
            projectCurrencyLabel.Size = new Size(39, 17);
            projectCurrencyLabel.TabIndex = 0;
            projectCurrencyLabel.Text = "GBP";
            // 
            // projectBudgetLabel
            // 
            projectBudgetLabel.AutoSize = true;
            projectBudgetLabel.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            projectBudgetLabel.ForeColor = Color.DarkRed;
            projectBudgetLabel.Location = new Point(75, 80);
            projectBudgetLabel.Name = "projectBudgetLabel";
            projectBudgetLabel.Size = new Size(56, 17);
            projectBudgetLabel.TabIndex = 0;
            projectBudgetLabel.Text = "100000";
            // 
            // projectDeadLineLabel
            // 
            projectDeadLineLabel.AutoSize = true;
            projectDeadLineLabel.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            projectDeadLineLabel.ForeColor = Color.DarkRed;
            projectDeadLineLabel.Location = new Point(107, 53);
            projectDeadLineLabel.Name = "projectDeadLineLabel";
            projectDeadLineLabel.Size = new Size(80, 17);
            projectDeadLineLabel.TabIndex = 0;
            projectDeadLineLabel.Text = "2024/12/15";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(15, 53);
            label2.Name = "label2";
            label2.Size = new Size(86, 17);
            label2.TabIndex = 0;
            label2.Text = "Dead Line : ";
            // 
            // projectTitleLabel
            // 
            projectTitleLabel.AutoSize = true;
            projectTitleLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            projectTitleLabel.ForeColor = Color.DarkRed;
            projectTitleLabel.Location = new Point(13, 13);
            projectTitleLabel.Name = "projectTitleLabel";
            projectTitleLabel.Size = new Size(118, 25);
            projectTitleLabel.TabIndex = 0;
            projectTitleLabel.Text = "Project Title";
            // 
            // noProjectLabel
            // 
            noProjectLabel.AutoSize = true;
            noProjectLabel.Location = new Point(326, 263);
            noProjectLabel.Name = "noProjectLabel";
            noProjectLabel.Size = new Size(0, 15);
            noProjectLabel.TabIndex = 0;
            // 
            // clientProfilePanel
            // 
            clientProfilePanel.BackColor = Color.SeaShell;
            clientProfilePanel.Controls.Add(userDetailsLabel);
            clientProfilePanel.Controls.Add(updateUserButton);
            clientProfilePanel.Controls.Add(addressTextBox);
            clientProfilePanel.Controls.Add(phoneNoTextBox);
            clientProfilePanel.Controls.Add(emailTextBox);
            clientProfilePanel.Controls.Add(lastNameTextBox);
            clientProfilePanel.Controls.Add(firstNameTextBox);
            clientProfilePanel.Controls.Add(addressLabel);
            clientProfilePanel.Controls.Add(phoneNoLabel);
            clientProfilePanel.Controls.Add(emailLabel);
            clientProfilePanel.Controls.Add(lastNameLabel);
            clientProfilePanel.Controls.Add(firstNameLabel);
            clientProfilePanel.Location = new Point(12, 65);
            clientProfilePanel.Name = "clientProfilePanel";
            clientProfilePanel.Size = new Size(308, 584);
            clientProfilePanel.TabIndex = 1;
            // 
            // userDetailsLabel
            // 
            userDetailsLabel.AutoSize = true;
            userDetailsLabel.Font = new Font("Arial", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            userDetailsLabel.ForeColor = Color.DarkRed;
            userDetailsLabel.Location = new Point(16, 37);
            userDetailsLabel.Name = "userDetailsLabel";
            userDetailsLabel.Size = new Size(150, 29);
            userDetailsLabel.TabIndex = 2;
            userDetailsLabel.Text = "User Details";
            // 
            // updateUserButton
            // 
            updateUserButton.BackColor = Color.Maroon;
            updateUserButton.FlatStyle = FlatStyle.Popup;
            updateUserButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateUserButton.ForeColor = Color.White;
            updateUserButton.Location = new Point(16, 477);
            updateUserButton.Name = "updateUserButton";
            updateUserButton.Size = new Size(273, 47);
            updateUserButton.TabIndex = 0;
            updateUserButton.Text = "Update Details";
            updateUserButton.UseVisualStyleBackColor = false;
            updateUserButton.Click += updateUserButton_Click;
            // 
            // addressTextBox
            // 
            addressTextBox.BackColor = Color.RosyBrown;
            addressTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressTextBox.ForeColor = Color.White;
            addressTextBox.Location = new Point(16, 410);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(273, 29);
            addressTextBox.TabIndex = 1;
            // 
            // phoneNoTextBox
            // 
            phoneNoTextBox.BackColor = Color.RosyBrown;
            phoneNoTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneNoTextBox.ForeColor = Color.White;
            phoneNoTextBox.Location = new Point(16, 329);
            phoneNoTextBox.Name = "phoneNoTextBox";
            phoneNoTextBox.Size = new Size(273, 29);
            phoneNoTextBox.TabIndex = 1;
            // 
            // emailTextBox
            // 
            emailTextBox.BackColor = Color.RosyBrown;
            emailTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTextBox.ForeColor = Color.White;
            emailTextBox.Location = new Point(16, 253);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(273, 29);
            emailTextBox.TabIndex = 1;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.BackColor = Color.RosyBrown;
            lastNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameTextBox.ForeColor = Color.White;
            lastNameTextBox.Location = new Point(16, 178);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(273, 29);
            lastNameTextBox.TabIndex = 1;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.BackColor = Color.RosyBrown;
            firstNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNameTextBox.ForeColor = Color.White;
            firstNameTextBox.Location = new Point(16, 105);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(273, 29);
            firstNameTextBox.TabIndex = 1;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.BackColor = Color.Transparent;
            addressLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressLabel.ForeColor = Color.DarkRed;
            addressLabel.Location = new Point(16, 386);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(81, 21);
            addressLabel.TabIndex = 0;
            addressLabel.Text = "Address  : ";
            // 
            // phoneNoLabel
            // 
            phoneNoLabel.AutoSize = true;
            phoneNoLabel.BackColor = Color.Transparent;
            phoneNoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneNoLabel.ForeColor = Color.DarkRed;
            phoneNoLabel.Location = new Point(16, 305);
            phoneNoLabel.Name = "phoneNoLabel";
            phoneNoLabel.Size = new Size(90, 21);
            phoneNoLabel.TabIndex = 0;
            phoneNoLabel.Text = "Phone No : ";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = Color.Transparent;
            emailLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailLabel.ForeColor = Color.DarkRed;
            emailLabel.Location = new Point(16, 229);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(59, 21);
            emailLabel.TabIndex = 0;
            emailLabel.Text = "Email : ";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.BackColor = Color.Transparent;
            lastNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameLabel.ForeColor = Color.DarkRed;
            lastNameLabel.Location = new Point(16, 154);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(95, 21);
            lastNameLabel.TabIndex = 0;
            lastNameLabel.Text = "Last Name : ";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.BackColor = Color.Transparent;
            firstNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNameLabel.ForeColor = Color.DarkRed;
            firstNameLabel.Location = new Point(16, 84);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(97, 21);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name : ";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.BackColor = Color.Transparent;
            userNameLabel.Font = new Font("Script MT Bold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userNameLabel.ForeColor = Color.DarkRed;
            userNameLabel.Location = new Point(16, 6);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(193, 33);
            userNameLabel.TabIndex = 0;
            userNameLabel.Text = "Hello, username";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(userNameLabel);
            panel1.Controls.Add(searchFreelancerButton);
            panel1.Controls.Add(postProjectButton);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1160, 47);
            panel1.TabIndex = 2;
            // 
            // searchFreelancerButton
            // 
            searchFreelancerButton.BackColor = Color.White;
            searchFreelancerButton.FlatAppearance.BorderColor = Color.DarkRed;
            searchFreelancerButton.FlatAppearance.BorderSize = 2;
            searchFreelancerButton.FlatStyle = FlatStyle.Flat;
            searchFreelancerButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchFreelancerButton.ForeColor = Color.DarkRed;
            searchFreelancerButton.Location = new Point(737, 0);
            searchFreelancerButton.Name = "searchFreelancerButton";
            searchFreelancerButton.Size = new Size(201, 47);
            searchFreelancerButton.TabIndex = 0;
            searchFreelancerButton.Text = "Search Freelancers";
            searchFreelancerButton.UseVisualStyleBackColor = false;
            searchFreelancerButton.Click += searchFreelancerButton_Click;
            // 
            // postProjectButton
            // 
            postProjectButton.BackColor = Color.Maroon;
            postProjectButton.FlatStyle = FlatStyle.Popup;
            postProjectButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            postProjectButton.ForeColor = Color.White;
            postProjectButton.Location = new Point(959, 0);
            postProjectButton.Name = "postProjectButton";
            postProjectButton.Size = new Size(201, 47);
            postProjectButton.TabIndex = 0;
            postProjectButton.Text = "Post a Project";
            postProjectButton.UseVisualStyleBackColor = false;
            postProjectButton.Click += postProjectButton_Click;
            // 
            // ClientHomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 661);
            Controls.Add(panel1);
            Controls.Add(clientProfilePanel);
            Controls.Add(projectContainerPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ClientHomeForm";
            Text = "ClientHomeForm";
            FormClosed += ClientHomeForm_FormClosed;
            Load += ClientHomeForm_Load;
            projectContainerPanel.ResumeLayout(false);
            projectContainerPanel.PerformLayout();
            projectPanel.ResumeLayout(false);
            projectPanel.PerformLayout();
            clientProfilePanel.ResumeLayout(false);
            clientProfilePanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel projectContainerPanel;
        private Panel clientProfilePanel;
        private Label userNameLabel;
        private Panel panel1;
        private Button postProjectButton;
        private Label noProjectLabel;
        private Panel projectPanel;
        private Label projectTitleLabel;
        private Button projectDetailsButton;
        private Label projectBudgetLabel;
        private Label label1;
        private Label projectCurrencyLabel;
        private Label label2;
        private Label projectDeadLineLabel;
        private TextBox projectDescriptionTextBox;
        private Label projectIdLabel;
        private Button deleteProjectButton;
        private Label firstNameLabel;
        private Label emailLabel;
        private Label lastNameLabel;
        private Label phoneNoLabel;
        private Label addressLabel;
        private TextBox addressTextBox;
        private TextBox phoneNoTextBox;
        private TextBox emailTextBox;
        private TextBox lastNameTextBox;
        private TextBox firstNameTextBox;
        private Label userDetailsLabel;
        private Button updateUserButton;
        private Button searchFreelancerButton;
    }
}