using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            
        }

       

        private void button_Login_Click(object sender, EventArgs e)
        {
            string user_login = LoginField.Text;
            string user_password = PasswordField.Text;

            DB dB = new DB();

            DataTable datatable = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `Login` = @u_l AND `password` = @u_p",dB.getConnection());
          
            command.Parameters.Add("@u_l",MySqlDbType.VarChar).Value = user_login;
            command.Parameters.Add("@u_p", MySqlDbType.VarChar).Value = user_password;

            adapter.SelectCommand = command;
            adapter.Fill(datatable);
        
            if(datatable.Rows.Count > 0)
            {
                HeadForm headForm = new HeadForm(user_login);
                headForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль!");

            }
        }
        private void Clear(object sender, MouseEventArgs e)
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
