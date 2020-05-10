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
    public partial class HeadForm : Form
    {
        string ul;
        private string user_login;
        private string user_group;
        public HeadForm(string user_login)
        {
            InitializeComponent();
            ul = user_login;
            if (user_login == "Guest")
            {
                button1.Enabled = false;
                button1.Visible = false;
                button3.Enabled = false;
                button3.Visible = false;
            }
            if (user_group != "head_admin" | user_group != "team_admin")
            {
                button5.Enabled = false;
                button5.Visible = false;
            }
            this.user_login = user_login;
            string user_info,user_firstname,user_lastname,user_email;
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `Login` = @u_l", db.getConnection());
            command.Parameters.Add("@u_l", MySqlDbType.VarChar).Value = user_login;
            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                user_firstname =reader["First_name"].ToString();
                user_lastname = reader["Last_name"].ToString();
                user_email = reader["email"].ToString();
                user_info = user_login +"\n"+ user_firstname +" "+ user_lastname;
                db.closeConnection();
                reader.Close();
                User_label_info.Text = user_info;
            }

        }

        private void HeadForm_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            StartForm startForm = new StartForm();
            startForm.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TeamsForm teamsForm = new TeamsForm(user_login);
            teamsForm.Show();
            Close();

        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            TopPForm topPForm = new TopPForm(user_login);
            topPForm.Show();
            Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminForm Admin = new AdminForm(ul);
            Admin.Show();
            Close();
        }
    }
}

