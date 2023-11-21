namespace WPC_1
{
    partial class User_GestioGrups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_GestioGrups));
            menuStrip1 = new MenuStrip();
            op1ToolStripMenuItem = new ToolStripMenuItem();
            iniciStripMenuItem = new ToolStripMenuItem();
            logoutStripMenuItem = new ToolStripMenuItem();
            pageLocation = new Label();
            label2 = new Label();
            creaGrupBtn = new Label();
            pictureBoxCreaGrup = new PictureBox();
            pictureBoxLlistaGrupTipus = new PictureBox();
            llistaGrupsTypeBtn = new Label();
            pictureBoxAddMemberGrup = new PictureBox();
            addMemberGrupBtn = new Label();
            listGrupsTipus = new ListBox();
            rbAdmin = new RadioButton();
            llistatBox = new GroupBox();
            totalGrupsLlista = new TextBox();
            label1 = new Label();
            infoSelecciona = new Label();
            imprimirLlistatBtn = new Button();
            rbTots = new RadioButton();
            rbMembre = new RadioButton();
            pictureBoxUpdateMemberGrup = new PictureBox();
            updateMemberBtn = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCreaGrup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLlistaGrupTipus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAddMemberGrup).BeginInit();
            llistatBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUpdateMemberGrup).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { op1ToolStripMenuItem });
            menuStrip1.Location = new Point(12, 11);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(261, 57);
            menuStrip1.TabIndex = 20;
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
            iniciStripMenuItem.Text = "Inici";
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
            pageLocation.Location = new Point(105, 24);
            pageLocation.Name = "pageLocation";
            pageLocation.Size = new Size(325, 28);
            pageLocation.TabIndex = 19;
            pageLocation.Text = "location: Username>MenuUsuari>";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(107, 55, 35);
            label2.Location = new Point(96, 78);
            label2.Name = "label2";
            label2.Size = new Size(368, 60);
            label2.TabIndex = 27;
            label2.Text = "Gestió de Grups";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // creaGrupBtn
            // 
            creaGrupBtn.AutoSize = true;
            creaGrupBtn.BackColor = Color.Transparent;
            creaGrupBtn.Cursor = Cursors.Hand;
            creaGrupBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            creaGrupBtn.ForeColor = Color.FromArgb(107, 55, 35);
            creaGrupBtn.Location = new Point(167, 262);
            creaGrupBtn.Name = "creaGrupBtn";
            creaGrupBtn.Size = new Size(174, 32);
            creaGrupBtn.TabIndex = 26;
            creaGrupBtn.Text = "Crear un grup";
            creaGrupBtn.Click += creaGrupBtn_Click;
            // 
            // pictureBoxCreaGrup
            // 
            pictureBoxCreaGrup.BackColor = Color.Transparent;
            pictureBoxCreaGrup.Image = (Image)resources.GetObject("pictureBoxCreaGrup.Image");
            pictureBoxCreaGrup.Location = new Point(120, 258);
            pictureBoxCreaGrup.Name = "pictureBoxCreaGrup";
            pictureBoxCreaGrup.Size = new Size(41, 36);
            pictureBoxCreaGrup.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCreaGrup.TabIndex = 28;
            pictureBoxCreaGrup.TabStop = false;
            // 
            // pictureBoxLlistaGrupTipus
            // 
            pictureBoxLlistaGrupTipus.BackColor = Color.Transparent;
            pictureBoxLlistaGrupTipus.Image = (Image)resources.GetObject("pictureBoxLlistaGrupTipus.Image");
            pictureBoxLlistaGrupTipus.Location = new Point(120, 172);
            pictureBoxLlistaGrupTipus.Name = "pictureBoxLlistaGrupTipus";
            pictureBoxLlistaGrupTipus.Size = new Size(41, 36);
            pictureBoxLlistaGrupTipus.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLlistaGrupTipus.TabIndex = 30;
            pictureBoxLlistaGrupTipus.TabStop = false;
            // 
            // llistaGrupsTypeBtn
            // 
            llistaGrupsTypeBtn.AutoSize = true;
            llistaGrupsTypeBtn.BackColor = Color.Transparent;
            llistaGrupsTypeBtn.Cursor = Cursors.Hand;
            llistaGrupsTypeBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            llistaGrupsTypeBtn.ForeColor = Color.FromArgb(107, 55, 35);
            llistaGrupsTypeBtn.Location = new Point(167, 176);
            llistaGrupsTypeBtn.Name = "llistaGrupsTypeBtn";
            llistaGrupsTypeBtn.Size = new Size(254, 32);
            llistaGrupsTypeBtn.TabIndex = 29;
            llistaGrupsTypeBtn.Text = "Llistar grup per tipus";
            llistaGrupsTypeBtn.Click += llistaGrupsTypeBtn_Click;
            // 
            // pictureBoxAddMemberGrup
            // 
            pictureBoxAddMemberGrup.BackColor = Color.Transparent;
            pictureBoxAddMemberGrup.Image = (Image)resources.GetObject("pictureBoxAddMemberGrup.Image");
            pictureBoxAddMemberGrup.Location = new Point(120, 343);
            pictureBoxAddMemberGrup.Name = "pictureBoxAddMemberGrup";
            pictureBoxAddMemberGrup.Size = new Size(41, 36);
            pictureBoxAddMemberGrup.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAddMemberGrup.TabIndex = 32;
            pictureBoxAddMemberGrup.TabStop = false;
            // 
            // addMemberGrupBtn
            // 
            addMemberGrupBtn.AutoSize = true;
            addMemberGrupBtn.BackColor = Color.Transparent;
            addMemberGrupBtn.Cursor = Cursors.Hand;
            addMemberGrupBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addMemberGrupBtn.ForeColor = Color.FromArgb(107, 55, 35);
            addMemberGrupBtn.Location = new Point(167, 347);
            addMemberGrupBtn.Name = "addMemberGrupBtn";
            addMemberGrupBtn.Size = new Size(187, 32);
            addMemberGrupBtn.TabIndex = 31;
            addMemberGrupBtn.Text = "Afegir membre";
            addMemberGrupBtn.Click += addMemberGrupBtn_Click;
            // 
            // listGrupsTipus
            // 
            listGrupsTipus.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            listGrupsTipus.FormattingEnabled = true;
            listGrupsTipus.ItemHeight = 28;
            listGrupsTipus.Location = new Point(76, 108);
            listGrupsTipus.MultiColumn = true;
            listGrupsTipus.Name = "listGrupsTipus";
            listGrupsTipus.Size = new Size(591, 424);
            listGrupsTipus.TabIndex = 33;
            // 
            // rbAdmin
            // 
            rbAdmin.AutoSize = true;
            rbAdmin.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rbAdmin.Location = new Point(107, 73);
            rbAdmin.Name = "rbAdmin";
            rbAdmin.Size = new Size(137, 32);
            rbAdmin.TabIndex = 34;
            rbAdmin.TabStop = true;
            rbAdmin.Text = "Sóc Admin";
            rbAdmin.UseVisualStyleBackColor = true;
            // 
            // llistatBox
            // 
            llistatBox.BackColor = Color.Transparent;
            llistatBox.Controls.Add(totalGrupsLlista);
            llistatBox.Controls.Add(label1);
            llistatBox.Controls.Add(infoSelecciona);
            llistatBox.Controls.Add(imprimirLlistatBtn);
            llistatBox.Controls.Add(rbTots);
            llistatBox.Controls.Add(rbMembre);
            llistatBox.Controls.Add(listGrupsTipus);
            llistatBox.Controls.Add(rbAdmin);
            llistatBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            llistatBox.ForeColor = Color.FromArgb(107, 55, 35);
            llistatBox.Location = new Point(439, 172);
            llistatBox.Name = "llistatBox";
            llistatBox.Size = new Size(791, 539);
            llistatBox.TabIndex = 35;
            llistatBox.TabStop = false;
            llistatBox.Text = "Llistat de Grups";
            llistatBox.Visible = false;
            // 
            // totalGrupsLlista
            // 
            totalGrupsLlista.Font = new Font("Segoe UI", 14F, FontStyle.Italic, GraphicsUnit.Point);
            totalGrupsLlista.Location = new Point(693, 132);
            totalGrupsLlista.Name = "totalGrupsLlista";
            totalGrupsLlista.Size = new Size(63, 45);
            totalGrupsLlista.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(107, 55, 35);
            label1.Location = new Point(693, 90);
            label1.Name = "label1";
            label1.Size = new Size(64, 30);
            label1.TabIndex = 39;
            label1.Text = "Total:";
            // 
            // infoSelecciona
            // 
            infoSelecciona.AutoSize = true;
            infoSelecciona.Location = new Point(138, 40);
            infoSelecciona.Name = "infoSelecciona";
            infoSelecciona.Size = new Size(384, 28);
            infoSelecciona.TabIndex = 38;
            infoSelecciona.Text = "Selecciona una de les opcions i prem \"Go!\"";
            // 
            // imprimirLlistatBtn
            // 
            imprimirLlistatBtn.Location = new Point(526, 73);
            imprimirLlistatBtn.Name = "imprimirLlistatBtn";
            imprimirLlistatBtn.Size = new Size(94, 34);
            imprimirLlistatBtn.TabIndex = 37;
            imprimirLlistatBtn.Text = "Go!";
            imprimirLlistatBtn.UseVisualStyleBackColor = true;
            imprimirLlistatBtn.Click += imprimirLlistatBtn_Click;
            // 
            // rbTots
            // 
            rbTots.AutoSize = true;
            rbTots.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rbTots.Location = new Point(430, 73);
            rbTots.Name = "rbTots";
            rbTots.Size = new Size(78, 32);
            rbTots.TabIndex = 36;
            rbTots.TabStop = true;
            rbTots.Text = "Tots";
            rbTots.UseVisualStyleBackColor = true;
            // 
            // rbMembre
            // 
            rbMembre.AutoSize = true;
            rbMembre.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rbMembre.Location = new Point(261, 73);
            rbMembre.Name = "rbMembre";
            rbMembre.Size = new Size(150, 32);
            rbMembre.TabIndex = 35;
            rbMembre.TabStop = true;
            rbMembre.Text = "Sóc Membre";
            rbMembre.UseVisualStyleBackColor = true;
            // 
            // pictureBoxUpdateMemberGrup
            // 
            pictureBoxUpdateMemberGrup.BackColor = Color.Transparent;
            pictureBoxUpdateMemberGrup.Image = (Image)resources.GetObject("pictureBoxUpdateMemberGrup.Image");
            pictureBoxUpdateMemberGrup.Location = new Point(120, 434);
            pictureBoxUpdateMemberGrup.Name = "pictureBoxUpdateMemberGrup";
            pictureBoxUpdateMemberGrup.Size = new Size(41, 36);
            pictureBoxUpdateMemberGrup.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxUpdateMemberGrup.TabIndex = 37;
            pictureBoxUpdateMemberGrup.TabStop = false;
            // 
            // updateMemberBtn
            // 
            updateMemberBtn.AutoSize = true;
            updateMemberBtn.BackColor = Color.Transparent;
            updateMemberBtn.Cursor = Cursors.Hand;
            updateMemberBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            updateMemberBtn.ForeColor = Color.FromArgb(107, 55, 35);
            updateMemberBtn.Location = new Point(167, 438);
            updateMemberBtn.Name = "updateMemberBtn";
            updateMemberBtn.Size = new Size(230, 32);
            updateMemberBtn.TabIndex = 36;
            updateMemberBtn.Text = "Actualitza membre";
            updateMemberBtn.Click += updateMemberBtn_Click;
            // 
            // User_GestioGrups
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1333, 711);
            Controls.Add(pictureBoxUpdateMemberGrup);
            Controls.Add(updateMemberBtn);
            Controls.Add(llistatBox);
            Controls.Add(pictureBoxAddMemberGrup);
            Controls.Add(addMemberGrupBtn);
            Controls.Add(pictureBoxLlistaGrupTipus);
            Controls.Add(llistaGrupsTypeBtn);
            Controls.Add(pictureBoxCreaGrup);
            Controls.Add(label2);
            Controls.Add(creaGrupBtn);
            Controls.Add(menuStrip1);
            Controls.Add(pageLocation);
            Name = "User_GestioGrups";
            Text = "User_GestioGrups";
            WindowState = FormWindowState.Maximized;
            Load += User_GestioGrups_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCreaGrup).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLlistaGrupTipus).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAddMemberGrup).EndInit();
            llistatBox.ResumeLayout(false);
            llistatBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUpdateMemberGrup).EndInit();
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
        private Label creaGrupBtn;
        private PictureBox pictureBoxCreaGrup;
        private PictureBox pictureBoxLlistaGrupTipus;
        private Label llistaGrupsTypeBtn;
        private PictureBox pictureBoxAddMemberGrup;
        private Label addMemberGrupBtn;
        private ListBox listGrupsTipus;
        private RadioButton rbAdmin;
        private GroupBox llistatBox;
        private Button imprimirLlistatBtn;
        private RadioButton rbTots;
        private RadioButton rbMembre;
        private Label infoSelecciona;
        private TextBox totalGrupsLlista;
        private Label label1;
        private PictureBox pictureBoxUpdateMemberGrup;
        private Label updateMemberBtn;
    }
}