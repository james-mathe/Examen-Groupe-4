using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_Personne.Modals;

namespace Gestion_Personne
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            panelSetting.Visible = false;
            DesactiveSideBarButtons();
            ActiveConnection();
        }

        public void ActiveSideBarButtons()
        {
            btPerson.Enabled = true;
            btPhone.Enabled = true;
            btAdd.Enabled = true;
        }
        public void DesactiveSideBarButtons()
        {
            btPerson.Enabled = false;
            btPhone.Enabled = false;
            btAdd.Enabled = false;

        }

        public void ActiveConnection()
        {
            btDecon.Enabled = false;
        }
        public void DesactiveConnection()
        {
            btCon.Enabled = false;
            btDecon.Enabled = true;
        }

        private void btSettings_Click(object sender, EventArgs e)
        {
            panelSetting.Visible = !panelSetting.Visible;
        }

        private void btCon_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            connection.ShowDialog();
        }
    }
}
