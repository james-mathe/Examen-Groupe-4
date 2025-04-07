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
    }
}
