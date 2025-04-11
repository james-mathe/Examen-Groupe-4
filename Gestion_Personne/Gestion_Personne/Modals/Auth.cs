using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Personne.Modals
{
    public partial class Auth : Form
    {
        private Form menu;

        public Auth(Form m)
        {
            InitializeComponent();
            this.menu = m;
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

                (menu as Menu).DesactiveConnection();
                (menu as Menu).ActiveSideBarButtons();
                (menu as Menu).panelSetting.Visible = false;
                (menu as Menu).controlPanel.Visible = true;

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
