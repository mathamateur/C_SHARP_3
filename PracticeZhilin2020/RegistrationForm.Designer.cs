namespace PracticeZhilin2020
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Login = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.lastnameTB = new System.Windows.Forms.TextBox();
            this.firstnameTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.Registrationlabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 454);
            this.panel1.TabIndex = 1;
            // 
            // button_Login
            // 
            this.button_Login.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_Login.BackColor = System.Drawing.Color.White;
            this.button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Login.Location = new System.Drawing.Point(55, 352);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(219, 31);
            this.button_Login.TabIndex = 7;
            this.button_Login.Text = "Зарегестрироваться";
            this.button_Login.UseVisualStyleBackColor = false;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.button_Login);
            this.panel2.Controls.Add(this.Registrationlabel);
            this.panel2.Controls.Add(this.phoneTB);
            this.panel2.Controls.Add(this.emailTB);
            this.panel2.Controls.Add(this.lastnameTB);
            this.panel2.Controls.Add(this.firstnameTB);
            this.panel2.Controls.Add(this.PasswordTB);
            this.panel2.Controls.Add(this.LoginTB);
            this.panel2.Location = new System.Drawing.Point(49, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 397);
            this.panel2.TabIndex = 1;
            // 
            // phoneTB
            // 
            this.phoneTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.phoneTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneTB.Location = new System.Drawing.Point(98, 208);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(131, 24);
            this.phoneTB.TabIndex = 4;
            this.phoneTB.Text = "Телефон";
            this.phoneTB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClearP);
            this.phoneTB.MouseLeave += new System.EventHandler(this.Def);
            this.phoneTB.MouseHover += new System.EventHandler(this.Phone);
            // 
            // emailTB
            // 
            this.emailTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.emailTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailTB.Location = new System.Drawing.Point(98, 180);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(131, 24);
            this.emailTB.TabIndex = 3;
            this.emailTB.Text = "Email";
            this.emailTB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClearE);
            // 
            // lastnameTB
            // 
            this.lastnameTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lastnameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastnameTB.Location = new System.Drawing.Point(98, 152);
            this.lastnameTB.Name = "lastnameTB";
            this.lastnameTB.Size = new System.Drawing.Size(131, 24);
            this.lastnameTB.TabIndex = 2;
            this.lastnameTB.Text = "Фамилия";
            this.lastnameTB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClearF);
            // 
            // firstnameTB
            // 
            this.firstnameTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.firstnameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstnameTB.Location = new System.Drawing.Point(98, 124);
            this.firstnameTB.Name = "firstnameTB";
            this.firstnameTB.Size = new System.Drawing.Size(131, 24);
            this.firstnameTB.TabIndex = 1;
            this.firstnameTB.Text = "Имя";
            this.firstnameTB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClearN);
            // 
            // PasswordTB
            // 
            this.PasswordTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PasswordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTB.Location = new System.Drawing.Point(98, 264);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(131, 24);
            this.PasswordTB.TabIndex = 6;
            this.PasswordTB.Text = "Пароль";
            this.PasswordTB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Pass);
            // 
            // LoginTB
            // 
            this.LoginTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LoginTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTB.Location = new System.Drawing.Point(98, 236);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(131, 24);
            this.LoginTB.TabIndex = 5;
            this.LoginTB.Text = "Логин";
            this.LoginTB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClearL);
            // 
            // Registrationlabel
            // 
            this.Registrationlabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Registrationlabel.Font = new System.Drawing.Font("Calibri", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Registrationlabel.Location = new System.Drawing.Point(34, 1);
            this.Registrationlabel.Name = "Registrationlabel";
            this.Registrationlabel.Size = new System.Drawing.Size(268, 51);
            this.Registrationlabel.TabIndex = 0;
            this.Registrationlabel.Text = "Регистрация";
            this.Registrationlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 454);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrationForm";
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.TextBox LoginTB;
        private System.Windows.Forms.Label Registrationlabel;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.TextBox lastnameTB;
        private System.Windows.Forms.TextBox firstnameTB;
    }
}