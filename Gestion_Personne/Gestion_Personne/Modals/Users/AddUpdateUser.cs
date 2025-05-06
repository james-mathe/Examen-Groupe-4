using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Personne.Modals.Users
{
    public partial class AddUpdateUser : Form
    {
        private UserControl user;
        public int idU;
        private Classes.Config config;
        private DialogResult Dr;
        public AddUpdateUser(UserControl u)
        {
            InitializeComponent();
            this.user = u;
        }

        private void AddUpdateUser_Load(object sender, EventArgs e)
        {
            textPass.UseSystemPasswordChar = false;
            textCpass.UseSystemPasswordChar = false;
        }
        public String IsEmpty()
        {
            if (textUser.Text == "username" || textUser.Text == "")
            {
                return "Fill the Username Field";
            }
            if (textPass.Text == "password" || textPass.Text == "")
            {
                return "Fill the Password Field";
            }
            if (textCpass.Text == "Confirm Pass" || textCpass.Text == "")
            {
                return "Fill the Confirm Password Field";
            }
            return null;
        }

        private void textUser_Enter(object sender, EventArgs e)
        {
            if (textUser.Text == "username")
            {
                textUser.Text = "";
                textUser.ForeColor = Color.DimGray;
            }
        }

        private void textUser_Leave(object sender, EventArgs e)
        {
            if (textUser.Text == "" || textUser.Text == "username" || textUser.Text.Contains(" "))
            {
                textUser.Text = "username";
                textUser.ForeColor = Color.FromArgb(198, 190, 255);
            }
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
            if (textPass.UseSystemPasswordChar == true)
            {
                textPass.UseSystemPasswordChar = false;
                eyes.Image = Properties.Resources.icons8_hide_24px;
            }
            else
            {
                textPass.UseSystemPasswordChar = true;
                eyes.Image = Properties.Resources.icons8_eye_24px;
            }
        }

        private void btsaveUser_Click(object sender, EventArgs e)
        {
            config = new Classes.Config();
            if (IsEmpty() == null)
            {
                if (config.ServerType == "Sql Server")
                {
                    if(textPass.Text == textCpass.Text)
                    {
                        if (titleUser.Text == "Add User")
                        {
                            Classes.User.AddUpdateDeleteUser add = new Classes.User.AddUpdateDeleteUser();
                            if (add.addUserSql(textUser.Text, textPass.Text) == true)
                            {
                                (user as UserControls.User_User).DisplayUser("");
                                MessageBox.Show("User Added Successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();

                            }
                            else
                            {
                                MessageBox.Show("Error Adding User", "Add", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            Classes.User.AddUpdateDeleteUser update = new Classes.User.AddUpdateDeleteUser();
                            Dr = MessageBox.Show("Do you Want to Update this User??", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (Dr == DialogResult.Yes)
                            {
                                if (update.UpdateUserSql(idU, textUser.Text, textPass.Text) == true)
                                {
                                    (user as UserControls.User_User).DisplayUser("");
                                    MessageBox.Show("User Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Error Updating User", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    this.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Update Canceled", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("The Password Doesn't Match each other. Try Again!!", "Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    if (textPass.Text == textCpass.Text)
                    {
                        if (titleUser.Text == "Add User")
                        {
                            Classes.User.AddUpdateDeleteUser add = new Classes.User.AddUpdateDeleteUser();
                            if (add.addUserMySql(textUser.Text, textPass.Text) == true)
                            {
                                (user as UserControls.User_User).DisplayUser("");
                                MessageBox.Show("User Added Successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();

                            }
                            else
                            {
                                MessageBox.Show("Error Adding User", "Add", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            Classes.User.AddUpdateDeleteUser update = new Classes.User.AddUpdateDeleteUser();
                            Dr = MessageBox.Show("Do you Want to Update this User??", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (Dr == DialogResult.Yes)
                            {
                                if (update.UpdateUserMySql(idU, textUser.Text, textPass.Text) == true)
                                {
                                    (user as UserControls.User_User).DisplayUser("");
                                    MessageBox.Show("User Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Error Updating User", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    this.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Update Canceled", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("The Password Doesn't Match each other. Try Again!!", "Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show(IsEmpty(), "Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eyesCpass_Click(object sender, EventArgs e)
        {
            if (textCpass.UseSystemPasswordChar == true)
            {
                textCpass.UseSystemPasswordChar = false;
                eyesCpass.Image = Properties.Resources.icons8_hide_24px;
            }
            else
            {
                textCpass.UseSystemPasswordChar = true;
                eyesCpass.Image = Properties.Resources.icons8_eye_24px;
            }
        }

        private void textCpass_Enter(object sender, EventArgs e)
        {
            if (textCpass.Text == "Confirm Pass")
            {
                textCpass.Text = "";
                textCpass.UseSystemPasswordChar = true;
                textCpass.ForeColor = Color.DimGray;
            }
        }

        private void textCpass_Leave(object sender, EventArgs e)
        {
            if (textCpass.Text == "" || textCpass.Text == "Confirm Pass")
            {
                textCpass.Text = "Confirm Pass";
                textCpass.UseSystemPasswordChar = false;
                textCpass.ForeColor = Color.FromArgb(198, 190, 255);
            }
        }
    }
}
