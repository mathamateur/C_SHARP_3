namespace PracticeZhilin2020
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.PanelAdmin = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AddTeamAdmin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PanelAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelAdmin
            // 
            this.PanelAdmin.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.PanelAdmin.Controls.Add(this.button1);
            this.PanelAdmin.Controls.Add(this.button3);
            this.PanelAdmin.Controls.Add(this.button2);
            this.PanelAdmin.Controls.Add(this.AddTeamAdmin);
            this.PanelAdmin.Location = new System.Drawing.Point(0, 0);
            this.PanelAdmin.Name = "PanelAdmin";
            this.PanelAdmin.Size = new System.Drawing.Size(276, 388);
            this.PanelAdmin.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(3, 197);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(270, 91);
            this.button3.TabIndex = 2;
            this.button3.Text = "Добавить игрока";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(3, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(270, 91);
            this.button2.TabIndex = 1;
            this.button2.Text = "Добавить команду";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AddTeamAdmin
            // 
            this.AddTeamAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddTeamAdmin.Location = new System.Drawing.Point(3, 3);
            this.AddTeamAdmin.Name = "AddTeamAdmin";
            this.AddTeamAdmin.Size = new System.Drawing.Size(270, 91);
            this.AddTeamAdmin.TabIndex = 0;
            this.AddTeamAdmin.Text = "Добавить администратора команды";
            this.AddTeamAdmin.UseVisualStyleBackColor = true;
            this.AddTeamAdmin.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(3, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 91);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить матч";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 388);
            this.Controls.Add(this.PanelAdmin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.PanelAdmin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelAdmin;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AddTeamAdmin;
        private System.Windows.Forms.Button button1;
    }
}