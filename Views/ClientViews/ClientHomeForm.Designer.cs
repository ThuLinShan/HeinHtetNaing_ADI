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
            userNameLabel = new Label();
            panel1 = new Panel();
            postProjectButton = new Button();
            projectContainerPanel.SuspendLayout();
            projectPanel.SuspendLayout();
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
            projectPanel.TabIndex = 1;
            // 
            // projectDescriptionTextBox
            // 
            projectDescriptionTextBox.Enabled = false;
            projectDescriptionTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            projectDescriptionTextBox.Location = new Point(211, 18);
            projectDescriptionTextBox.Multiline = true;
            projectDescriptionTextBox.Name = "projectDescriptionTextBox";
            projectDescriptionTextBox.Size = new Size(575, 120);
            projectDescriptionTextBox.TabIndex = 2;
            // 
            // projectDetailsButton
            // 
            projectDetailsButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            projectDetailsButton.ForeColor = Color.DarkRed;
            projectDetailsButton.Location = new Point(15, 109);
            projectDetailsButton.Name = "projectDetailsButton";
            projectDetailsButton.Size = new Size(127, 29);
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
            projectCurrencyLabel.Click += projectBudgetLabel_Click;
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
            projectBudgetLabel.Click += projectBudgetLabel_Click;
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
            clientProfilePanel.Location = new Point(12, 65);
            clientProfilePanel.Name = "clientProfilePanel";
            clientProfilePanel.Size = new Size(308, 584);
            clientProfilePanel.TabIndex = 1;
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
            panel1.Controls.Add(postProjectButton);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1160, 47);
            panel1.TabIndex = 2;
            // 
            // postProjectButton
            // 
            postProjectButton.BackColor = Color.Maroon;
            postProjectButton.FlatStyle = FlatStyle.Flat;
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
    }
}