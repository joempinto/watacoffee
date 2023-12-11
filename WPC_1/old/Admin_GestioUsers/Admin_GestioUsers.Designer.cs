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
            llistaUsers = new Label();
            pictureBoxLllistaUsers = new PictureBox();
            menuStrip1 = new MenuStrip();
            op1ToolStripMenuItem = new ToolStripMenuItem();
            op2ToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            listBoxUsers = new ListBox();
            totalUsers = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLllistaUsers).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(107, 55, 35);
            label2.Location = new Point(125, 58);
            label2.Name = "label2";
            label2.Size = new Size(379, 60);
            label2.TabIndex = 16;
            label2.Text = "Gestió d'Usuaris";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // pageLocation
            // 
            pageLocation.AutoSize = true;
            pageLocation.BackColor = Color.Transparent;
            pageLocation.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            pageLocation.ForeColor = Color.FromArgb(107, 55, 50);
            pageLocation.Location = new Point(132, 20);
            pageLocation.Name = "pageLocation";
            pageLocation.Size = new Size(377, 28);
            pageLocation.TabIndex = 15;
            pageLocation.Text = "location: Username>GestiodelaAplicacio";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(678, 202);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(41, 36);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // llistaUsers
            // 
            llistaUsers.AutoSize = true;
            llistaUsers.BackColor = Color.Transparent;
            llistaUsers.Cursor = Cursors.Hand;
            llistaUsers.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            llistaUsers.ForeColor = Color.FromArgb(107, 55, 35);
            llistaUsers.Location = new Point(226, 157);
            llistaUsers.Name = "llistaUsers";
            llistaUsers.Size = new Size(251, 32);
            llistaUsers.TabIndex = 11;
            llistaUsers.Text = "Llista tots els usuaris";
            llistaUsers.Click += llistaUsers_Click;
            // 
            // pictureBoxLllistaUsers
            // 
            pictureBoxLllistaUsers.BackColor = Color.Transparent;
            pictureBoxLllistaUsers.Cursor = Cursors.Hand;
            pictureBoxLllistaUsers.Image = (Image)resources.GetObject("pictureBoxLllistaUsers.Image");
            pictureBoxLllistaUsers.Location = new Point(132, 137);
            pictureBoxLllistaUsers.Name = "pictureBoxLllistaUsers";
            pictureBoxLllistaUsers.Size = new Size(88, 78);
            pictureBoxLllistaUsers.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLllistaUsers.TabIndex = 10;
            pictureBoxLllistaUsers.TabStop = false;
            pictureBoxLllistaUsers.Click += pictureBoxLllistaUsers_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { op1ToolStripMenuItem });
            menuStrip1.Location = new Point(9, 8);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(81, 57);
            menuStrip1.TabIndex = 17;
            menuStrip1.Text = "menuStrip1";
            // 
            // op1ToolStripMenuItem
            // 
            op1ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { op2ToolStripMenuItem, logoutToolStripMenuItem });
            op1ToolStripMenuItem.Image = Properties.Resources.main_coffee;
            op1ToolStripMenuItem.Name = "op1ToolStripMenuItem";
            op1ToolStripMenuItem.Size = new Size(73, 53);
            op1ToolStripMenuItem.Text = "Menu";
            op1ToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // op2ToolStripMenuItem
            // 
            op2ToolStripMenuItem.Name = "op2ToolStripMenuItem";
            op2ToolStripMenuItem.Size = new Size(270, 34);
            op2ToolStripMenuItem.Text = "Inici";
            op2ToolStripMenuItem.Click += op2ToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(270, 34);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // listBoxUsers
            // 
            listBoxUsers.FormattingEnabled = true;
            listBoxUsers.ItemHeight = 25;
            listBoxUsers.Location = new Point(275, 248);
            listBoxUsers.Name = "listBoxUsers";
            listBoxUsers.Size = new Size(455, 279);
            listBoxUsers.TabIndex = 18;
            // 
            // totalUsers
            // 
            totalUsers.Font = new Font("Segoe UI", 14F, FontStyle.Italic, GraphicsUnit.Point);
            totalUsers.Location = new Point(609, 197);
            totalUsers.Name = "totalUsers";
            totalUsers.Size = new Size(63, 45);
            totalUsers.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(107, 55, 35);
            label1.Location = new Point(542, 207);
            label1.Name = "label1";
            label1.Size = new Size(64, 30);
            label1.TabIndex = 19;
            label1.Text = "Total:";
            // 
            // Admin_GestioUsers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(924, 546);
            Controls.Add(totalUsers);
            Controls.Add(label1);
            Controls.Add(listBoxUsers);
            Controls.Add(label2);
            Controls.Add(pageLocation);
            Controls.Add(pictureBox4);
            Controls.Add(llistaUsers);
            Controls.Add(pictureBoxLllistaUsers);
            Controls.Add(menuStrip1);
            Name = "Admin_GestioUsers";
            Text = "(ADMIN) Gestió de Users";
            WindowState = FormWindowState.Maximized;
            Load += Admin_GestioUsers_load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
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
        private Label llistaUsers;
        private PictureBox pictureBoxLllistaUsers;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem op1ToolStripMenuItem;
        private ToolStripMenuItem op2ToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ListBox listBoxUsers;
        private TextBox totalUsers;
        private Label label1;
    }
}