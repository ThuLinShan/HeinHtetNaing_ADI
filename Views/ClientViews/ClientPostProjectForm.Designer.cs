using System.Windows.Forms;

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
            clearStartDateButton = new Button();
            startDateTimePicker = new DateTimePicker();
            deadLineDateTimePicker = new DateTimePicker();
            projectCurrencyComboBox = new ComboBox();
            backButton = new Button();
            postProjectButton = new Button();
            projectDescription = new Label();
            projectBudgetCurrencyLabel = new Label();
            startDateLabel = new Label();
            projectBudgetLabel = new Label();
            deadLineLabel = new Label();
            skillTadLabel = new Label();
            projectTitleLabel = new Label();
            projectDescriptionTextBox = new TextBox();
            projectBudgetTextBox = new TextBox();
            skillTagTextBox = new TextBox();
            projectTitleTextBox = new TextBox();
            clientPostProjectLabel = new Label();
            panel1 = new Panel();
            clientSignupPanel.SuspendLayout();
            SuspendLayout();
            // 
            // clientSignupPanel
            // 
            clientSignupPanel.BackColor = Color.White;
            clientSignupPanel.Controls.Add(clearStartDateButton);
            clientSignupPanel.Controls.Add(startDateTimePicker);
            clientSignupPanel.Controls.Add(deadLineDateTimePicker);
            clientSignupPanel.Controls.Add(projectCurrencyComboBox);
            clientSignupPanel.Controls.Add(backButton);
            clientSignupPanel.Controls.Add(postProjectButton);
            clientSignupPanel.Controls.Add(projectDescription);
            clientSignupPanel.Controls.Add(projectBudgetCurrencyLabel);
            clientSignupPanel.Controls.Add(startDateLabel);
            clientSignupPanel.Controls.Add(projectBudgetLabel);
            clientSignupPanel.Controls.Add(deadLineLabel);
            clientSignupPanel.Controls.Add(skillTadLabel);
            clientSignupPanel.Controls.Add(projectTitleLabel);
            clientSignupPanel.Controls.Add(projectDescriptionTextBox);
            clientSignupPanel.Controls.Add(projectBudgetTextBox);
            clientSignupPanel.Controls.Add(skillTagTextBox);
            clientSignupPanel.Controls.Add(projectTitleTextBox);
            clientSignupPanel.Controls.Add(clientPostProjectLabel);
            clientSignupPanel.Controls.Add(panel1);
            clientSignupPanel.Location = new Point(192, 0);
            clientSignupPanel.Name = "clientSignupPanel";
            clientSignupPanel.Size = new Size(818, 665);
            clientSignupPanel.TabIndex = 2;
            // 
            // clearStartDateButton
            // 
            clearStartDateButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clearStartDateButton.Location = new Point(660, 284);
            clearStartDateButton.Name = "clearStartDateButton";
            clearStartDateButton.Size = new Size(75, 26);
            clearStartDateButton.TabIndex = 10;
            clearStartDateButton.Text = "Clear";
            clearStartDateButton.UseVisualStyleBackColor = true;
            clearStartDateButton.Click += clearStartDateButton_Click;
            // 
            // startDateTimePicker
            // 
            startDateTimePicker.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startDateTimePicker.CustomFormat = " ";
            startDateTimePicker.Format = DateTimePickerFormat.Custom;
            startDateTimePicker.Location = new Point(451, 285);
            startDateTimePicker.Name = "startDateTimePicker";
            startDateTimePicker.Size = new Size(203, 23);
            startDateTimePicker.TabIndex = 9;
            startDateTimePicker.ValueChanged += startDateTimePicker_ValueChanged;
            // 
            // deadLineDateTimePicker
            // 
            deadLineDateTimePicker.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deadLineDateTimePicker.Format = DateTimePickerFormat.Short;
            deadLineDateTimePicker.Location = new Point(451, 343);
            deadLineDateTimePicker.Name = "deadLineDateTimePicker";
            deadLineDateTimePicker.Size = new Size(284, 23);
            deadLineDateTimePicker.TabIndex = 9;
            // 
            // projectCurrencyComboBox
            // 
            projectCurrencyComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            projectCurrencyComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            projectCurrencyComboBox.FormattingEnabled = true;
            projectCurrencyComboBox.Location = new Point(614, 413);
            projectCurrencyComboBox.Name = "projectCurrencyComboBox";
            projectCurrencyComboBox.Size = new Size(121, 29);
            projectCurrencyComboBox.TabIndex = 8;
            // 
            // backButton
            // 
            backButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backButton.Location = new Point(219, 508);
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
            postProjectButton.Location = new Point(511, 508);
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
            projectDescription.Location = new Point(58, 267);
            projectDescription.Name = "projectDescription";
            projectDescription.Size = new Size(113, 15);
            projectDescription.TabIndex = 3;
            projectDescription.Text = "Project Description :";
            // 
            // projectBudgetCurrencyLabel
            // 
            projectBudgetCurrencyLabel.AutoSize = true;
            projectBudgetCurrencyLabel.Location = new Point(614, 395);
            projectBudgetCurrencyLabel.Name = "projectBudgetCurrencyLabel";
            projectBudgetCurrencyLabel.Size = new Size(64, 15);
            projectBudgetCurrencyLabel.TabIndex = 3;
            projectBudgetCurrencyLabel.Text = "Currency : ";
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Location = new Point(451, 267);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new Size(124, 15);
            startDateLabel.TabIndex = 3;
            startDateLabel.Text = "Start Date (Optional) : ";
            // 
            // projectBudgetLabel
            // 
            projectBudgetLabel.AutoSize = true;
            projectBudgetLabel.Location = new Point(451, 395);
            projectBudgetLabel.Name = "projectBudgetLabel";
            projectBudgetLabel.Size = new Size(54, 15);
            projectBudgetLabel.TabIndex = 3;
            projectBudgetLabel.Text = "Budget : ";
            // 
            // deadLineLabel
            // 
            deadLineLabel.AutoSize = true;
            deadLineLabel.Location = new Point(451, 325);
            deadLineLabel.Name = "deadLineLabel";
            deadLineLabel.Size = new Size(68, 15);
            deadLineLabel.TabIndex = 3;
            deadLineLabel.Text = "Dead Line : ";
            // 
            // skillTadLabel
            // 
            skillTadLabel.AutoSize = true;
            skillTadLabel.Location = new Point(451, 179);
            skillTadLabel.Name = "skillTadLabel";
            skillTadLabel.Size = new Size(63, 15);
            skillTadLabel.TabIndex = 3;
            skillTadLabel.Text = "Skill Tags : ";
            // 
            // projectTitleLabel
            // 
            projectTitleLabel.AutoSize = true;
            projectTitleLabel.Location = new Point(58, 179);
            projectTitleLabel.Name = "projectTitleLabel";
            projectTitleLabel.Size = new Size(78, 15);
            projectTitleLabel.TabIndex = 3;
            projectTitleLabel.Text = "Project Title : ";
            // 
            // projectDescriptionTextBox
            // 
            projectDescriptionTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            projectDescriptionTextBox.ForeColor = Color.DarkRed;
            projectDescriptionTextBox.Location = new Point(58, 285);
            projectDescriptionTextBox.Multiline = true;
            projectDescriptionTextBox.Name = "projectDescriptionTextBox";
            projectDescriptionTextBox.Size = new Size(284, 157);
            projectDescriptionTextBox.TabIndex = 2;
            // 
            // projectBudgetTextBox
            // 
            projectBudgetTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            projectBudgetTextBox.ForeColor = Color.DarkRed;
            projectBudgetTextBox.Location = new Point(451, 413);
            projectBudgetTextBox.Name = "projectBudgetTextBox";
            projectBudgetTextBox.Size = new Size(156, 29);
            projectBudgetTextBox.TabIndex = 2;
            projectBudgetTextBox.KeyPress += projectBudgetTextBox_KeyPress;
            // 
            // skillTagTextBox
            // 
            skillTagTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            skillTagTextBox.ForeColor = Color.DarkRed;
            skillTagTextBox.Location = new Point(451, 197);
            skillTagTextBox.Name = "skillTagTextBox";
            skillTagTextBox.Size = new Size(284, 29);
            skillTagTextBox.TabIndex = 2;
            // 
            // projectTitleTextBox
            // 
            projectTitleTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            projectTitleTextBox.ForeColor = Color.DarkRed;
            projectTitleTextBox.Location = new Point(58, 197);
            projectTitleTextBox.Name = "projectTitleTextBox";
            projectTitleTextBox.Size = new Size(284, 29);
            projectTitleTextBox.TabIndex = 2;
            // 
            // clientPostProjectLabel
            // 
            clientPostProjectLabel.AutoSize = true;
            clientPostProjectLabel.BackColor = Color.Transparent;
            clientPostProjectLabel.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clientPostProjectLabel.ForeColor = Color.DarkRed;
            clientPostProjectLabel.Location = new Point(38, 71);
            clientPostProjectLabel.Name = "clientPostProjectLabel";
            clientPostProjectLabel.Size = new Size(396, 47);
            clientPostProjectLabel.TabIndex = 0;
            clientPostProjectLabel.Text = "Enter you project details";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkRed;
            panel1.Location = new Point(27, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 463);
            panel1.TabIndex = 1;
            // 
            // ClientPostProjectForm
            // 
            BackColor = Color.DarkRed;
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
        private TextBox projectDescriptionTextBox;
        private TextBox projectTitleTextBox;
        private Panel panel1;
        private Label clientPostProjectLabel;
        private Label projectBudgetLabel;
        private TextBox projectBudgetTextBox;
        private ComboBox projectCurrencyComboBox;
        private Label projectBudgetCurrencyLabel;
        private Label skillTadLabel;
        private TextBox skillTagTextBox;
        private DateTimePicker deadLineDateTimePicker;
        private Label deadLineLabel;
        private DateTimePicker startDateTimePicker;
        private Label startDateLabel;
        private Button clearStartDateButton;
    }
}