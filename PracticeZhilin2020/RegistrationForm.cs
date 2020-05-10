using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeZhilin2020
{
    public partial class RegistrationForm : Form
    {
        bool flag = false;
        string ul = "";
        string pattern = ("^\\+?\\d+[09]*$");

        public RegistrationForm()
        {
            InitializeComponent();
            firstnameTB.Text = "Имя";
            lastnameTB.Text = "Фамилия";
            emailTB.Text = "Email";
            phoneTB.Text = "Телефон";
            LoginTB.Text = "Логин";
            PasswordTB.Text = "Пароль";
            //string pattern = ("^\\+?\\d+[09]*$");
        }
        public RegistrationForm(bool f)
        {
            flag = f;
            InitializeComponent();
            firstnameTB.Text = "Имя";
            lastnameTB.Text = "Фамилия";
            emailTB.Text = "Email";
            phoneTB.Text = "Телефон";
            LoginTB.Text = "Логин";
            PasswordTB.Text = "Пароль";
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            if (firstnameTB.Text == "" || firstnameTB.Text == "Имя")
                return;          
            if (lastnameTB.Text == "" || lastnameTB.Text == "Фамилия")
                return;
            if (emailTB.Text == "" || emailTB.Text == "Email")
                return;
            if (phoneTB.Text == "" || phoneTB.Text == "Телефон"|| !Regex.IsMatch(phoneTB.Text, pattern))
            
                    return;
            if (LoginTB.Text == "" || LoginTB.Text == "Логин")
                return;
            if (PasswordTB.Text == "" || PasswordTB.Text == "Пароль")
                return;
            if (checkUser())
                return;
            
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`Login`, `First_name`, `Last_name`, `User_group`, `password`, `email`, `phone`, `Voices_player_id`, `Voices_coach_id`) VALUES (@login, @first_name, @last_name, @user_group, @password, @email, @phone, NULL, NULL);",db.getConnection());

            command.Parameters.Add("@login",MySqlDbType.VarChar).Value = LoginTB.Text;
            command.Parameters.Add("@first_name", MySqlDbType.VarChar).Value = firstnameTB.Text;
            command.Parameters.Add("@last_name", MySqlDbType.VarChar).Value = lastnameTB.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = PasswordTB.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = emailTB.Text;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phoneTB.Text;
            if (flag)
            {
                command.Parameters.Add("@user_group", MySqlDbType.VarChar).Value = "team_admin";
                ul = "admin";
            }
            else command.Parameters.Add("@user_group", MySqlDbType.VarChar).Value = "user";

            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                if (flag)
                {
                    AdminForm Admin = new AdminForm(ul);
                    Admin.Show();
                    Close();
                }
                else
                {
                    this.Close();
                    HeadForm headForm = new HeadForm(LoginTB.Text);
                    headForm.Show();
                }
            }
            else
                MessageBox.Show("Error");

            db.closeConnection();
        }
        public Boolean checkUser()
        {
            DB dB = new DB();

            DataTable datatable = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `Login` = @u_l", dB.getConnection());

            command.Parameters.Add("@u_l", MySqlDbType.VarChar).Value = LoginTB.Text;
            

            adapter.SelectCommand = command;
            adapter.Fill(datatable);

            if (datatable.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь с таким логином уже существует");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void ClearN(object sender, MouseEventArgs e)
        {
            if ((sender as TextBox).Text == "Имя")
                (sender as TextBox).Text = "";
        }

        private void ClearF(object sender, MouseEventArgs e)
        {
            if ((sender as TextBox).Text == "Фамилия")
                (sender as TextBox).Text = "";
        }

        private void ClearE(object sender, MouseEventArgs e)
        {
            if ((sender as TextBox).Text == "Email")
                (sender as TextBox).Text = "";
        }

        private void ClearP(object sender, MouseEventArgs e)
        {
            if ((sender as TextBox).Text == "+7-___-___-__-__")
                (sender as TextBox).Text = "";
        }

        private void Phone(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == "Телефон")
                (sender as TextBox).Text = "+7-___-___-__-__";
        }

        private void Def(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == "+7-___-___-__-__" | (sender as TextBox).Text == "")
                (sender as TextBox).Text = "Телефон";
        }

        private void ClearL(object sender, MouseEventArgs e)
        {
            if ((sender as TextBox).Text == "Логин")
                (sender as TextBox).Text = "";
        }

        private void Pass(object sender, MouseEventArgs e)
        {
            if ((sender as TextBox).Text == "Пароль")
                (sender as TextBox).Text = "";
            (sender as TextBox).UseSystemPasswordChar = true;
        }
    }
}
