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
    public partial class RapportModal : Form
    {
        public RapportModal()
        {
            InitializeComponent();
        }

        private void RapportModal_Load(object sender, EventArgs e)
        {

            this.reportpreview.RefreshReport();
        }
    }
}
