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
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCreaGrup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLlistaGrupTipus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAddMemberGrup).BeginInit();
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
            menuStrip1.Size = new Size(81, 57);
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
            iniciStripMenuItem.Size = new Size(171, 34);
            iniciStripMenuItem.Text = "Inici";
            iniciStripMenuItem.Click += iniciStripMenuItem_Click;
            // 
            // logoutStripMenuItem
            // 
            logoutStripMenuItem.Name = "logoutStripMenuItem";
            logoutStripMenuItem.Size = new Size(171, 34);
            logoutStripMenuItem.Text = "Logout";
            // 
            // pageLocation
            // 
            pageLocation.AutoSize = true;
            pageLocation.BackColor = Color.Transparent;
            pageLocation.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            pageLocation.ForeColor = Color.FromArgb(107, 55, 50);
            pageLocation.Location = new Point(105, 24);
            pageLocation.Name = "pageLocation";
            pageLocation.Size = new Size(377, 28);
            pageLocation.TabIndex = 19;
            pageLocation.Text = "location: Username>GestiodelaAplicacio";
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
            creaGrupBtn.Location = new Point(167, 166);
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
            pictureBoxCreaGrup.Location = new Point(120, 162);
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
            pictureBoxLlistaGrupTipus.Location = new Point(120, 255);
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
            llistaGrupsTypeBtn.Location = new Point(167, 259);
            llistaGrupsTypeBtn.Name = "llistaGrupsTypeBtn";
            llistaGrupsTypeBtn.Size = new Size(254, 32);
            llistaGrupsTypeBtn.TabIndex = 29;
            llistaGrupsTypeBtn.Text = "Llistar grup per tipus";
            // 
            // pictureBoxAddMemberGrup
            // 
            pictureBoxAddMemberGrup.BackColor = Color.Transparent;
            pictureBoxAddMemberGrup.Image = (Image)resources.GetObject("pictureBoxAddMemberGrup.Image");
            pictureBoxAddMemberGrup.Location = new Point(120, 350);
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
            addMemberGrupBtn.Location = new Point(167, 354);
            addMemberGrupBtn.Name = "addMemberGrupBtn";
            addMemberGrupBtn.Size = new Size(187, 32);
            addMemberGrupBtn.TabIndex = 31;
            addMemberGrupBtn.Text = "Afegir membre";
            // 
            // User_GestioGrups
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
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
    }
}