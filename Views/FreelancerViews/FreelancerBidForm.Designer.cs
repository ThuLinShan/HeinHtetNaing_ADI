namespace HeinHtetNaing_ADI.Views.FreelancerViews
{
    partial class FreelancerBidForm
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
            commentTextBox = new TextBox();
            rateTypeComboBox = new ComboBox();
            confirmBidButton = new Button();
            rateCurrency = new Label();
            rateTextBox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            projectDeadlineLabel = new Label();
            projectBudgetLabel = new Label();
            label4 = new Label();
            projectTitleLabel = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            panel10 = new Panel();
            panel11 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Tomato;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(commentTextBox);
            panel1.Controls.Add(rateTypeComboBox);
            panel1.Controls.Add(confirmBidButton);
            panel1.Controls.Add(rateCurrency);
            panel1.Controls.Add(rateTextBox);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(projectDeadlineLabel);
            panel1.Controls.Add(projectBudgetLabel);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(projectTitleLabel);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(196, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 537);
            panel1.TabIndex = 0;
            // 
            // commentTextBox
            // 
            commentTextBox.BackColor = Color.MistyRose;
            commentTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            commentTextBox.Location = new Point(36, 315);
            commentTextBox.Multiline = true;
            commentTextBox.Name = "commentTextBox";
            commentTextBox.Size = new Size(273, 119);
            commentTextBox.TabIndex = 6;
            // 
            // rateTypeComboBox
            // 
            rateTypeComboBox.BackColor = Color.MistyRose;
            rateTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            rateTypeComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rateTypeComboBox.ForeColor = Color.White;
            rateTypeComboBox.FormattingEnabled = true;
            rateTypeComboBox.Items.AddRange(new object[] { "PER HOUR", "PER DAYS", "PER WEEKS", "PER MONTH", "PER YEAR" });
            rateTypeComboBox.Location = new Point(36, 260);
            rateTypeComboBox.Name = "rateTypeComboBox";
            rateTypeComboBox.Size = new Size(273, 29);
            rateTypeComboBox.TabIndex = 5;
            // 
            // confirmBidButton
            // 
            confirmBidButton.BackColor = Color.Tomato;
            confirmBidButton.FlatStyle = FlatStyle.Popup;
            confirmBidButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmBidButton.ForeColor = Color.White;
            confirmBidButton.Location = new Point(33, 440);
            confirmBidButton.Name = "confirmBidButton";
            confirmBidButton.Size = new Size(276, 43);
            confirmBidButton.TabIndex = 4;
            confirmBidButton.Text = "Confirm BId";
            confirmBidButton.UseVisualStyleBackColor = false;
            confirmBidButton.Click += confirmBidButton_Click;
            // 
            // rateCurrency
            // 
            rateCurrency.AutoSize = true;
            rateCurrency.BackColor = Color.MistyRose;
            rateCurrency.BorderStyle = BorderStyle.Fixed3D;
            rateCurrency.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rateCurrency.ForeColor = Color.DarkRed;
            rateCurrency.Location = new Point(256, 221);
            rateCurrency.Name = "rateCurrency";
            rateCurrency.Padding = new Padding(5);
            rateCurrency.Size = new Size(53, 33);
            rateCurrency.TabIndex = 3;
            rateCurrency.Text = "GPD";
            // 
            // rateTextBox
            // 
            rateTextBox.BackColor = Color.MistyRose;
            rateTextBox.BorderStyle = BorderStyle.FixedSingle;
            rateTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rateTextBox.ForeColor = Color.Black;
            rateTextBox.Location = new Point(36, 221);
            rateTextBox.Name = "rateTextBox";
            rateTextBox.Size = new Size(214, 33);
            rateTextBox.TabIndex = 2;
            rateTextBox.KeyPress += rateTextBox_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Yellow;
            label6.Location = new Point(36, 292);
            label6.Name = "label6";
            label6.Size = new Size(114, 20);
            label6.TabIndex = 1;
            label6.Text = "Your Comment";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Yellow;
            label5.Location = new Point(36, 198);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 1;
            label5.Text = "Your Rate";
            // 
            // projectDeadlineLabel
            // 
            projectDeadlineLabel.AutoSize = true;
            projectDeadlineLabel.Font = new Font("Segoe UI", 11.25F);
            projectDeadlineLabel.ForeColor = Color.Yellow;
            projectDeadlineLabel.Location = new Point(147, 173);
            projectDeadlineLabel.Name = "projectDeadlineLabel";
            projectDeadlineLabel.Size = new Size(85, 20);
            projectDeadlineLabel.TabIndex = 1;
            projectDeadlineLabel.Text = "2024/11/28";
            // 
            // projectBudgetLabel
            // 
            projectBudgetLabel.AutoSize = true;
            projectBudgetLabel.Font = new Font("Segoe UI", 11.25F);
            projectBudgetLabel.ForeColor = Color.Yellow;
            projectBudgetLabel.Location = new Point(149, 144);
            projectBudgetLabel.Name = "projectBudgetLabel";
            projectBudgetLabel.Size = new Size(73, 20);
            projectBudgetLabel.TabIndex = 1;
            projectBudgetLabel.Text = "01010101";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.ForeColor = Color.Yellow;
            label4.Location = new Point(35, 173);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 1;
            label4.Text = "Deadline : ";
            // 
            // projectTitleLabel
            // 
            projectTitleLabel.AutoSize = true;
            projectTitleLabel.Font = new Font("Segoe UI", 11.25F);
            projectTitleLabel.ForeColor = Color.Yellow;
            projectTitleLabel.Location = new Point(147, 115);
            projectTitleLabel.Name = "projectTitleLabel";
            projectTitleLabel.Size = new Size(74, 20);
            projectTitleLabel.TabIndex = 1;
            projectTitleLabel.Text = "Title Here";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.ForeColor = Color.Yellow;
            label3.Location = new Point(37, 144);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 1;
            label3.Text = "Budget : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(35, 115);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 1;
            label2.Text = "Project Title : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(42, 49);
            label1.Name = "label1";
            label1.Padding = new Padding(5);
            label1.Size = new Size(274, 40);
            label1.TabIndex = 0;
            label1.Text = "__Project Bid______________";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Salmon;
            panel2.Location = new Point(593, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 445);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Tomato;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Location = new Point(656, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(22, 163);
            panel3.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Salmon;
            panel4.Location = new Point(733, 89);
            panel4.Name = "panel4";
            panel4.Size = new Size(22, 38);
            panel4.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Tomato;
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Location = new Point(713, 273);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 160);
            panel5.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Tomato;
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Location = new Point(102, 238);
            panel6.Name = "panel6";
            panel6.Size = new Size(22, 65);
            panel6.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Tomato;
            panel7.BorderStyle = BorderStyle.Fixed3D;
            panel7.Location = new Point(41, 360);
            panel7.Name = "panel7";
            panel7.Size = new Size(22, 160);
            panel7.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Salmon;
            panel8.Location = new Point(12, 12);
            panel8.Name = "panel8";
            panel8.Size = new Size(10, 267);
            panel8.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Salmon;
            panel9.Location = new Point(117, 29);
            panel9.Name = "panel9";
            panel9.Size = new Size(22, 65);
            panel9.TabIndex = 0;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Salmon;
            panel10.Location = new Point(129, 413);
            panel10.Name = "panel10";
            panel10.Size = new Size(10, 199);
            panel10.TabIndex = 0;
            // 
            // panel11
            // 
            panel11.BackColor = Color.Tomato;
            panel11.BorderStyle = BorderStyle.Fixed3D;
            panel11.Location = new Point(646, 454);
            panel11.Name = "panel11";
            panel11.Size = new Size(22, 95);
            panel11.TabIndex = 0;
            // 
            // FreelancerBidForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tomato;
            ClientSize = new Size(784, 561);
            Controls.Add(panel1);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel10);
            Controls.Add(panel9);
            Controls.Add(panel6);
            Controls.Add(panel11);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FreelancerBidForm";
            Text = "FreelancerBidForm";
            Load += FreelancerBidForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel11;
        private TextBox rateTextBox;
        private Label label5;
        private Label rateCurrency;
        private Label projectDeadlineLabel;
        private Label projectBudgetLabel;
        private Label projectTitleLabel;
        private Button confirmBidButton;
        private ComboBox rateTypeComboBox;
        private TextBox commentTextBox;
        private Label label6;
    }
}