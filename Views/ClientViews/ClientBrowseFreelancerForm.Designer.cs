namespace HeinHtetNaing_ADI.Views.ClientViews
{
    partial class ClientBrowseFreelancerForm
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
            panel1 = new Panel();
            label1 = new Label();
            searchButton = new Button();
            searchFreelancerTextBox = new TextBox();
            freelancerContainerPanel = new Panel();
            freelancerPanel = new Panel();
            detailsButton = new Button();
            label3 = new Label();
            label2 = new Label();
            freelancerExpertiseTextBox = new TextBox();
            freelancerSkillsTextBox = new TextBox();
            freelancerNameLabel = new Label();
            panel1.SuspendLayout();
            freelancerContainerPanel.SuspendLayout();
            freelancerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(searchButton);
            panel1.Controls.Add(searchFreelancerTextBox);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(610, 82);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(44, 8);
            label1.Name = "label1";
            label1.Size = new Size(229, 15);
            label1.TabIndex = 2;
            label1.Text = "You can search by using skills or experties.";
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.DarkRed;
            searchButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchButton.ForeColor = Color.White;
            searchButton.Location = new Point(444, 25);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(164, 35);
            searchButton.TabIndex = 1;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // searchFreelancerTextBox
            // 
            searchFreelancerTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchFreelancerTextBox.Location = new Point(44, 26);
            searchFreelancerTextBox.Name = "searchFreelancerTextBox";
            searchFreelancerTextBox.Size = new Size(394, 33);
            searchFreelancerTextBox.TabIndex = 0;
            // 
            // freelancerContainerPanel
            // 
            freelancerContainerPanel.AutoScroll = true;
            freelancerContainerPanel.BackColor = Color.RosyBrown;
            freelancerContainerPanel.BorderStyle = BorderStyle.Fixed3D;
            freelancerContainerPanel.Controls.Add(freelancerPanel);
            freelancerContainerPanel.Location = new Point(12, 100);
            freelancerContainerPanel.Name = "freelancerContainerPanel";
            freelancerContainerPanel.Size = new Size(610, 549);
            freelancerContainerPanel.TabIndex = 1;
            // 
            // freelancerPanel
            // 
            freelancerPanel.BackColor = Color.White;
            freelancerPanel.Controls.Add(detailsButton);
            freelancerPanel.Controls.Add(label3);
            freelancerPanel.Controls.Add(label2);
            freelancerPanel.Controls.Add(freelancerExpertiseTextBox);
            freelancerPanel.Controls.Add(freelancerSkillsTextBox);
            freelancerPanel.Controls.Add(freelancerNameLabel);
            freelancerPanel.Location = new Point(34, 13);
            freelancerPanel.Name = "freelancerPanel";
            freelancerPanel.Size = new Size(404, 238);
            freelancerPanel.TabIndex = 0;
            // 
            // detailsButton
            // 
            detailsButton.ForeColor = Color.DarkRed;
            detailsButton.Location = new Point(233, 177);
            detailsButton.Name = "detailsButton";
            detailsButton.Size = new Size(149, 38);
            detailsButton.TabIndex = 3;
            detailsButton.Text = "Details";
            detailsButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(21, 118);
            label3.Name = "label3";
            label3.Size = new Size(83, 21);
            label3.TabIndex = 2;
            label3.Text = "expertise : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(21, 53);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 2;
            label2.Text = "skills : ";
            // 
            // freelancerExpertiseTextBox
            // 
            freelancerExpertiseTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            freelancerExpertiseTextBox.Location = new Point(21, 142);
            freelancerExpertiseTextBox.Name = "freelancerExpertiseTextBox";
            freelancerExpertiseTextBox.Size = new Size(361, 29);
            freelancerExpertiseTextBox.TabIndex = 1;
            // 
            // freelancerSkillsTextBox
            // 
            freelancerSkillsTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            freelancerSkillsTextBox.Location = new Point(21, 77);
            freelancerSkillsTextBox.Name = "freelancerSkillsTextBox";
            freelancerSkillsTextBox.Size = new Size(361, 29);
            freelancerSkillsTextBox.TabIndex = 1;
            // 
            // freelancerNameLabel
            // 
            freelancerNameLabel.AutoSize = true;
            freelancerNameLabel.BackColor = Color.DarkRed;
            freelancerNameLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            freelancerNameLabel.ForeColor = Color.White;
            freelancerNameLabel.Location = new Point(243, 17);
            freelancerNameLabel.Name = "freelancerNameLabel";
            freelancerNameLabel.Padding = new Padding(5);
            freelancerNameLabel.Size = new Size(139, 31);
            freelancerNameLabel.TabIndex = 0;
            freelancerNameLabel.Text = "FreelancerName";
            // 
            // ClientBrowseFreelancerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 661);
            Controls.Add(freelancerContainerPanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ClientBrowseFreelancerForm";
            Text = "ClientBrowseFreelancerForm";
            Load += ClientBrowseFreelancerForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            freelancerContainerPanel.ResumeLayout(false);
            freelancerPanel.ResumeLayout(false);
            freelancerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button searchButton;
        private TextBox searchFreelancerTextBox;
        private Panel freelancerContainerPanel;
        private Panel freelancerPanel;
        private Label freelancerNameLabel;
        private Label label2;
        private TextBox freelancerSkillsTextBox;
        private Label label3;
        private TextBox freelancerExpertiseTextBox;
        private Button detailsButton;
    }
}