using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeZhilin2020
{
    public partial class TopPForm : Form
    {
        private Panel[] PlayerPanel;    // Array of textboxes
        int count = -1;
        int DynamicButtonCount = 0;
        private string user_login;
        public int id_player;
        public TopPForm(string user_login)
        {
            this.user_login = user_login;
            InitializeComponent();
            PlayerPanel = new Panel[100];
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT * FROM players", db.getConnection());
            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                write_panel(reader);
            }
            reader.Close();
            db.closeConnection();

        }

        void write_panel(MySqlDataReader reader)
        {

            count++;
            DynamicButtonCount++;

            //panel
            PlayerPanel[count] = new Panel();
            PlayerPanel[count].BackColor = Color.White;
            PlayerPanel[count].BorderStyle = BorderStyle.FixedSingle;
            PlayerPanel[count].Size = new System.Drawing.Size(665, 80);
            PlayerPanel[count].Name = reader["Id"].ToString();



            //player_name
            Label nameLabel = new Label();
            nameLabel.Text = reader["first_name"].ToString();
            nameLabel.ForeColor = Color.Black;
            nameLabel.Font = new Font("Century Gothic", 18);
            nameLabel.Size = new System.Drawing.Size(300, 30);
            nameLabel.Location = new System.Drawing.Point(0, 0);

            //player_last_name
            Label infoLabel = new Label();
            infoLabel.Text = reader["last_name"].ToString();
            infoLabel.ForeColor = Color.Black;
            infoLabel.Font = new Font("Century Gothic", 18, FontStyle.Bold);
            infoLabel.Size = new System.Drawing.Size(300, 30);
            infoLabel.Location = new System.Drawing.Point(0, 35);

            //goals
            Label goalLabel = new Label();
            goalLabel.Text = reader["goals"].ToString();
            goalLabel.ForeColor = Color.Black;
            goalLabel.Font = new Font("Century Gothic", 20);
            goalLabel.Size = new System.Drawing.Size(80, 35);
            goalLabel.Location = new System.Drawing.Point(390, 35);
            goalLabel.TextAlign = ContentAlignment.MiddleLeft;

            //assists
            Label assistLabel = new Label();
            assistLabel.Text = reader["assists"].ToString();
            assistLabel.ForeColor = Color.Black;
            assistLabel.Font = new Font("Century Gothic", 20);
            assistLabel.Size = new System.Drawing.Size(80, 35);
            assistLabel.Location = new System.Drawing.Point(470, 35);
            assistLabel.TextAlign = ContentAlignment.MiddleLeft;

            //yellow_cards
            Label ycLabel = new Label();
            ycLabel.Text = reader["yellow_cards"].ToString();
            ycLabel.ForeColor = Color.Black;
            ycLabel.Font = new Font("Century Gothic", 20);
            ycLabel.Size = new System.Drawing.Size(80, 35);
            ycLabel.Location = new System.Drawing.Point(550, 35);
            ycLabel.TextAlign = ContentAlignment.MiddleLeft;

            //red_cards
            Label rcLabel = new Label();
            rcLabel.Text = reader["yellow_cards"].ToString();
            rcLabel.ForeColor = Color.Black;
            rcLabel.Font = new Font("Century Gothic", 20);
            rcLabel.Size = new System.Drawing.Size(80, 35);
            rcLabel.Location = new System.Drawing.Point(630, 35);
            rcLabel.TextAlign = ContentAlignment.MiddleLeft;

            //info
            string name = "" + DynamicButtonCount;
            Button info = new Button();
            info.Name = name;
            info.BackgroundImage = Image.FromFile("C:\\Users\\Aleksandr\\Downloads\\iconfinder_icon-ios7-information-outline_211761.png");
            info.BackgroundImageLayout = ImageLayout.Stretch;
            info.Location = new System.Drawing.Point(300, 35);
            info.Size = new System.Drawing.Size(35, 35);
            info.Click += new EventHandler(this.club_Info_Click);




            PlayerPanel[count].Controls.Add(nameLabel);
            PlayerPanel[count].Controls.Add(infoLabel);
            PlayerPanel[count].Controls.Add(goalLabel);
            PlayerPanel[count].Controls.Add(assistLabel);
            PlayerPanel[count].Controls.Add(ycLabel);
            PlayerPanel[count].Controls.Add(rcLabel);
            PlayerPanel[count].Controls.Add(info);
            playersPanel.Controls.Add(PlayerPanel[count]);
        }

        private System.Windows.Forms.FlowLayoutPanel playersPanel;
        private System.Windows.Forms.Label nameForm;
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopPForm));
            this.nameForm = new System.Windows.Forms.Label();
            this.playersPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameForm
            // 
            this.nameForm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nameForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.nameForm.Location = new System.Drawing.Point(300, 0);
            this.nameForm.Name = "nameForm";
            this.nameForm.Size = new System.Drawing.Size(300, 50);
            this.nameForm.TabIndex = 0;
            this.nameForm.Text = "Топ игроков";
            this.nameForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playersPanel
            // 
            this.playersPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playersPanel.AutoScroll = true;
            this.playersPanel.Location = new System.Drawing.Point(0, 100);
            this.playersPanel.Name = "playersPanel";
            this.playersPanel.Size = new System.Drawing.Size(900, 446);
            this.playersPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(500, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 50);
            this.panel1.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(191, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 50);
            this.button4.TabIndex = 3;
            this.button4.Text = "Желтые карточки";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(288, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "Красные карточки";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(96, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ассисты";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Голы";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(0, 546);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(138, 54);
            this.button5.TabIndex = 2;
            this.button5.Text = "Главное меню";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Location = new System.Drawing.Point(144, 546);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(54, 54);
            this.button6.TabIndex = 3;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // TopPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nameForm);
            this.Controls.Add(this.playersPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TopPForm";
            this.Text = "TopPlayers";
            this.Load += new System.EventHandler(this.TopPForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            for (int i = count; i > 0; i--)
                playersPanel.Controls.Remove(PlayerPanel[i]);


            PlayerPanel = new Panel[100];
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT * FROM players ORDER BY goals DESC", db.getConnection());
            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                write_panel(reader);
            }
            reader.Close();
            db.closeConnection();

        }

        private void TopPForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = count; i > 0; i--)
                playersPanel.Controls.Remove(PlayerPanel[i]);


            PlayerPanel = new Panel[100];
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT * FROM players ORDER BY assists DESC", db.getConnection());
            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                write_panel(reader);
            }
            reader.Close();
            db.closeConnection();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = count; i > 0; i--)
                playersPanel.Controls.Remove(PlayerPanel[i]);


            PlayerPanel = new Panel[100];
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT * FROM players ORDER BY yellow_cards DESC", db.getConnection());
            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                write_panel(reader);
            }
            reader.Close();
            db.closeConnection();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = count; i > 0; i--)
                playersPanel.Controls.Remove(PlayerPanel[i]);


            PlayerPanel = new Panel[100];
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT * FROM players ORDER BY red_cards DESC", db.getConnection());
            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                write_panel(reader);
            }
            reader.Close();
            db.closeConnection();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            HeadForm headForm = new HeadForm(user_login);
            headForm.Show();
            Close();
        }
        private void club_Info_Click(object sender, EventArgs e)
        {
            Button dynamicButton = (sender as Button);
            int x = Int32.Parse(dynamicButton.Name);
            id_player = Int32.Parse(PlayerPanel[x - 1].Name);
            PlInfoForm playerInfoForm = new PlInfoForm(id_player);
            playerInfoForm.Show();
        }
    }
}
