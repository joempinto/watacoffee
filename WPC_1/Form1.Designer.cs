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
            pictureBox1 = new PictureBox();
            textBoxUsuari = new TextBox();
            textBoxContrasenya = new TextBox();
            labelUsuari = new Label();
            labelContrasenya = new Label();
            buttonEntra = new Button();
            labelSinscrit = new Label();
            label1 = new Label();
            groupBoxMain = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxMain.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(80, 112);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(383, 398);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBoxUsuari
            // 
            textBoxUsuari.Location = new Point(596, 178);
            textBoxUsuari.Margin = new Padding(4, 5, 4, 5);
            textBoxUsuari.Name = "textBoxUsuari";
            textBoxUsuari.Size = new Size(303, 39);
            textBoxUsuari.TabIndex = 1;
            // 
            // textBoxContrasenya
            // 
            textBoxContrasenya.Location = new Point(596, 302);
            textBoxContrasenya.Margin = new Padding(4, 5, 4, 5);
            textBoxContrasenya.Name = "textBoxContrasenya";
            textBoxContrasenya.Size = new Size(303, 39);
            textBoxContrasenya.TabIndex = 2;
            // 
            // labelUsuari
            // 
            labelUsuari.AutoSize = true;
            labelUsuari.BackColor = Color.Transparent;
            labelUsuari.Location = new Point(597, 145);
            labelUsuari.Margin = new Padding(4, 0, 4, 0);
            labelUsuari.Name = "labelUsuari";
            labelUsuari.Size = new Size(80, 32);
            labelUsuari.TabIndex = 3;
            labelUsuari.Text = "Usuari";
            // 
            // labelContrasenya
            // 
            labelContrasenya.AutoSize = true;
            labelContrasenya.BackColor = Color.Transparent;
            labelContrasenya.Location = new Point(596, 268);
            labelContrasenya.Margin = new Padding(4, 0, 4, 0);
            labelContrasenya.Name = "labelContrasenya";
            labelContrasenya.Size = new Size(146, 32);
            labelContrasenya.TabIndex = 4;
            labelContrasenya.Text = "Contrasenya";
            // 
            // buttonEntra
            // 
            buttonEntra.BackColor = Color.Sienna;
            buttonEntra.BackgroundImageLayout = ImageLayout.None;
            buttonEntra.FlatAppearance.BorderColor = Color.FromArgb(128, 64, 0);
            buttonEntra.FlatAppearance.BorderSize = 4;
            buttonEntra.FlatStyle = FlatStyle.Popup;
            buttonEntra.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEntra.Location = new Point(673, 378);
            buttonEntra.Margin = new Padding(4, 5, 4, 5);
            buttonEntra.Name = "buttonEntra";
            buttonEntra.Size = new Size(166, 67);
            buttonEntra.TabIndex = 5;
            buttonEntra.Text = "ENTRA";
            buttonEntra.UseVisualStyleBackColor = false;
            // 
            // labelSinscrit
            // 
            labelSinscrit.AutoSize = true;
            labelSinscrit.BackColor = Color.Transparent;
            labelSinscrit.ForeColor = SystemColors.ActiveCaptionText;
            labelSinscrit.Location = new Point(514, 518);
            labelSinscrit.Margin = new Padding(4, 0, 4, 0);
            labelSinscrit.Name = "labelSinscrit";
            labelSinscrit.Size = new Size(262, 32);
            labelSinscrit.TabIndex = 6;
            labelSinscrit.Text = "Si no estàs registrat/da,";
            labelSinscrit.Click += labelSinscrit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(779, 518);
            label1.Name = "label1";
            label1.Size = new Size(170, 32);
            label1.TabIndex = 7;
            label1.Text = "Dona't d'alta!";
            // 
            // groupBoxMain
            // 
            groupBoxMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxMain.AutoSize = true;
            groupBoxMain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBoxMain.BackgroundImage = (Image)resources.GetObject("groupBoxMain.BackgroundImage");
            groupBoxMain.Controls.Add(label1);
            groupBoxMain.Controls.Add(labelSinscrit);
            groupBoxMain.Controls.Add(buttonEntra);
            groupBoxMain.Controls.Add(labelContrasenya);
            groupBoxMain.Controls.Add(labelUsuari);
            groupBoxMain.Controls.Add(textBoxContrasenya);
            groupBoxMain.Controls.Add(textBoxUsuari);
            groupBoxMain.Controls.Add(pictureBox1);
            groupBoxMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxMain.ForeColor = SystemColors.ControlLight;
            groupBoxMain.Location = new Point(150, 93);
            groupBoxMain.Margin = new Padding(4, 5, 4, 5);
            groupBoxMain.Name = "groupBoxMain";
            groupBoxMain.Padding = new Padding(4, 5, 4, 5);
            groupBoxMain.Size = new Size(956, 587);
            groupBoxMain.TabIndex = 0;
            groupBoxMain.TabStop = false;
            groupBoxMain.Text = "Benvingut/da !";
            groupBoxMain.Enter += groupBox1_Enter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 702);
            Controls.Add(groupBoxMain);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Who Pays Coffee";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxMain.ResumeLayout(false);
            groupBoxMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBoxUsuari;
        private TextBox textBoxContrasenya;
        private Label labelUsuari;
        private Label labelContrasenya;
        private Button buttonEntra;
        private Label labelSinscrit;
        private Label label1;
        private GroupBox groupBoxMain;
    }
}