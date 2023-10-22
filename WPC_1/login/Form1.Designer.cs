namespace WPC_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureCoffee = new PictureBox();
            labelTitle = new Label();
            labelEmail = new Label();
            labelPassword = new Label();
            textBoxEmail = new TextBox();
            textBoxPassword = new TextBox();
            buttonEntra = new Button();
            labelDonaAlta = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureCoffee).BeginInit();
            SuspendLayout();
            // 
            // pictureCoffee
            // 
            pictureCoffee.Anchor = AnchorStyles.None;
            pictureCoffee.BackColor = Color.Transparent;
            pictureCoffee.Image = (Image)resources.GetObject("pictureCoffee.Image");
            pictureCoffee.Location = new Point(96, 139);
            pictureCoffee.Name = "pictureCoffee";
            pictureCoffee.Size = new Size(390, 378);
            pictureCoffee.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureCoffee.TabIndex = 0;
            pictureCoffee.TabStop = false;
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.None;
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Segoe UI Black", 28F, FontStyle.Italic, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.FromArgb(107, 55, 35);
            labelTitle.Location = new Point(242, 30);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(522, 74);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Who Pays Coffee?";
            // 
            // labelEmail
            // 
            labelEmail.Anchor = AnchorStyles.None;
            labelEmail.AutoSize = true;
            labelEmail.BackColor = Color.Transparent;
            labelEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmail.ForeColor = Color.FromArgb(107, 55, 35);
            labelEmail.Location = new Point(544, 177);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(59, 28);
            labelEmail.TabIndex = 2;
            labelEmail.Text = "Email";
            // 
            // labelPassword
            // 
            labelPassword.Anchor = AnchorStyles.None;
            labelPassword.AutoSize = true;
            labelPassword.BackColor = Color.Transparent;
            labelPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.ForeColor = Color.FromArgb(107, 55, 35);
            labelPassword.Location = new Point(544, 279);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(120, 28);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Contrasenya";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Anchor = AnchorStyles.None;
            textBoxEmail.Location = new Point(544, 208);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(292, 39);
            textBoxEmail.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.None;
            textBoxPassword.Location = new Point(544, 310);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(292, 39);
            textBoxPassword.TabIndex = 5;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonEntra
            // 
            buttonEntra.Anchor = AnchorStyles.None;
            buttonEntra.BackColor = Color.FromArgb(107, 55, 35);
            buttonEntra.BackgroundImageLayout = ImageLayout.None;
            buttonEntra.FlatAppearance.BorderColor = Color.FromArgb(107, 55, 35);
            buttonEntra.FlatStyle = FlatStyle.Popup;
            buttonEntra.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEntra.ForeColor = Color.FromArgb(64, 0, 0);
            buttonEntra.Location = new Point(594, 367);
            buttonEntra.Name = "buttonEntra";
            buttonEntra.Size = new Size(207, 60);
            buttonEntra.TabIndex = 6;
            buttonEntra.Text = "ENTRA";
            buttonEntra.UseVisualStyleBackColor = false;
            buttonEntra.Click += buttonEntra_ClickAsync;
            // 
            // labelDonaAlta
            // 
            labelDonaAlta.Anchor = AnchorStyles.None;
            labelDonaAlta.AutoSize = true;
            labelDonaAlta.BackColor = Color.Transparent;
            labelDonaAlta.Cursor = Cursors.Hand;
            labelDonaAlta.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelDonaAlta.ForeColor = Color.FromArgb(107, 55, 35);
            labelDonaAlta.Location = new Point(617, 474);
            labelDonaAlta.Name = "labelDonaAlta";
            labelDonaAlta.Size = new Size(164, 30);
            labelDonaAlta.TabIndex = 7;
            labelDonaAlta.Text = "Donar-se d'alta";
            labelDonaAlta.Click += labelDonaAlta_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(957, 635);
            Controls.Add(labelDonaAlta);
            Controls.Add(buttonEntra);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxEmail);
            Controls.Add(labelPassword);
            Controls.Add(labelEmail);
            Controls.Add(labelTitle);
            Controls.Add(pictureCoffee);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            ImeMode = ImeMode.On;
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Benvingut/da a WPC?";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureCoffee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureCoffee;
        private Label labelTitle;
        private Label labelEmail;
        private Label labelPassword;
        private TextBox textBoxEmail;
        private TextBox textBoxPassword;
        private Button buttonEntra;
        private Label labelDonaAlta;}
}