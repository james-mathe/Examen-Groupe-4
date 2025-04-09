using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Personne.UserControls
{
    public partial class User_Personne : UserControl
    {
        private static User_Personne person;
        public static User_Personne instance
        {
            get
            {
                if(person == null)
                {
                    person = new User_Personne();
                }
                return person;
            }
        }
        public User_Personne()
        {
            InitializeComponent();
        }

        private void textSearch_Enter(object sender, EventArgs e)
        {
            if(textSearch.Text == "Search")
            {
                textSearch.Text = "";
                textSearch.ForeColor = Color.DimGray;
            }
        }

        private void textSearch_Leave(object sender, EventArgs e)
        {
            if(textSearch.Text == "" || textSearch.Text == "Search")
            {
                textSearch.Text = "Search";
                textSearch.ForeColor = Color.FromArgb(198, 190, 255);
            }
        }

        private void User_personne_Load(object sender, EventArgs e)
        {
            tablePerson.Rows.Add(1, "james", "mathe", "Kambale","M");
            tablePerson.Rows.Add(2, "james", "mathe", "Kambale", "M");
            tablePerson.Rows.Add(3, "james", "mathe", "Kambale", "M");
            tablePerson.Rows.Add(4, "james", "mathe", "Kambale", "M");
            tablePerson.Rows.Add(5, "james", "mathe", "Kambale", "M");
            tablePerson.Rows.Add(6, "james", "mathe", "Kambale", "M");
        }
    }
}
