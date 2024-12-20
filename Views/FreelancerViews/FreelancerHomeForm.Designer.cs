
namespace HeinHtetNaing_ADI.Views.FreelancerViews
{
    partial class FreelancerHomeForm
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
            headerPanel = new Panel();
            panel1 = new Panel();
            dashboardLinkedLabel = new LinkLabel();
            searchButton = new Button();
            browseProjectLabel = new Label();
            searchTextBox = new TextBox();
            projectsContainerPanel = new Panel();
            projectPanel = new Panel();
            projectRequiredSkillsTextBox = new TextBox();
            bidButton = new Button();
            projectDeadlineLabel = new Label();
            profectBudgetLabel = new Label();
            label4 = new Label();
            label3 = new Label();
            projectBidLabel = new Label();
            label2 = new Label();
            label1 = new Label();
            projectCreatedAtLabel = new Label();
            projectDescriptionTextBox = new TextBox();
            projectTitleLabel = new Label();
            profilePanel = new Panel();
            saveProfileButton = new Button();
            skillsDataGridView = new DataGridView();
            skillId = new DataGridViewTextBoxColumn();
            skillName = new DataGridViewTextBoxColumn();
            skillLevel = new DataGridViewComboBoxColumn();
            phoneNoTextBox = new TextBox();
            label10 = new Label();
            label9 = new Label();
            emailTextBox = new TextBox();
            label8 = new Label();
            lastNameTextBox = new TextBox();
            label7 = new Label();
            firstNameTextBox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            headerPanel.SuspendLayout();
            panel1.SuspendLayout();
            projectsContainerPanel.SuspendLayout();
            projectPanel.SuspendLayout();
            profilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)skillsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.Salmon;
            headerPanel.Controls.Add(panel1);
            headerPanel.Controls.Add(searchButton);
            headerPanel.Controls.Add(browseProjectLabel);
            headerPanel.Controls.Add(searchTextBox);
            headerPanel.Location = new Point(12, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1160, 81);
            headerPanel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Tomato;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(dashboardLinkedLabel);
            panel1.Location = new Point(923, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(237, 81);
            panel1.TabIndex = 3;
            // 
            // dashboardLinkedLabel
            // 
            dashboardLinkedLabel.ActiveLinkColor = Color.BlueViolet;
            dashboardLinkedLabel.AutoSize = true;
            dashboardLinkedLabel.BackColor = Color.Transparent;
            dashboardLinkedLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboardLinkedLabel.LinkColor = Color.White;
            dashboardLinkedLabel.Location = new Point(37, 21);
            dashboardLinkedLabel.Name = "dashboardLinkedLabel";
            dashboardLinkedLabel.Size = new Size(169, 32);
            dashboardLinkedLabel.TabIndex = 0;
            dashboardLinkedLabel.TabStop = true;
            dashboardLinkedLabel.Text = "Dashboard 📊";
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.Tomato;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchButton.ForeColor = SystemColors.Control;
            searchButton.Location = new Point(696, 21);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(174, 33);
            searchButton.TabIndex = 2;
            searchButton.Text = "Search 🔍";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // browseProjectLabel
            // 
            browseProjectLabel.AutoSize = true;
            browseProjectLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            browseProjectLabel.ForeColor = Color.White;
            browseProjectLabel.Location = new Point(20, 18);
            browseProjectLabel.Name = "browseProjectLabel";
            browseProjectLabel.Size = new Size(210, 32);
            browseProjectLabel.TabIndex = 1;
            browseProjectLabel.Text = "Browse Projects :";
            // 
            // searchTextBox
            // 
            searchTextBox.BackColor = Color.White;
            searchTextBox.BorderStyle = BorderStyle.FixedSingle;
            searchTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchTextBox.ForeColor = Color.DarkRed;
            searchTextBox.Location = new Point(236, 22);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(454, 33);
            searchTextBox.TabIndex = 0;
            // 
            // projectsContainerPanel
            // 
            projectsContainerPanel.AutoScroll = true;
            projectsContainerPanel.BackColor = Color.White;
            projectsContainerPanel.BorderStyle = BorderStyle.Fixed3D;
            projectsContainerPanel.Controls.Add(projectPanel);
            projectsContainerPanel.Location = new Point(12, 87);
            projectsContainerPanel.Name = "projectsContainerPanel";
            projectsContainerPanel.Size = new Size(808, 578);
            projectsContainerPanel.TabIndex = 1;
            // 
            // projectPanel
            // 
            projectPanel.BackColor = Color.Tomato;
            projectPanel.BorderStyle = BorderStyle.FixedSingle;
            projectPanel.Controls.Add(projectRequiredSkillsTextBox);
            projectPanel.Controls.Add(bidButton);
            projectPanel.Controls.Add(projectDeadlineLabel);
            projectPanel.Controls.Add(profectBudgetLabel);
            projectPanel.Controls.Add(label4);
            projectPanel.Controls.Add(label3);
            projectPanel.Controls.Add(projectBidLabel);
            projectPanel.Controls.Add(label2);
            projectPanel.Controls.Add(label1);
            projectPanel.Controls.Add(projectCreatedAtLabel);
            projectPanel.Controls.Add(projectDescriptionTextBox);
            projectPanel.Controls.Add(projectTitleLabel);
            projectPanel.Location = new Point(4, 4);
            projectPanel.Name = "projectPanel";
            projectPanel.Size = new Size(770, 191);
            projectPanel.TabIndex = 0;
            // 
            // projectRequiredSkillsTextBox
            // 
            projectRequiredSkillsTextBox.BackColor = Color.Salmon;
            projectRequiredSkillsTextBox.BorderStyle = BorderStyle.None;
            projectRequiredSkillsTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            projectRequiredSkillsTextBox.ForeColor = Color.White;
            projectRequiredSkillsTextBox.Location = new Point(551, 117);
            projectRequiredSkillsTextBox.Name = "projectRequiredSkillsTextBox";
            projectRequiredSkillsTextBox.ReadOnly = true;
            projectRequiredSkillsTextBox.Size = new Size(214, 26);
            projectRequiredSkillsTextBox.TabIndex = 4;
            // 
            // bidButton
            // 
            bidButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bidButton.ForeColor = Color.Tomato;
            bidButton.Location = new Point(550, 149);
            bidButton.Name = "bidButton";
            bidButton.Size = new Size(215, 35);
            bidButton.TabIndex = 3;
            bidButton.Text = "Bid";
            bidButton.UseVisualStyleBackColor = true;
            // 
            // projectDeadlineLabel
            // 
            projectDeadlineLabel.AutoSize = true;
            projectDeadlineLabel.Font = new Font("Segoe UI", 11.25F);
            projectDeadlineLabel.ForeColor = Color.White;
            projectDeadlineLabel.Location = new Point(640, 65);
            projectDeadlineLabel.Name = "projectDeadlineLabel";
            projectDeadlineLabel.Size = new Size(85, 20);
            projectDeadlineLabel.TabIndex = 2;
            projectDeadlineLabel.Text = "2024/11/22";
            projectDeadlineLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // profectBudgetLabel
            // 
            profectBudgetLabel.AutoSize = true;
            profectBudgetLabel.Font = new Font("Segoe UI", 11.25F);
            profectBudgetLabel.ForeColor = Color.White;
            profectBudgetLabel.Location = new Point(640, 34);
            profectBudgetLabel.Name = "profectBudgetLabel";
            profectBudgetLabel.Size = new Size(82, 20);
            profectBudgetLabel.TabIndex = 2;
            profectBudgetLabel.Text = "20000 GPD";
            profectBudgetLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(554, 94);
            label4.Name = "label4";
            label4.Size = new Size(123, 20);
            label4.TabIndex = 2;
            label4.Text = "Required Skill(s) :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(554, 65);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 2;
            label3.Text = "Deadline : ";
            // 
            // projectBidLabel
            // 
            projectBidLabel.AutoSize = true;
            projectBidLabel.Font = new Font("Segoe UI", 11.25F);
            projectBidLabel.ForeColor = Color.White;
            projectBidLabel.Location = new Point(640, 7);
            projectBidLabel.Name = "projectBidLabel";
            projectBidLabel.RightToLeft = RightToLeft.No;
            projectBidLabel.Size = new Size(25, 20);
            projectBidLabel.TabIndex = 2;
            projectBidLabel.Text = "15";
            projectBidLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(554, 34);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 2;
            label2.Text = "Budget : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(554, 7);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 2;
            label1.Text = "Total Bid :";
            // 
            // projectCreatedAtLabel
            // 
            projectCreatedAtLabel.AutoSize = true;
            projectCreatedAtLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            projectCreatedAtLabel.ForeColor = Color.White;
            projectCreatedAtLabel.Location = new Point(405, 5);
            projectCreatedAtLabel.Name = "projectCreatedAtLabel";
            projectCreatedAtLabel.Size = new Size(140, 17);
            projectCreatedAtLabel.TabIndex = 2;
            projectCreatedAtLabel.Text = "Posted at : 2024/12/48";
            // 
            // projectDescriptionTextBox
            // 
            projectDescriptionTextBox.BackColor = Color.Salmon;
            projectDescriptionTextBox.BorderStyle = BorderStyle.None;
            projectDescriptionTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            projectDescriptionTextBox.ForeColor = Color.White;
            projectDescriptionTextBox.Location = new Point(3, 34);
            projectDescriptionTextBox.Multiline = true;
            projectDescriptionTextBox.Name = "projectDescriptionTextBox";
            projectDescriptionTextBox.ReadOnly = true;
            projectDescriptionTextBox.Size = new Size(542, 150);
            projectDescriptionTextBox.TabIndex = 1;
            // 
            // projectTitleLabel
            // 
            projectTitleLabel.AutoSize = true;
            projectTitleLabel.BackColor = Color.Snow;
            projectTitleLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            projectTitleLabel.ForeColor = Color.Tomato;
            projectTitleLabel.Location = new Point(3, 2);
            projectTitleLabel.Name = "projectTitleLabel";
            projectTitleLabel.Padding = new Padding(3);
            projectTitleLabel.Size = new Size(104, 27);
            projectTitleLabel.TabIndex = 0;
            projectTitleLabel.Text = "Project Title";
            // 
            // profilePanel
            // 
            profilePanel.BackColor = Color.MistyRose;
            profilePanel.Controls.Add(saveProfileButton);
            profilePanel.Controls.Add(skillsDataGridView);
            profilePanel.Controls.Add(phoneNoTextBox);
            profilePanel.Controls.Add(label10);
            profilePanel.Controls.Add(label9);
            profilePanel.Controls.Add(emailTextBox);
            profilePanel.Controls.Add(label8);
            profilePanel.Controls.Add(lastNameTextBox);
            profilePanel.Controls.Add(label7);
            profilePanel.Controls.Add(firstNameTextBox);
            profilePanel.Controls.Add(label6);
            profilePanel.Controls.Add(label5);
            profilePanel.Location = new Point(826, 87);
            profilePanel.Name = "profilePanel";
            profilePanel.Size = new Size(346, 578);
            profilePanel.TabIndex = 2;
            // 
            // saveProfileButton
            // 
            saveProfileButton.BackColor = Color.Tomato;
            saveProfileButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveProfileButton.ForeColor = SystemColors.Control;
            saveProfileButton.Location = new Point(3, 528);
            saveProfileButton.Name = "saveProfileButton";
            saveProfileButton.Size = new Size(337, 40);
            saveProfileButton.TabIndex = 4;
            saveProfileButton.Text = "Save Profile";
            saveProfileButton.UseVisualStyleBackColor = false;
            saveProfileButton.Click += saveProfileButton_Click;
            // 
            // skillsDataGridView
            // 
            skillsDataGridView.BackgroundColor = Color.MistyRose;
            skillsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            skillsDataGridView.Columns.AddRange(new DataGridViewColumn[] { skillId, skillName, skillLevel });
            skillsDataGridView.GridColor = Color.Tomato;
            skillsDataGridView.Location = new Point(3, 373);
            skillsDataGridView.Name = "skillsDataGridView";
            skillsDataGridView.Size = new Size(337, 137);
            skillsDataGridView.TabIndex = 3;
            // 
            // skillId
            // 
            skillId.HeaderText = "Skill Id";
            skillId.Name = "skillId";
            skillId.Visible = false;
            skillId.Width = 5;
            // 
            // skillName
            // 
            skillName.HeaderText = "Skill Name";
            skillName.Name = "skillName";
            skillName.Resizable = DataGridViewTriState.False;
            skillName.Width = 140;
            // 
            // skillLevel
            // 
            skillLevel.HeaderText = "Skill Level";
            skillLevel.Items.AddRange(new object[] { "INTERMEDIATE", "ADVANCED", "EXPERT" });
            skillLevel.Name = "skillLevel";
            skillLevel.Resizable = DataGridViewTriState.False;
            skillLevel.Width = 140;
            // 
            // phoneNoTextBox
            // 
            phoneNoTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneNoTextBox.Location = new Point(3, 301);
            phoneNoTextBox.Name = "phoneNoTextBox";
            phoneNoTextBox.Size = new Size(337, 29);
            phoneNoTextBox.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Tomato;
            label10.Location = new Point(3, 347);
            label10.Name = "label10";
            label10.Size = new Size(46, 21);
            label10.TabIndex = 1;
            label10.Text = "Skills";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Tomato;
            label9.Location = new Point(3, 277);
            label9.Name = "label9";
            label9.Size = new Size(79, 21);
            label9.TabIndex = 1;
            label9.Text = "Phone No";
            // 
            // emailTextBox
            // 
            emailTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTextBox.Location = new Point(3, 226);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(337, 29);
            emailTextBox.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Tomato;
            label8.Location = new Point(3, 202);
            label8.Name = "label8";
            label8.Size = new Size(48, 21);
            label8.TabIndex = 1;
            label8.Text = "Email";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameTextBox.Location = new Point(3, 157);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(337, 29);
            lastNameTextBox.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Tomato;
            label7.Location = new Point(3, 133);
            label7.Name = "label7";
            label7.Size = new Size(84, 21);
            label7.TabIndex = 1;
            label7.Text = "Last Name";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNameTextBox.Location = new Point(3, 92);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(337, 29);
            firstNameTextBox.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Tomato;
            label6.Location = new Point(3, 68);
            label6.Name = "label6";
            label6.Size = new Size(86, 21);
            label6.TabIndex = 1;
            label6.Text = "First Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.OrangeRed;
            label5.Location = new Point(3, 20);
            label5.Name = "label5";
            label5.Size = new Size(175, 32);
            label5.TabIndex = 0;
            label5.Text = "Profile Details";
            // 
            // FreelancerHomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1184, 661);
            Controls.Add(profilePanel);
            Controls.Add(projectsContainerPanel);
            Controls.Add(headerPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FreelancerHomeForm";
            Text = "FreelancerHomeForm";
            FormClosed += FreelancerHomeForm_FormClosed;
            Load += FreelancerHomeForm_Load;
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            projectsContainerPanel.ResumeLayout(false);
            projectPanel.ResumeLayout(false);
            projectPanel.PerformLayout();
            profilePanel.ResumeLayout(false);
            profilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)skillsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel headerPanel;
        private TextBox searchTextBox;
        private Label browseProjectLabel;
        private Button searchButton;
        private Panel panel1;
        private LinkLabel dashboardLinkedLabel;
        private Panel projectsContainerPanel;
        private Panel profilePanel;
        private Panel projectPanel;
        private Label projectTitleLabel;
        private TextBox projectDescriptionTextBox;
        private Label projectCreatedAtLabel;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button bidButton;
        private Label projectDeadlineLabel;
        private Label profectBudgetLabel;
        private Label projectBidLabel;
        private TextBox projectRequiredSkillsTextBox;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox firstNameTextBox;
        private TextBox phoneNoTextBox;
        private Label label9;
        private TextBox emailTextBox;
        private Label label8;
        private TextBox lastNameTextBox;
        private Label label7;
        private DataGridView skillsDataGridView;
        private Label label10;
        private DataGridViewTextBoxColumn skillId;
        private DataGridViewTextBoxColumn skillName;
        private DataGridViewComboBoxColumn skillLevel;
        private Button saveProfileButton;
    }
}