using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_Personne.Classes;
using System.Data.SqlClient;

namespace Gestion_Personne.Modals
{
    public partial class Auth : Form
    {
        private Form menu;
        private Config config;
        private SqlConnection sqlcon;
        private SqlCommand sqlcmd;

        public Auth(Form m)
        {
            InitializeComponent();
            this.menu = m;
            this.config = new Config();
        }
        public String IsEmpty()
        {
            if(textUser.Text == "username" || textUser.Text == "")
            {
                return "Fill the Username Field";
            }
            if (textPass.Text == "password" || textPass.Text == "")
            {
                return "Fill the Password Field";
            }
            return null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(IsEmpty() == null)
            {
                sqlcon = config.getSqlConnection();
                
                try
                {
                    sqlcon.Open();
                    if(sqlcon.State == ConnectionState.Open)
                    {
                        String sql = "select * from users where username=@user and pwd=@pwd";
                        SqlDataReader reader;
                        sqlcmd = new SqlCommand(sql, sqlcon);
                        sqlcmd.Parameters.AddWithValue("@user", textUser.Text);
                        sqlcmd.Parameters.AddWithValue("@pwd", textPass.Text);

                        reader = sqlcmd.ExecuteReader();
                        if (reader.Read())
                        {
                            MessageBox.Show("Welcom "+textUser.Text+"!!", "Authentification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            (menu as Menu).DesactiveConnection();
                            (menu as Menu).ActiveSideBarButtons();
                            (menu as Menu).panelSetting.Visible = false;
                            (menu as Menu).controlPanel.Visible = true;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Username or Password is not correct", "Authentification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Sql Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(IsEmpty(), "Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textUser_Enter(object sender, EventArgs e)
        {
            if(textUser.Text == "username")
            {
                textUser.Text = "";
                textUser.ForeColor = Color.DimGray;
            }
        }

        private void textUser_Leave(object sender, EventArgs e)
        {
            if(textUser.Text == "" || textUser.Text == "username")
            {
                textUser.Text = "username";
                textUser.ForeColor = Color.FromArgb(198, 190, 255);
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            textPass.UseSystemPasswordChar = false;
        }

        private void textPass_Enter(object sender, EventArgs e)
        {
            if (textPass.Text == "password")
            {
                textPass.Text = "";
                textPass.UseSystemPasswordChar = true;
                textPass.ForeColor = Color.DimGray;
            }
        }

        private void textPass_Leave(object sender, EventArgs e)
        {
            if (textPass.Text == "" || textPass.Text == "password")
            {
                textPass.Text = "password";
                textPass.UseSystemPasswordChar = false;
                textPass.ForeColor = Color.FromArgb(198, 190, 255);
            }
        }

        private void eyes_Click(object sender, EventArgs e)
        {
            if(textPass.UseSystemPasswordChar == true)
            {
                textPass.UseSystemPasswordChar = false;
                eyes.Image = global::Gestion_Personne.Properties.Resources.icons8_hide_24px;
            }
            else
            {
                textPass.UseSystemPasswordChar = true;
                eyes.Image = global::Gestion_Personne.Properties.Resources.icons8_eye_24px;
            }
        }
    }
}
