
namespace Gestion_Personne.Modals.Phones
{
    partial class AddUpdatePhone
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUpdatePhone));
            this.btsavePhone = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.comboCountry = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textnumber = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.titlePhone = new System.Windows.Forms.Label();
            this.textinitial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textfullname = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tablePerson = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btsavePhone
            // 
            this.btsavePhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btsavePhone.BackColor = System.Drawing.Color.White;
            this.btsavePhone.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(69)))), ((int)(((byte)(255)))));
            this.btsavePhone.FlatAppearance.BorderSize = 2;
            this.btsavePhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsavePhone.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsavePhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(69)))), ((int)(((byte)(255)))));
            this.btsavePhone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btsavePhone.Location = new System.Drawing.Point(468, 446);
            this.btsavePhone.Name = "btsavePhone";
            this.btsavePhone.Size = new System.Drawing.Size(353, 48);
            this.btsavePhone.TabIndex = 65;
            this.btsavePhone.Text = "Add";
            this.btsavePhone.UseVisualStyleBackColor = false;
            this.btsavePhone.Click += new System.EventHandler(this.btsavePerson_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(69)))), ((int)(((byte)(255)))));
            this.panel5.Location = new System.Drawing.Point(517, 239);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(303, 3);
            this.panel5.TabIndex = 63;
            // 
            // comboCountry
            // 
            this.comboCountry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboCountry.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboCountry.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.comboCountry.FormattingEnabled = true;
            this.comboCountry.Items.AddRange(new object[] {
            "M",
            "F"});
            this.comboCountry.Location = new System.Drawing.Point(517, 197);
            this.comboCountry.Name = "comboCountry";
            this.comboCountry.Size = new System.Drawing.Size(304, 40);
            this.comboCountry.TabIndex = 62;
            this.comboCountry.Text = "Select Country";
            this.comboCountry.SelectedIndexChanged += new System.EventHandler(this.comboCountry_SelectedIndexChanged);
            this.comboCountry.Enter += new System.EventHandler(this.comboCountry_Enter);
            this.comboCountry.Leave += new System.EventHandler(this.comboCountry_Leave);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(69)))), ((int)(((byte)(255)))));
            this.panel3.Location = new System.Drawing.Point(515, 313);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(305, 3);
            this.panel3.TabIndex = 60;
            // 
            // textnumber
            // 
            this.textnumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textnumber.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textnumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textnumber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textnumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.textnumber.Location = new System.Drawing.Point(585, 278);
            this.textnumber.MaxLength = 9;
            this.textnumber.Name = "textnumber";
            this.textnumber.Size = new System.Drawing.Size(235, 32);
            this.textnumber.TabIndex = 59;
            this.textnumber.Text = "9xx";
            this.textnumber.Enter += new System.EventHandler(this.textnumber_Enter);
            this.textnumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textnumber_KeyPress);
            this.textnumber.Leave += new System.EventHandler(this.textnumber_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(69)))), ((int)(((byte)(255)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 10);
            this.panel1.TabIndex = 57;
            // 
            // titlePhone
            // 
            this.titlePhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titlePhone.AutoSize = true;
            this.titlePhone.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlePhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(69)))), ((int)(((byte)(255)))));
            this.titlePhone.Location = new System.Drawing.Point(302, 15);
            this.titlePhone.Name = "titlePhone";
            this.titlePhone.Size = new System.Drawing.Size(232, 40);
            this.titlePhone.TabIndex = 56;
            this.titlePhone.Text = "Add Number";
            // 
            // textinitial
            // 
            this.textinitial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textinitial.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textinitial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textinitial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textinitial.ForeColor = System.Drawing.Color.DimGray;
            this.textinitial.Location = new System.Drawing.Point(515, 278);
            this.textinitial.MaxLength = 4;
            this.textinitial.Name = "textinitial";
            this.textinitial.ReadOnly = true;
            this.textinitial.Size = new System.Drawing.Size(64, 32);
            this.textinitial.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(69)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(463, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 32);
            this.label1.TabIndex = 67;
            this.label1.Text = "FullName";
            // 
            // textfullname
            // 
            this.textfullname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textfullname.AutoSize = true;
            this.textfullname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textfullname.ForeColor = System.Drawing.Color.DimGray;
            this.textfullname.Location = new System.Drawing.Point(463, 124);
            this.textfullname.Name = "textfullname";
            this.textfullname.Size = new System.Drawing.Size(0, 32);
            this.textfullname.TabIndex = 68;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tablePerson);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.textSearch);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(69)))), ((int)(((byte)(255)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 436);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Person";
            // 
            // tablePerson
            // 
            this.tablePerson.AllowUserToAddRows = false;
            this.tablePerson.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            this.tablePerson.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablePerson.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePerson.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablePerson.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tablePerson.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablePerson.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(69)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablePerson.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablePerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablePerson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.id,
            this.nam,
            this.LName,
            this.fName});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(69)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(69)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablePerson.DefaultCellStyle = dataGridViewCellStyle3;
            this.tablePerson.EnableHeadersVisualStyles = false;
            this.tablePerson.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(69)))), ((int)(((byte)(255)))));
            this.tablePerson.Location = new System.Drawing.Point(6, 74);
            this.tablePerson.MultiSelect = false;
            this.tablePerson.Name = "tablePerson";
            this.tablePerson.ReadOnly = true;
            this.tablePerson.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tablePerson.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DimGray;
            this.tablePerson.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tablePerson.RowTemplate.Height = 30;
            this.tablePerson.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tablePerson.Size = new System.Drawing.Size(437, 354);
            this.tablePerson.TabIndex = 29;
            this.tablePerson.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablePerson_CellContentClick);
            this.tablePerson.Click += new System.EventHandler(this.tablePerson_Click);
            // 
            // num
            // 
            this.num.FillWeight = 25F;
            this.num.HeaderText = "#";
            this.num.Name = "num";
            this.num.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "idP";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // nam
            // 
            this.nam.HeaderText = "Name";
            this.nam.Name = "nam";
            this.nam.ReadOnly = true;
            // 
            // LName
            // 
            this.LName.HeaderText = "Last-Name";
            this.LName.Name = "LName";
            this.LName.ReadOnly = true;
            // 
            // fName
            // 
            this.fName.HeaderText = "First-Name";
            this.fName.Name = "fName";
            this.fName.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(69)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(6, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(437, 3);
            this.panel2.TabIndex = 29;
            // 
            // textSearch
            // 
            this.textSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSearch.BackColor = System.Drawing.SystemColors.Control;
            this.textSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.textSearch.Location = new System.Drawing.Point(6, 31);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(437, 32);
            this.textSearch.TabIndex = 28;
            this.textSearch.Text = "Search";
            this.textSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            this.textSearch.Enter += new System.EventHandler(this.textSearch_Enter);
            this.textSearch.Leave += new System.EventHandler(this.textSearch_Leave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Gestion_Personne.Properties.Resources.icons8_country_50px;
            this.pictureBox4.Location = new System.Drawing.Point(469, 188);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(45, 57);
            this.pictureBox4.TabIndex = 64;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::Gestion_Personne.Properties.Resources.icons8_phone_50px;
            this.pictureBox2.Location = new System.Drawing.Point(467, 269);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 52);
            this.pictureBox2.TabIndex = 61;
            this.pictureBox2.TabStop = false;
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btExit.FlatAppearance.BorderSize = 0;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Image = global::Gestion_Personne.Properties.Resources.icons8_Close_40px;
            this.btExit.Location = new System.Drawing.Point(794, 15);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(36, 29);
            this.btExit.TabIndex = 58;
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // AddUpdatePhone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 512);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textfullname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textinitial);
            this.Controls.Add(this.btsavePhone);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.comboCountry);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textnumber);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titlePhone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddUpdatePhone";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUpdatePhone";
            this.Load += new System.EventHandler(this.AddUpdatePhone_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btsavePhone;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.ComboBox comboCountry;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.TextBox textnumber;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label titlePhone;
        public System.Windows.Forms.TextBox textinitial;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label textfullname;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView tablePerson;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nam;
        private System.Windows.Forms.DataGridViewTextBoxColumn LName;
        private System.Windows.Forms.DataGridViewTextBoxColumn fName;
    }
}