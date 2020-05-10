namespace PracticeZhilin2020
{
    partial class TeamsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamsForm));
            this.TeamsList = new System.Windows.Forms.Label();
            this.clubsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.mainMenu = new System.Windows.Forms.Button();
            this.printbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TeamsList
            // 
            this.TeamsList.AutoSize = true;
            this.TeamsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TeamsList.Location = new System.Drawing.Point(309, 9);
            this.TeamsList.Name = "TeamsList";
            this.TeamsList.Size = new System.Drawing.Size(260, 39);
            this.TeamsList.TabIndex = 0;
            this.TeamsList.Text = "Список команд";
            // 
            // clubsPanel
            // 
            this.clubsPanel.Location = new System.Drawing.Point(0, 50);
            this.clubsPanel.Name = "clubsPanel";
            this.clubsPanel.Size = new System.Drawing.Size(900, 385);
            this.clubsPanel.TabIndex = 1;
            // 
            // mainMenu
            // 
            this.mainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainMenu.Location = new System.Drawing.Point(0, 445);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(138, 54);
            this.mainMenu.TabIndex = 2;
            this.mainMenu.Text = "Главное меню";
            this.mainMenu.UseVisualStyleBackColor = true;
            this.mainMenu.Click += new System.EventHandler(this.mainMenu_Click);
            // 
            // printbutton
            // 
            this.printbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("printbutton.BackgroundImage")));
            this.printbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.printbutton.Location = new System.Drawing.Point(138, 445);
            this.printbutton.Name = "printbutton";
            this.printbutton.Size = new System.Drawing.Size(54, 54);
            this.printbutton.TabIndex = 3;
            this.printbutton.UseVisualStyleBackColor = true;
            // 
            // TeamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.printbutton);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.clubsPanel);
            this.Controls.Add(this.TeamsList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TeamsForm";
            this.Text = "TeamsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TeamsList;
        private System.Windows.Forms.FlowLayoutPanel clubsPanel;
        private System.Windows.Forms.Button mainMenu;
        private System.Windows.Forms.Button printbutton;
    }
}