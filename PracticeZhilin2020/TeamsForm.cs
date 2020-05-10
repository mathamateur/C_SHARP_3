using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PracticeZhilin2020
{
    public partial class TeamsForm : Form
    {
        private Panel[] ClubPanel;    // Массив Панелей
        int count = -1;
        int DynamicButtonCount = 0;
        int id_club;
        private string user_login;
        public TeamsForm(string user_login)
        {
            InitializeComponent();
            this.user_login = user_login;
            ClubPanel = new Panel[100];
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT * FROM clubs", db.getConnection());
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
            ClubPanel[count] = new Panel();
            ClubPanel[count].BackColor = Color.White;
            ClubPanel[count].BorderStyle = BorderStyle.FixedSingle;
            ClubPanel[count].Size = new System.Drawing.Size(665, 80);
            ClubPanel[count].Name = reader["Id"].ToString();


            //team_name
            Label nameLabel = new Label();
            nameLabel.Text = reader["team_name"].ToString();
            nameLabel.ForeColor = Color.Black;
            nameLabel.Font = new Font("Century Gothic", 20, FontStyle.Bold);
            nameLabel.Size = new System.Drawing.Size(660, 30);
            nameLabel.Location = new System.Drawing.Point(0, 0);

            //place
            Label infoLabel = new Label();
            infoLabel.Text = reader["club_location"].ToString();
            infoLabel.ForeColor = Color.Black;
            infoLabel.Font = new Font("Century Gothic", 20);
            infoLabel.Size = new System.Drawing.Size(660, 30);
            infoLabel.Location = new System.Drawing.Point(0, 35);

            //button
            string name = "" + DynamicButtonCount;
            Button btnDynamicButton = new Button();
            btnDynamicButton.Name = name;
            btnDynamicButton.Text = "Подробнее";
            btnDynamicButton.Cursor = Cursors.Hand;
            btnDynamicButton.Size = new System.Drawing.Size(150, 30);
            btnDynamicButton.Font = new Font("Century Gothic", 15);
            btnDynamicButton.Location = new System.Drawing.Point(500, 35);
            btnDynamicButton.Click += new EventHandler(this.club_Info_Click);
            btnDynamicButton.BringToFront();

            ClubPanel[count].Controls.Add(btnDynamicButton);
            ClubPanel[count].Controls.Add(nameLabel);
            ClubPanel[count].Controls.Add(infoLabel);
            clubsPanel.Controls.Add(ClubPanel[count]);

        }
        private void club_Info_Click(object sender, EventArgs e)
        {
            Button dynamicButton = (sender as Button);
            int x = Int32.Parse(dynamicButton.Name);
            id_club = Int32.Parse(ClubPanel[x - 1].Name);
            TeamInfoForm teaminfo = new TeamInfoForm(id_club, user_login);
            teaminfo.Show();
        }
        private void mainMenu_Click(object sender, EventArgs e)
        {
            HeadForm headForm = new HeadForm(user_login);
            headForm.Show();
            Close();
        }
    }
}
