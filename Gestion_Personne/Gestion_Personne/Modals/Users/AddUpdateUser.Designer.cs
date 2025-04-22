
namespace Gestion_Personne.Modals.Users
{
    partial class AddUpdateUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUpdateUser));
            this.btsaveUser = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textPass = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textUser = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.titleUser = new System.Windows.Forms.Label();
            this.eyes = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btsaveUser
            // 
            this.btsaveUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btsaveUser.BackColor = System.Drawing.Color.White;
            this.btsaveUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(69)))), ((int)(((byte)(255)))));
            this.btsaveUser.FlatAppearance.BorderSize = 2;
            this.btsaveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsaveUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsaveUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(69)))), ((int)(((byte)(255)))));
            this.btsaveUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btsaveUser.Location = new System.Drawing.Point(6, 289);
            this.btsaveUser.Name = "btsaveUser";
            this.btsaveUser.Size = new System.Drawing.Size(338, 48);
            this.btsaveUser.TabIndex = 54;
            this.btsaveUser.Text = "Add";
            this.btsaveUser.UseVisualStyleBackColor = false;
            this.btsaveUser.Click += new System.EventHandler(this.btsaveUser_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(69)))), ((int)(((byte)(255)))));
            this.panel5.Location = new System.Drawing.Point(61, 229);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(283, 3);
            this.panel5.TabIndex = 52;
            // 
            // textPass
            // 
            this.textPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textPass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.textPass.Location = new System.Drawing.Point(61, 195);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(283, 32);
            this.textPass.TabIndex = 51;
            this.textPass.Text = "password";
            this.textPass.UseSystemPasswordChar = true;
            this.textPass.Enter += new System.EventHandler(this.textPass_Enter);
            this.textPass.Leave += new System.EventHandler(this.textPass_Leave);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(69)))), ((int)(((byte)(255)))));
            this.panel4.Location = new System.Drawing.Point(61, 136);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(283, 3);
            this.panel4.TabIndex = 49;
            // 
            // textUser
            // 
            this.textUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.textUser.Location = new System.Drawing.Point(61, 102);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(283, 32);
            this.textUser.TabIndex = 48;
            this.textUser.Text = "username";
            this.textUser.Enter += new System.EventHandler(this.textUser_Enter);
            this.textUser.Leave += new System.EventHandler(this.textUser_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(69)))), ((int)(((byte)(255)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 10);
            this.panel1.TabIndex = 46;
            // 
            // titleUser
            // 
            this.titleUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleUser.AutoSize = true;
            this.titleUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(69)))), ((int)(((byte)(255)))));
            this.titleUser.Location = new System.Drawing.Point(84, 13);
            this.titleUser.Name = "titleUser";
            this.titleUser.Size = new System.Drawing.Size(177, 40);
            this.titleUser.TabIndex = 45;
            this.titleUser.Text = "Add User";
            // 
            // eyes
            // 
            this.eyes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.eyes.FlatAppearance.BorderSize = 0;
            this.eyes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eyes.Image = global::Gestion_Personne.Properties.Resources.icons8_eye_24px;
            this.eyes.Location = new System.Drawing.Point(308, 201);
            this.eyes.Name = "eyes";
            this.eyes.Size = new System.Drawing.Size(36, 20);
            this.eyes.TabIndex = 55;
            this.eyes.UseVisualStyleBackColor = true;
            this.eyes.Click += new System.EventHandler(this.eyes_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Image = global::Gestion_Personne.Properties.Resources.icons8_password_50px;
            this.pictureBox4.Location = new System.Drawing.Point(6, 182);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(51, 52);
            this.pictureBox4.TabIndex = 53;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::Gestion_Personne.Properties.Resources.icons8_user_50px;
            this.pictureBox3.Location = new System.Drawing.Point(6, 90);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 52);
            this.pictureBox3.TabIndex = 50;
            this.pictureBox3.TabStop = false;
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btExit.FlatAppearance.BorderSize = 0;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Image = global::Gestion_Personne.Properties.Resources.icons8_Close_40px;
            this.btExit.Location = new System.Drawing.Point(314, 13);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(36, 29);
            this.btExit.TabIndex = 47;
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // AddUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 349);
            this.Controls.Add(this.eyes);
            this.Controls.Add(this.btsaveUser);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titleUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddUpdateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUpdateUser";
            this.Load += new System.EventHandler(this.AddUpdateUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button eyes;
        public System.Windows.Forms.Button btsaveUser;
        public System.Windows.Forms.TextBox textPass;
        public System.Windows.Forms.Label titleUser;
    }
}