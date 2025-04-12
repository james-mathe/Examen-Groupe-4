using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_Personne.Modals.people;

namespace Gestion_Personne.UserControls
{
    public partial class User_Personne : UserControl
    {
        private static User_Personne person;
        public int idP;
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
            tablePerson.Rows.Add(1, 1, "james", "mathe", "Kambale","M");
            tablePerson.Rows.Add(2, 6, "james", "mathe", "Kambale", "M");
            tablePerson.Rows.Add(3, 5, "james", "mathe", "Kambale", "M");
            tablePerson.Rows.Add(4, 7, "james", "mathe", "Kambale", "M");
            tablePerson.Rows.Add(5, 7, "james", "mathe", "Kambale", "M");
            tablePerson.Rows.Add(6, 1, "james", "mathe", "Kambale", "M");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddUpdatePerson addPerson = new AddUpdatePerson(this);
            addPerson.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(tablePerson.Rows.Count > 0)
            {
                AddUpdatePerson updatePerson = new AddUpdatePerson(this);
                updatePerson.idP = (int)tablePerson.CurrentRow.Cells[1].Value;
                updatePerson.textname.Text = tablePerson.CurrentRow.Cells[4].Value.ToString();
                updatePerson.textLastname.Text = tablePerson.CurrentRow.Cells[3].Value.ToString();
                updatePerson.textFirstname.Text = tablePerson.CurrentRow.Cells[2].Value.ToString();
                updatePerson.comboGender.Text = tablePerson.CurrentRow.Cells[5].Value.ToString();

                updatePerson.textname.ForeColor = Color.DimGray;
                updatePerson.textLastname.ForeColor = Color.DimGray;
                updatePerson.textFirstname.ForeColor = Color.DimGray;
                updatePerson.comboGender.ForeColor = Color.DimGray;

                updatePerson.titlePerson.Text = "Update Person";
                updatePerson.titlePerson.Location = new Point(59, 13); 
                updatePerson.btsavePerson.Text = "Update";
                updatePerson.ShowDialog();
            }
            else
            {
                MessageBox.Show("Table is Empty fill it before", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tablePerson.Rows.Count > 0)
            {
                
                idP = (int)tablePerson.CurrentRow.Cells[1].Value;
                DialogResult DR = MessageBox.Show("Do you Want to Delete this Person??", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DR == DialogResult.Yes)
                {
                    MessageBox.Show("Person Deleted Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Delete action Canceled", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Table is Empty, fill it before", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
