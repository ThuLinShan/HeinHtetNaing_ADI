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
            projectPanel = new Panel();
            noProjectLabel = new Label();
            clientProfilePanel = new Panel();
            userNameLabel = new Label();
            panel1 = new Panel();
            postProjectButton = new Button();
            projectPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // projectPanel
            // 
            projectPanel.AutoScroll = true;
            projectPanel.BackColor = SystemColors.ControlLight;
            projectPanel.Controls.Add(noProjectLabel);
            projectPanel.Location = new Point(326, 65);
            projectPanel.Name = "projectPanel";
            projectPanel.Size = new Size(846, 584);
            projectPanel.TabIndex = 0;
            // 
            // noProjectLabel
            // 
            noProjectLabel.AutoSize = true;
            noProjectLabel.Location = new Point(326, 263);
            noProjectLabel.Name = "noProjectLabel";
            noProjectLabel.Size = new Size(197, 15);
            noProjectLabel.TabIndex = 0;
            noProjectLabel.Text = "You haven't posted any projects yet.";
            // 
            // clientProfilePanel
            // 
            clientProfilePanel.BackColor = Color.White;
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
            panel1.BackColor = Color.SeaShell;
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
            Controls.Add(projectPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ClientHomeForm";
            Text = "ClientHomeForm";
            FormClosed += ClientHomeForm_FormClosed;
            Load += ClientHomeForm_Load;
            projectPanel.ResumeLayout(false);
            projectPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel projectPanel;
        private Panel clientProfilePanel;
        private Label userNameLabel;
        private Panel panel1;
        private Button postProjectButton;
        private Label noProjectLabel;
    }
}