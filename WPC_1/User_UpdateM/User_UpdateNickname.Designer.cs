namespace WPC_1
{
    partial class User_UpdateNickname
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_UpdateNickname));
            nouNicknameTxt = new TextBox();
            labelNouNickname = new Label();
            labelCancelUpdateMembre = new Label();
            confirmaUpdateMembreBtn = new Button();
            nicknameAnticTxt = new TextBox();
            labelNicknameAntic = new Label();
            idGrupTxt = new TextBox();
            labelGrupID = new Label();
            labelUpdate = new Label();
            SuspendLayout();
            // 
            // nouNicknameTxt
            // 
            nouNicknameTxt.Anchor = AnchorStyles.None;
            nouNicknameTxt.Location = new Point(288, 230);
            nouNicknameTxt.Name = "nouNicknameTxt";
            nouNicknameTxt.Size = new Size(274, 31);
            nouNicknameTxt.TabIndex = 71;
            // 
            // labelNouNickname
            // 
            labelNouNickname.Anchor = AnchorStyles.None;
            labelNouNickname.AutoSize = true;
            labelNouNickname.BackColor = Color.Transparent;
            labelNouNickname.ForeColor = Color.FromArgb(107, 55, 35);
            labelNouNickname.Location = new Point(146, 233);
            labelNouNickname.Name = "labelNouNickname";
            labelNouNickname.Size = new Size(129, 25);
            labelNouNickname.TabIndex = 70;
            labelNouNickname.Text = "Nou Nickname";
            // 
            // labelCancelUpdateMembre
            // 
            labelCancelUpdateMembre.Anchor = AnchorStyles.None;
            labelCancelUpdateMembre.AutoSize = true;
            labelCancelUpdateMembre.BackColor = Color.Transparent;
            labelCancelUpdateMembre.Cursor = Cursors.Hand;
            labelCancelUpdateMembre.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelCancelUpdateMembre.ForeColor = Color.FromArgb(107, 55, 35);
            labelCancelUpdateMembre.Location = new Point(307, 392);
            labelCancelUpdateMembre.Name = "labelCancelUpdateMembre";
            labelCancelUpdateMembre.Size = new Size(109, 30);
            labelCancelUpdateMembre.TabIndex = 69;
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
            confirmaUpdateMembreBtn.Location = new Point(262, 307);
            confirmaUpdateMembreBtn.Name = "confirmaUpdateMembreBtn";
            confirmaUpdateMembreBtn.Size = new Size(192, 67);
            confirmaUpdateMembreBtn.TabIndex = 68;
            confirmaUpdateMembreBtn.Text = "Confirmar";
            confirmaUpdateMembreBtn.UseVisualStyleBackColor = false;
            confirmaUpdateMembreBtn.Click += confirmaUpdateMembreBtn_Click;
            // 
            // nicknameAnticTxt
            // 
            nicknameAnticTxt.Anchor = AnchorStyles.None;
            nicknameAnticTxt.Location = new Point(288, 174);
            nicknameAnticTxt.Name = "nicknameAnticTxt";
            nicknameAnticTxt.Size = new Size(274, 31);
            nicknameAnticTxt.TabIndex = 67;
            // 
            // labelNicknameAntic
            // 
            labelNicknameAntic.Anchor = AnchorStyles.None;
            labelNicknameAntic.AutoSize = true;
            labelNicknameAntic.BackColor = Color.Transparent;
            labelNicknameAntic.ForeColor = Color.FromArgb(107, 55, 35);
            labelNicknameAntic.Location = new Point(147, 177);
            labelNicknameAntic.Name = "labelNicknameAntic";
            labelNicknameAntic.Size = new Size(132, 25);
            labelNicknameAntic.TabIndex = 66;
            labelNicknameAntic.Text = "Nickname antic";
            // 
            // idGrupTxt
            // 
            idGrupTxt.Anchor = AnchorStyles.None;
            idGrupTxt.Location = new Point(288, 120);
            idGrupTxt.Name = "idGrupTxt";
            idGrupTxt.Size = new Size(274, 31);
            idGrupTxt.TabIndex = 65;
            // 
            // labelGrupID
            // 
            labelGrupID.Anchor = AnchorStyles.None;
            labelGrupID.AutoSize = true;
            labelGrupID.BackColor = Color.Transparent;
            labelGrupID.ForeColor = Color.FromArgb(107, 55, 35);
            labelGrupID.Location = new Point(147, 123);
            labelGrupID.Name = "labelGrupID";
            labelGrupID.Size = new Size(74, 25);
            labelGrupID.TabIndex = 64;
            labelGrupID.Text = "ID Grup";
            // 
            // labelUpdate
            // 
            labelUpdate.Anchor = AnchorStyles.None;
            labelUpdate.AutoSize = true;
            labelUpdate.BackColor = Color.Transparent;
            labelUpdate.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelUpdate.ForeColor = Color.FromArgb(107, 55, 35);
            labelUpdate.Location = new Point(147, 38);
            labelUpdate.Name = "labelUpdate";
            labelUpdate.Size = new Size(409, 54);
            labelUpdate.TabIndex = 63;
            labelUpdate.Text = "Actualiza Nickname";
            labelUpdate.TextAlign = ContentAlignment.TopCenter;
            // 
            // User_UpdateNickname
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(696, 450);
            Controls.Add(nouNicknameTxt);
            Controls.Add(labelNouNickname);
            Controls.Add(labelCancelUpdateMembre);
            Controls.Add(confirmaUpdateMembreBtn);
            Controls.Add(nicknameAnticTxt);
            Controls.Add(labelNicknameAntic);
            Controls.Add(idGrupTxt);
            Controls.Add(labelGrupID);
            Controls.Add(labelUpdate);
            Name = "User_UpdateNickname";
            Text = "User_UpdateNickname";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nouNicknameTxt;
        private Label labelNouNickname;
        private Label labelCancelUpdateMembre;
        private Button confirmaUpdateMembreBtn;
        private TextBox nicknameAnticTxt;
        private Label labelNicknameAntic;
        private TextBox idGrupTxt;
        private Label labelGrupID;
        private Label labelUpdate;
    }
}