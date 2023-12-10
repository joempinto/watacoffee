namespace WPC_1
{
    partial class User_PayMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_PayMenu));
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            op1ToolStripMenuItem = new ToolStripMenuItem();
            iniciStripMenuItem = new ToolStripMenuItem();
            logoutStripMenuItem = new ToolStripMenuItem();
            pageLocation = new Label();
            label6 = new Label();
            listView1 = new ListView();
            listView2 = new ListView();
            label1 = new Label();
            groupBoxSeleccio = new GroupBox();
            comboBox1 = new ComboBox();
            columnHeaderGroupID = new ColumnHeader();
            columnHeaderNomGroup = new ColumnHeader();
            columnHeaderMembreID = new ColumnHeader();
            columnHeaderNickname = new ColumnHeader();
            columnHeaderIsAdmin = new ColumnHeader();
            groupBox1 = new GroupBox();
            buttonConfirmaPayment = new Button();
            membreEscollit = new TextBox();
            labelMembreEscollit = new Label();
            grupEscollit = new TextBox();
            labelGrupEscollit = new Label();
            labelDataPagament = new Label();
            datePagament = new DateTimePicker();
            textBoxQuantitat = new TextBox();
            label7 = new Label();
            groupBoxParamEscollits = new GroupBox();
            pictureBoxTicket = new PictureBox();
            labelTicket = new Label();
            menuStrip1.SuspendLayout();
            groupBoxSeleccio.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBoxParamEscollits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTicket).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(107, 55, 35);
            label2.Location = new Point(323, 115);
            label2.Name = "label2";
            label2.Size = new Size(428, 60);
            label2.TabIndex = 23;
            label2.Text = "Afegeix Pagament";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { op1ToolStripMenuItem });
            menuStrip1.Location = new Point(38, 31);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(81, 57);
            menuStrip1.TabIndex = 27;
            menuStrip1.Text = "menuStrip1";
            // 
            // op1ToolStripMenuItem
            // 
            op1ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { iniciStripMenuItem, logoutStripMenuItem });
            op1ToolStripMenuItem.Image = Properties.Resources.main_coffee;
            op1ToolStripMenuItem.Name = "op1ToolStripMenuItem";
            op1ToolStripMenuItem.Size = new Size(73, 53);
            op1ToolStripMenuItem.Text = "Menu";
            op1ToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // iniciStripMenuItem
            // 
            iniciStripMenuItem.Name = "iniciStripMenuItem";
            iniciStripMenuItem.Size = new Size(213, 34);
            iniciStripMenuItem.Text = "Menú Usuari";
            // 
            // logoutStripMenuItem
            // 
            logoutStripMenuItem.Name = "logoutStripMenuItem";
            logoutStripMenuItem.Size = new Size(213, 34);
            logoutStripMenuItem.Text = "Logout";
            // 
            // pageLocation
            // 
            pageLocation.AutoSize = true;
            pageLocation.BackColor = Color.Transparent;
            pageLocation.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            pageLocation.ForeColor = Color.FromArgb(107, 55, 50);
            pageLocation.Location = new Point(126, 45);
            pageLocation.Name = "pageLocation";
            pageLocation.Size = new Size(662, 28);
            pageLocation.TabIndex = 26;
            pageLocation.Text = "location: Username>MenuUsuari>PagamentsiEstadistiques>Pagaments";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = Color.FromArgb(107, 55, 35);
            label6.Location = new Point(57, 39);
            label6.Name = "label6";
            label6.Size = new Size(56, 28);
            label6.TabIndex = 29;
            label6.Text = "Grup";
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.None;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeaderGroupID, columnHeaderNomGroup });
            listView1.Location = new Point(57, 75);
            listView1.Name = "listView1";
            listView1.Size = new Size(586, 170);
            listView1.TabIndex = 30;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // listView2
            // 
            listView2.Anchor = AnchorStyles.None;
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeaderMembreID, columnHeaderNickname, columnHeaderIsAdmin });
            listView2.Location = new Point(57, 287);
            listView2.Name = "listView2";
            listView2.Size = new Size(586, 213);
            listView2.TabIndex = 32;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.FromArgb(107, 55, 35);
            label1.Location = new Point(57, 259);
            label1.Name = "label1";
            label1.Size = new Size(86, 28);
            label1.TabIndex = 31;
            label1.Text = "Membre";
            // 
            // groupBoxSeleccio
            // 
            groupBoxSeleccio.Anchor = AnchorStyles.None;
            groupBoxSeleccio.BackColor = Color.Transparent;
            groupBoxSeleccio.Controls.Add(comboBox1);
            groupBoxSeleccio.Controls.Add(listView2);
            groupBoxSeleccio.Controls.Add(label1);
            groupBoxSeleccio.Controls.Add(listView1);
            groupBoxSeleccio.Controls.Add(label6);
            groupBoxSeleccio.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxSeleccio.ForeColor = Color.FromArgb(107, 55, 35);
            groupBoxSeleccio.Location = new Point(182, 187);
            groupBoxSeleccio.Name = "groupBoxSeleccio";
            groupBoxSeleccio.Size = new Size(694, 519);
            groupBoxSeleccio.TabIndex = 33;
            groupBoxSeleccio.TabStop = false;
            groupBoxSeleccio.Text = "Àrea de selecció";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "En sóc Admin", "En sóc Membre", "Tots" });
            comboBox1.Location = new Point(141, 39);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 36);
            comboBox1.TabIndex = 34;
            comboBox1.Text = "Filtra si...";
            // 
            // columnHeaderGroupID
            // 
            columnHeaderGroupID.Text = "ID del Grup";
            columnHeaderGroupID.Width = 131;
            // 
            // columnHeaderNomGroup
            // 
            columnHeaderNomGroup.Text = "Nom del Grup";
            columnHeaderNomGroup.Width = 451;
            // 
            // columnHeaderMembreID
            // 
            columnHeaderMembreID.Text = "ID Membre";
            columnHeaderMembreID.Width = 131;
            // 
            // columnHeaderNickname
            // 
            columnHeaderNickname.Text = "Nickname";
            columnHeaderNickname.Width = 131;
            // 
            // columnHeaderIsAdmin
            // 
            columnHeaderIsAdmin.Text = "Is Admin?";
            columnHeaderIsAdmin.Width = 131;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(labelTicket);
            groupBox1.Controls.Add(pictureBoxTicket);
            groupBox1.Controls.Add(groupBoxParamEscollits);
            groupBox1.Controls.Add(textBoxQuantitat);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(datePagament);
            groupBox1.Controls.Add(labelDataPagament);
            groupBox1.Controls.Add(buttonConfirmaPayment);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.FromArgb(107, 55, 35);
            groupBox1.Location = new Point(64, 738);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(940, 291);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Àrea Pagament";
            // 
            // buttonConfirmaPayment
            // 
            buttonConfirmaPayment.Anchor = AnchorStyles.None;
            buttonConfirmaPayment.BackColor = Color.FromArgb(107, 55, 35);
            buttonConfirmaPayment.FlatStyle = FlatStyle.Popup;
            buttonConfirmaPayment.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonConfirmaPayment.ForeColor = Color.FromArgb(64, 0, 0);
            buttonConfirmaPayment.Location = new Point(708, 123);
            buttonConfirmaPayment.Name = "buttonConfirmaPayment";
            buttonConfirmaPayment.Size = new Size(202, 93);
            buttonConfirmaPayment.TabIndex = 37;
            buttonConfirmaPayment.Text = "Confirmar";
            buttonConfirmaPayment.UseVisualStyleBackColor = false;
            // 
            // membreEscollit
            // 
            membreEscollit.Anchor = AnchorStyles.None;
            membreEscollit.Enabled = false;
            membreEscollit.Location = new Point(11, 151);
            membreEscollit.Name = "membreEscollit";
            membreEscollit.Size = new Size(274, 34);
            membreEscollit.TabIndex = 36;
            membreEscollit.UseSystemPasswordChar = true;
            // 
            // labelMembreEscollit
            // 
            labelMembreEscollit.Anchor = AnchorStyles.None;
            labelMembreEscollit.AutoSize = true;
            labelMembreEscollit.BackColor = Color.Transparent;
            labelMembreEscollit.ForeColor = Color.FromArgb(107, 55, 35);
            labelMembreEscollit.Location = new Point(11, 120);
            labelMembreEscollit.Name = "labelMembreEscollit";
            labelMembreEscollit.Size = new Size(187, 28);
            labelMembreEscollit.TabIndex = 35;
            labelMembreEscollit.Text = "Membre seleccionat";
            // 
            // grupEscollit
            // 
            grupEscollit.Anchor = AnchorStyles.None;
            grupEscollit.Enabled = false;
            grupEscollit.Location = new Point(11, 72);
            grupEscollit.Name = "grupEscollit";
            grupEscollit.Size = new Size(274, 34);
            grupEscollit.TabIndex = 34;
            grupEscollit.UseSystemPasswordChar = true;
            // 
            // labelGrupEscollit
            // 
            labelGrupEscollit.Anchor = AnchorStyles.None;
            labelGrupEscollit.AutoSize = true;
            labelGrupEscollit.BackColor = Color.Transparent;
            labelGrupEscollit.ForeColor = Color.FromArgb(107, 55, 35);
            labelGrupEscollit.Location = new Point(11, 41);
            labelGrupEscollit.Name = "labelGrupEscollit";
            labelGrupEscollit.Size = new Size(157, 28);
            labelGrupEscollit.TabIndex = 33;
            labelGrupEscollit.Text = "Grup seleccionat";
            // 
            // labelDataPagament
            // 
            labelDataPagament.Anchor = AnchorStyles.None;
            labelDataPagament.AutoSize = true;
            labelDataPagament.BackColor = Color.Transparent;
            labelDataPagament.ForeColor = Color.FromArgb(107, 55, 35);
            labelDataPagament.Location = new Point(352, 51);
            labelDataPagament.Name = "labelDataPagament";
            labelDataPagament.Size = new Size(179, 28);
            labelDataPagament.TabIndex = 38;
            labelDataPagament.Text = "Data del pagament";
            // 
            // datePagament
            // 
            datePagament.Anchor = AnchorStyles.None;
            datePagament.CustomFormat = "yyyy-MM-dd";
            datePagament.Format = DateTimePickerFormat.Custom;
            datePagament.Location = new Point(352, 87);
            datePagament.Name = "datePagament";
            datePagament.Size = new Size(300, 34);
            datePagament.TabIndex = 39;
            datePagament.Value = new DateTime(2023, 12, 8, 18, 33, 48, 0);
            // 
            // textBoxQuantitat
            // 
            textBoxQuantitat.Anchor = AnchorStyles.None;
            textBoxQuantitat.Enabled = false;
            textBoxQuantitat.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxQuantitat.Location = new Point(352, 181);
            textBoxQuantitat.Name = "textBoxQuantitat";
            textBoxQuantitat.Size = new Size(300, 48);
            textBoxQuantitat.TabIndex = 41;
            textBoxQuantitat.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.ForeColor = Color.FromArgb(107, 55, 35);
            label7.Location = new Point(352, 150);
            label7.Name = "label7";
            label7.Size = new Size(123, 28);
            label7.TabIndex = 40;
            label7.Text = "Quantitat (€)";
            // 
            // groupBoxParamEscollits
            // 
            groupBoxParamEscollits.Anchor = AnchorStyles.None;
            groupBoxParamEscollits.Controls.Add(membreEscollit);
            groupBoxParamEscollits.Controls.Add(labelMembreEscollit);
            groupBoxParamEscollits.Controls.Add(grupEscollit);
            groupBoxParamEscollits.Controls.Add(labelGrupEscollit);
            groupBoxParamEscollits.Enabled = false;
            groupBoxParamEscollits.Location = new Point(19, 51);
            groupBoxParamEscollits.Name = "groupBoxParamEscollits";
            groupBoxParamEscollits.Size = new Size(302, 212);
            groupBoxParamEscollits.TabIndex = 42;
            groupBoxParamEscollits.TabStop = false;
            groupBoxParamEscollits.Text = "Selecció feta";
            // 
            // pictureBoxTicket
            // 
            pictureBoxTicket.Anchor = AnchorStyles.None;
            pictureBoxTicket.BackColor = Color.Transparent;
            pictureBoxTicket.Image = (Image)resources.GetObject("pictureBoxTicket.Image");
            pictureBoxTicket.Location = new Point(423, 245);
            pictureBoxTicket.Name = "pictureBoxTicket";
            pictureBoxTicket.Size = new Size(35, 32);
            pictureBoxTicket.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxTicket.TabIndex = 43;
            pictureBoxTicket.TabStop = false;
            // 
            // labelTicket
            // 
            labelTicket.Anchor = AnchorStyles.None;
            labelTicket.AutoSize = true;
            labelTicket.BackColor = Color.Transparent;
            labelTicket.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelTicket.ForeColor = Color.FromArgb(107, 55, 35);
            labelTicket.Location = new Point(464, 251);
            labelTicket.Name = "labelTicket";
            labelTicket.Size = new Size(104, 21);
            labelTicket.TabIndex = 44;
            labelTicket.Text = "Upload Ticket";
            // 
            // User_PayMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1035, 1050);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxSeleccio);
            Controls.Add(menuStrip1);
            Controls.Add(pageLocation);
            Controls.Add(label2);
            Name = "User_PayMenu";
            Text = "Menu Pagaments";
            Load += User_PayMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBoxSeleccio.ResumeLayout(false);
            groupBoxSeleccio.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxParamEscollits.ResumeLayout(false);
            groupBoxParamEscollits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTicket).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem op1ToolStripMenuItem;
        private ToolStripMenuItem iniciStripMenuItem;
        private ToolStripMenuItem logoutStripMenuItem;
        private Label pageLocation;
        private Label label6;
        private ListView listView1;
        private ListView listView2;
        private Label label1;
        private GroupBox groupBoxSeleccio;
        private ComboBox comboBox1;
        private ColumnHeader columnHeaderGroupID;
        private ColumnHeader columnHeaderNomGroup;
        private ColumnHeader columnHeaderMembreID;
        private ColumnHeader columnHeaderNickname;
        private ColumnHeader columnHeaderIsAdmin;
        private GroupBox groupBox1;
        private Button buttonConfirmaPayment;
        private TextBox membreEscollit;
        private Label labelMembreEscollit;
        private TextBox grupEscollit;
        private Label labelGrupEscollit;
        private DateTimePicker datePagament;
        private Label labelDataPagament;
        private TextBox textBoxQuantitat;
        private Label label7;
        private GroupBox groupBoxParamEscollits;
        private PictureBox pictureBoxTicket;
        private Label labelTicket;
    }
}