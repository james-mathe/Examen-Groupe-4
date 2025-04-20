
namespace Gestion_Personne.Modals.Address
{
    partial class AddUpdateAddress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUpdateAddress));
            this.fName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablePerson = new System.Windows.Forms.DataGridView();
            this.LName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textfullname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btsaveAddress = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.comboCountry = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textCity = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.titleAddress = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textTown = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textqua = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textAv = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablePerson)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // fName
            // 
            this.fName.HeaderText = "First-Name";
            this.fName.Name = "fName";
            this.fName.ReadOnly = true;
            // 
            // nam
            // 
            this.nam.HeaderText = "Name";
            this.nam.Name = "nam";
            this.nam.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "idP";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // num
            // 
            this.num.FillWeight = 25F;
            this.num.HeaderText = "#";
            this.num.Name = "num";
            this.num.ReadOnly = true;
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
            this.tablePerson.Size = new System.Drawing.Size(437, 426);
            this.tablePerson.TabIndex = 29;
            this.tablePerson.Click += new System.EventHandler(this.tablePerson_Click);
            // 
            // LName
            // 
            this.LName.HeaderText = "Last-Name";
            this.LName.Name = "LName";
            this.LName.ReadOnly = true;
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
            this.textSearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.textSearch.Location = new System.Drawing.Point(6, 40);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(437, 25);
            this.textSearch.TabIndex = 28;
            this.textSearch.Text = "Search";
            this.textSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            this.textSearch.Enter += new System.EventHandler(this.textSearch_Enter);
            this.textSearch.Leave += new System.EventHandler(this.textSearch_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tablePerson);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.textSearch);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(69)))), ((int)(((byte)(255)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 508);
            this.groupBox1.TabIndex = 83;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Person";
            // 
            // textfullname
            // 
            this.textfullname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textfullname.AutoSize = true;
            this.textfullname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textfullname.ForeColor = System.Drawing.Color.DimGray;
            this.textfullname.Location = new System.Drawing.Point(469, 115);
            this.textfullname.Name = "textfullname";
            this.textfullname.Size = new System.Drawing.Size(0, 32);
            this.textfullname.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(69)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(463, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 32);
            this.label1.TabIndex = 81;
            this.label1.Text = "FullName";
            // 
            // btsaveAddress
            // 
            this.btsaveAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btsaveAddress.BackColor = System.Drawing.Color.White;
            this.btsaveAddress.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(69)))), ((int)(((byte)(255)))));
            this.btsaveAddress.FlatAppearance.BorderSize = 2;
            this.btsaveAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsaveAddress.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsaveAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(69)))), ((int)(((byte)(255)))));
            this.btsaveAddress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btsaveAddress.Location = new System.Drawing.Point(469, 519);
            this.btsaveAddress.Name = "btsaveAddress";
            this.btsaveAddress.Size = new System.Drawing.Size(353, 48);
            this.btsaveAddress.TabIndex = 79;
            this.btsaveAddress.Text = "Add";
            this.btsaveAddress.UseVisualStyleBackColor = false;
            this.btsaveAddress.Click += new System.EventHandler(this.btsaveAddress_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(69)))), ((int)(((byte)(255)))));
            this.panel5.Location = new System.Drawing.Point(515, 219);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(305, 3);
            this.panel5.TabIndex = 77;
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
            this.comboCountry.Location = new System.Drawing.Point(515, 177);
            this.comboCountry.Name = "comboCountry";
            this.comboCountry.Size = new System.Drawing.Size(306, 40);
            this.comboCountry.TabIndex = 76;
            this.comboCountry.Text = "Select Country";
            this.comboCountry.Enter += new System.EventHandler(this.comboCountry_Enter);
            this.comboCountry.Leave += new System.EventHandler(this.comboCountry_Leave);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(69)))), ((int)(((byte)(255)))));
            this.panel3.Location = new System.Drawing.Point(515, 287);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(305, 3);
            this.panel3.TabIndex = 74;
            // 
            // textCity
            // 
            this.textCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textCity.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.textCity.Location = new System.Drawing.Point(517, 252);
            this.textCity.MaxLength = 9;
            this.textCity.Name = "textCity";
            this.textCity.Size = new System.Drawing.Size(303, 32);
            this.textCity.TabIndex = 73;
            this.textCity.Text = "City";
            this.textCity.Enter += new System.EventHandler(this.textCity_Enter);
            this.textCity.Leave += new System.EventHandler(this.textCity_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(69)))), ((int)(((byte)(255)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 10);
            this.panel1.TabIndex = 71;
            // 
            // titleAddress
            // 
            this.titleAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleAddress.AutoSize = true;
            this.titleAddress.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(69)))), ((int)(((byte)(255)))));
            this.titleAddress.Location = new System.Drawing.Point(302, 16);
            this.titleAddress.Name = "titleAddress";
            this.titleAddress.Size = new System.Drawing.Size(238, 40);
            this.titleAddress.TabIndex = 70;
            this.titleAddress.Text = "Add Address";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(69)))), ((int)(((byte)(255)))));
            this.panel4.Location = new System.Drawing.Point(515, 355);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(305, 3);
            this.panel4.TabIndex = 85;
            // 
            // textTown
            // 
            this.textTown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textTown.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textTown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textTown.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.textTown.Location = new System.Drawing.Point(517, 320);
            this.textTown.MaxLength = 9;
            this.textTown.Name = "textTown";
            this.textTown.Size = new System.Drawing.Size(303, 32);
            this.textTown.TabIndex = 84;
            this.textTown.Text = "Town";
            this.textTown.Enter += new System.EventHandler(this.textTown_Enter);
            this.textTown.Leave += new System.EventHandler(this.textTown_Leave);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(69)))), ((int)(((byte)(255)))));
            this.panel6.Location = new System.Drawing.Point(516, 423);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(305, 3);
            this.panel6.TabIndex = 88;
            // 
            // textqua
            // 
            this.textqua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textqua.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textqua.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textqua.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textqua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.textqua.Location = new System.Drawing.Point(518, 388);
            this.textqua.MaxLength = 9;
            this.textqua.Name = "textqua";
            this.textqua.Size = new System.Drawing.Size(303, 32);
            this.textqua.TabIndex = 87;
            this.textqua.Text = "Quarter";
            this.textqua.Enter += new System.EventHandler(this.textqua_Enter);
            this.textqua.Leave += new System.EventHandler(this.textqua_Leave);
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(69)))), ((int)(((byte)(255)))));
            this.panel7.Location = new System.Drawing.Point(516, 492);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(305, 3);
            this.panel7.TabIndex = 91;
            // 
            // textAv
            // 
            this.textAv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textAv.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textAv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textAv.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.textAv.Location = new System.Drawing.Point(518, 457);
            this.textAv.MaxLength = 9;
            this.textAv.Name = "textAv";
            this.textAv.Size = new System.Drawing.Size(303, 32);
            this.textAv.TabIndex = 90;
            this.textAv.Text = "Avenue";
            this.textAv.Enter += new System.EventHandler(this.textAv_Enter);
            this.textAv.Leave += new System.EventHandler(this.textAv_Leave);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.Image = global::Gestion_Personne.Properties.Resources.icons8_streets_50px;
            this.pictureBox5.Location = new System.Drawing.Point(468, 448);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(45, 52);
            this.pictureBox5.TabIndex = 92;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::Gestion_Personne.Properties.Resources.icons8_city_hall_50px;
            this.pictureBox3.Location = new System.Drawing.Point(468, 379);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 52);
            this.pictureBox3.TabIndex = 89;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Gestion_Personne.Properties.Resources.icons8_embassy_50px;
            this.pictureBox1.Location = new System.Drawing.Point(467, 311);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 52);
            this.pictureBox1.TabIndex = 86;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Gestion_Personne.Properties.Resources.icons8_country_50px;
            this.pictureBox4.Location = new System.Drawing.Point(467, 168);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(45, 57);
            this.pictureBox4.TabIndex = 78;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::Gestion_Personne.Properties.Resources.icons8_city_50px;
            this.pictureBox2.Location = new System.Drawing.Point(467, 243);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 52);
            this.pictureBox2.TabIndex = 75;
            this.pictureBox2.TabStop = false;
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btExit.FlatAppearance.BorderSize = 0;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Image = global::Gestion_Personne.Properties.Resources.icons8_Close_40px;
            this.btExit.Location = new System.Drawing.Point(794, 16);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(36, 29);
            this.btExit.TabIndex = 72;
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // AddUpdateAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 579);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.textAv);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.textqua);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textTown);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textfullname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btsaveAddress);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.comboCountry);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textCity);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titleAddress);
            this.Controls.Add(this.btExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddUpdateAddress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUpdateAddress";
            this.Load += new System.EventHandler(this.AddUpdateAddress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePerson)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn fName;
        private System.Windows.Forms.DataGridViewTextBoxColumn nam;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        public System.Windows.Forms.DataGridView tablePerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn LName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label textfullname;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btsaveAddress;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.ComboBox comboCountry;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.TextBox textCity;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label titleAddress;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox textTown;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.TextBox textqua;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox5;
        public System.Windows.Forms.TextBox textAv;
    }
}