namespace HeinHtetNaing_ADI.Views.ClientViews
{
    partial class ClientPostProjectForm
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
            projectCurrencyComboBox = new ComboBox();
            backButton = new Button();
            postProjectButton = new Button();
            projectDescription = new Label();
            projectBudgetCurrencyLabel = new Label();
            projectBudgetLabel = new Label();
            projectTitleLabel = new Label();
            passwordTextBox = new TextBox();
            projectBudgetTextBox = new TextBox();
            emailTextBox = new TextBox();
            panel1 = new Panel();
            clientPostProjectLabel = new Label();
            clientSignupPanel.SuspendLayout();
            SuspendLayout();
            // 
            // clientSignupPanel
            // 
            clientSignupPanel.BackColor = Color.White;
            clientSignupPanel.Controls.Add(projectCurrencyComboBox);
            clientSignupPanel.Controls.Add(backButton);
            clientSignupPanel.Controls.Add(postProjectButton);
            clientSignupPanel.Controls.Add(projectDescription);
            clientSignupPanel.Controls.Add(projectBudgetCurrencyLabel);
            clientSignupPanel.Controls.Add(projectBudgetLabel);
            clientSignupPanel.Controls.Add(projectTitleLabel);
            clientSignupPanel.Controls.Add(passwordTextBox);
            clientSignupPanel.Controls.Add(projectBudgetTextBox);
            clientSignupPanel.Controls.Add(emailTextBox);
            clientSignupPanel.Controls.Add(clientPostProjectLabel);
            clientSignupPanel.Controls.Add(panel1);
            clientSignupPanel.Location = new Point(192, 12);
            clientSignupPanel.Name = "clientSignupPanel";
            clientSignupPanel.Size = new Size(818, 637);
            clientSignupPanel.TabIndex = 2;
            // 
            // projectCurrencyComboBox
            // 
            projectCurrencyComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            projectCurrencyComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            projectCurrencyComboBox.FormattingEnabled = true;
            projectCurrencyComboBox.Location = new Point(221, 461);
            projectCurrencyComboBox.Name = "projectCurrencyComboBox";
            projectCurrencyComboBox.Size = new Size(121, 29);
            projectCurrencyComboBox.TabIndex = 8;
            // 
            // backButton
            // 
            backButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backButton.Location = new Point(204, 572);
            backButton.Name = "backButton";
            backButton.Size = new Size(286, 41);
            backButton.TabIndex = 7;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // postProjectButton
            // 
            postProjectButton.BackColor = Color.DarkRed;
            postProjectButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            postProjectButton.ForeColor = Color.White;
            postProjectButton.Location = new Point(496, 572);
            postProjectButton.Name = "postProjectButton";
            postProjectButton.Size = new Size(286, 41);
            postProjectButton.TabIndex = 4;
            postProjectButton.Text = "Post";
            postProjectButton.UseVisualStyleBackColor = false;
            postProjectButton.Click += postProjectButton_Click;
            // 
            // projectDescription
            // 
            projectDescription.AutoSize = true;
            projectDescription.Location = new Point(58, 214);
            projectDescription.Name = "projectDescription";
            projectDescription.Size = new Size(113, 15);
            projectDescription.TabIndex = 3;
            projectDescription.Text = "Project Description :";
            // 
            // projectBudgetCurrencyLabel
            // 
            projectBudgetCurrencyLabel.AutoSize = true;
            projectBudgetCurrencyLabel.Location = new Point(221, 443);
            projectBudgetCurrencyLabel.Name = "projectBudgetCurrencyLabel";
            projectBudgetCurrencyLabel.Size = new Size(64, 15);
            projectBudgetCurrencyLabel.TabIndex = 3;
            projectBudgetCurrencyLabel.Text = "Currency : ";
            // 
            // projectBudgetLabel
            // 
            projectBudgetLabel.AutoSize = true;
            projectBudgetLabel.Location = new Point(58, 443);
            projectBudgetLabel.Name = "projectBudgetLabel";
            projectBudgetLabel.Size = new Size(54, 15);
            projectBudgetLabel.TabIndex = 3;
            projectBudgetLabel.Text = "Budget : ";
            // 
            // projectTitleLabel
            // 
            projectTitleLabel.AutoSize = true;
            projectTitleLabel.Location = new Point(58, 154);
            projectTitleLabel.Name = "projectTitleLabel";
            projectTitleLabel.Size = new Size(78, 15);
            projectTitleLabel.TabIndex = 3;
            projectTitleLabel.Text = "Project Title : ";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.ForeColor = Color.DarkRed;
            passwordTextBox.Location = new Point(58, 232);
            passwordTextBox.Multiline = true;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(284, 195);
            passwordTextBox.TabIndex = 2;
            // 
            // projectBudgetTextBox
            // 
            projectBudgetTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            projectBudgetTextBox.ForeColor = Color.DarkRed;
            projectBudgetTextBox.Location = new Point(58, 461);
            projectBudgetTextBox.Name = "projectBudgetTextBox";
            projectBudgetTextBox.Size = new Size(156, 29);
            projectBudgetTextBox.TabIndex = 2;
            projectBudgetTextBox.KeyPress += projectBudgetTextBox_KeyPress;
            // 
            // emailTextBox
            // 
            emailTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTextBox.ForeColor = Color.DarkRed;
            emailTextBox.Location = new Point(58, 172);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(284, 29);
            emailTextBox.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkRed;
            panel1.Location = new Point(27, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 463);
            panel1.TabIndex = 1;
            // 
            // clientPostProjectLabel
            // 
            clientPostProjectLabel.AutoSize = true;
            clientPostProjectLabel.BackColor = Color.Transparent;
            clientPostProjectLabel.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clientPostProjectLabel.ForeColor = Color.DarkRed;
            clientPostProjectLabel.Location = new Point(58, 56);
            clientPostProjectLabel.Name = "clientPostProjectLabel";
            clientPostProjectLabel.Size = new Size(396, 47);
            clientPostProjectLabel.TabIndex = 0;
            clientPostProjectLabel.Text = "Enter you project details";
            // 
            // ClientPostProjectForm
            // 
            ClientSize = new Size(1184, 661);
            Controls.Add(clientSignupPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ClientPostProjectForm";
            Text = "Post a Project";
            Load += ClientPostProjectForm_Load;
            clientSignupPanel.ResumeLayout(false);
            clientSignupPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel clientSignupPanel;
        private Button backButton;
        private Button postProjectButton;
        private Label projectDescription;
        private Label projectTitleLabel;
        private TextBox passwordTextBox;
        private TextBox emailTextBox;
        private Panel panel1;
        private Label clientPostProjectLabel;
        private Label projectBudgetLabel;
        private TextBox projectBudgetTextBox;
        private ComboBox projectCurrencyComboBox;
        private Label projectBudgetCurrencyLabel;
    }
}