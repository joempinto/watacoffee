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
            rbAdmin = new RadioButton();
            llistatBox = new GroupBox();
            listGrupsTipus = new ListView();
            idGrupHeader1 = new ColumnHeader();
            nomGrupHeader2 = new ColumnHeader();
            totalGrupsLlista = new TextBox();
            label3 = new Label();
            label1 = new Label();
            idGrupShow = new TextBox();
            infoSelecciona = new Label();
            imprimirLlistatBtn = new Button();
            rbTots = new RadioButton();
            rbMembre = new RadioButton();
            pictureBoxShowMembresGrup = new PictureBox();
            showMembresGrupBtn = new Label();
            pictureBoxDeleteGrup = new PictureBox();
            deleteGrupBtn = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCreaGrup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLlistaGrupTipus).BeginInit();
            llistatBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShowMembresGrup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDeleteGrup).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { op1ToolStripMenuItem });
            menuStrip1.Location = new Point(8, 7);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(56, 45);
            menuStrip1.TabIndex = 20;
            menuStrip1.Text = "menuStrip1";
            // 
            // op1ToolStripMenuItem
            // 
            op1ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { iniciStripMenuItem, logoutStripMenuItem });
            op1ToolStripMenuItem.Image = Properties.Resources.main_coffee;
            op1ToolStripMenuItem.Name = "op1ToolStripMenuItem";
            op1ToolStripMenuItem.Size = new Size(50, 43);
            op1ToolStripMenuItem.Text = "Menu";
            op1ToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // iniciStripMenuItem
            // 
            iniciStripMenuItem.Name = "iniciStripMenuItem";
            iniciStripMenuItem.Size = new Size(112, 22);
            iniciStripMenuItem.Text = "Inici";
            iniciStripMenuItem.Click += iniciStripMenuItem_Click;
            // 
            // logoutStripMenuItem
            // 
            logoutStripMenuItem.Name = "logoutStripMenuItem";
            logoutStripMenuItem.Size = new Size(112, 22);
            logoutStripMenuItem.Text = "Logout";
            logoutStripMenuItem.Click += logoutStripMenuItem_Click;
            // 
            // pageLocation
            // 
            pageLocation.AutoSize = true;
            pageLocation.BackColor = Color.Transparent;
            pageLocation.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            pageLocation.ForeColor = Color.FromArgb(107, 55, 50);
            pageLocation.Location = new Point(74, 14);
            pageLocation.Margin = new Padding(2, 0, 2, 0);
            pageLocation.Name = "pageLocation";
            pageLocation.Size = new Size(225, 19);
            pageLocation.TabIndex = 19;
            pageLocation.Text = "location: Username>MenuUsuari>";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(107, 55, 35);
            label2.Location = new Point(67, 47);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(251, 41);
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
            creaGrupBtn.Location = new Point(125, 124);
            creaGrupBtn.Margin = new Padding(2, 0, 2, 0);
            creaGrupBtn.Name = "creaGrupBtn";
            creaGrupBtn.Size = new Size(114, 21);
            creaGrupBtn.TabIndex = 26;
            creaGrupBtn.Text = "Crear un grup";
            creaGrupBtn.Click += creaGrupBtn_Click_1;
            // 
            // pictureBoxCreaGrup
            // 
            pictureBoxCreaGrup.BackColor = Color.Transparent;
            pictureBoxCreaGrup.Image = (Image)resources.GetObject("pictureBoxCreaGrup.Image");
            pictureBoxCreaGrup.Location = new Point(92, 121);
            pictureBoxCreaGrup.Margin = new Padding(2);
            pictureBoxCreaGrup.Name = "pictureBoxCreaGrup";
            pictureBoxCreaGrup.Size = new Size(29, 22);
            pictureBoxCreaGrup.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCreaGrup.TabIndex = 28;
            pictureBoxCreaGrup.TabStop = false;
            // 
            // pictureBoxLlistaGrupTipus
            // 
            pictureBoxLlistaGrupTipus.BackColor = Color.Transparent;
            pictureBoxLlistaGrupTipus.Image = (Image)resources.GetObject("pictureBoxLlistaGrupTipus.Image");
            pictureBoxLlistaGrupTipus.Location = new Point(91, 180);
            pictureBoxLlistaGrupTipus.Margin = new Padding(2);
            pictureBoxLlistaGrupTipus.Name = "pictureBoxLlistaGrupTipus";
            pictureBoxLlistaGrupTipus.Size = new Size(29, 22);
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
            llistaGrupsTypeBtn.Location = new Point(124, 182);
            llistaGrupsTypeBtn.Margin = new Padding(2, 0, 2, 0);
            llistaGrupsTypeBtn.Name = "llistaGrupsTypeBtn";
            llistaGrupsTypeBtn.Size = new Size(167, 21);
            llistaGrupsTypeBtn.TabIndex = 29;
            llistaGrupsTypeBtn.Text = "Llistar grup per tipus";
            llistaGrupsTypeBtn.Click += llistaGrupsTypeBtn_Click;
            // 
            // rbAdmin
            // 
            rbAdmin.AutoSize = true;
            rbAdmin.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rbAdmin.Location = new Point(75, 44);
            rbAdmin.Margin = new Padding(2);
            rbAdmin.Name = "rbAdmin";
            rbAdmin.Size = new Size(96, 23);
            rbAdmin.TabIndex = 34;
            rbAdmin.TabStop = true;
            rbAdmin.Text = "Sóc Admin";
            rbAdmin.UseVisualStyleBackColor = true;
            // 
            // llistatBox
            // 
            llistatBox.BackColor = Color.Transparent;
            llistatBox.Controls.Add(listGrupsTipus);
            llistatBox.Controls.Add(totalGrupsLlista);
            llistatBox.Controls.Add(label3);
            llistatBox.Controls.Add(label1);
            llistatBox.Controls.Add(idGrupShow);
            llistatBox.Controls.Add(infoSelecciona);
            llistatBox.Controls.Add(imprimirLlistatBtn);
            llistatBox.Controls.Add(rbTots);
            llistatBox.Controls.Add(rbMembre);
            llistatBox.Controls.Add(rbAdmin);
            llistatBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            llistatBox.ForeColor = Color.FromArgb(107, 55, 35);
            llistatBox.Location = new Point(340, 103);
            llistatBox.Margin = new Padding(2);
            llistatBox.Name = "llistatBox";
            llistatBox.Padding = new Padding(2);
            llistatBox.Size = new Size(554, 323);
            llistatBox.TabIndex = 35;
            llistatBox.TabStop = false;
            llistatBox.Text = "Llistat de Grups";
            llistatBox.Visible = false;
            // 
            // listGrupsTipus
            // 
            listGrupsTipus.Columns.AddRange(new ColumnHeader[] { idGrupHeader1, nomGrupHeader2 });
            listGrupsTipus.FullRowSelect = true;
            listGrupsTipus.Location = new Point(20, 70);
            listGrupsTipus.Margin = new Padding(2);
            listGrupsTipus.Name = "listGrupsTipus";
            listGrupsTipus.Size = new Size(462, 251);
            listGrupsTipus.TabIndex = 41;
            listGrupsTipus.UseCompatibleStateImageBehavior = false;
            listGrupsTipus.View = View.Details;
            listGrupsTipus.SelectedIndexChanged += selectedIndexChanged;
            listGrupsTipus.Click += listIndex_Click;
            // 
            // idGrupHeader1
            // 
            idGrupHeader1.Text = "Group ID";
            idGrupHeader1.Width = 92;
            // 
            // nomGrupHeader2
            // 
            nomGrupHeader2.Text = "Nom Del Grup";
            nomGrupHeader2.Width = 562;
            // 
            // totalGrupsLlista
            // 
            totalGrupsLlista.Font = new Font("Segoe UI", 14F, FontStyle.Italic, GraphicsUnit.Point);
            totalGrupsLlista.Location = new Point(485, 79);
            totalGrupsLlista.Margin = new Padding(2);
            totalGrupsLlista.Name = "totalGrupsLlista";
            totalGrupsLlista.Size = new Size(45, 32);
            totalGrupsLlista.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(107, 55, 35);
            label3.Location = new Point(485, 127);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(58, 19);
            label3.TabIndex = 41;
            label3.Text = "Grup ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(107, 55, 35);
            label1.Location = new Point(485, 54);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 39;
            label1.Text = "Total:";
            // 
            // idGrupShow
            // 
            idGrupShow.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            idGrupShow.Location = new Point(486, 146);
            idGrupShow.Margin = new Padding(2);
            idGrupShow.Name = "idGrupShow";
            idGrupShow.Size = new Size(58, 29);
            idGrupShow.TabIndex = 41;
            // 
            // infoSelecciona
            // 
            infoSelecciona.AutoSize = true;
            infoSelecciona.Location = new Point(97, 24);
            infoSelecciona.Margin = new Padding(2, 0, 2, 0);
            infoSelecciona.Name = "infoSelecciona";
            infoSelecciona.Size = new Size(267, 19);
            infoSelecciona.TabIndex = 38;
            infoSelecciona.Text = "Selecciona una de les opcions i prem \"Go!\"";
            // 
            // imprimirLlistatBtn
            // 
            imprimirLlistatBtn.Location = new Point(368, 44);
            imprimirLlistatBtn.Margin = new Padding(2);
            imprimirLlistatBtn.Name = "imprimirLlistatBtn";
            imprimirLlistatBtn.Size = new Size(66, 20);
            imprimirLlistatBtn.TabIndex = 37;
            imprimirLlistatBtn.Text = "Go!";
            imprimirLlistatBtn.UseVisualStyleBackColor = true;
            imprimirLlistatBtn.Click += imprimirLlistatBtn_Click;
            // 
            // rbTots
            // 
            rbTots.AutoSize = true;
            rbTots.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rbTots.Location = new Point(301, 44);
            rbTots.Margin = new Padding(2);
            rbTots.Name = "rbTots";
            rbTots.Size = new Size(54, 23);
            rbTots.TabIndex = 36;
            rbTots.TabStop = true;
            rbTots.Text = "Tots";
            rbTots.UseVisualStyleBackColor = true;
            // 
            // rbMembre
            // 
            rbMembre.AutoSize = true;
            rbMembre.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rbMembre.Location = new Point(183, 44);
            rbMembre.Margin = new Padding(2);
            rbMembre.Name = "rbMembre";
            rbMembre.Size = new Size(106, 23);
            rbMembre.TabIndex = 35;
            rbMembre.TabStop = true;
            rbMembre.Text = "Sóc Membre";
            rbMembre.UseVisualStyleBackColor = true;
            // 
            // pictureBoxShowMembresGrup
            // 
            pictureBoxShowMembresGrup.BackColor = Color.Transparent;
            pictureBoxShowMembresGrup.Enabled = false;
            pictureBoxShowMembresGrup.Image = (Image)resources.GetObject("pictureBoxShowMembresGrup.Image");
            pictureBoxShowMembresGrup.Location = new Point(91, 245);
            pictureBoxShowMembresGrup.Margin = new Padding(2);
            pictureBoxShowMembresGrup.Name = "pictureBoxShowMembresGrup";
            pictureBoxShowMembresGrup.Size = new Size(29, 22);
            pictureBoxShowMembresGrup.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxShowMembresGrup.TabIndex = 39;
            pictureBoxShowMembresGrup.TabStop = false;
            // 
            // showMembresGrupBtn
            // 
            showMembresGrupBtn.AutoSize = true;
            showMembresGrupBtn.BackColor = Color.Transparent;
            showMembresGrupBtn.Cursor = Cursors.Hand;
            showMembresGrupBtn.Enabled = false;
            showMembresGrupBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            showMembresGrupBtn.ForeColor = Color.FromArgb(107, 55, 35);
            showMembresGrupBtn.Location = new Point(124, 247);
            showMembresGrupBtn.Margin = new Padding(2, 0, 2, 0);
            showMembresGrupBtn.Name = "showMembresGrupBtn";
            showMembresGrupBtn.Size = new Size(201, 21);
            showMembresGrupBtn.TabIndex = 38;
            showMembresGrupBtn.Text = "Gestió membres del grup";
            showMembresGrupBtn.Click += showMembresGrupBtn_Click;
            // 
            // pictureBoxDeleteGrup
            // 
            pictureBoxDeleteGrup.BackColor = Color.Transparent;
            pictureBoxDeleteGrup.Enabled = false;
            pictureBoxDeleteGrup.Image = (Image)resources.GetObject("pictureBoxDeleteGrup.Image");
            pictureBoxDeleteGrup.Location = new Point(91, 308);
            pictureBoxDeleteGrup.Margin = new Padding(2);
            pictureBoxDeleteGrup.Name = "pictureBoxDeleteGrup";
            pictureBoxDeleteGrup.Size = new Size(29, 22);
            pictureBoxDeleteGrup.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxDeleteGrup.TabIndex = 43;
            pictureBoxDeleteGrup.TabStop = false;
            // 
            // deleteGrupBtn
            // 
            deleteGrupBtn.AutoSize = true;
            deleteGrupBtn.BackColor = Color.Transparent;
            deleteGrupBtn.Cursor = Cursors.Hand;
            deleteGrupBtn.Enabled = false;
            deleteGrupBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            deleteGrupBtn.ForeColor = Color.FromArgb(107, 55, 35);
            deleteGrupBtn.Location = new Point(124, 311);
            deleteGrupBtn.Margin = new Padding(2, 0, 2, 0);
            deleteGrupBtn.Name = "deleteGrupBtn";
            deleteGrupBtn.Size = new Size(114, 21);
            deleteGrupBtn.TabIndex = 42;
            deleteGrupBtn.Text = "Eliminar grup";
            deleteGrupBtn.Click += deleteGrupBtn_Click;
            // 
            // User_GestioGrups
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(899, 421);
            Controls.Add(pictureBoxDeleteGrup);
            Controls.Add(deleteGrupBtn);
            Controls.Add(pictureBoxShowMembresGrup);
            Controls.Add(showMembresGrupBtn);
            Controls.Add(llistatBox);
            Controls.Add(pictureBoxLlistaGrupTipus);
            Controls.Add(llistaGrupsTypeBtn);
            Controls.Add(pictureBoxCreaGrup);
            Controls.Add(label2);
            Controls.Add(creaGrupBtn);
            Controls.Add(menuStrip1);
            Controls.Add(pageLocation);
            Margin = new Padding(2);
            Name = "User_GestioGrups";
            Text = "User_GestioGrups";
            WindowState = FormWindowState.Maximized;
            Load += User_GestioGrups_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCreaGrup).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLlistaGrupTipus).EndInit();
            llistatBox.ResumeLayout(false);
            llistatBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShowMembresGrup).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDeleteGrup).EndInit();
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
        private RadioButton rbAdmin;
        private GroupBox llistatBox;
        private Button imprimirLlistatBtn;
        private RadioButton rbTots;
        private RadioButton rbMembre;
        private Label infoSelecciona;
        private TextBox totalGrupsLlista;
        private Label label1;
        private PictureBox pictureBoxShowMembresGrup;
        private Label showMembresGrupBtn;
        private TextBox idGrupShow;
        private Label label3;
        private PictureBox pictureBoxDeleteGrup;
        private Label deleteGrupBtn;
        private ListView listGrupsTipus;
        private ColumnHeader idGrupHeader1;
        private ColumnHeader nomGrupHeader2;
    }
}