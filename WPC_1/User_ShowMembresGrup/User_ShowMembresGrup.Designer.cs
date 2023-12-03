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
            nicknameHeader2 = new ColumnHeader();
            usernameHeader3 = new ColumnHeader();
            adminHeader4 = new ColumnHeader();
            updateMemberBtn = new Button();
            eliminaMemberBtn = new Button();
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
            labelCancelListMembres.Location = new Point(357, 695);
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
            addMemberGrupBtn.Location = new Point(77, 612);
            addMemberGrupBtn.Name = "addMemberGrupBtn";
            addMemberGrupBtn.Size = new Size(192, 67);
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
            labelShowMembres.Location = new Point(250, 47);
            labelShowMembres.Name = "labelShowMembres";
            labelShowMembres.Size = new Size(324, 54);
            labelShowMembres.TabIndex = 48;
            labelShowMembres.Text = "Show Membres";
            labelShowMembres.TextAlign = ContentAlignment.TopCenter;
            // 
            // totalParticipantsGroup
            // 
            totalParticipantsGroup.Anchor = AnchorStyles.None;
            totalParticipantsGroup.Font = new Font("Segoe UI", 14F, FontStyle.Italic, GraphicsUnit.Point);
            totalParticipantsGroup.Location = new Point(669, 103);
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
            labelTotalMembres.Location = new Point(602, 113);
            labelTotalMembres.Name = "labelTotalMembres";
            labelTotalMembres.Size = new Size(64, 30);
            labelTotalMembres.TabIndex = 51;
            labelTotalMembres.Text = "Total:";
            // 
            // listMembres
            // 
            listMembres.Anchor = AnchorStyles.None;
            listMembres.Columns.AddRange(new ColumnHeader[] { groupIDHeader1, nicknameHeader2, usernameHeader3, adminHeader4 });
            listMembres.FullRowSelect = true;
            listMembres.Location = new Point(77, 154);
            listMembres.MultiSelect = false;
            listMembres.Name = "listMembres";
            listMembres.Size = new Size(655, 395);
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
            // nicknameHeader2
            // 
            nicknameHeader2.Text = "Nickname";
            nicknameHeader2.Width = 131;
            // 
            // usernameHeader3
            // 
            usernameHeader3.Text = "Username";
            usernameHeader3.Width = 131;
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
            updateMemberBtn.Location = new Point(310, 612);
            updateMemberBtn.Name = "updateMemberBtn";
            updateMemberBtn.Size = new Size(192, 67);
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
            eliminaMemberBtn.Location = new Point(540, 612);
            eliminaMemberBtn.Name = "eliminaMemberBtn";
            eliminaMemberBtn.Size = new Size(192, 67);
            eliminaMemberBtn.TabIndex = 55;
            eliminaMemberBtn.Text = "Eliminar";
            eliminaMemberBtn.UseVisualStyleBackColor = false;
            // 
            // User_ShowMembresGrup
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 745);
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
        private ColumnHeader nicknameHeader2;
        private ColumnHeader usernameHeader3;
        private ColumnHeader adminHeader4;
        protected ListView listMembres;
        private Button updateMemberBtn;
        private Button eliminaMemberBtn;
    }
}