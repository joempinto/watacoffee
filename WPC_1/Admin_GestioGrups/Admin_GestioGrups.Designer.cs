namespace WPC_1
{
    partial class Admin_GestioGrups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_GestioGrups));
            pageLocation = new Label();
            menuStrip1 = new MenuStrip();
            op1ToolStripMenuItem = new ToolStripMenuItem();
            iniciStripMenuItem = new ToolStripMenuItem();
            logoutStripMenuItem = new ToolStripMenuItem();
            totalGrups = new TextBox();
            label1 = new Label();
            listBoxUsers = new ListBox();
            label2 = new Label();
            pictureBox4 = new PictureBox();
            llistaGrups = new Label();
            pictureBoxLllistaGrups = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLllistaGrups).BeginInit();
            SuspendLayout();
            // 
            // pageLocation
            // 
            pageLocation.AutoSize = true;
            pageLocation.BackColor = Color.Transparent;
            pageLocation.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            pageLocation.ForeColor = Color.FromArgb(107, 55, 50);
            pageLocation.Location = new Point(102, 22);
            pageLocation.Name = "pageLocation";
            pageLocation.Size = new Size(377, 28);
            pageLocation.TabIndex = 16;
            pageLocation.Text = "location: Username>GestiodelaAplicacio";
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { op1ToolStripMenuItem });
            menuStrip1.Location = new Point(9, 9);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(81, 57);
            menuStrip1.TabIndex = 18;
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
            logoutStripMenuItem.Click += logoutStripMenuItem_Click;
            // 
            // totalGrups
            // 
            totalGrups.Font = new Font("Segoe UI", 14F, FontStyle.Italic, GraphicsUnit.Point);
            totalGrups.Location = new Point(613, 211);
            totalGrups.Name = "totalGrups";
            totalGrups.Size = new Size(42, 45);
            totalGrups.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(107, 55, 35);
            label1.Location = new Point(546, 221);
            label1.Name = "label1";
            label1.Size = new Size(64, 30);
            label1.TabIndex = 26;
            label1.Text = "Total:";
            // 
            // listBoxUsers
            // 
            listBoxUsers.FormattingEnabled = true;
            listBoxUsers.HorizontalScrollbar = true;
            listBoxUsers.ItemHeight = 25;
            listBoxUsers.Location = new Point(258, 262);
            listBoxUsers.MultiColumn = true;
            listBoxUsers.Name = "listBoxUsers";
            listBoxUsers.Size = new Size(455, 279);
            listBoxUsers.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(107, 55, 35);
            label2.Location = new Point(108, 72);
            label2.Name = "label2";
            label2.Size = new Size(368, 60);
            label2.TabIndex = 24;
            label2.Text = "Gestió de Grups";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(661, 216);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(41, 36);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 23;
            pictureBox4.TabStop = false;
            // 
            // llistaGrups
            // 
            llistaGrups.AutoSize = true;
            llistaGrups.BackColor = Color.Transparent;
            llistaGrups.Cursor = Cursors.Hand;
            llistaGrups.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            llistaGrups.ForeColor = Color.FromArgb(107, 55, 35);
            llistaGrups.Location = new Point(209, 171);
            llistaGrups.Name = "llistaGrups";
            llistaGrups.Size = new Size(235, 32);
            llistaGrups.TabIndex = 22;
            llistaGrups.Text = "Llista tots els grups";
            llistaGrups.Click += llistaGrups_Click;
            // 
            // pictureBoxLllistaGrups
            // 
            pictureBoxLllistaGrups.BackColor = Color.Transparent;
            pictureBoxLllistaGrups.Cursor = Cursors.Hand;
            pictureBoxLllistaGrups.Image = (Image)resources.GetObject("pictureBoxLllistaGrups.Image");
            pictureBoxLllistaGrups.Location = new Point(115, 151);
            pictureBoxLllistaGrups.Name = "pictureBoxLllistaGrups";
            pictureBoxLllistaGrups.Size = new Size(88, 78);
            pictureBoxLllistaGrups.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLllistaGrups.TabIndex = 21;
            pictureBoxLllistaGrups.TabStop = false;
            pictureBoxLllistaGrups.Click += pictureBoxLllistaGrups_Click;
            // 
            // Admin_GestioGrups
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(845, 634);
            Controls.Add(totalGrups);
            Controls.Add(label1);
            Controls.Add(listBoxUsers);
            Controls.Add(label2);
            Controls.Add(pictureBox4);
            Controls.Add(llistaGrups);
            Controls.Add(pictureBoxLllistaGrups);
            Controls.Add(menuStrip1);
            Controls.Add(pageLocation);
            Name = "Admin_GestioGrups";
            Text = "Admin_GestioGrups";
            WindowState = FormWindowState.Maximized;
            Load += Admin_GestioGrups_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLllistaGrups).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label pageLocation;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem op1ToolStripMenuItem;
        private ToolStripMenuItem iniciStripMenuItem;
        private ToolStripMenuItem logoutStripMenuItem;
        private TextBox totalGrups;
        private Label label1;
        private ListBox listBoxUsers;
        private Label label2;
        private PictureBox pictureBox4;
        private Label llistaGrups;
        private PictureBox pictureBoxLllistaGrups;
    }
}