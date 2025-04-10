using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_Personne.Modals;
using Gestion_Personne.UserControls;

namespace Gestion_Personne
{
    public partial class Menu : Form
    {
        private readonly string configFilePath = Application.StartupPath + @"\Sqlconfig.ini";
        private Color activeForeColor = Color.FromArgb(94, 69, 255);
        private Color activeBackColor = Color.White;
        private Color defaultForeColor = Color.White;
        private Color defaultBackColor = Color.FromArgb(94, 69, 255);
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
            btCon.Enabled = true;
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
            Server_Config server_Config = new Server_Config(this);
            server_Config.ShowDialog();
        }

        private void btDecon_Click(object sender, EventArgs e)
        {
            ActiveConnection();
            DesactiveSideBarButtons();
            controlPanel.Visible = false;
            controlPanel.Controls.Clear();
            btPerson.BackColor = defaultBackColor;
            btPerson.ForeColor = defaultForeColor;
            btPhone.BackColor = defaultBackColor;
            btPhone.ForeColor = defaultForeColor;
            btAdd.BackColor = defaultBackColor;
            btAdd.ForeColor = defaultForeColor;

        }

        private void btPerson_Click(object sender, EventArgs e)
        {
            btPerson.BackColor = activeBackColor;
            btPerson.ForeColor = activeForeColor;
            btPhone.BackColor = defaultBackColor;
            btPhone.ForeColor = defaultForeColor;
            btAdd.BackColor = defaultBackColor;
            btAdd.ForeColor = defaultForeColor;
            if (!controlPanel.Controls.Contains(User_Personne.instance))
            {
                controlPanel.Controls.Add(User_Personne.instance);
                User_Personne.instance.Dock = DockStyle.Fill;
                User_Personne.instance.BringToFront();
            }
            else
            {
                User_Personne.instance.BringToFront();
            }
        }
    }
}
