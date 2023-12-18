namespace WPC_1
{
    partial class User_deletePagament
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_deletePagament));
            menuStrip1 = new MenuStrip();
            op1ToolStripMenuItem = new ToolStripMenuItem();
            iniciStripMenuItem = new ToolStripMenuItem();
            logoutStripMenuItem = new ToolStripMenuItem();
            pageLocation = new Label();
            label2 = new Label();
            groupBoxSeleccio = new GroupBox();
            comboBox1 = new ComboBox();
            listGrupsTipus = new ListView();
            columnHeaderGroupID = new ColumnHeader();
            columnHeaderNomGroup = new ColumnHeader();
            label6 = new Label();
            listPagamentsGrup = new ListView();
            columnHeaderIsMember = new ColumnHeader();
            columnHeaderNickname = new ColumnHeader();
            columnHeaderAmount = new ColumnHeader();
            columnHeaderData = new ColumnHeader();
            eliminaPagamentBtn = new Button();
            labelCancelListMembres = new Label();
            numGrupTxt = new TextBox();
            numPagamentTxt = new TextBox();
            refreshBtn = new Button();
            menuStrip1.SuspendLayout();
            groupBoxSeleccio.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { op1ToolStripMenuItem });
            menuStrip1.Location = new Point(25, 20);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(261, 57);
            menuStrip1.TabIndex = 30;
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
            iniciStripMenuItem.Size = new Size(270, 34);
            iniciStripMenuItem.Text = "Menú Usuari";
            iniciStripMenuItem.Click += iniciStripMenuItem_Click;
            // 
            // logoutStripMenuItem
            // 
            logoutStripMenuItem.Name = "logoutStripMenuItem";
            logoutStripMenuItem.Size = new Size(270, 34);
            logoutStripMenuItem.Text = "Logout";
            logoutStripMenuItem.Click += logoutStripMenuItem_Click;
            // 
            // pageLocation
            // 
            pageLocation.AutoSize = true;
            pageLocation.BackColor = Color.Transparent;
            pageLocation.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            pageLocation.ForeColor = Color.FromArgb(107, 55, 50);
            pageLocation.Location = new Point(113, 34);
            pageLocation.Name = "pageLocation";
            pageLocation.Size = new Size(662, 28);
            pageLocation.TabIndex = 29;
            pageLocation.Text = "location: Username>MenuUsuari>PagamentsiEstadistiques>Pagaments";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(107, 55, 35);
            label2.Location = new Point(298, 63);
            label2.Name = "label2";
            label2.Size = new Size(418, 60);
            label2.TabIndex = 28;
            label2.Text = "Elimina Pagament";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBoxSeleccio
            // 
            groupBoxSeleccio.Anchor = AnchorStyles.None;
            groupBoxSeleccio.BackColor = Color.Transparent;
            groupBoxSeleccio.Controls.Add(comboBox1);
            groupBoxSeleccio.Controls.Add(listGrupsTipus);
            groupBoxSeleccio.Controls.Add(label6);
            groupBoxSeleccio.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxSeleccio.ForeColor = Color.FromArgb(107, 55, 35);
            groupBoxSeleccio.Location = new Point(141, 126);
            groupBoxSeleccio.Name = "groupBoxSeleccio";
            groupBoxSeleccio.Size = new Size(694, 287);
            groupBoxSeleccio.TabIndex = 34;
            groupBoxSeleccio.TabStop = false;
            groupBoxSeleccio.Text = "Àrea de selecció";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "En sóc Admin", "En sóc Membre", "Tots" });
            comboBox1.Location = new Point(144, 30);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 36);
            comboBox1.TabIndex = 34;
            comboBox1.Text = "Filtra si...";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // listGrupsTipus
            // 
            listGrupsTipus.Anchor = AnchorStyles.None;
            listGrupsTipus.Columns.AddRange(new ColumnHeader[] { columnHeaderGroupID, columnHeaderNomGroup });
            listGrupsTipus.FullRowSelect = true;
            listGrupsTipus.Location = new Point(56, 67);
            listGrupsTipus.MultiSelect = false;
            listGrupsTipus.Name = "listGrupsTipus";
            listGrupsTipus.Size = new Size(586, 209);
            listGrupsTipus.TabIndex = 30;
            listGrupsTipus.UseCompatibleStateImageBehavior = false;
            listGrupsTipus.View = View.Details;
            listGrupsTipus.SelectedIndexChanged += listGrupsTipus_SelectedIndexChanged;
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
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = Color.FromArgb(107, 55, 35);
            label6.Location = new Point(56, 31);
            label6.Name = "label6";
            label6.Size = new Size(56, 28);
            label6.TabIndex = 29;
            label6.Text = "Grup";
            // 
            // listPagamentsGrup
            // 
            listPagamentsGrup.Anchor = AnchorStyles.None;
            listPagamentsGrup.Columns.AddRange(new ColumnHeader[] { columnHeaderIsMember, columnHeaderNickname, columnHeaderAmount, columnHeaderData });
            listPagamentsGrup.FullRowSelect = true;
            listPagamentsGrup.Location = new Point(157, 424);
            listPagamentsGrup.MultiSelect = false;
            listPagamentsGrup.Name = "listPagamentsGrup";
            listPagamentsGrup.Size = new Size(664, 374);
            listPagamentsGrup.TabIndex = 37;
            listPagamentsGrup.UseCompatibleStateImageBehavior = false;
            listPagamentsGrup.View = View.Details;
            listPagamentsGrup.SelectedIndexChanged += listPagamentsGrup_SelectedIndexChanged;
            // 
            // columnHeaderIsMember
            // 
            columnHeaderIsMember.Text = "És Membre?";
            columnHeaderIsMember.Width = 131;
            // 
            // columnHeaderNickname
            // 
            columnHeaderNickname.Text = "Nickname";
            columnHeaderNickname.Width = 131;
            // 
            // columnHeaderAmount
            // 
            columnHeaderAmount.Text = "Quantitat";
            columnHeaderAmount.Width = 131;
            // 
            // columnHeaderData
            // 
            columnHeaderData.Text = "Data Pagament";
            columnHeaderData.Width = 150;
            // 
            // eliminaPagamentBtn
            // 
            eliminaPagamentBtn.Anchor = AnchorStyles.None;
            eliminaPagamentBtn.BackColor = Color.FromArgb(107, 55, 35);
            eliminaPagamentBtn.Enabled = false;
            eliminaPagamentBtn.FlatStyle = FlatStyle.Popup;
            eliminaPagamentBtn.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            eliminaPagamentBtn.ForeColor = Color.FromArgb(64, 0, 0);
            eliminaPagamentBtn.Location = new Point(276, 834);
            eliminaPagamentBtn.Name = "eliminaPagamentBtn";
            eliminaPagamentBtn.Size = new Size(191, 67);
            eliminaPagamentBtn.TabIndex = 57;
            eliminaPagamentBtn.Text = "Eliminar";
            eliminaPagamentBtn.UseVisualStyleBackColor = false;
            eliminaPagamentBtn.Click += eliminaPagamentBtn_Click;
            // 
            // labelCancelListMembres
            // 
            labelCancelListMembres.Anchor = AnchorStyles.None;
            labelCancelListMembres.AutoSize = true;
            labelCancelListMembres.BackColor = Color.Transparent;
            labelCancelListMembres.Cursor = Cursors.Hand;
            labelCancelListMembres.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelCancelListMembres.ForeColor = Color.FromArgb(107, 55, 35);
            labelCancelListMembres.Location = new Point(558, 855);
            labelCancelListMembres.Name = "labelCancelListMembres";
            labelCancelListMembres.Size = new Size(109, 30);
            labelCancelListMembres.TabIndex = 56;
            labelCancelListMembres.Text = "Cancel.lar";
            labelCancelListMembres.Click += labelCancelListMembres_Click;
            // 
            // numGrupTxt
            // 
            numGrupTxt.Anchor = AnchorStyles.None;
            numGrupTxt.BackColor = Color.FromArgb(107, 55, 35);
            numGrupTxt.Font = new Font("Segoe UI", 14F, FontStyle.Italic, GraphicsUnit.Point);
            numGrupTxt.ForeColor = Color.Black;
            numGrupTxt.Location = new Point(864, 244);
            numGrupTxt.Name = "numGrupTxt";
            numGrupTxt.Size = new Size(64, 45);
            numGrupTxt.TabIndex = 63;
            numGrupTxt.Visible = false;
            // 
            // numPagamentTxt
            // 
            numPagamentTxt.Anchor = AnchorStyles.None;
            numPagamentTxt.BackColor = Color.FromArgb(107, 55, 35);
            numPagamentTxt.Font = new Font("Segoe UI", 14F, FontStyle.Italic, GraphicsUnit.Point);
            numPagamentTxt.ForeColor = Color.Black;
            numPagamentTxt.Location = new Point(864, 517);
            numPagamentTxt.Name = "numPagamentTxt";
            numPagamentTxt.Size = new Size(64, 45);
            numPagamentTxt.TabIndex = 64;
            numPagamentTxt.Visible = false;
            // 
            // refreshBtn
            // 
            refreshBtn.Anchor = AnchorStyles.None;
            refreshBtn.Location = new Point(708, 802);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(112, 34);
            refreshBtn.TabIndex = 65;
            refreshBtn.Text = "Refresh";
            refreshBtn.UseVisualStyleBackColor = true;
            refreshBtn.Click += refreshBtn_Click;
            // 
            // User_deletePagament
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(960, 913);
            Controls.Add(refreshBtn);
            Controls.Add(numPagamentTxt);
            Controls.Add(numGrupTxt);
            Controls.Add(eliminaPagamentBtn);
            Controls.Add(labelCancelListMembres);
            Controls.Add(listPagamentsGrup);
            Controls.Add(groupBoxSeleccio);
            Controls.Add(menuStrip1);
            Controls.Add(pageLocation);
            Controls.Add(label2);
            Name = "User_deletePagament";
            Text = "User_deletePagament";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBoxSeleccio.ResumeLayout(false);
            groupBoxSeleccio.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem op1ToolStripMenuItem;
        private ToolStripMenuItem iniciStripMenuItem;
        private ToolStripMenuItem logoutStripMenuItem;
        private Label pageLocation;
        private Label label2;
        private GroupBox groupBoxSeleccio;
        private ComboBox comboBox1;
        private ListView listGrupsTipus;
        private ColumnHeader columnHeaderGroupID;
        private ColumnHeader columnHeaderNomGroup;
        private Label label6;
        private ListView listPagamentsGrup;
        private ColumnHeader columnHeaderIsMember;
        private ColumnHeader columnHeaderNickname;
        private ColumnHeader columnHeaderAmount;
        private ColumnHeader columnHeaderData;
        private Button eliminaPagamentBtn;
        private Label labelCancelListMembres;
        private TextBox numGrupTxt;
        private TextBox numPagamentTxt;
        private Button refreshBtn;
    }
}