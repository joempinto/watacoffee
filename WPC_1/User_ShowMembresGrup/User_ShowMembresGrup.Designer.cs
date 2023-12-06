namespace WPC_1
{
    partial class User_ShowMembresGrup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_ShowMembresGrup));
            labelCancelListMembres = new Label();
            addMemberGrupBtn = new Button();
            labelShowMembres = new Label();
            totalParticipantsGroup = new TextBox();
            labelTotalMembres = new Label();
            listMembres = new ListView();
            groupIDHeader1 = new ColumnHeader();
            userIDHeader2 = new ColumnHeader();
            nicknameHeader3 = new ColumnHeader();
            usernameHeader4 = new ColumnHeader();
            adminHeader4 = new ColumnHeader();
            updateMemberBtn = new Button();
            eliminaMemberBtn = new Button();
            menuStrip1 = new MenuStrip();
            op1ToolStripMenuItem = new ToolStripMenuItem();
            iniciStripMenuItem = new ToolStripMenuItem();
            logoutStripMenuItem = new ToolStripMenuItem();
            pageLocation = new Label();
            label1 = new Label();
            refreshBtn = new Button();
            numGrupTxt = new TextBox();
            linkUsernameBtn = new Button();
            updateNicknameBtn = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // labelCancelListMembres
            // 
            labelCancelListMembres.Anchor = AnchorStyles.None;
            labelCancelListMembres.AutoSize = true;
            labelCancelListMembres.BackColor = Color.Transparent;
            labelCancelListMembres.Cursor = Cursors.Hand;
            labelCancelListMembres.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelCancelListMembres.ForeColor = Color.FromArgb(107, 55, 35);
            labelCancelListMembres.Location = new Point(586, 796);
            labelCancelListMembres.Name = "labelCancelListMembres";
            labelCancelListMembres.Size = new Size(109, 30);
            labelCancelListMembres.TabIndex = 50;
            labelCancelListMembres.Text = "Cancel.lar";
            labelCancelListMembres.Click += label1_Click;
            // 
            // addMemberGrupBtn
            // 
            addMemberGrupBtn.Anchor = AnchorStyles.None;
            addMemberGrupBtn.BackColor = Color.FromArgb(107, 55, 35);
            addMemberGrupBtn.Enabled = false;
            addMemberGrupBtn.FlatStyle = FlatStyle.Popup;
            addMemberGrupBtn.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            addMemberGrupBtn.ForeColor = Color.FromArgb(64, 0, 0);
            addMemberGrupBtn.Location = new Point(80, 698);
            addMemberGrupBtn.Name = "addMemberGrupBtn";
            addMemberGrupBtn.Size = new Size(191, 67);
            addMemberGrupBtn.TabIndex = 49;
            addMemberGrupBtn.Text = "Afegir";
            addMemberGrupBtn.UseVisualStyleBackColor = false;
            addMemberGrupBtn.Click += addMemberGrupBtn_Click;
            // 
            // labelShowMembres
            // 
            labelShowMembres.Anchor = AnchorStyles.None;
            labelShowMembres.AutoSize = true;
            labelShowMembres.BackColor = Color.Transparent;
            labelShowMembres.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelShowMembres.ForeColor = Color.FromArgb(107, 55, 35);
            labelShowMembres.Location = new Point(153, 106);
            labelShowMembres.Name = "labelShowMembres";
            labelShowMembres.Size = new Size(517, 54);
            labelShowMembres.TabIndex = 48;
            labelShowMembres.Text = "Llistat Membres del Grup";
            labelShowMembres.TextAlign = ContentAlignment.TopCenter;
            // 
            // totalParticipantsGroup
            // 
            totalParticipantsGroup.Anchor = AnchorStyles.None;
            totalParticipantsGroup.Font = new Font("Segoe UI", 14F, FontStyle.Italic, GraphicsUnit.Point);
            totalParticipantsGroup.Location = new Point(672, 174);
            totalParticipantsGroup.Name = "totalParticipantsGroup";
            totalParticipantsGroup.Size = new Size(63, 45);
            totalParticipantsGroup.TabIndex = 52;
            // 
            // labelTotalMembres
            // 
            labelTotalMembres.Anchor = AnchorStyles.None;
            labelTotalMembres.AutoSize = true;
            labelTotalMembres.BackColor = Color.Transparent;
            labelTotalMembres.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotalMembres.ForeColor = Color.FromArgb(107, 55, 35);
            labelTotalMembres.Location = new Point(604, 184);
            labelTotalMembres.Name = "labelTotalMembres";
            labelTotalMembres.Size = new Size(64, 30);
            labelTotalMembres.TabIndex = 51;
            labelTotalMembres.Text = "Total:";
            // 
            // listMembres
            // 
            listMembres.Anchor = AnchorStyles.None;
            listMembres.Columns.AddRange(new ColumnHeader[] { groupIDHeader1, userIDHeader2, nicknameHeader3, usernameHeader4, adminHeader4 });
            listMembres.FullRowSelect = true;
            listMembres.Location = new Point(80, 224);
            listMembres.MultiSelect = false;
            listMembres.Name = "listMembres";
            listMembres.Size = new Size(655, 396);
            listMembres.TabIndex = 53;
            listMembres.UseCompatibleStateImageBehavior = false;
            listMembres.View = View.Details;
            listMembres.SelectedIndexChanged += selectedIndexChanged;
            listMembres.Click += listIndex_Click;
            // 
            // groupIDHeader1
            // 
            groupIDHeader1.Text = "Group ID";
            groupIDHeader1.Width = 131;
            // 
            // userIDHeader2
            // 
            userIDHeader2.Text = "User ID";
            userIDHeader2.Width = 131;
            // 
            // nicknameHeader3
            // 
            nicknameHeader3.Text = "Nickname";
            nicknameHeader3.Width = 131;
            // 
            // usernameHeader4
            // 
            usernameHeader4.Text = "Username";
            usernameHeader4.Width = 131;
            // 
            // adminHeader4
            // 
            adminHeader4.Text = "Is Admin?";
            adminHeader4.Width = 131;
            // 
            // updateMemberBtn
            // 
            updateMemberBtn.Anchor = AnchorStyles.None;
            updateMemberBtn.BackColor = Color.FromArgb(107, 55, 35);
            updateMemberBtn.Enabled = false;
            updateMemberBtn.FlatStyle = FlatStyle.Popup;
            updateMemberBtn.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            updateMemberBtn.ForeColor = Color.FromArgb(64, 0, 0);
            updateMemberBtn.Location = new Point(313, 698);
            updateMemberBtn.Name = "updateMemberBtn";
            updateMemberBtn.Size = new Size(190, 67);
            updateMemberBtn.TabIndex = 54;
            updateMemberBtn.Text = "Actualitzar";
            updateMemberBtn.UseVisualStyleBackColor = false;
            updateMemberBtn.Click += updateMemberBtn_Click;
            // 
            // eliminaMemberBtn
            // 
            eliminaMemberBtn.Anchor = AnchorStyles.None;
            eliminaMemberBtn.BackColor = Color.FromArgb(107, 55, 35);
            eliminaMemberBtn.Enabled = false;
            eliminaMemberBtn.FlatStyle = FlatStyle.Popup;
            eliminaMemberBtn.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            eliminaMemberBtn.ForeColor = Color.FromArgb(64, 0, 0);
            eliminaMemberBtn.Location = new Point(543, 698);
            eliminaMemberBtn.Name = "eliminaMemberBtn";
            eliminaMemberBtn.Size = new Size(191, 67);
            eliminaMemberBtn.TabIndex = 55;
            eliminaMemberBtn.Text = "Eliminar";
            eliminaMemberBtn.UseVisualStyleBackColor = false;
            eliminaMemberBtn.Click += eliminaMemberBtn_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { op1ToolStripMenuItem });
            menuStrip1.Location = new Point(27, 21);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(81, 57);
            menuStrip1.TabIndex = 57;
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
            iniciStripMenuItem.Click += iniciStripMenuItem_Click;
            // 
            // logoutStripMenuItem
            // 
            logoutStripMenuItem.Name = "logoutStripMenuItem";
            logoutStripMenuItem.Size = new Size(213, 34);
            logoutStripMenuItem.Text = "Logout";
            logoutStripMenuItem.Click += logoutStripMenuItem_Click;
            // 
            // pageLocation
            // 
            pageLocation.AutoSize = true;
            pageLocation.BackColor = Color.Transparent;
            pageLocation.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            pageLocation.ForeColor = Color.FromArgb(107, 55, 50);
            pageLocation.Location = new Point(122, 32);
            pageLocation.Name = "pageLocation";
            pageLocation.Size = new Size(437, 28);
            pageLocation.TabIndex = 56;
            pageLocation.Text = "location: Username>MenuUsuari>GestioGrups";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(107, 55, 35);
            label1.Location = new Point(80, 665);
            label1.Name = "label1";
            label1.Size = new Size(430, 28);
            label1.TabIndex = 58;
            label1.Text = "Accions relacionades amb els membres del grup";
            // 
            // refreshBtn
            // 
            refreshBtn.Anchor = AnchorStyles.None;
            refreshBtn.Location = new Point(623, 626);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(112, 34);
            refreshBtn.TabIndex = 59;
            refreshBtn.Text = "Refresh";
            refreshBtn.UseVisualStyleBackColor = true;
            refreshBtn.Click += refreshBtn_Click;
            // 
            // numGrupTxt
            // 
            numGrupTxt.Anchor = AnchorStyles.None;
            numGrupTxt.BackColor = Color.FromArgb(107, 55, 35);
            numGrupTxt.Font = new Font("Segoe UI", 14F, FontStyle.Italic, GraphicsUnit.Point);
            numGrupTxt.ForeColor = Color.Black;
            numGrupTxt.Location = new Point(671, 117);
            numGrupTxt.Name = "numGrupTxt";
            numGrupTxt.Size = new Size(64, 45);
            numGrupTxt.TabIndex = 61;
            numGrupTxt.Visible = false;
            // 
            // linkUsernameBtn
            // 
            linkUsernameBtn.Anchor = AnchorStyles.None;
            linkUsernameBtn.Location = new Point(325, 795);
            linkUsernameBtn.Name = "linkUsernameBtn";
            linkUsernameBtn.Size = new Size(169, 34);
            linkUsernameBtn.TabIndex = 62;
            linkUsernameBtn.Text = "Link Username";
            linkUsernameBtn.UseVisualStyleBackColor = true;
            linkUsernameBtn.Visible = false;
            linkUsernameBtn.Click += linkUsernameBtn_Click;
            // 
            // updateNicknameBtn
            // 
            updateNicknameBtn.Anchor = AnchorStyles.None;
            updateNicknameBtn.Location = new Point(325, 851);
            updateNicknameBtn.Name = "updateNicknameBtn";
            updateNicknameBtn.Size = new Size(169, 34);
            updateNicknameBtn.TabIndex = 63;
            updateNicknameBtn.Text = "Update Nickname";
            updateNicknameBtn.UseVisualStyleBackColor = true;
            updateNicknameBtn.Visible = false;
            updateNicknameBtn.Click += updateNicknameBtn_Click;
            // 
            // User_ShowMembresGrup
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 899);
            Controls.Add(updateNicknameBtn);
            Controls.Add(linkUsernameBtn);
            Controls.Add(numGrupTxt);
            Controls.Add(refreshBtn);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(pageLocation);
            Controls.Add(eliminaMemberBtn);
            Controls.Add(updateMemberBtn);
            Controls.Add(listMembres);
            Controls.Add(totalParticipantsGroup);
            Controls.Add(labelTotalMembres);
            Controls.Add(labelCancelListMembres);
            Controls.Add(addMemberGrupBtn);
            Controls.Add(labelShowMembres);
            Name = "User_ShowMembresGrup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User_ShowMembresGrup";
            WindowState = FormWindowState.Maximized;
            Load += cabecera_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
        private Label labelCancelListMembres;
        private Button addMemberGrupBtn;
        private Label labelShowMembres;
        private TextBox totalParticipantsGroup;
        private Label labelTotalMembres;
        private ColumnHeader groupIDHeader1;
        private ColumnHeader nicknameHeader3;
        private ColumnHeader usernameHeader4;
        private ColumnHeader adminHeader4;
        protected ListView listMembres;
        private Button updateMemberBtn;
        private Button eliminaMemberBtn;
        private ColumnHeader userIDHeader2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem op1ToolStripMenuItem;
        private ToolStripMenuItem iniciStripMenuItem;
        private ToolStripMenuItem logoutStripMenuItem;
        private Label pageLocation;
        private Label label1;
        private Button refreshBtn;
        private TextBox numGrupTxt;
        private Button linkUsernameBtn;
        private Button updateNicknameBtn;
    }
}