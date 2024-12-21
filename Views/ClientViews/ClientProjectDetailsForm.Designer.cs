namespace HeinHtetNaing_ADI.Views.ClientViews
{
    partial class ClientProjectDetailsForm
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
            totalBidLabel = new Label();
            label9 = new Label();
            projectTitleLabel = new Label();
            statusPendingLabel = new Label();
            panel2 = new Panel();
            statusPanel = new Panel();
            panel4 = new Panel();
            statusCompletedLabel = new Label();
            statusOngoingLabel = new Label();
            label17 = new Label();
            label14 = new Label();
            projectEndDateLabel = new Label();
            projectStartDateLabel = new Label();
            reviewPanel = new Panel();
            saveProjectReviewButton = new Button();
            projectReviewTextBox = new TextBox();
            projectRatingNumericUpDown = new NumericUpDown();
            label7 = new Label();
            label8 = new Label();
            label13 = new Label();
            label6 = new Label();
            panel3 = new Panel();
            projectDescriptionTextBox = new TextBox();
            deadLineLabel = new Label();
            projectFreeLancerNameLabel = new Label();
            projectPostedAtLabel = new Label();
            clientNameLabel = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            bidsContainerPanel = new Panel();
            bidPanel = new Panel();
            freelancerDetailsButton = new Button();
            acceptBidButton = new Button();
            bidCommentTextBox = new TextBox();
            label11 = new Label();
            bidRateLabel = new Label();
            label12 = new Label();
            label10 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            statusPanel.SuspendLayout();
            panel4.SuspendLayout();
            reviewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)projectRatingNumericUpDown).BeginInit();
            panel3.SuspendLayout();
            bidsContainerPanel.SuspendLayout();
            bidPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkRed;
            panel1.Controls.Add(totalBidLabel);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(projectTitleLabel);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1182, 78);
            panel1.TabIndex = 0;
            // 
            // totalBidLabel
            // 
            totalBidLabel.AutoSize = true;
            totalBidLabel.BackColor = Color.Transparent;
            totalBidLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalBidLabel.ForeColor = Color.White;
            totalBidLabel.Location = new Point(1037, 48);
            totalBidLabel.Name = "totalBidLabel";
            totalBidLabel.Size = new Size(101, 18);
            totalBidLabel.TabIndex = 0;
            totalBidLabel.Text = "total : 30 bids";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(845, 39);
            label9.Name = "label9";
            label9.Size = new Size(59, 27);
            label9.TabIndex = 0;
            label9.Text = "Bids";
            // 
            // projectTitleLabel
            // 
            projectTitleLabel.AutoSize = true;
            projectTitleLabel.Font = new Font("Arial", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
            projectTitleLabel.Location = new Point(40, 27);
            projectTitleLabel.Name = "projectTitleLabel";
            projectTitleLabel.Size = new Size(56, 27);
            projectTitleLabel.TabIndex = 1;
            projectTitleLabel.Text = "Title";
            // 
            // statusPendingLabel
            // 
            statusPendingLabel.AutoSize = true;
            statusPendingLabel.BackColor = Color.Transparent;
            statusPendingLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusPendingLabel.ForeColor = Color.Gray;
            statusPendingLabel.Location = new Point(31, 14);
            statusPendingLabel.Name = "statusPendingLabel";
            statusPendingLabel.Padding = new Padding(3);
            statusPendingLabel.Size = new Size(87, 31);
            statusPendingLabel.TabIndex = 2;
            statusPendingLabel.Text = "Pending";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(statusPanel);
            panel2.Controls.Add(reviewPanel);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(2, 84);
            panel2.Name = "panel2";
            panel2.Size = new Size(826, 576);
            panel2.TabIndex = 1;
            // 
            // statusPanel
            // 
            statusPanel.BorderStyle = BorderStyle.FixedSingle;
            statusPanel.Controls.Add(panel4);
            statusPanel.Controls.Add(label17);
            statusPanel.Controls.Add(label14);
            statusPanel.Controls.Add(projectEndDateLabel);
            statusPanel.Controls.Add(projectStartDateLabel);
            statusPanel.Location = new Point(385, 13);
            statusPanel.Name = "statusPanel";
            statusPanel.Size = new Size(430, 196);
            statusPanel.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Silver;
            panel4.Controls.Add(statusCompletedLabel);
            panel4.Controls.Add(statusPendingLabel);
            panel4.Controls.Add(statusOngoingLabel);
            panel4.Location = new Point(25, 23);
            panel4.Name = "panel4";
            panel4.Size = new Size(385, 59);
            panel4.TabIndex = 3;
            // 
            // statusCompletedLabel
            // 
            statusCompletedLabel.AutoSize = true;
            statusCompletedLabel.BackColor = Color.Transparent;
            statusCompletedLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusCompletedLabel.ForeColor = Color.DimGray;
            statusCompletedLabel.Location = new Point(237, 14);
            statusCompletedLabel.Name = "statusCompletedLabel";
            statusCompletedLabel.Padding = new Padding(3);
            statusCompletedLabel.Size = new Size(110, 31);
            statusCompletedLabel.TabIndex = 2;
            statusCompletedLabel.Text = "Completed";
            // 
            // statusOngoingLabel
            // 
            statusOngoingLabel.AutoSize = true;
            statusOngoingLabel.BackColor = Color.Transparent;
            statusOngoingLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusOngoingLabel.ForeColor = Color.DimGray;
            statusOngoingLabel.Location = new Point(139, 13);
            statusOngoingLabel.Name = "statusOngoingLabel";
            statusOngoingLabel.Padding = new Padding(3);
            statusOngoingLabel.Size = new Size(92, 31);
            statusOngoingLabel.TabIndex = 2;
            statusOngoingLabel.Text = "Ongoing";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Symbol", 11.25F);
            label17.Location = new Point(25, 137);
            label17.Name = "label17";
            label17.Size = new Size(85, 20);
            label17.TabIndex = 0;
            label17.Text = "Ended At  : ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Symbol", 11.25F);
            label14.Location = new Point(25, 106);
            label14.Name = "label14";
            label14.Size = new Size(91, 20);
            label14.TabIndex = 0;
            label14.Text = "Started At  : ";
            // 
            // projectEndDateLabel
            // 
            projectEndDateLabel.AutoSize = true;
            projectEndDateLabel.Font = new Font("Segoe UI Symbol", 11.25F);
            projectEndDateLabel.ForeColor = Color.DarkRed;
            projectEndDateLabel.Location = new Point(147, 137);
            projectEndDateLabel.Name = "projectEndDateLabel";
            projectEndDateLabel.Size = new Size(85, 20);
            projectEndDateLabel.TabIndex = 0;
            projectEndDateLabel.Text = "2024/12/18";
            // 
            // projectStartDateLabel
            // 
            projectStartDateLabel.AutoSize = true;
            projectStartDateLabel.Font = new Font("Segoe UI Symbol", 11.25F);
            projectStartDateLabel.ForeColor = Color.DarkRed;
            projectStartDateLabel.Location = new Point(147, 106);
            projectStartDateLabel.Name = "projectStartDateLabel";
            projectStartDateLabel.Size = new Size(85, 20);
            projectStartDateLabel.TabIndex = 0;
            projectStartDateLabel.Text = "2024/12/18";
            // 
            // reviewPanel
            // 
            reviewPanel.BorderStyle = BorderStyle.FixedSingle;
            reviewPanel.Controls.Add(saveProjectReviewButton);
            reviewPanel.Controls.Add(projectReviewTextBox);
            reviewPanel.Controls.Add(projectRatingNumericUpDown);
            reviewPanel.Controls.Add(label7);
            reviewPanel.Controls.Add(label8);
            reviewPanel.Controls.Add(label13);
            reviewPanel.Controls.Add(label6);
            reviewPanel.Enabled = false;
            reviewPanel.Location = new Point(385, 215);
            reviewPanel.Name = "reviewPanel";
            reviewPanel.Size = new Size(430, 334);
            reviewPanel.TabIndex = 2;
            // 
            // saveProjectReviewButton
            // 
            saveProjectReviewButton.BackColor = Color.DarkRed;
            saveProjectReviewButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveProjectReviewButton.ForeColor = Color.White;
            saveProjectReviewButton.Location = new Point(24, 265);
            saveProjectReviewButton.Name = "saveProjectReviewButton";
            saveProjectReviewButton.Size = new Size(385, 49);
            saveProjectReviewButton.TabIndex = 8;
            saveProjectReviewButton.Text = "Save Review";
            saveProjectReviewButton.UseVisualStyleBackColor = false;
            saveProjectReviewButton.Click += saveProjectReviewButton_Click;
            // 
            // projectReviewTextBox
            // 
            projectReviewTextBox.BackColor = Color.White;
            projectReviewTextBox.ForeColor = Color.DarkRed;
            projectReviewTextBox.Location = new Point(24, 129);
            projectReviewTextBox.Multiline = true;
            projectReviewTextBox.Name = "projectReviewTextBox";
            projectReviewTextBox.Size = new Size(385, 130);
            projectReviewTextBox.TabIndex = 4;
            // 
            // projectRatingNumericUpDown
            // 
            projectRatingNumericUpDown.BorderStyle = BorderStyle.None;
            projectRatingNumericUpDown.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            projectRatingNumericUpDown.ForeColor = Color.DarkRed;
            projectRatingNumericUpDown.Location = new Point(123, 77);
            projectRatingNumericUpDown.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            projectRatingNumericUpDown.Name = "projectRatingNumericUpDown";
            projectRatingNumericUpDown.Size = new Size(43, 25);
            projectRatingNumericUpDown.TabIndex = 7;
            projectRatingNumericUpDown.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkRed;
            label7.Location = new Point(279, 17);
            label7.Name = "label7";
            label7.Size = new Size(130, 25);
            label7.TabIndex = 5;
            label7.Text = "Client Review";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.ForeColor = Color.DarkRed;
            label8.Location = new Point(24, 105);
            label8.Name = "label8";
            label8.Size = new Size(90, 21);
            label8.TabIndex = 6;
            label8.Text = "Comment : ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F);
            label13.ForeColor = Color.DarkRed;
            label13.Location = new Point(172, 76);
            label13.Name = "label13";
            label13.Size = new Size(74, 21);
            label13.TabIndex = 6;
            label13.Text = "(out of 5)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.DarkRed;
            label6.Location = new Point(25, 77);
            label6.Name = "label6";
            label6.Size = new Size(66, 21);
            label6.TabIndex = 6;
            label6.Text = "Rating : ";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(projectDescriptionTextBox);
            panel3.Controls.Add(deadLineLabel);
            panel3.Controls.Add(projectFreeLancerNameLabel);
            panel3.Controls.Add(projectPostedAtLabel);
            panel3.Controls.Add(clientNameLabel);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(10, 13);
            panel3.Name = "panel3";
            panel3.Size = new Size(369, 536);
            panel3.TabIndex = 1;
            // 
            // projectDescriptionTextBox
            // 
            projectDescriptionTextBox.BackColor = Color.White;
            projectDescriptionTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            projectDescriptionTextBox.ForeColor = Color.DarkRed;
            projectDescriptionTextBox.Location = new Point(3, 199);
            projectDescriptionTextBox.Multiline = true;
            projectDescriptionTextBox.Name = "projectDescriptionTextBox";
            projectDescriptionTextBox.ReadOnly = true;
            projectDescriptionTextBox.Size = new Size(361, 332);
            projectDescriptionTextBox.TabIndex = 1;
            // 
            // deadLineLabel
            // 
            deadLineLabel.AutoSize = true;
            deadLineLabel.Font = new Font("Segoe UI Symbol", 11.25F);
            deadLineLabel.ForeColor = Color.DarkRed;
            deadLineLabel.Location = new Point(151, 128);
            deadLineLabel.Name = "deadLineLabel";
            deadLineLabel.Size = new Size(85, 20);
            deadLineLabel.TabIndex = 0;
            deadLineLabel.Text = "2025/01/15";
            // 
            // projectFreeLancerNameLabel
            // 
            projectFreeLancerNameLabel.AutoSize = true;
            projectFreeLancerNameLabel.Font = new Font("Segoe UI Symbol", 11.25F);
            projectFreeLancerNameLabel.ForeColor = Color.DarkRed;
            projectFreeLancerNameLabel.Location = new Point(151, 94);
            projectFreeLancerNameLabel.Name = "projectFreeLancerNameLabel";
            projectFreeLancerNameLabel.Size = new Size(45, 20);
            projectFreeLancerNameLabel.TabIndex = 0;
            projectFreeLancerNameLabel.Text = "None";
            // 
            // projectPostedAtLabel
            // 
            projectPostedAtLabel.AutoSize = true;
            projectPostedAtLabel.Font = new Font("Segoe UI Symbol", 11.25F);
            projectPostedAtLabel.ForeColor = Color.DarkRed;
            projectPostedAtLabel.Location = new Point(151, 58);
            projectPostedAtLabel.Name = "projectPostedAtLabel";
            projectPostedAtLabel.Size = new Size(85, 20);
            projectPostedAtLabel.TabIndex = 0;
            projectPostedAtLabel.Text = "2024/12/18";
            // 
            // clientNameLabel
            // 
            clientNameLabel.AutoSize = true;
            clientNameLabel.Font = new Font("Segoe UI Symbol", 11.25F);
            clientNameLabel.ForeColor = Color.DarkRed;
            clientNameLabel.Location = new Point(151, 22);
            clientNameLabel.Name = "clientNameLabel";
            clientNameLabel.Size = new Size(168, 20);
            clientNameLabel.TabIndex = 0;
            clientNameLabel.Text = "First Name + Last Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Symbol", 11.25F);
            label5.Location = new Point(29, 128);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 0;
            label5.Text = "Deadline : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Symbol", 11.25F);
            label4.Location = new Point(29, 94);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 0;
            label4.Text = "Freelancer : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 11.25F);
            label2.Location = new Point(29, 161);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 0;
            label2.Text = "Description :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 11.25F);
            label3.Location = new Point(29, 58);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 0;
            label3.Text = "Posted At : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 11.25F);
            label1.Location = new Point(29, 22);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Client : ";
            // 
            // bidsContainerPanel
            // 
            bidsContainerPanel.AutoScroll = true;
            bidsContainerPanel.BackColor = Color.IndianRed;
            bidsContainerPanel.Controls.Add(bidPanel);
            bidsContainerPanel.Location = new Point(834, 84);
            bidsContainerPanel.Name = "bidsContainerPanel";
            bidsContainerPanel.Size = new Size(350, 576);
            bidsContainerPanel.TabIndex = 2;
            // 
            // bidPanel
            // 
            bidPanel.BackColor = Color.MistyRose;
            bidPanel.BorderStyle = BorderStyle.FixedSingle;
            bidPanel.Controls.Add(freelancerDetailsButton);
            bidPanel.Controls.Add(acceptBidButton);
            bidPanel.Controls.Add(bidCommentTextBox);
            bidPanel.Controls.Add(label11);
            bidPanel.Controls.Add(bidRateLabel);
            bidPanel.Controls.Add(label12);
            bidPanel.Controls.Add(label10);
            bidPanel.Location = new Point(13, 13);
            bidPanel.Name = "bidPanel";
            bidPanel.Size = new Size(300, 245);
            bidPanel.TabIndex = 0;
            // 
            // freelancerDetailsButton
            // 
            freelancerDetailsButton.AutoSize = true;
            freelancerDetailsButton.BackColor = Color.IndianRed;
            freelancerDetailsButton.FlatStyle = FlatStyle.Flat;
            freelancerDetailsButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            freelancerDetailsButton.ForeColor = SystemColors.Control;
            freelancerDetailsButton.Location = new Point(150, 11);
            freelancerDetailsButton.Name = "freelancerDetailsButton";
            freelancerDetailsButton.Size = new Size(133, 32);
            freelancerDetailsButton.TabIndex = 2;
            freelancerDetailsButton.Text = "Freelancer Name";
            freelancerDetailsButton.UseVisualStyleBackColor = false;
            // 
            // acceptBidButton
            // 
            acceptBidButton.BackColor = Color.IndianRed;
            acceptBidButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            acceptBidButton.ForeColor = SystemColors.Control;
            acceptBidButton.Location = new Point(5, 199);
            acceptBidButton.Name = "acceptBidButton";
            acceptBidButton.Size = new Size(290, 41);
            acceptBidButton.TabIndex = 2;
            acceptBidButton.Text = "Accept";
            acceptBidButton.UseVisualStyleBackColor = false;
            // 
            // bidCommentTextBox
            // 
            bidCommentTextBox.BackColor = Color.MistyRose;
            bidCommentTextBox.Location = new Point(3, 88);
            bidCommentTextBox.Multiline = true;
            bidCommentTextBox.Name = "bidCommentTextBox";
            bidCommentTextBox.Size = new Size(290, 107);
            bidCommentTextBox.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F);
            label11.Location = new Point(3, 61);
            label11.Name = "label11";
            label11.Size = new Size(75, 17);
            label11.TabIndex = 0;
            label11.Text = "Comment : ";
            // 
            // bidRateLabel
            // 
            bidRateLabel.AutoSize = true;
            bidRateLabel.Font = new Font("Segoe UI", 9.75F);
            bidRateLabel.Location = new Point(231, 59);
            bidRateLabel.Name = "bidRateLabel";
            bidRateLabel.Padding = new Padding(3);
            bidRateLabel.Size = new Size(52, 23);
            bidRateLabel.TabIndex = 0;
            bidRateLabel.Text = "20$/hr";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F);
            label12.Location = new Point(183, 59);
            label12.Name = "label12";
            label12.Padding = new Padding(3);
            label12.Size = new Size(51, 23);
            label12.TabIndex = 0;
            label12.Text = "Rate : ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.IndianRed;
            label10.Location = new Point(3, 17);
            label10.Name = "label10";
            label10.Padding = new Padding(3);
            label10.Size = new Size(70, 26);
            label10.TabIndex = 0;
            label10.Text = "Bid by : ";
            // 
            // ClientProjectDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(1184, 661);
            Controls.Add(bidsContainerPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ClientProjectDetailsForm";
            Text = "ClientProjectDetailsForm";
            Load += ClientProjectDetailsForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            statusPanel.ResumeLayout(false);
            statusPanel.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            reviewPanel.ResumeLayout(false);
            reviewPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)projectRatingNumericUpDown).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            bidsContainerPanel.ResumeLayout(false);
            bidPanel.ResumeLayout(false);
            bidPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label projectTitleLabel;
        private Label statusPendingLabel;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Label clientNameLabel;
        private TextBox projectDescriptionTextBox;
        private Label label2;
        private Label projectPostedAtLabel;
        private Label label3;
        private Label projectFreeLancerNameLabel;
        private Label label4;
        private Label deadLineLabel;
        private Label label5;
        private Panel bidsContainerPanel;
        private Panel reviewPanel;
        private Button saveProjectReviewButton;
        private TextBox projectReviewTextBox;
        private NumericUpDown projectRatingNumericUpDown;
        private Label label7;
        private Label label8;
        private Label label6;
        private Label label9;
        private Panel bidPanel;
        private Label label10;
        private TextBox bidCommentTextBox;
        private Label label11;
        private Label bidRateLabel;
        private Label label12;
        private Label totalBidLabel;
        private Button acceptBidButton;
        private Button freelancerDetailsButton;
        private Label label13;
        private Panel statusPanel;
        private Label statusOngoingLabel;
        private Label statusCompletedLabel;
        private Panel panel4;
        private Label label17;
        private Label label14;
        private Label projectEndDateLabel;
        private Label projectStartDateLabel;
    }
}