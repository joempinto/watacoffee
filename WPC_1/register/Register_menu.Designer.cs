/*
 * created by JMPinto
 */

namespace WPC_1
{
    partial class register_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register_Menu));
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            registerNom = new TextBox();
            registerEmail = new TextBox();
            label5 = new Label();
            registerPassword1 = new TextBox();
            label6 = new Label();
            registerPassword2 = new TextBox();
            label3 = new Label();
            buttonConfirmaRegister = new Button();
            label7 = new Label();
            labelDonaAlta = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(411, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(212, 188);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(41, 36);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(107, 55, 35);
            label2.Location = new Point(330, 206);
            label2.Name = "label2";
            label2.Size = new Size(358, 60);
            label2.TabIndex = 9;
            label2.Text = "Alta nou usuari";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(315, 259);
            label1.Name = "label1";
            label1.Size = new Size(404, 25);
            label1.TabIndex = 10;
            label1.Text = "Introdueix les dades següents per donar-te d'alta.";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(315, 332);
            label4.Name = "label4";
            label4.Size = new Size(104, 25);
            label4.TabIndex = 12;
            label4.Text = "Nom usuari";
            // 
            // registerNom
            // 
            registerNom.Anchor = AnchorStyles.None;
            registerNom.Location = new Point(425, 329);
            registerNom.Name = "registerNom";
            registerNom.Size = new Size(274, 31);
            registerNom.TabIndex = 13;
            // 
            // registerEmail
            // 
            registerEmail.Anchor = AnchorStyles.None;
            registerEmail.Location = new Point(425, 379);
            registerEmail.Name = "registerEmail";
            registerEmail.Size = new Size(274, 31);
            registerEmail.TabIndex = 15;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(365, 382);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 14;
            label5.Text = "Email";
            // 
            // registerPassword1
            // 
            registerPassword1.Anchor = AnchorStyles.None;
            registerPassword1.Location = new Point(425, 434);
            registerPassword1.Name = "registerPassword1";
            registerPassword1.Size = new Size(274, 31);
            registerPassword1.TabIndex = 17;
            registerPassword1.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(315, 437);
            label6.Name = "label6";
            label6.Size = new Size(110, 25);
            label6.TabIndex = 16;
            label6.Text = "Contrasenya";
            // 
            // registerPassword2
            // 
            registerPassword2.Anchor = AnchorStyles.None;
            registerPassword2.Location = new Point(425, 488);
            registerPassword2.Name = "registerPassword2";
            registerPassword2.Size = new Size(274, 31);
            registerPassword2.TabIndex = 19;
            registerPassword2.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(316, 480);
            label3.Name = "label3";
            label3.Size = new Size(96, 25);
            label3.TabIndex = 18;
            label3.Text = "Repeteix la";
            // 
            // buttonConfirmaRegister
            // 
            buttonConfirmaRegister.Anchor = AnchorStyles.None;
            buttonConfirmaRegister.BackColor = Color.FromArgb(107, 55, 35);
            buttonConfirmaRegister.FlatStyle = FlatStyle.Popup;
            buttonConfirmaRegister.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonConfirmaRegister.ForeColor = Color.FromArgb(64, 0, 0);
            buttonConfirmaRegister.Location = new Point(418, 568);
            buttonConfirmaRegister.Name = "buttonConfirmaRegister";
            buttonConfirmaRegister.Size = new Size(202, 78);
            buttonConfirmaRegister.TabIndex = 20;
            buttonConfirmaRegister.Text = "Confirmar";
            buttonConfirmaRegister.UseVisualStyleBackColor = false;
            buttonConfirmaRegister.Click += buttonConfirmaRegister_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(316, 505);
            label7.Name = "label7";
            label7.Size = new Size(107, 25);
            label7.TabIndex = 21;
            label7.Text = "contrasenya";
            // 
            // labelDonaAlta
            // 
            labelDonaAlta.Anchor = AnchorStyles.None;
            labelDonaAlta.AutoSize = true;
            labelDonaAlta.BackColor = Color.Transparent;
            labelDonaAlta.Cursor = Cursors.Hand;
            labelDonaAlta.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelDonaAlta.ForeColor = Color.FromArgb(107, 55, 35);
            labelDonaAlta.Location = new Point(461, 655);
            labelDonaAlta.Name = "labelDonaAlta";
            labelDonaAlta.Size = new Size(109, 30);
            labelDonaAlta.TabIndex = 22;
            labelDonaAlta.Text = "Cancel.lar";
            labelDonaAlta.Click += labelDonaAlta_Click;
            // 
            // register_Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(973, 688);
            Controls.Add(labelDonaAlta);
            Controls.Add(label7);
            Controls.Add(buttonConfirmaRegister);
            Controls.Add(registerPassword2);
            Controls.Add(label3);
            Controls.Add(registerPassword1);
            Controls.Add(label6);
            Controls.Add(registerEmail);
            Controls.Add(label5);
            Controls.Add(registerNom);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox1);
            ForeColor = Color.FromArgb(107, 55, 35);
            Name = "register_Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dona't d'alta!";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox registerNom;
        private TextBox registerEmail;
        private Label label5;
        private TextBox registerPassword1;
        private Label label6;
        private TextBox registerPassword2;
        private Label label3;
        private Button buttonConfirmaRegister;
        private Label label7;
        private Label labelDonaAlta;
    }
}