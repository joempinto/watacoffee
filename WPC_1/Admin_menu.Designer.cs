namespace WPC_1
{
    partial class admin_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_Menu));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            pictureBox4 = new PictureBox();
            label4 = new Label();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            op1ToolStripMenuItem = new ToolStripMenuItem();
            op2ToolStripMenuItem = new ToolStripMenuItem();
            op3ToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(290, 139);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 153);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(107, 55, 35);
            label1.Location = new Point(511, 188);
            label1.Name = "label1";
            label1.Size = new Size(98, 32);
            label1.TabIndex = 1;
            label1.Text = "Usuaris";
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(290, 366);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(180, 163);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(107, 55, 35);
            label3.Location = new Point(511, 424);
            label3.Name = "label3";
            label3.Size = new Size(82, 32);
            label3.TabIndex = 5;
            label3.Text = "Grups";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(41, 36);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(107, 55, 50);
            label4.Location = new Point(67, 18);
            label4.Name = "label4";
            label4.Size = new Size(111, 28);
            label4.TabIndex = 7;
            label4.Text = "userAdmin";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(107, 55, 35);
            label2.Location = new Point(215, 32);
            label2.Name = "label2";
            label2.Size = new Size(461, 60);
            label2.TabIndex = 8;
            label2.Text = "Gestió de l'aplicació";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { op1ToolStripMenuItem });
            menuStrip1.Location = new Point(14, 59);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(261, 57);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
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
            op2ToolStripMenuItem.Size = new Size(270, 34);
            op2ToolStripMenuItem.Text = "Inici";
            // 
            // op3ToolStripMenuItem
            // 
            op3ToolStripMenuItem.Name = "op3ToolStripMenuItem";
            op3ToolStripMenuItem.Size = new Size(270, 34);
            op3ToolStripMenuItem.Text = "Delete";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(270, 34);
            logoutToolStripMenuItem.Text = "Logout";
            // 
            // admin_Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(858, 596);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(pictureBox4);
            Controls.Add(label3);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "admin_Menu";
            Text = "Admin";
            WindowState = FormWindowState.Maximized;
            Load += admin_Menu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox3;
        private Label label3;
        private PictureBox pictureBox4;
        private Label label4;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem op1ToolStripMenuItem;
        private ToolStripMenuItem op2ToolStripMenuItem;
        private ToolStripMenuItem op3ToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
    }
}