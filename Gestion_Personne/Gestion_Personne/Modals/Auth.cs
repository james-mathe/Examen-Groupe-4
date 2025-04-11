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
    }
}
