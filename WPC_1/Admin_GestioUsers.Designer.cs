namespace WPC_1
{
    partial class Admin_GestioUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_GestioUsers));
            label2 = new Label();
            pageLocation = new Label();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            llistaUsers = new Label();
            pictureBoxLllistaUsers = new PictureBox();
            menuStrip1 = new MenuStrip();
            op1ToolStripMenuItem = new ToolStripMenuItem();
            op2ToolStripMenuItem = new ToolStripMenuItem();
            op3ToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLllistaUsers).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(107, 55, 35);
            label2.Location = new Point(326, 48);
            label2.Name = "label2";
            label2.Size = new Size(401, 60);
            label2.TabIndex = 16;
            label2.Text = "Gestió de Usuaris";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // pageLocation
            // 
            pageLocation.AutoSize = true;
            pageLocation.BackColor = Color.Transparent;
            pageLocation.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            pageLocation.ForeColor = Color.FromArgb(107, 55, 50);
            pageLocation.Location = new Point(92, 20);
            pageLocation.Name = "pageLocation";
            pageLocation.Size = new Size(377, 28);
            pageLocation.TabIndex = 15;
            pageLocation.Text = "location: Username>GestiodelaAplicacio";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(23, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(41, 36);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(107, 55, 35);
            label3.Location = new Point(629, 427);
            label3.Name = "label3";
            label3.Size = new Size(82, 32);
            label3.TabIndex = 13;
            label3.Text = "Grups";
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(408, 369);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(180, 163);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // llistaUsers
            // 
            llistaUsers.Anchor = AnchorStyles.None;
            llistaUsers.AutoSize = true;
            llistaUsers.BackColor = Color.Transparent;
            llistaUsers.Cursor = Cursors.Hand;
            llistaUsers.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            llistaUsers.ForeColor = Color.FromArgb(107, 55, 35);
            llistaUsers.Location = new Point(629, 191);
            llistaUsers.Name = "llistaUsers";
            llistaUsers.Size = new Size(162, 32);
            llistaUsers.TabIndex = 11;
            llistaUsers.Text = "Llista usuaris";
            llistaUsers.Click += llistaUsers_Click;
            // 
            // pictureBoxLllistaUsers
            // 
            pictureBoxLllistaUsers.Anchor = AnchorStyles.None;
            pictureBoxLllistaUsers.BackColor = Color.Transparent;
            pictureBoxLllistaUsers.Cursor = Cursors.Hand;
            pictureBoxLllistaUsers.Image = (Image)resources.GetObject("pictureBoxLllistaUsers.Image");
            pictureBoxLllistaUsers.Location = new Point(408, 142);
            pictureBoxLllistaUsers.Name = "pictureBoxLllistaUsers";
            pictureBoxLllistaUsers.Size = new Size(180, 153);
            pictureBoxLllistaUsers.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLllistaUsers.TabIndex = 10;
            pictureBoxLllistaUsers.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { op1ToolStripMenuItem });
            menuStrip1.Location = new Point(23, 73);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(81, 57);
            menuStrip1.TabIndex = 17;
            menuStrip1.Text = "menuStrip1";
            // 
            // op1ToolStripMenuItem
            // 
            op1ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { op2ToolStripMenuItem, op3ToolStripMenuItem, logoutToolStripMenuItem });
            op1ToolStripMenuItem.Image = Properties.Resources.main_coffee;
            op1ToolStripMenuItem.Name = "op1ToolStripMenuItem";
            op1ToolStripMenuItem.Size = new Size(73, 53);
            op1ToolStripMenuItem.Text = "Menu";
            op1ToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // op2ToolStripMenuItem
            // 
            op2ToolStripMenuItem.Name = "op2ToolStripMenuItem";
            op2ToolStripMenuItem.Size = new Size(171, 34);
            op2ToolStripMenuItem.Text = "Inici";
            // 
            // op3ToolStripMenuItem
            // 
            op3ToolStripMenuItem.Name = "op3ToolStripMenuItem";
            op3ToolStripMenuItem.Size = new Size(171, 34);
            op3ToolStripMenuItem.Text = "Delete";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(171, 34);
            logoutToolStripMenuItem.Text = "Logout";
            // 
            // Admin_GestioUsers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(924, 546);
            Controls.Add(label2);
            Controls.Add(pageLocation);
            Controls.Add(pictureBox4);
            Controls.Add(label3);
            Controls.Add(pictureBox3);
            Controls.Add(llistaUsers);
            Controls.Add(pictureBoxLllistaUsers);
            Controls.Add(menuStrip1);
            Name = "Admin_GestioUsers";
            Text = "(ADMIN) Gestió de Users";
            WindowState = FormWindowState.Maximized;
            Load += Admin_GestioUsers_load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLllistaUsers).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label pageLocation;
        private PictureBox pictureBox4;
        private Label label3;
        private PictureBox pictureBox3;
        private Label llistaUsers;
        private PictureBox pictureBoxLllistaUsers;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem op1ToolStripMenuItem;
        private ToolStripMenuItem op2ToolStripMenuItem;
        private ToolStripMenuItem op3ToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
    }
}