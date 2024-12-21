namespace HeinHtetNaing_ADI.Views.FreelancerViews
{
    partial class FreelancerDashboardForm
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
            ongoingProjectCountLabel = new Label();
            label2 = new Label();
            ongoingProjectsContainer = new Panel();
            ongoingProject = new Panel();
            projectUpdateButton = new Button();
            comboBox1 = new ComboBox();
            projectDeadlineDateTimePicker = new DateTimePicker();
            projectClientNameLabel = new Label();
            label7 = new Label();
            projectStatedAtLabel = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label6 = new Label();
            projectTitleLabel = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label8 = new Label();
            completedProjectCountLabel = new Label();
            completedProjectContainer = new Panel();
            completedProject = new Panel();
            completedProjectTitleLabel = new Label();
            label1 = new Label();
            completedProjectStartedAtLabel = new Label();
            label9 = new Label();
            completedProjectEndedAtLabel = new Label();
            label11 = new Label();
            completedProjectClientName = new Label();
            label12 = new Label();
            completedProjectClientRatingLabel = new Label();
            label13 = new Label();
            completedProejctClientCommentTextBox = new TextBox();
            ongoingProjectsContainer.SuspendLayout();
            ongoingProject.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            completedProjectContainer.SuspendLayout();
            completedProject.SuspendLayout();
            SuspendLayout();
            // 
            // ongoingProjectCountLabel
            // 
            ongoingProjectCountLabel.AutoSize = true;
            ongoingProjectCountLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            ongoingProjectCountLabel.ForeColor = Color.White;
            ongoingProjectCountLabel.Location = new Point(534, 18);
            ongoingProjectCountLabel.Name = "ongoingProjectCountLabel";
            ongoingProjectCountLabel.Size = new Size(25, 21);
            ongoingProjectCountLabel.TabIndex = 1;
            ongoingProjectCountLabel.Text = "12";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(359, 19);
            label2.Name = "label2";
            label2.Size = new Size(134, 20);
            label2.TabIndex = 1;
            label2.Text = "Ongoing Projects : ";
            // 
            // ongoingProjectsContainer
            // 
            ongoingProjectsContainer.AutoScroll = true;
            ongoingProjectsContainer.BackColor = Color.Tomato;
            ongoingProjectsContainer.BorderStyle = BorderStyle.Fixed3D;
            ongoingProjectsContainer.Controls.Add(ongoingProject);
            ongoingProjectsContainer.Location = new Point(12, 78);
            ongoingProjectsContainer.Name = "ongoingProjectsContainer";
            ongoingProjectsContainer.Size = new Size(578, 571);
            ongoingProjectsContainer.TabIndex = 0;
            // 
            // ongoingProject
            // 
            ongoingProject.BackColor = Color.Salmon;
            ongoingProject.Controls.Add(projectUpdateButton);
            ongoingProject.Controls.Add(comboBox1);
            ongoingProject.Controls.Add(projectDeadlineDateTimePicker);
            ongoingProject.Controls.Add(projectClientNameLabel);
            ongoingProject.Controls.Add(label7);
            ongoingProject.Controls.Add(projectStatedAtLabel);
            ongoingProject.Controls.Add(label5);
            ongoingProject.Controls.Add(label4);
            ongoingProject.Controls.Add(label3);
            ongoingProject.Controls.Add(label6);
            ongoingProject.Controls.Add(projectTitleLabel);
            ongoingProject.Location = new Point(3, 3);
            ongoingProject.Name = "ongoingProject";
            ongoingProject.Size = new Size(554, 267);
            ongoingProject.TabIndex = 0;
            // 
            // projectUpdateButton
            // 
            projectUpdateButton.BackColor = Color.Tomato;
            projectUpdateButton.FlatStyle = FlatStyle.Flat;
            projectUpdateButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            projectUpdateButton.ForeColor = Color.White;
            projectUpdateButton.Location = new Point(284, 184);
            projectUpdateButton.Name = "projectUpdateButton";
            projectUpdateButton.Size = new Size(196, 40);
            projectUpdateButton.TabIndex = 4;
            projectUpdateButton.Text = "Update";
            projectUpdateButton.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.LightCoral;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(280, 93);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 28);
            comboBox1.TabIndex = 3;
            // 
            // projectDeadlineDateTimePicker
            // 
            projectDeadlineDateTimePicker.CalendarFont = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            projectDeadlineDateTimePicker.CalendarMonthBackground = Color.LightCoral;
            projectDeadlineDateTimePicker.CalendarTitleBackColor = Color.LightCoral;
            projectDeadlineDateTimePicker.Location = new Point(280, 129);
            projectDeadlineDateTimePicker.Name = "projectDeadlineDateTimePicker";
            projectDeadlineDateTimePicker.Size = new Size(200, 23);
            projectDeadlineDateTimePicker.TabIndex = 2;
            // 
            // projectClientNameLabel
            // 
            projectClientNameLabel.AutoSize = true;
            projectClientNameLabel.Font = new Font("Segoe UI", 11.25F);
            projectClientNameLabel.ForeColor = Color.White;
            projectClientNameLabel.Location = new Point(122, 204);
            projectClientNameLabel.Name = "projectClientNameLabel";
            projectClientNameLabel.Size = new Size(91, 20);
            projectClientNameLabel.TabIndex = 1;
            projectClientNameLabel.Text = "Client Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(32, 204);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 1;
            label7.Text = "Name : ";
            // 
            // projectStatedAtLabel
            // 
            projectStatedAtLabel.AutoSize = true;
            projectStatedAtLabel.Font = new Font("Segoe UI", 11.25F);
            projectStatedAtLabel.ForeColor = Color.White;
            projectStatedAtLabel.Location = new Point(280, 63);
            projectStatedAtLabel.Name = "projectStatedAtLabel";
            projectStatedAtLabel.Size = new Size(85, 20);
            projectStatedAtLabel.TabIndex = 1;
            projectStatedAtLabel.Text = "2024/10/28";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(32, 129);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 1;
            label5.Text = "Deadline : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(32, 96);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 1;
            label4.Text = "Status : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(32, 63);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 1;
            label3.Text = "Started At : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Yellow;
            label6.Location = new Point(32, 173);
            label6.Name = "label6";
            label6.Size = new Size(104, 25);
            label6.TabIndex = 0;
            label6.Text = "Client info";
            // 
            // projectTitleLabel
            // 
            projectTitleLabel.AutoSize = true;
            projectTitleLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            projectTitleLabel.ForeColor = Color.Yellow;
            projectTitleLabel.Location = new Point(32, 23);
            projectTitleLabel.Name = "projectTitleLabel";
            projectTitleLabel.Size = new Size(166, 25);
            projectTitleLabel.TabIndex = 0;
            projectTitleLabel.Text = "Project Title Here";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Tomato;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(ongoingProjectCountLabel);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(578, 60);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkRed;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(completedProjectCountLabel);
            panel2.Location = new Point(596, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(576, 60);
            panel2.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F);
            label8.ForeColor = Color.Aquamarine;
            label8.Location = new Point(345, 18);
            label8.Name = "label8";
            label8.Size = new Size(150, 20);
            label8.TabIndex = 1;
            label8.Text = "Completed Projects : ";
            // 
            // completedProjectCountLabel
            // 
            completedProjectCountLabel.AutoSize = true;
            completedProjectCountLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            completedProjectCountLabel.ForeColor = Color.Aquamarine;
            completedProjectCountLabel.Location = new Point(520, 17);
            completedProjectCountLabel.Name = "completedProjectCountLabel";
            completedProjectCountLabel.Size = new Size(25, 21);
            completedProjectCountLabel.TabIndex = 1;
            completedProjectCountLabel.Text = "12";
            // 
            // completedProjectContainer
            // 
            completedProjectContainer.BackColor = Color.DarkRed;
            completedProjectContainer.Controls.Add(completedProject);
            completedProjectContainer.Location = new Point(596, 78);
            completedProjectContainer.Name = "completedProjectContainer";
            completedProjectContainer.Size = new Size(576, 571);
            completedProjectContainer.TabIndex = 1;
            // 
            // completedProject
            // 
            completedProject.BackColor = Color.PaleTurquoise;
            completedProject.Controls.Add(completedProejctClientCommentTextBox);
            completedProject.Controls.Add(completedProjectClientRatingLabel);
            completedProject.Controls.Add(completedProjectClientName);
            completedProject.Controls.Add(completedProjectEndedAtLabel);
            completedProject.Controls.Add(completedProjectStartedAtLabel);
            completedProject.Controls.Add(label13);
            completedProject.Controls.Add(label12);
            completedProject.Controls.Add(label11);
            completedProject.Controls.Add(label9);
            completedProject.Controls.Add(label1);
            completedProject.Controls.Add(completedProjectTitleLabel);
            completedProject.Location = new Point(3, 5);
            completedProject.Name = "completedProject";
            completedProject.Size = new Size(555, 215);
            completedProject.TabIndex = 0;
            // 
            // completedProjectTitleLabel
            // 
            completedProjectTitleLabel.AutoSize = true;
            completedProjectTitleLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            completedProjectTitleLabel.ForeColor = Color.DarkRed;
            completedProjectTitleLabel.Location = new Point(34, 23);
            completedProjectTitleLabel.Name = "completedProjectTitleLabel";
            completedProjectTitleLabel.Size = new Size(208, 25);
            completedProjectTitleLabel.TabIndex = 0;
            completedProjectTitleLabel.Text = "Your project title label";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(34, 67);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 1;
            label1.Text = "Started At : ";
            // 
            // completedProjectStartedAtLabel
            // 
            completedProjectStartedAtLabel.AutoSize = true;
            completedProjectStartedAtLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            completedProjectStartedAtLabel.ForeColor = Color.DarkRed;
            completedProjectStartedAtLabel.Location = new Point(141, 67);
            completedProjectStartedAtLabel.Name = "completedProjectStartedAtLabel";
            completedProjectStartedAtLabel.Size = new Size(85, 20);
            completedProjectStartedAtLabel.TabIndex = 1;
            completedProjectStartedAtLabel.Text = "2024/11/29";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DarkRed;
            label9.Location = new Point(34, 101);
            label9.Name = "label9";
            label9.Size = new Size(81, 20);
            label9.TabIndex = 1;
            label9.Text = "Ended At : ";
            // 
            // completedProjectEndedAtLabel
            // 
            completedProjectEndedAtLabel.AutoSize = true;
            completedProjectEndedAtLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            completedProjectEndedAtLabel.ForeColor = Color.DarkRed;
            completedProjectEndedAtLabel.Location = new Point(141, 101);
            completedProjectEndedAtLabel.Name = "completedProjectEndedAtLabel";
            completedProjectEndedAtLabel.Size = new Size(85, 20);
            completedProjectEndedAtLabel.TabIndex = 1;
            completedProjectEndedAtLabel.Text = "2025/11/29";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.DarkRed;
            label11.Location = new Point(34, 132);
            label11.Name = "label11";
            label11.Size = new Size(102, 20);
            label11.TabIndex = 1;
            label11.Text = "Client Name : ";
            // 
            // completedProjectClientName
            // 
            completedProjectClientName.AutoSize = true;
            completedProjectClientName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            completedProjectClientName.ForeColor = Color.DarkRed;
            completedProjectClientName.Location = new Point(141, 132);
            completedProjectClientName.Name = "completedProjectClientName";
            completedProjectClientName.Size = new Size(121, 20);
            completedProjectClientName.TabIndex = 1;
            completedProjectClientName.Text = "Client name here";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.DarkRed;
            label12.Location = new Point(34, 161);
            label12.Name = "label12";
            label12.Size = new Size(63, 20);
            label12.TabIndex = 1;
            label12.Text = "Rating : ";
            // 
            // completedProjectClientRatingLabel
            // 
            completedProjectClientRatingLabel.AutoSize = true;
            completedProjectClientRatingLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            completedProjectClientRatingLabel.ForeColor = Color.DarkRed;
            completedProjectClientRatingLabel.Location = new Point(141, 161);
            completedProjectClientRatingLabel.Name = "completedProjectClientRatingLabel";
            completedProjectClientRatingLabel.Size = new Size(31, 20);
            completedProjectClientRatingLabel.TabIndex = 1;
            completedProjectClientRatingLabel.Text = "4/5";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.DarkRed;
            label13.Location = new Point(296, 27);
            label13.Name = "label13";
            label13.Size = new Size(127, 20);
            label13.TabIndex = 1;
            label13.Text = "Client Comment : ";
            // 
            // completedProejctClientCommentTextBox
            // 
            completedProejctClientCommentTextBox.BackColor = Color.PaleTurquoise;
            completedProejctClientCommentTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            completedProejctClientCommentTextBox.ForeColor = Color.DarkRed;
            completedProejctClientCommentTextBox.Location = new Point(296, 50);
            completedProejctClientCommentTextBox.Multiline = true;
            completedProejctClientCommentTextBox.Name = "completedProejctClientCommentTextBox";
            completedProejctClientCommentTextBox.ReadOnly = true;
            completedProejctClientCommentTextBox.Size = new Size(233, 131);
            completedProejctClientCommentTextBox.TabIndex = 2;
            // 
            // FreelancerDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(1184, 661);
            Controls.Add(completedProjectContainer);
            Controls.Add(panel2);
            Controls.Add(ongoingProjectsContainer);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FreelancerDashboardForm";
            Text = "FreelancerDashboardForm";
            Load += FreelancerDashboardForm_Load;
            ongoingProjectsContainer.ResumeLayout(false);
            ongoingProject.ResumeLayout(false);
            ongoingProject.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            completedProjectContainer.ResumeLayout(false);
            completedProject.ResumeLayout(false);
            completedProject.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel ongoingProjectsContainer;
        private Panel ongoingProject;
        private Label ongoingProjectCountLabel;
        private Label label2;
        private Panel panel1;
        private Label projectTitleLabel;
        private Label label4;
        private Label label3;
        private Label label7;
        private Label label5;
        private Label label6;
        private DateTimePicker projectDeadlineDateTimePicker;
        private ComboBox comboBox1;
        private Label projectClientNameLabel;
        private Button projectUpdateButton;
        private Label projectStatedAtLabel;
        private Panel panel2;
        private Label label8;
        private Label completedProjectCountLabel;
        private Panel completedProjectContainer;
        private Panel completedProject;
        private Label completedProjectTitleLabel;
        private Label label1;
        private Label completedProjectStartedAtLabel;
        private Label completedProjectEndedAtLabel;
        private Label label9;
        private Label completedProjectClientName;
        private Label label11;
        private TextBox completedProejctClientCommentTextBox;
        private Label completedProjectClientRatingLabel;
        private Label label13;
        private Label label12;
    }
}