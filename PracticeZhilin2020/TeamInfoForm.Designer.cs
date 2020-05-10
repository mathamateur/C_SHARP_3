namespace PracticeZhilin2020
{
    partial class TeamInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamInfoForm));
            this.TeamLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HeadCoachLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ClubCaptainLabel = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.BestScorerLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ClubManagerLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TeamsLosesLabel = new System.Windows.Forms.Label();
            this.TeamsWinnsLabel = new System.Windows.Forms.Label();
            this.TeamsGoalConcededLabel = new System.Windows.Forms.Label();
            this.TeamsGoalScoredLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.TeamLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeamLogo
            // 
            this.TeamLogo.Location = new System.Drawing.Point(0, 0);
            this.TeamLogo.Name = "TeamLogo";
            this.TeamLogo.Size = new System.Drawing.Size(209, 162);
            this.TeamLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TeamLogo.TabIndex = 0;
            this.TeamLogo.TabStop = false;
            this.TeamLogo.Click += new System.EventHandler(this.TeamLogo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Главный тренер:";
            // 
            // HeadCoachLabel
            // 
            this.HeadCoachLabel.AutoSize = true;
            this.HeadCoachLabel.Location = new System.Drawing.Point(5, 17);
            this.HeadCoachLabel.Name = "HeadCoachLabel";
            this.HeadCoachLabel.Size = new System.Drawing.Size(82, 17);
            this.HeadCoachLabel.TabIndex = 2;
            this.HeadCoachLabel.Text = "HeadCoach";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Капитан команды:";
            // 
            // ClubCaptainLabel
            // 
            this.ClubCaptainLabel.AutoSize = true;
            this.ClubCaptainLabel.Location = new System.Drawing.Point(5, 88);
            this.ClubCaptainLabel.Name = "ClubCaptainLabel";
            this.ClubCaptainLabel.Size = new System.Drawing.Size(84, 17);
            this.ClubCaptainLabel.TabIndex = 4;
            this.ClubCaptainLabel.Text = "ClubCaptain";
            this.ClubCaptainLabel.Click += new System.EventHandler(this.ClubCaptainLabel_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label3.Location = new System.Drawing.Point(3, 181);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(165, 18);
            this.Label3.TabIndex = 5;
            this.Label3.Text = "Лучший бомбардир:";
            // 
            // BestScorerLabel
            // 
            this.BestScorerLabel.AutoSize = true;
            this.BestScorerLabel.Location = new System.Drawing.Point(3, 198);
            this.BestScorerLabel.Name = "BestScorerLabel";
            this.BestScorerLabel.Size = new System.Drawing.Size(113, 17);
            this.BestScorerLabel.TabIndex = 6;
            this.BestScorerLabel.Text = "BestScorerLabel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Менеджер клуба:";
            // 
            // ClubManagerLabel
            // 
            this.ClubManagerLabel.AutoSize = true;
            this.ClubManagerLabel.Location = new System.Drawing.Point(3, 196);
            this.ClubManagerLabel.Name = "ClubManagerLabel";
            this.ClubManagerLabel.Size = new System.Drawing.Size(92, 17);
            this.ClubManagerLabel.TabIndex = 8;
            this.ClubManagerLabel.Text = "ClubManager";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.TeamsLosesLabel);
            this.panel1.Controls.Add(this.TeamsWinnsLabel);
            this.panel1.Controls.Add(this.TeamsGoalConcededLabel);
            this.panel1.Controls.Add(this.TeamsGoalScoredLabel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 116);
            this.panel1.TabIndex = 9;
            // 
            // TeamsLosesLabel
            // 
            this.TeamsLosesLabel.AutoSize = true;
            this.TeamsLosesLabel.Location = new System.Drawing.Point(19, 90);
            this.TeamsLosesLabel.Name = "TeamsLosesLabel";
            this.TeamsLosesLabel.Size = new System.Drawing.Size(99, 17);
            this.TeamsLosesLabel.TabIndex = 17;
            this.TeamsLosesLabel.Text = "Поражений: 0";
            // 
            // TeamsWinnsLabel
            // 
            this.TeamsWinnsLabel.AutoSize = true;
            this.TeamsWinnsLabel.Location = new System.Drawing.Point(19, 73);
            this.TeamsWinnsLabel.Name = "TeamsWinnsLabel";
            this.TeamsWinnsLabel.Size = new System.Drawing.Size(66, 17);
            this.TeamsWinnsLabel.TabIndex = 16;
            this.TeamsWinnsLabel.Text = "Побед: 0";
            // 
            // TeamsGoalConcededLabel
            // 
            this.TeamsGoalConcededLabel.AutoSize = true;
            this.TeamsGoalConcededLabel.Location = new System.Drawing.Point(19, 56);
            this.TeamsGoalConcededLabel.Name = "TeamsGoalConcededLabel";
            this.TeamsGoalConcededLabel.Size = new System.Drawing.Size(141, 17);
            this.TeamsGoalConcededLabel.TabIndex = 15;
            this.TeamsGoalConcededLabel.Text = "Голов пропущено: 0";
            // 
            // TeamsGoalScoredLabel
            // 
            this.TeamsGoalScoredLabel.AutoSize = true;
            this.TeamsGoalScoredLabel.Location = new System.Drawing.Point(19, 39);
            this.TeamsGoalScoredLabel.Name = "TeamsGoalScoredLabel";
            this.TeamsGoalScoredLabel.Size = new System.Drawing.Size(113, 17);
            this.TeamsGoalScoredLabel.TabIndex = 14;
            this.TeamsGoalScoredLabel.Text = "Голов забито: 0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(19, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Показатели в сезоне:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.HeadCoachLabel);
            this.panel2.Controls.Add(this.ClubCaptainLabel);
            this.panel2.Controls.Add(this.Label3);
            this.panel2.Controls.Add(this.BestScorerLabel);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(399, 301);
            this.panel2.TabIndex = 10;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(357, 12);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(399, 426);
            this.splitContainer1.SplitterDistance = 305;
            this.splitContainer1.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel3.Controls.Add(this.TeamLogo);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.ClubManagerLabel);
            this.panel3.Location = new System.Drawing.Point(51, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(275, 266);
            this.panel3.TabIndex = 12;
            // 
            // TeamInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TeamInfoForm";
            this.Text = "TeamInfoForm";
            this.Load += new System.EventHandler(this.TeamInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TeamLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox TeamLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HeadCoachLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ClubCaptainLabel;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label BestScorerLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ClubManagerLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TeamsLosesLabel;
        private System.Windows.Forms.Label TeamsWinnsLabel;
        private System.Windows.Forms.Label TeamsGoalConcededLabel;
        private System.Windows.Forms.Label TeamsGoalScoredLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel3;
    }
}