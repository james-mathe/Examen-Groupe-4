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
    public partial class Connection : Form
    {
        private Form menu;
        public Connection(Form m)
        {
            InitializeComponent();
            this.menu = m;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (menu as Menu).DesactiveConnection();
            (menu as Menu).ActiveSideBarButtons();
            (menu as Menu).panelSetting.Visible = false;
        }

        private void Connection_Load(object sender, EventArgs e)
        {
            textPass.UseSystemPasswordChar = false;
        }

        private void textServ_Enter(object sender, EventArgs e)
        {
            if(textServ.Text == "server name")
            {
                textServ.Text = "";
                textServ.ForeColor = Color.Black;
            }
        }

        private void textServ_Leave(object sender, EventArgs e)
        {
            if(textServ.Text == "" || textServ.Text == "server name")
            {
                textServ.Text = "server name";
                textServ.ForeColor = Color.FromArgb(198, 190, 255);
            }
        }

        private void textUser_Enter(object sender, EventArgs e)
        {
            if(textUser.Text == "username")
            {
                textUser.Text = "";
                textUser.ForeColor = Color.Black;
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
    }
}
