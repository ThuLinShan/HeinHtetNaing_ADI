namespace HeinHtetNaing_ADI
{
    partial class Welcome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel5 = new Panel();
            panel3 = new Panel();
            iamLabel1 = new Label();
            freeLancerLabelLink = new LinkLabel();
            WelcomeLabel = new Label();
            label3 = new Label();
            panel9 = new Panel();
            panel6 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            clientLabelLink = new LinkLabel();
            label2 = new Label();
            guidLinkedLabel = new LinkLabel();
            panel8 = new Panel();
            label1 = new Label();
            panel7 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Salmon;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(WelcomeLabel);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(panel6);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(582, 664);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Salmon;
            panel5.Location = new Point(50, 212);
            panel5.Name = "panel5";
            panel5.Size = new Size(12, 331);
            panel5.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Tomato;
            panel3.Controls.Add(iamLabel1);
            panel3.Controls.Add(freeLancerLabelLink);
            panel3.Location = new Point(0, 296);
            panel3.Name = "panel3";
            panel3.Size = new Size(579, 120);
            panel3.TabIndex = 3;
            // 
            // iamLabel1
            // 
            iamLabel1.AutoSize = true;
            iamLabel1.BackColor = Color.Tomato;
            iamLabel1.Font = new Font("Segoe UI", 12F);
            iamLabel1.ForeColor = SystemColors.ControlLightLight;
            iamLabel1.Location = new Point(151, 56);
            iamLabel1.Name = "iamLabel1";
            iamLabel1.Size = new Size(56, 21);
            iamLabel1.TabIndex = 1;
            iamLabel1.Text = "I am a ";
            iamLabel1.Click += iamLabel1_Click;
            // 
            // freeLancerLabelLink
            // 
            freeLancerLabelLink.AutoSize = true;
            freeLancerLabelLink.BackColor = Color.Transparent;
            freeLancerLabelLink.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            freeLancerLabelLink.LinkColor = Color.White;
            freeLancerLabelLink.Location = new Point(213, 35);
            freeLancerLabelLink.Name = "freeLancerLabelLink";
            freeLancerLabelLink.Size = new Size(185, 47);
            freeLancerLabelLink.TabIndex = 2;
            freeLancerLabelLink.TabStop = true;
            freeLancerLabelLink.Text = "FreeLancer";
            freeLancerLabelLink.LinkClicked += freeLancerLabelLink_LinkClicked;
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WelcomeLabel.ForeColor = Color.White;
            WelcomeLabel.Location = new Point(345, 106);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(234, 56);
            WelcomeLabel.TabIndex = 0;
            WelcomeLabel.Text = "Welcome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(10, 632);
            label3.Name = "label3";
            label3.Size = new Size(194, 20);
            label3.TabIndex = 0;
            label3.Text = "Please choose your user type.\r\n";
            // 
            // panel9
            // 
            panel9.BackColor = Color.Tomato;
            panel9.Location = new Point(31, 69);
            panel9.Name = "panel9";
            panel9.Size = new Size(13, 221);
            panel9.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Tomato;
            panel6.Location = new Point(77, 240);
            panel6.Name = "panel6";
            panel6.Size = new Size(18, 150);
            panel6.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(guidLinkedLabel);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel7);
            panel2.Location = new Point(581, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(600, 664);
            panel2.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.WhiteSmoke;
            panel4.Controls.Add(clientLabelLink);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(0, 296);
            panel4.Name = "panel4";
            panel4.Size = new Size(597, 120);
            panel4.TabIndex = 4;
            // 
            // clientLabelLink
            // 
            clientLabelLink.AutoSize = true;
            clientLabelLink.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clientLabelLink.LinkColor = Color.DarkRed;
            clientLabelLink.Location = new Point(248, 35);
            clientLabelLink.Name = "clientLabelLink";
            clientLabelLink.Size = new Size(108, 47);
            clientLabelLink.TabIndex = 2;
            clientLabelLink.TabStop = true;
            clientLabelLink.Text = "Client";
            clientLabelLink.LinkClicked += clientLabelLink_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(186, 56);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 1;
            label2.Text = "I am a ";
            label2.Click += iamLabel1_Click;
            // 
            // guidLinkedLabel
            // 
            guidLinkedLabel.AutoSize = true;
            guidLinkedLabel.Location = new Point(512, 637);
            guidLinkedLabel.Name = "guidLinkedLabel";
            guidLinkedLabel.Size = new Size(68, 15);
            guidLinkedLabel.TabIndex = 3;
            guidLinkedLabel.TabStop = true;
            guidLinkedLabel.Text = "Need Help?";
            // 
            // panel8
            // 
            panel8.BackColor = Color.Salmon;
            panel8.Location = new Point(415, 462);
            panel8.Name = "panel8";
            panel8.Size = new Size(10, 301);
            panel8.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Tomato;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(9, 120);
            label1.Name = "label1";
            label1.Padding = new Padding(5);
            label1.Size = new Size(339, 42);
            label1.TabIndex = 0;
            label1.Text = "to our freelancing platform";
            // 
            // panel7
            // 
            panel7.BackColor = Color.Salmon;
            panel7.Location = new Point(450, 227);
            panel7.Name = "panel7";
            panel7.Size = new Size(10, 468);
            panel7.TabIndex = 4;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 661);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Welcome";
            Text = "Welcome";
            FormClosing += Welcome_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label WelcomeLabel;
        private Panel panel2;
        private Label iamLabel1;
        private Label label1;
        private Label label2;
        private LinkLabel freeLancerLabelLink;
        private Label label3;
        private LinkLabel guidLinkedLabel;
        private LinkLabel clientLabelLink;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel8;
        private Panel panel7;
        private Panel panel9;
    }
}
