namespace WPC_1
{
    partial class User_Graphs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Graphs));
            labelGrup = new Label();
            menuStrip1 = new MenuStrip();
            op1ToolStripMenuItem = new ToolStripMenuItem();
            iniciStripMenuItem = new ToolStripMenuItem();
            logoutStripMenuItem = new ToolStripMenuItem();
            pageLocation = new Label();
            dataInici = new DateTimePicker();
            dataFinal = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            groupBoxFiltreDates = new GroupBox();
            checkBoxFiltreDates = new CheckBox();
            labelSelGrup = new Label();
            labelSelUser = new Label();
            listGrupsTipus = new ListView();
            columnHeaderNomGrup = new ColumnHeader();
            listMembres = new ListView();
            columnHeaderNickname = new ColumnHeader();
            buttonOKMostraDades = new Button();
            listDadesResult = new ListView();
            columnHeaderNick = new ColumnHeader();
            columnHeaderPAmount = new ColumnHeader();
            columnHeaderDate = new ColumnHeader();
            columnHeaderIsMember = new ColumnHeader();
            labelResult = new Label();
            numMembreTxt = new TextBox();
            numGrupTxt = new TextBox();
            comboBoxSelDades = new ComboBox();
            label6 = new Label();
            nicknameTxt = new TextBox();
            labelNickname = new Label();
            listViewReq3 = new ListView();
            columnHeadNickname = new ColumnHeader();
            columnHeadTotalAmount = new ColumnHeader();
            columnHeadMemberId = new ColumnHeader();
            listViewReq1 = new ListView();
            columnHeaderNicky = new ColumnHeader();
            columnHeaderPDAmount = new ColumnHeader();
            columnHeaderPDDate = new ColumnHeader();
            button1 = new Button();
            labelCancelEstadistiques = new Label();
            menuStrip1.SuspendLayout();
            groupBoxFiltreDates.SuspendLayout();
            SuspendLayout();
            // 
            // labelGrup
            // 
            labelGrup.Anchor = AnchorStyles.None;
            labelGrup.AutoSize = true;
            labelGrup.BackColor = Color.Transparent;
            labelGrup.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold, GraphicsUnit.Point);
            labelGrup.ForeColor = Color.FromArgb(107, 55, 35);
            labelGrup.Location = new Point(116, 168);
            labelGrup.Name = "labelGrup";
            labelGrup.Size = new Size(310, 60);
            labelGrup.TabIndex = 25;
            labelGrup.Text = "Estadístiques";
            labelGrup.TextAlign = ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { op1ToolStripMenuItem });
            menuStrip1.Location = new Point(21, 16);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(261, 57);
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
            pageLocation.Location = new Point(116, 27);
            pageLocation.Name = "pageLocation";
            pageLocation.Size = new Size(680, 28);
            pageLocation.TabIndex = 26;
            pageLocation.Text = "location: Username>MenuUsuari>PagamentsiEstadistiques>Estadístiques\r\n";
            // 
            // dataInici
            // 
            dataInici.Anchor = AnchorStyles.None;
            dataInici.CustomFormat = "yyyy-MM-dd";
            dataInici.Format = DateTimePickerFormat.Custom;
            dataInici.Location = new Point(20, 68);
            dataInici.Name = "dataInici";
            dataInici.Size = new Size(128, 31);
            dataInici.TabIndex = 28;
            // 
            // dataFinal
            // 
            dataFinal.Anchor = AnchorStyles.None;
            dataFinal.CustomFormat = "yyyy-MM-dd";
            dataFinal.Format = DateTimePickerFormat.Custom;
            dataFinal.Location = new Point(182, 68);
            dataFinal.Name = "dataFinal";
            dataFinal.Size = new Size(128, 31);
            dataFinal.TabIndex = 29;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(107, 55, 35);
            label1.Location = new Point(31, 34);
            label1.Name = "label1";
            label1.Size = new Size(100, 30);
            label1.TabIndex = 40;
            label1.Text = "Data inici";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(107, 55, 35);
            label2.Location = new Point(195, 34);
            label2.Name = "label2";
            label2.Size = new Size(103, 30);
            label2.TabIndex = 41;
            label2.Text = "Data final";
            // 
            // groupBoxFiltreDates
            // 
            groupBoxFiltreDates.Anchor = AnchorStyles.None;
            groupBoxFiltreDates.BackColor = Color.Transparent;
            groupBoxFiltreDates.Controls.Add(label2);
            groupBoxFiltreDates.Controls.Add(label1);
            groupBoxFiltreDates.Controls.Add(dataFinal);
            groupBoxFiltreDates.Controls.Add(dataInici);
            groupBoxFiltreDates.Enabled = false;
            groupBoxFiltreDates.ForeColor = Color.FromArgb(107, 55, 35);
            groupBoxFiltreDates.Location = new Point(948, 169);
            groupBoxFiltreDates.Name = "groupBoxFiltreDates";
            groupBoxFiltreDates.Size = new Size(334, 122);
            groupBoxFiltreDates.TabIndex = 42;
            groupBoxFiltreDates.TabStop = false;
            groupBoxFiltreDates.Text = "Filtrar per dates?";
            // 
            // checkBoxFiltreDates
            // 
            checkBoxFiltreDates.Anchor = AnchorStyles.None;
            checkBoxFiltreDates.AutoSize = true;
            checkBoxFiltreDates.Cursor = Cursors.Hand;
            checkBoxFiltreDates.Location = new Point(920, 180);
            checkBoxFiltreDates.Name = "checkBoxFiltreDates";
            checkBoxFiltreDates.Size = new Size(22, 21);
            checkBoxFiltreDates.TabIndex = 44;
            checkBoxFiltreDates.UseVisualStyleBackColor = true;
            checkBoxFiltreDates.CheckedChanged += checkBoxFiltreDates_CheckedChanged;
            // 
            // labelSelGrup
            // 
            labelSelGrup.Anchor = AnchorStyles.None;
            labelSelGrup.AutoSize = true;
            labelSelGrup.Location = new Point(464, 178);
            labelSelGrup.Name = "labelSelGrup";
            labelSelGrup.Size = new Size(138, 25);
            labelSelGrup.TabIndex = 49;
            labelSelGrup.Text = "Selecciona Grup";
            // 
            // labelSelUser
            // 
            labelSelUser.Anchor = AnchorStyles.None;
            labelSelUser.AutoSize = true;
            labelSelUser.Location = new Point(694, 178);
            labelSelUser.Name = "labelSelUser";
            labelSelUser.Size = new Size(148, 25);
            labelSelUser.TabIndex = 51;
            labelSelUser.Text = "Selecciona Usuari";
            // 
            // listGrupsTipus
            // 
            listGrupsTipus.Anchor = AnchorStyles.None;
            listGrupsTipus.Columns.AddRange(new ColumnHeader[] { columnHeaderNomGrup });
            listGrupsTipus.FullRowSelect = true;
            listGrupsTipus.Location = new Point(464, 204);
            listGrupsTipus.MultiSelect = false;
            listGrupsTipus.Name = "listGrupsTipus";
            listGrupsTipus.Size = new Size(193, 168);
            listGrupsTipus.TabIndex = 52;
            listGrupsTipus.UseCompatibleStateImageBehavior = false;
            listGrupsTipus.View = View.Details;
            listGrupsTipus.SelectedIndexChanged += listGrupsTipus_SelectedIndexChanged;
            // 
            // columnHeaderNomGrup
            // 
            columnHeaderNomGrup.Text = "";
            columnHeaderNomGrup.Width = 189;
            // 
            // listMembres
            // 
            listMembres.Anchor = AnchorStyles.None;
            listMembres.Columns.AddRange(new ColumnHeader[] { columnHeaderNickname });
            listMembres.FullRowSelect = true;
            listMembres.Location = new Point(694, 204);
            listMembres.MultiSelect = false;
            listMembres.Name = "listMembres";
            listMembres.Size = new Size(197, 168);
            listMembres.TabIndex = 53;
            listMembres.UseCompatibleStateImageBehavior = false;
            listMembres.View = View.Details;
            listMembres.SelectedIndexChanged += listMembres_SelectedIndexChanged;
            // 
            // columnHeaderNickname
            // 
            columnHeaderNickname.Text = "";
            columnHeaderNickname.Width = 193;
            // 
            // buttonOKMostraDades
            // 
            buttonOKMostraDades.Anchor = AnchorStyles.None;
            buttonOKMostraDades.BackColor = Color.FromArgb(107, 55, 35);
            buttonOKMostraDades.Cursor = Cursors.Hand;
            buttonOKMostraDades.FlatStyle = FlatStyle.Popup;
            buttonOKMostraDades.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonOKMostraDades.ForeColor = Color.FromArgb(64, 0, 0);
            buttonOKMostraDades.Location = new Point(1143, 297);
            buttonOKMostraDades.Name = "buttonOKMostraDades";
            buttonOKMostraDades.Size = new Size(119, 113);
            buttonOKMostraDades.TabIndex = 54;
            buttonOKMostraDades.Text = "OK";
            buttonOKMostraDades.UseVisualStyleBackColor = false;
            buttonOKMostraDades.Click += buttonOKMostraDades_Click;
            // 
            // listDadesResult
            // 
            listDadesResult.Anchor = AnchorStyles.None;
            listDadesResult.Columns.AddRange(new ColumnHeader[] { columnHeaderNick, columnHeaderPAmount, columnHeaderDate, columnHeaderIsMember });
            listDadesResult.FullRowSelect = true;
            listDadesResult.Location = new Point(185, 453);
            listDadesResult.MultiSelect = false;
            listDadesResult.Name = "listDadesResult";
            listDadesResult.Size = new Size(762, 393);
            listDadesResult.TabIndex = 56;
            listDadesResult.UseCompatibleStateImageBehavior = false;
            listDadesResult.View = View.Details;
            // 
            // columnHeaderNick
            // 
            columnHeaderNick.Text = "Nickname";
            columnHeaderNick.Width = 200;
            // 
            // columnHeaderPAmount
            // 
            columnHeaderPAmount.Text = "Quantitat Pagada";
            columnHeaderPAmount.Width = 160;
            // 
            // columnHeaderDate
            // 
            columnHeaderDate.Text = "Data Pagament";
            columnHeaderDate.Width = 160;
            // 
            // columnHeaderIsMember
            // 
            columnHeaderIsMember.Text = "Encara Membre?";
            columnHeaderIsMember.Width = 143;
            // 
            // labelResult
            // 
            labelResult.Anchor = AnchorStyles.None;
            labelResult.AutoSize = true;
            labelResult.Location = new Point(188, 427);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(143, 25);
            labelResult.TabIndex = 55;
            labelResult.Text = "Dades resultants";
            // 
            // numMembreTxt
            // 
            numMembreTxt.Anchor = AnchorStyles.None;
            numMembreTxt.BackColor = Color.FromArgb(107, 55, 35);
            numMembreTxt.Font = new Font("Segoe UI", 14F, FontStyle.Italic, GraphicsUnit.Point);
            numMembreTxt.ForeColor = Color.Black;
            numMembreTxt.Location = new Point(362, 298);
            numMembreTxt.Name = "numMembreTxt";
            numMembreTxt.Size = new Size(64, 45);
            numMembreTxt.TabIndex = 65;
            numMembreTxt.Visible = false;
            // 
            // numGrupTxt
            // 
            numGrupTxt.Anchor = AnchorStyles.None;
            numGrupTxt.BackColor = Color.FromArgb(107, 55, 35);
            numGrupTxt.Font = new Font("Segoe UI", 14F, FontStyle.Italic, GraphicsUnit.Point);
            numGrupTxt.ForeColor = Color.Black;
            numGrupTxt.Location = new Point(362, 246);
            numGrupTxt.Name = "numGrupTxt";
            numGrupTxt.Size = new Size(64, 45);
            numGrupTxt.TabIndex = 64;
            numGrupTxt.Visible = false;
            // 
            // comboBoxSelDades
            // 
            comboBoxSelDades.Anchor = AnchorStyles.None;
            comboBoxSelDades.FormattingEnabled = true;
            comboBoxSelDades.Items.AddRange(new object[] { "Per Usuari", "Per Grup", "Totals Acumulats", "Per nickname" });
            comboBoxSelDades.Location = new Point(955, 330);
            comboBoxSelDades.Name = "comboBoxSelDades";
            comboBoxSelDades.Size = new Size(182, 33);
            comboBoxSelDades.TabIndex = 66;
            comboBoxSelDades.SelectedIndexChanged += comboBoxSelDades_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(956, 302);
            label6.Name = "label6";
            label6.Size = new Size(151, 25);
            label6.TabIndex = 67;
            label6.Text = "Dades a mostrar?";
            // 
            // nicknameTxt
            // 
            nicknameTxt.Anchor = AnchorStyles.None;
            nicknameTxt.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point);
            nicknameTxt.Location = new Point(958, 417);
            nicknameTxt.Name = "nicknameTxt";
            nicknameTxt.Size = new Size(300, 35);
            nicknameTxt.TabIndex = 68;
            nicknameTxt.Visible = false;
            // 
            // labelNickname
            // 
            labelNickname.Anchor = AnchorStyles.None;
            labelNickname.AutoSize = true;
            labelNickname.Location = new Point(958, 389);
            labelNickname.Name = "labelNickname";
            labelNickname.Size = new Size(161, 25);
            labelNickname.TabIndex = 69;
            labelNickname.Text = "Nickname a buscar\r\n";
            labelNickname.Visible = false;
            // 
            // listViewReq3
            // 
            listViewReq3.Anchor = AnchorStyles.None;
            listViewReq3.Columns.AddRange(new ColumnHeader[] { columnHeadNickname, columnHeadTotalAmount, columnHeadMemberId });
            listViewReq3.Location = new Point(186, 453);
            listViewReq3.Name = "listViewReq3";
            listViewReq3.Size = new Size(761, 402);
            listViewReq3.TabIndex = 70;
            listViewReq3.UseCompatibleStateImageBehavior = false;
            listViewReq3.View = View.Details;
            // 
            // columnHeadNickname
            // 
            columnHeadNickname.Text = "nickname";
            columnHeadNickname.Width = 87;
            // 
            // columnHeadTotalAmount
            // 
            columnHeadTotalAmount.Text = "TotalAmount";
            columnHeadTotalAmount.Width = 116;
            // 
            // columnHeadMemberId
            // 
            columnHeadMemberId.Text = "MemberId";
            columnHeadMemberId.Width = 597;
            // 
            // listViewReq1
            // 
            listViewReq1.Anchor = AnchorStyles.None;
            listViewReq1.Columns.AddRange(new ColumnHeader[] { columnHeaderNicky, columnHeaderPDAmount, columnHeaderPDDate });
            listViewReq1.FullRowSelect = true;
            listViewReq1.Location = new Point(186, 453);
            listViewReq1.MultiSelect = false;
            listViewReq1.Name = "listViewReq1";
            listViewReq1.Size = new Size(761, 402);
            listViewReq1.TabIndex = 71;
            listViewReq1.UseCompatibleStateImageBehavior = false;
            listViewReq1.View = View.Details;
            // 
            // columnHeaderNicky
            // 
            columnHeaderNicky.Text = "Nickname";
            columnHeaderNicky.Width = 90;
            // 
            // columnHeaderPDAmount
            // 
            columnHeaderPDAmount.Text = "PDAmount";
            columnHeaderPDAmount.Width = 100;
            // 
            // columnHeaderPDDate
            // 
            columnHeaderPDDate.Text = "PDDate";
            columnHeaderPDDate.Width = 560;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(107, 55, 35);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(64, 0, 0);
            button1.Location = new Point(979, 752);
            button1.Name = "button1";
            button1.Size = new Size(160, 62);
            button1.TabIndex = 72;
            button1.Text = "Gràfica";
            button1.UseVisualStyleBackColor = false;
            // 
            // labelCancelEstadistiques
            // 
            labelCancelEstadistiques.Anchor = AnchorStyles.None;
            labelCancelEstadistiques.AutoSize = true;
            labelCancelEstadistiques.BackColor = Color.Transparent;
            labelCancelEstadistiques.Cursor = Cursors.Hand;
            labelCancelEstadistiques.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelCancelEstadistiques.ForeColor = Color.FromArgb(107, 55, 35);
            labelCancelEstadistiques.Location = new Point(624, 874);
            labelCancelEstadistiques.Name = "labelCancelEstadistiques";
            labelCancelEstadistiques.Size = new Size(109, 30);
            labelCancelEstadistiques.TabIndex = 73;
            labelCancelEstadistiques.Text = "Cancel.lar";
            labelCancelEstadistiques.Click += labelCancelEstadistiques_Click;
            // 
            // User_Graphs
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1360, 913);
            Controls.Add(labelCancelEstadistiques);
            Controls.Add(button1);
            Controls.Add(listViewReq3);
            Controls.Add(listViewReq1);
            Controls.Add(labelNickname);
            Controls.Add(nicknameTxt);
            Controls.Add(label6);
            Controls.Add(comboBoxSelDades);
            Controls.Add(numMembreTxt);
            Controls.Add(numGrupTxt);
            Controls.Add(listDadesResult);
            Controls.Add(labelResult);
            Controls.Add(buttonOKMostraDades);
            Controls.Add(listMembres);
            Controls.Add(listGrupsTipus);
            Controls.Add(labelSelUser);
            Controls.Add(labelSelGrup);
            Controls.Add(checkBoxFiltreDates);
            Controls.Add(groupBoxFiltreDates);
            Controls.Add(menuStrip1);
            Controls.Add(pageLocation);
            Controls.Add(labelGrup);
            Name = "User_Graphs";
            ShowIcon = false;
            Text = "Estadístiques de WPC";
            WindowState = FormWindowState.Maximized;
            Load += User_Graphs_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBoxFiltreDates.ResumeLayout(false);
            groupBoxFiltreDates.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelGrup;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem op1ToolStripMenuItem;
        private ToolStripMenuItem iniciStripMenuItem;
        private ToolStripMenuItem logoutStripMenuItem;
        private Label pageLocation;
        private DateTimePicker dataInici;
        private DateTimePicker dataFinal;
        private Label label1;
        private Label label2;
        private GroupBox groupBoxFiltreDates;
        private CheckBox checkBoxFiltreDates;
        private Label labelSelGrup;
        private Label labelSelUser;
        private ListView listGrupsTipus;
        private ListView listMembres;
        private Button buttonOKMostraDades;
        private ListView listDadesResult;
        private Label labelResult;
        private ColumnHeader columnHeaderNickname;
        private ColumnHeader columnHeaderNick;
        private ColumnHeader columnHeaderPAmount;
        private ColumnHeader columnHeaderDate;
        private ColumnHeader columnHeaderIsMember;
        private ColumnHeader columnHeaderNomGrup;
        private TextBox numMembreTxt;
        private TextBox numGrupTxt;
        private ComboBox comboBoxSelDades;
        private Label label6;
        private TextBox nicknameTxt;
        private Label labelNickname;
        private ListView listViewReq3;
        private ColumnHeader columnHeadNickname;
        private ColumnHeader columnHeadTotalAmount;
        private ColumnHeader columnHeadMemberId;
        private ListView listViewReq1;
        private ColumnHeader columnHeaderNicky;
        private ColumnHeader columnHeaderPDAmount;
        private ColumnHeader columnHeaderPDDate;
        private Button button1;
        private Label labelCancelEstadistiques;
    }
}