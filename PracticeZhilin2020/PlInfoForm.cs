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
    public partial class PlInfoForm : Form
    {
        int id_player;
        public PlInfoForm(int id_player)
        {
            InitializeComponent();
            this.id_player = id_player;
            ObjectInfoSystem.Player player = new ObjectInfoSystem.Player();
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT * FROM players WHERE Id = @i_p", db.getConnection());
            command.Parameters.Add("@i_p", MySqlDbType.Int32).Value = id_player;
            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                name.Text = reader["first_name"].ToString();
                lastName.Text = reader["last_name"].ToString();
                dateOfBirth.Text = reader["date_of_birth"].ToString().Substring(0,10);
                nationality.Text = reader["nationality"].ToString();
                workFoot.Text = reader["work_foot"].ToString();
                position.Text = reader["positions"].ToString();
                goals.Text = reader["goals"].ToString();
                assists.Text = reader["assists"].ToString();
                yellowCards.Text = reader["yellow_cards"].ToString();
                redCards.Text = reader["red_cards"].ToString();
            }
            reader.Close();
        }
    }
}
