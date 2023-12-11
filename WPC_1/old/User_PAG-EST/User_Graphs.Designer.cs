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
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            groupBoxFiltreDates = new GroupBox();
            checkBoxFiltreDates = new CheckBox();
            xUsuariBtn = new Button();
            xGrupBtn = new Button();
            totalsBtn = new Button();
            labelSelGrup = new Label();
            labelSelUser = new Label();
            listView1 = new ListView();
            listView2 = new ListView();
            buttonOKMostraDades = new Button();
            listView3 = new ListView();
            labelResult = new Label();
            columnHeaderNomGrup = new ColumnHeader();
            columnHeaderNickname = new ColumnHeader();
            columnHeaderNick = new ColumnHeader();
            columnHeaderPAmount = new ColumnHeader();
            columnHeaderDate = new ColumnHeader();
            columnHeaderIsMember = new ColumnHeader();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            columnHeaderTicket = new ColumnHeader();
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
            labelGrup.Location = new Point(116, 75);
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
            pageLocation.Location = new Point(116, 27);
            pageLocation.Name = "pageLocation";
            pageLocation.Size = new Size(680, 28);
            pageLocation.TabIndex = 26;
            pageLocation.Text = "location: Username>MenuUsuari>PagamentsiEstadistiques>Estadístiques\r\n";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(20, 68);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(128, 31);
            dateTimePicker1.TabIndex = 28;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Anchor = AnchorStyles.None;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(182, 68);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(128, 31);
            dateTimePicker2.TabIndex = 29;
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
            groupBoxFiltreDates.Controls.Add(dateTimePicker2);
            groupBoxFiltreDates.Controls.Add(dateTimePicker1);
            groupBoxFiltreDates.Enabled = false;
            groupBoxFiltreDates.ForeColor = Color.FromArgb(107, 55, 35);
            groupBoxFiltreDates.Location = new Point(948, 76);
            groupBoxFiltreDates.Name = "groupBoxFiltreDates";
            groupBoxFiltreDates.Size = new Size(334, 122);
            groupBoxFiltreDates.TabIndex = 42;
            groupBoxFiltreDates.TabStop = false;
            groupBoxFiltreDates.Text = "Filtrar per dates?";
            // 
            // checkBoxFiltreDates
            // 
            checkBoxFiltreDates.AutoSize = true;
            checkBoxFiltreDates.Location = new Point(920, 87);
            checkBoxFiltreDates.Name = "checkBoxFiltreDates";
            checkBoxFiltreDates.Size = new Size(22, 21);
            checkBoxFiltreDates.TabIndex = 44;
            checkBoxFiltreDates.UseVisualStyleBackColor = true;
            // 
            // xUsuariBtn
            // 
            xUsuariBtn.Anchor = AnchorStyles.None;
            xUsuariBtn.Location = new Point(968, 245);
            xUsuariBtn.Name = "xUsuariBtn";
            xUsuariBtn.Size = new Size(164, 34);
            xUsuariBtn.TabIndex = 45;
            xUsuariBtn.Text = "USUARI";
            xUsuariBtn.UseVisualStyleBackColor = true;
            // 
            // xGrupBtn
            // 
            xGrupBtn.Anchor = AnchorStyles.None;
            xGrupBtn.Location = new Point(968, 205);
            xGrupBtn.Name = "xGrupBtn";
            xGrupBtn.Size = new Size(164, 34);
            xGrupBtn.TabIndex = 46;
            xGrupBtn.Text = "GRUP";
            xGrupBtn.UseVisualStyleBackColor = true;
            // 
            // totalsBtn
            // 
            totalsBtn.Anchor = AnchorStyles.None;
            totalsBtn.Location = new Point(968, 285);
            totalsBtn.Name = "totalsBtn";
            totalsBtn.Size = new Size(164, 34);
            totalsBtn.TabIndex = 47;
            totalsBtn.Text = "ACUMULATS";
            totalsBtn.UseVisualStyleBackColor = true;
            // 
            // labelSelGrup
            // 
            labelSelGrup.Anchor = AnchorStyles.None;
            labelSelGrup.AutoSize = true;
            labelSelGrup.Location = new Point(464, 85);
            labelSelGrup.Name = "labelSelGrup";
            labelSelGrup.Size = new Size(138, 25);
            labelSelGrup.TabIndex = 49;
            labelSelGrup.Text = "Selecciona Grup";
            // 
            // labelSelUser
            // 
            labelSelUser.Anchor = AnchorStyles.None;
            labelSelUser.AutoSize = true;
            labelSelUser.Location = new Point(694, 85);
            labelSelUser.Name = "labelSelUser";
            labelSelUser.Size = new Size(148, 25);
            labelSelUser.TabIndex = 51;
            labelSelUser.Text = "Selecciona Usuari";
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.None;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeaderNomGrup });
            listView1.Location = new Point(464, 111);
            listView1.Name = "listView1";
            listView1.Size = new Size(193, 139);
            listView1.TabIndex = 52;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // listView2
            // 
            listView2.Anchor = AnchorStyles.None;
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeaderNickname });
            listView2.Location = new Point(694, 111);
            listView2.Name = "listView2";
            listView2.Size = new Size(197, 139);
            listView2.TabIndex = 53;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // buttonOKMostraDades
            // 
            buttonOKMostraDades.Anchor = AnchorStyles.None;
            buttonOKMostraDades.BackColor = Color.FromArgb(107, 55, 35);
            buttonOKMostraDades.FlatStyle = FlatStyle.Popup;
            buttonOKMostraDades.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonOKMostraDades.ForeColor = Color.FromArgb(64, 0, 0);
            buttonOKMostraDades.Location = new Point(1143, 204);
            buttonOKMostraDades.Name = "buttonOKMostraDades";
            buttonOKMostraDades.Size = new Size(119, 113);
            buttonOKMostraDades.TabIndex = 54;
            buttonOKMostraDades.Text = "OK";
            buttonOKMostraDades.UseVisualStyleBackColor = false;
            // 
            // listView3
            // 
            listView3.Anchor = AnchorStyles.None;
            listView3.Columns.AddRange(new ColumnHeader[] { columnHeaderNick, columnHeaderPAmount, columnHeaderDate, columnHeaderIsMember, columnHeaderTicket });
            listView3.Location = new Point(131, 322);
            listView3.Name = "listView3";
            listView3.Size = new Size(766, 393);
            listView3.TabIndex = 56;
            listView3.UseCompatibleStateImageBehavior = false;
            listView3.View = View.Details;
            // 
            // labelResult
            // 
            labelResult.Anchor = AnchorStyles.None;
            labelResult.AutoSize = true;
            labelResult.Location = new Point(131, 296);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(143, 25);
            labelResult.TabIndex = 55;
            labelResult.Text = "Dades resultants";
            // 
            // columnHeaderNomGrup
            // 
            columnHeaderNomGrup.Text = "Nom";
            columnHeaderNomGrup.Width = 189;
            // 
            // columnHeaderNickname
            // 
            columnHeaderNickname.Text = "Nickname";
            columnHeaderNickname.Width = 193;
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
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(968, 549);
            label3.Name = "label3";
            label3.Size = new Size(190, 50);
            label3.TabIndex = 57;
            label3.Text = "#35/36:\r\nnick, member, amount";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(968, 486);
            label4.Name = "label4";
            label4.Size = new Size(234, 50);
            label4.TabIndex = 58;
            label4.Text = "#33/34:\r\nnick, amount, date, member";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(968, 417);
            label5.Name = "label5";
            label5.Size = new Size(158, 50);
            label5.TabIndex = 59;
            label5.Text = "#31/32:\r\nnick, amount, date";
            // 
            // columnHeaderTicket
            // 
            columnHeaderTicket.Text = "Té Ticket?";
            columnHeaderTicket.Width = 100;
            // 
            // User_Graphs
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1360, 727);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(listView3);
            Controls.Add(labelResult);
            Controls.Add(buttonOKMostraDades);
            Controls.Add(listView2);
            Controls.Add(listView1);
            Controls.Add(labelSelUser);
            Controls.Add(labelSelGrup);
            Controls.Add(totalsBtn);
            Controls.Add(xGrupBtn);
            Controls.Add(xUsuariBtn);
            Controls.Add(checkBoxFiltreDates);
            Controls.Add(groupBoxFiltreDates);
            Controls.Add(menuStrip1);
            Controls.Add(pageLocation);
            Controls.Add(labelGrup);
            Name = "User_Graphs";
            ShowIcon = false;
            Text = "Estadístiques de WPC";
            WindowState = FormWindowState.Maximized;
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
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private Label label2;
        private GroupBox groupBoxFiltreDates;
        private CheckBox checkBoxFiltreDates;
        private Button xUsuariBtn;
        private Button xGrupBtn;
        private Button totalsBtn;
        private Label labelSelGrup;
        private Label labelSelUser;
        private ListView listView1;
        private ListView listView2;
        private Button buttonOKMostraDades;
        private ColumnHeader columnHeaderNomGrup;
        private ListView listView3;
        private Label labelResult;
        private ColumnHeader columnHeaderNickname;
        private ColumnHeader columnHeaderNick;
        private ColumnHeader columnHeaderPAmount;
        private ColumnHeader columnHeaderDate;
        private ColumnHeader columnHeaderIsMember;
        private Label label3;
        private Label label4;
        private Label label5;
        private ColumnHeader columnHeaderTicket;
    }
}