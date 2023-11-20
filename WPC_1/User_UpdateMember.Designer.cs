namespace WPC_1
{
    partial class User_UpdateMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_UpdateMember));
            labelUsername = new Label();
            usernameTxt = new TextBox();
            labelCancelUpdateMembre = new Label();
            confirmaUpdateMembreBtn = new Button();
            nicknameMembreTxt = new TextBox();
            labelNickname = new Label();
            idGrupTxt = new TextBox();
            labelGrupID = new Label();
            labelUpdate = new Label();
            SuspendLayout();
            // 
            // labelUsername
            // 
            labelUsername.Anchor = AnchorStyles.None;
            labelUsername.AutoSize = true;
            labelUsername.BackColor = Color.Transparent;
            labelUsername.ForeColor = Color.FromArgb(107, 55, 35);
            labelUsername.Location = new Point(115, 217);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(91, 25);
            labelUsername.TabIndex = 60;
            labelUsername.Text = "Username";
            // 
            // usernameTxt
            // 
            usernameTxt.Anchor = AnchorStyles.None;
            usernameTxt.Location = new Point(256, 214);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Size = new Size(274, 31);
            usernameTxt.TabIndex = 59;
            // 
            // labelCancelUpdateMembre
            // 
            labelCancelUpdateMembre.Anchor = AnchorStyles.None;
            labelCancelUpdateMembre.AutoSize = true;
            labelCancelUpdateMembre.BackColor = Color.Transparent;
            labelCancelUpdateMembre.Cursor = Cursors.Hand;
            labelCancelUpdateMembre.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelCancelUpdateMembre.ForeColor = Color.FromArgb(107, 55, 35);
            labelCancelUpdateMembre.Location = new Point(252, 365);
            labelCancelUpdateMembre.Name = "labelCancelUpdateMembre";
            labelCancelUpdateMembre.Size = new Size(109, 30);
            labelCancelUpdateMembre.TabIndex = 57;
            labelCancelUpdateMembre.Text = "Cancel.lar";
            labelCancelUpdateMembre.Click += labelCancelUpdateMembre_Click;
            // 
            // confirmaUpdateMembreBtn
            // 
            confirmaUpdateMembreBtn.Anchor = AnchorStyles.None;
            confirmaUpdateMembreBtn.BackColor = Color.FromArgb(107, 55, 35);
            confirmaUpdateMembreBtn.FlatStyle = FlatStyle.Popup;
            confirmaUpdateMembreBtn.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            confirmaUpdateMembreBtn.ForeColor = Color.FromArgb(64, 0, 0);
            confirmaUpdateMembreBtn.Location = new Point(215, 291);
            confirmaUpdateMembreBtn.Name = "confirmaUpdateMembreBtn";
            confirmaUpdateMembreBtn.Size = new Size(192, 67);
            confirmaUpdateMembreBtn.TabIndex = 56;
            confirmaUpdateMembreBtn.Text = "Confirmar";
            confirmaUpdateMembreBtn.UseVisualStyleBackColor = false;
            confirmaUpdateMembreBtn.Click += confirmaUpdateMembreBtn_Click;
            // 
            // nicknameMembreTxt
            // 
            nicknameMembreTxt.Anchor = AnchorStyles.None;
            nicknameMembreTxt.Location = new Point(256, 157);
            nicknameMembreTxt.Name = "nicknameMembreTxt";
            nicknameMembreTxt.Size = new Size(274, 31);
            nicknameMembreTxt.TabIndex = 55;
            // 
            // labelNickname
            // 
            labelNickname.Anchor = AnchorStyles.None;
            labelNickname.AutoSize = true;
            labelNickname.BackColor = Color.Transparent;
            labelNickname.ForeColor = Color.FromArgb(107, 55, 35);
            labelNickname.Location = new Point(115, 160);
            labelNickname.Name = "labelNickname";
            labelNickname.Size = new Size(90, 25);
            labelNickname.TabIndex = 54;
            labelNickname.Text = "Nickname";
            // 
            // idGrupTxt
            // 
            idGrupTxt.Anchor = AnchorStyles.None;
            idGrupTxt.Location = new Point(256, 103);
            idGrupTxt.Name = "idGrupTxt";
            idGrupTxt.Size = new Size(274, 31);
            idGrupTxt.TabIndex = 53;
            // 
            // labelGrupID
            // 
            labelGrupID.Anchor = AnchorStyles.None;
            labelGrupID.AutoSize = true;
            labelGrupID.BackColor = Color.Transparent;
            labelGrupID.ForeColor = Color.FromArgb(107, 55, 35);
            labelGrupID.Location = new Point(115, 106);
            labelGrupID.Name = "labelGrupID";
            labelGrupID.Size = new Size(74, 25);
            labelGrupID.TabIndex = 52;
            labelGrupID.Text = "ID Grup";
            // 
            // labelUpdate
            // 
            labelUpdate.Anchor = AnchorStyles.None;
            labelUpdate.AutoSize = true;
            labelUpdate.BackColor = Color.Transparent;
            labelUpdate.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold, GraphicsUnit.Point);
            labelUpdate.ForeColor = Color.FromArgb(107, 55, 35);
            labelUpdate.Location = new Point(136, 10);
            labelUpdate.Name = "labelUpdate";
            labelUpdate.Size = new Size(376, 60);
            labelUpdate.TabIndex = 51;
            labelUpdate.Text = "Update Membre";
            labelUpdate.TextAlign = ContentAlignment.TopCenter;
            // 
            // User_UpdateMember
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(600, 427);
            Controls.Add(labelUsername);
            Controls.Add(usernameTxt);
            Controls.Add(labelCancelUpdateMembre);
            Controls.Add(confirmaUpdateMembreBtn);
            Controls.Add(nicknameMembreTxt);
            Controls.Add(labelNickname);
            Controls.Add(idGrupTxt);
            Controls.Add(labelGrupID);
            Controls.Add(labelUpdate);
            Name = "User_UpdateMember";
            Text = "User_UpdateMember";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUsername;
        private TextBox usernameTxt;
        private Label labelCancelUpdateMembre;
        private Button confirmaUpdateMembreBtn;
        private TextBox nicknameMembreTxt;
        private Label labelNickname;
        private TextBox idGrupTxt;
        private Label labelGrupID;
        private Label labelUpdate;
    }
}