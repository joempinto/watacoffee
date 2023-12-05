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
            labelCancelListMembres.Location = new Point(250, 446);
            labelCancelListMembres.Margin = new Padding(2, 0, 2, 0);
            labelCancelListMembres.Name = "labelCancelListMembres";
            labelCancelListMembres.Size = new Size(76, 20);
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
            addMemberGrupBtn.Location = new Point(54, 396);
            addMemberGrupBtn.Margin = new Padding(2);
            addMemberGrupBtn.Name = "addMemberGrupBtn";
            addMemberGrupBtn.Size = new Size(134, 40);
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
            labelShowMembres.Location = new Point(175, 57);
            labelShowMembres.Margin = new Padding(2, 0, 2, 0);
            labelShowMembres.Name = "labelShowMembres";
            labelShowMembres.Size = new Size(222, 37);
            labelShowMembres.TabIndex = 48;
            labelShowMembres.Text = "Show Membres";
            labelShowMembres.TextAlign = ContentAlignment.TopCenter;
            // 
            // totalParticipantsGroup
            // 
            totalParticipantsGroup.Anchor = AnchorStyles.None;
            totalParticipantsGroup.Font = new Font("Segoe UI", 14F, FontStyle.Italic, GraphicsUnit.Point);
            totalParticipantsGroup.Location = new Point(468, 91);
            totalParticipantsGroup.Margin = new Padding(2);
            totalParticipantsGroup.Name = "totalParticipantsGroup";
            totalParticipantsGroup.Size = new Size(45, 32);
            totalParticipantsGroup.TabIndex = 52;
            // 
            // labelTotalMembres
            // 
            labelTotalMembres.Anchor = AnchorStyles.None;
            labelTotalMembres.AutoSize = true;
            labelTotalMembres.BackColor = Color.Transparent;
            labelTotalMembres.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotalMembres.ForeColor = Color.FromArgb(107, 55, 35);
            labelTotalMembres.Location = new Point(421, 97);
            labelTotalMembres.Margin = new Padding(2, 0, 2, 0);
            labelTotalMembres.Name = "labelTotalMembres";
            labelTotalMembres.Size = new Size(45, 20);
            labelTotalMembres.TabIndex = 51;
            labelTotalMembres.Text = "Total:";
            // 
            // listMembres
            // 
            listMembres.Anchor = AnchorStyles.None;
            listMembres.Columns.AddRange(new ColumnHeader[] { groupIDHeader1, userIDHeader2, nicknameHeader3, usernameHeader4, adminHeader4 });
            listMembres.FullRowSelect = true;
            listMembres.Location = new Point(54, 121);
            listMembres.Margin = new Padding(2);
            listMembres.MultiSelect = false;
            listMembres.Name = "listMembres";
            listMembres.Size = new Size(460, 239);
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
            updateMemberBtn.Location = new Point(217, 396);
            updateMemberBtn.Margin = new Padding(2);
            updateMemberBtn.Name = "updateMemberBtn";
            updateMemberBtn.Size = new Size(134, 40);
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
            eliminaMemberBtn.Location = new Point(378, 396);
            eliminaMemberBtn.Margin = new Padding(2);
            eliminaMemberBtn.Name = "eliminaMemberBtn";
            eliminaMemberBtn.Size = new Size(134, 40);
            eliminaMemberBtn.TabIndex = 55;
            eliminaMemberBtn.Text = "Eliminar";
            eliminaMemberBtn.UseVisualStyleBackColor = false;
            eliminaMemberBtn.Click += eliminaMemberBtn_Click;
            // 
            // User_ShowMembresGrup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(560, 478);
            Controls.Add(eliminaMemberBtn);
            Controls.Add(updateMemberBtn);
            Controls.Add(listMembres);
            Controls.Add(totalParticipantsGroup);
            Controls.Add(labelTotalMembres);
            Controls.Add(labelCancelListMembres);
            Controls.Add(addMemberGrupBtn);
            Controls.Add(labelShowMembres);
            Margin = new Padding(2);
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
        private ColumnHeader nicknameHeader3;
        private ColumnHeader usernameHeader4;
        private ColumnHeader adminHeader4;
        protected ListView listMembres;
        private Button updateMemberBtn;
        private Button eliminaMemberBtn;
        private ColumnHeader userIDHeader2;
    }
}