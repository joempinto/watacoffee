namespace WPC_1
{
    partial class User_LlistaMembresDeGrupPagaments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_LlistaMembresDeGrupPagaments));
            labelGrup = new Label();
            labelCancelCanviPwd = new Label();
            labelNomGrup = new Label();
            listView1 = new ListView();
            columnHeaderIsMember = new ColumnHeader();
            columnHeaderNickname = new ColumnHeader();
            columnHeaderAmount = new ColumnHeader();
            columnHeaderData = new ColumnHeader();
            columnHeaderHasTicket = new ColumnHeader();
            label6 = new Label();
            SuspendLayout();
            // 
            // labelGrup
            // 
            labelGrup.Anchor = AnchorStyles.None;
            labelGrup.AutoSize = true;
            labelGrup.BackColor = Color.Transparent;
            labelGrup.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold, GraphicsUnit.Point);
            labelGrup.ForeColor = Color.FromArgb(107, 55, 35);
            labelGrup.Location = new Point(25, 9);
            labelGrup.Name = "labelGrup";
            labelGrup.Size = new Size(132, 60);
            labelGrup.TabIndex = 24;
            labelGrup.Text = "Grup";
            labelGrup.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelCancelCanviPwd
            // 
            labelCancelCanviPwd.Anchor = AnchorStyles.None;
            labelCancelCanviPwd.AutoSize = true;
            labelCancelCanviPwd.BackColor = Color.Transparent;
            labelCancelCanviPwd.Cursor = Cursors.Hand;
            labelCancelCanviPwd.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelCancelCanviPwd.ForeColor = Color.FromArgb(107, 55, 35);
            labelCancelCanviPwd.Location = new Point(343, 685);
            labelCancelCanviPwd.Name = "labelCancelCanviPwd";
            labelCancelCanviPwd.Size = new Size(109, 30);
            labelCancelCanviPwd.TabIndex = 34;
            labelCancelCanviPwd.Text = "Cancel.lar";
            labelCancelCanviPwd.Click += labelCancelCanviPwd_Click;
            // 
            // labelNomGrup
            // 
            labelNomGrup.Anchor = AnchorStyles.None;
            labelNomGrup.AutoSize = true;
            labelNomGrup.BackColor = Color.Transparent;
            labelNomGrup.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold, GraphicsUnit.Point);
            labelNomGrup.ForeColor = Color.FromArgb(107, 55, 35);
            labelNomGrup.Location = new Point(144, 9);
            labelNomGrup.Name = "labelNomGrup";
            labelNomGrup.Size = new Size(230, 60);
            labelNomGrup.TabIndex = 35;
            labelNomGrup.Text = "nomGrup";
            labelNomGrup.TextAlign = ContentAlignment.TopCenter;
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.None;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeaderIsMember, columnHeaderNickname, columnHeaderAmount, columnHeaderData, columnHeaderHasTicket });
            listView1.Location = new Point(17, 81);
            listView1.Name = "listView1";
            listView1.Size = new Size(765, 579);
            listView1.TabIndex = 36;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
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
            // columnHeaderHasTicket
            // 
            columnHeaderHasTicket.Text = "Ticket uploaded?";
            columnHeaderHasTicket.Width = 146;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = Color.FromArgb(107, 55, 35);
            label6.Location = new Point(647, 37);
            label6.Name = "label6";
            label6.Size = new Size(111, 25);
            label6.TabIndex = 37;
            label6.Text = "Request #33";
            // 
            // User_LlistaMembresDeGrupPagaments
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 747);
            Controls.Add(label6);
            Controls.Add(listView1);
            Controls.Add(labelNomGrup);
            Controls.Add(labelCancelCanviPwd);
            Controls.Add(labelGrup);
            Name = "User_LlistaMembresDeGrupPagaments";
            Text = "User_LlistaMembresDeGrupPagaments";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelGrup;
        private Label labelCancelCanviPwd;
        private Label labelNomGrup;
        private ListView listView1;
        private ColumnHeader columnHeaderNickname;
        private Label label6;
        private ColumnHeader columnHeaderIsMember;
        private ColumnHeader columnHeaderAmount;
        private ColumnHeader columnHeaderData;
        private ColumnHeader columnHeaderHasTicket;
    }
}