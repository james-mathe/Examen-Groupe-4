
namespace Gestion_Personne
{
    partial class Menu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSetting = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.btDecon = new System.Windows.Forms.Button();
            this.btCon = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btPhone = new System.Windows.Forms.Button();
            this.btPerson = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btMin = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btSettings = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panelSetting.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(69)))), ((int)(((byte)(255)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1176, 10);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(69)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.btAdd);
            this.panel2.Controls.Add(this.btPhone);
            this.panel2.Controls.Add(this.btPerson);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 696);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panelSetting
            // 
            this.panelSetting.BackColor = System.Drawing.Color.White;
            this.panelSetting.Controls.Add(this.btDecon);
            this.panelSetting.Controls.Add(this.btCon);
            this.panelSetting.Location = new System.Drawing.Point(276, 16);
            this.panelSetting.Name = "panelSetting";
            this.panelSetting.Size = new System.Drawing.Size(309, 117);
            this.panelSetting.TabIndex = 6;
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Controls.Add(this.controlPanel);
            this.mainPanel.Location = new System.Drawing.Point(201, 84);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(975, 622);
            this.mainPanel.TabIndex = 7;
            // 
            // controlPanel
            // 
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlPanel.Location = new System.Drawing.Point(0, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(975, 622);
            this.controlPanel.TabIndex = 8;
            // 
            // btDecon
            // 
            this.btDecon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btDecon.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btDecon.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDecon.ForeColor = System.Drawing.Color.Red;
            this.btDecon.Image = global::Gestion_Personne.Properties.Resources.icons8_disconnected_50px;
            this.btDecon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDecon.Location = new System.Drawing.Point(3, 60);
            this.btDecon.Name = "btDecon";
            this.btDecon.Size = new System.Drawing.Size(303, 52);
            this.btDecon.TabIndex = 8;
            this.btDecon.Text = "        Deconnection";
            this.btDecon.UseVisualStyleBackColor = true;
            this.btDecon.Click += new System.EventHandler(this.btDecon_Click);
            // 
            // btCon
            // 
            this.btCon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btCon.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btCon.FlatAppearance.BorderSize = 2;
            this.btCon.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCon.ForeColor = System.Drawing.Color.Green;
            this.btCon.Image = global::Gestion_Personne.Properties.Resources.icons8_connected_50px;
            this.btCon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCon.Location = new System.Drawing.Point(3, 5);
            this.btCon.Name = "btCon";
            this.btCon.Size = new System.Drawing.Size(303, 52);
            this.btCon.TabIndex = 7;
            this.btCon.Text = "        Connection";
            this.btCon.UseVisualStyleBackColor = true;
            this.btCon.Click += new System.EventHandler(this.btCon_Click);
            // 
            // btAdd
            // 
            this.btAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btAdd.FlatAppearance.BorderSize = 0;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.Color.White;
            this.btAdd.Image = global::Gestion_Personne.Properties.Resources.icons8_address_50px_1;
            this.btAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAdd.Location = new System.Drawing.Point(2, 419);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(198, 52);
            this.btAdd.TabIndex = 8;
            this.btAdd.Text = "       Adresses";
            this.btAdd.UseVisualStyleBackColor = true;
            // 
            // btPhone
            // 
            this.btPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btPhone.FlatAppearance.BorderSize = 0;
            this.btPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPhone.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPhone.ForeColor = System.Drawing.Color.White;
            this.btPhone.Image = global::Gestion_Personne.Properties.Resources.icons8_cell_phone_50px;
            this.btPhone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPhone.Location = new System.Drawing.Point(1, 347);
            this.btPhone.Name = "btPhone";
            this.btPhone.Size = new System.Drawing.Size(199, 52);
            this.btPhone.TabIndex = 7;
            this.btPhone.Text = "        Telephones";
            this.btPhone.UseVisualStyleBackColor = true;
            // 
            // btPerson
            // 
            this.btPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btPerson.FlatAppearance.BorderSize = 0;
            this.btPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPerson.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPerson.ForeColor = System.Drawing.Color.White;
            this.btPerson.Image = global::Gestion_Personne.Properties.Resources.icons8_add_user_group_man_man_50px;
            this.btPerson.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPerson.Location = new System.Drawing.Point(1, 275);
            this.btPerson.Name = "btPerson";
            this.btPerson.Size = new System.Drawing.Size(199, 52);
            this.btPerson.TabIndex = 6;
            this.btPerson.Text = "        Personnes";
            this.btPerson.UseVisualStyleBackColor = true;
            this.btPerson.Click += new System.EventHandler(this.btPerson_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Gestion_Personne.Properties.Resources.icons8_crowd_200px;
            this.pictureBox1.Location = new System.Drawing.Point(0, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 193);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btMin
            // 
            this.btMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMin.FlatAppearance.BorderSize = 0;
            this.btMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMin.Image = global::Gestion_Personne.Properties.Resources.icons8_subtract_50px;
            this.btMin.Location = new System.Drawing.Point(1064, 16);
            this.btMin.Name = "btMin";
            this.btMin.Size = new System.Drawing.Size(50, 52);
            this.btMin.TabIndex = 4;
            this.btMin.UseVisualStyleBackColor = true;
            this.btMin.Click += new System.EventHandler(this.btMin_Click);
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btExit.FlatAppearance.BorderSize = 0;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Image = global::Gestion_Personne.Properties.Resources.icons8_multiply_50px;
            this.btExit.Location = new System.Drawing.Point(1120, 16);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(50, 52);
            this.btExit.TabIndex = 3;
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btSettings
            // 
            this.btSettings.FlatAppearance.BorderSize = 0;
            this.btSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSettings.Image = global::Gestion_Personne.Properties.Resources.icons8_database_administrator_50px;
            this.btSettings.Location = new System.Drawing.Point(206, 16);
            this.btSettings.Name = "btSettings";
            this.btSettings.Size = new System.Drawing.Size(64, 62);
            this.btSettings.TabIndex = 2;
            this.btSettings.UseVisualStyleBackColor = true;
            this.btSettings.Click += new System.EventHandler(this.btSettings_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1176, 706);
            this.Controls.Add(this.panelSetting);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btMin);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btSettings);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelSetting.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btSettings;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btMin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btPerson;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btPhone;
        private System.Windows.Forms.Button btDecon;
        private System.Windows.Forms.Button btCon;
        public System.Windows.Forms.Panel panelSetting;
        private System.Windows.Forms.Panel mainPanel;
        public System.Windows.Forms.Panel controlPanel;
    }
}

