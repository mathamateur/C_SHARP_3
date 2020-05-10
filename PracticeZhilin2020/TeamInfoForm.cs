using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeZhilin2020
{
    public partial class TeamInfoForm : Form
    {
        string login_user, user_group;
        int team_manager_id, team_id;
        public TeamInfoForm(int id_club,string login_user)
        {
            InitializeComponent();
            team_id = id_club;
            this.login_user = login_user; 
            ObjectInfoSystem.Club team = new ObjectInfoSystem.Club();
            DB db = new DB();
            
            MySqlCommand download_logo = new MySqlCommand("SELECT Logo FROM teams_logo WHERE team_id = @t_i", db.getConnection());
            download_logo.Parameters.Add("@t_i", MySqlDbType.VarChar).Value = id_club;
            db.openConnection();
            MySqlDataReader reader = download_logo.ExecuteReader();

            if (reader.Read())
            {
                byte[] image = (byte[])reader["Logo"];
                if (image == null)
                {
                    TeamLogo.Image = null;
                }
                else
                {
                    MemoryStream mstream = new MemoryStream(image);
                    TeamLogo.Image = System.Drawing.Image.FromStream(mstream);
                }
            }
                reader.Close();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `clubs` WHERE `Id` = @i_c", db.getConnection());
            command.Parameters.Add("@i_c", MySqlDbType.VarChar).Value = id_club;
            db.openConnection();
             reader = command.ExecuteReader();
            if (reader.Read())
            {
                team.club_info = reader["team_name"].ToString();
                team.club_location = reader["club_location"].ToString();
                team.creator_id = Int32.Parse(reader["Creator_id"].ToString());
                team.captain_id = Int32.Parse(reader["captain_id"].ToString());
                team.top_scorer_id = Int32.Parse(reader["top_scorer_id"].ToString());
                team.rudest_player_id = Int32.Parse(reader["rudest_player_id"].ToString());
                team.coach_id = Int32.Parse(reader["coach_id"].ToString());
                team.goals_scored= Int32.Parse(reader["goals_scored"].ToString());
                team.goals_conceded = Int32.Parse(reader["goals_conceded"].ToString());
                team.winning_mathes= Int32.Parse(reader["winning_matches"].ToString());
                team.loses_mathes = Int32.Parse(reader["losing_matches"].ToString());
                team_id = Int32.Parse(reader["Id"].ToString());
                team_manager_id = Int32.Parse(reader["Creator_id"].ToString());
            }
            reader.Close();

            ObjectInfoSystem.User club_manager = new ObjectInfoSystem.User();
            command = new MySqlCommand("SELECT * FROM `users` WHERE `Id` = @c_m", db.getConnection());
            command.Parameters.Add("@c_m", MySqlDbType.VarChar).Value = team.creator_id;
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                club_manager.first_name = reader["First_name"].ToString();
                club_manager.last_name = reader["Last_name"].ToString();
                club_manager.phone = reader["phone"].ToString();
                club_manager.email = reader["email"].ToString();
                
            }
            reader.Close();
            ClubManagerLabel.Text = club_manager.first_name + " " + club_manager.last_name +
                "\n" + club_manager.phone + "\n" + club_manager.email;
            ObjectInfoSystem.Coach coach = new ObjectInfoSystem.Coach();
            command = new MySqlCommand("SELECT * FROM `coaches` WHERE `Id` = @c_i", db.getConnection());
            command.Parameters.Add("@c_i", MySqlDbType.VarChar).Value = team.coach_id;
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                coach.first_name = reader["first_name"].ToString();
                coach.last_name = reader["last_name"].ToString();
                coach.nationality = reader["nationality"].ToString();
                coach.date_of_birth = reader["date_of_birth"].ToString().Substring(0,10);
            }
            reader.Close();
            HeadCoachLabel.Text = coach.first_name +" " +coach.last_name + "\n" + coach.nationality + "\n" + coach.date_of_birth;
            ObjectInfoSystem.Player captain = new ObjectInfoSystem.Player();
            command = new MySqlCommand("SELECT * FROM `players` WHERE `Id` = @c_i", db.getConnection());
            command.Parameters.Add("@c_i", MySqlDbType.VarChar).Value = team.captain_id;
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                captain.first_name = reader["first_name"].ToString();
                captain.last_name = reader["last_name"].ToString();
                captain.nationality = reader["nationality"].ToString();
                captain.positions = reader["positions"].ToString();
                captain.work_foot = Char.Parse(reader["work_foot"].ToString());
                captain.date_of_birth = reader["date_of_birth"].ToString().Substring(0,10);
                /*    captain.yellow_cards = Int32.Parse(reader["yellow_cards"].ToString());
                      captain.red_cards = Int32.Parse(reader["red_cards"].ToString());
                      captain.goals_scored = Int32.Parse(reader["goal_scored"].ToString());
                      captain.asissts = Int32.Parse(reader["assists"].ToString());*/
            }
            ClubCaptainLabel.Text = captain.first_name + " " + captain.last_name +
                "\n" + captain.nationality + "\n" + captain.positions + "\n" + captain.work_foot +"\n"+
                captain.date_of_birth;
            reader.Close();
            ObjectInfoSystem.Player top_scorer = new ObjectInfoSystem.Player();
            command = new MySqlCommand("SELECT * FROM `players` WHERE `Id` = @t_s", db.getConnection());
            command.Parameters.Add("@t_s", MySqlDbType.VarChar).Value = team.top_scorer_id;
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                top_scorer.first_name = reader["first_name"].ToString();
                top_scorer.last_name = reader["last_name"].ToString();
                top_scorer.nationality = reader["nationality"].ToString();
                top_scorer.positions = reader["positions"].ToString();
                top_scorer.work_foot = Char.Parse(reader["work_foot"].ToString());
                top_scorer.goals_scored = Int32.Parse(reader["goals"].ToString());

                //top_scorer.date_of_birth = reader["date_of_birth"].ToString();
                /*    captain.yellow_cards = Int32.Parse(reader["yellow_cards"].ToString());
                      captain.red_cards = Int32.Parse(reader["red_cards"].ToString());
                      captain.asissts = Int32.Parse(reader["assists"].ToString());*/
            }
            BestScorerLabel.Text = top_scorer.first_name + " " + top_scorer.last_name +
                "\n" + top_scorer.nationality + "\n" + top_scorer.positions + "\n" + top_scorer.work_foot + "\n" +
                top_scorer.date_of_birth +" Голов забил: "+ top_scorer.goals_scored;
            TeamsGoalScoredLabel.Text = "Голов забито: " + team.goals_scored;
            TeamsGoalConcededLabel.Text = "Голов пропущено: " + team.goals_conceded;
            TeamsWinnsLabel.Text = "Побед:" + team.winning_mathes;
            TeamsLosesLabel.Text = "Поражений: " + team.loses_mathes;
            reader.Close();
            db.closeConnection();
        }

        private void TeamInfoForm_Load(object sender, EventArgs e)
        {

        }

        private void ClubCaptainLabel_Click(object sender, EventArgs e)
        {

        }

        private void TeamLogo_Click(object sender, EventArgs e)
        {
            int user_id = 0;
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `Login` = @l_u", db.getConnection());
            command.Parameters.Add("@l_u", MySqlDbType.VarChar).Value = login_user;
            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                user_group = reader["User_group"].ToString();
                user_id = Int32.Parse(reader["Id"].ToString());
            }
            reader.Close();
            db.closeConnection();
            if((user_group=="team_admin" && team_manager_id==user_id)|| user_group =="head_admin")
            {
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    TeamLogo.Image = Image.FromFile(dialog.FileName);

                    MemoryStream ms = new MemoryStream();
                    TeamLogo.Image.Save(ms, TeamLogo.Image.RawFormat);
                    byte[] img = ms.ToArray();
                    command = new MySqlCommand("SELECT FROM * `teams_logo` WHERE `team_id` = @t_i)", db.getConnection());
                    command.Parameters.Add("@t_i", MySqlDbType.Int32).Value = team_id;

                    if (command == null)
                    {
                        command = new MySqlCommand("INSERT INTO teams_logo (Logo,team_id) VALUES (@img,@t_i)", db.getConnection());
                        command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;
                        command.Parameters.Add("@t_i", MySqlDbType.Int32).Value = team_id;
                        db.openConnection();
                    }
                    else
                    {
                        command = new MySqlCommand("UPDATE teams_logo SET Logo = @img", db.getConnection());
                        command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;
                        db.openConnection();
                    }
                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Логотип успешно загружен");
                        
                    }
                    db.closeConnection();
                    this.Close();
                }
            }
    
        }
    }
}
