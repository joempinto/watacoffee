namespace WPC_1
{
    partial class User_SelectionPE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_SelectionPE));
            grafsBtn = new Label();
            pictureBoxGrafs = new PictureBox();
            pictureBoxPay = new PictureBox();
            payBtn = new Label();
            labelSeleccio = new Label();
            labelCancelSelecPE = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGrafs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPay).BeginInit();
            SuspendLayout();
            // 
            // grafsBtn
            // 
            grafsBtn.Anchor = AnchorStyles.None;
            grafsBtn.AutoSize = true;
            grafsBtn.BackColor = Color.Transparent;
            grafsBtn.Cursor = Cursors.Hand;
            grafsBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grafsBtn.ForeColor = Color.FromArgb(107, 55, 35);
            grafsBtn.Location = new Point(485, 313);
            grafsBtn.Name = "grafsBtn";
            grafsBtn.Size = new Size(163, 32);
            grafsBtn.TabIndex = 15;
            grafsBtn.Text = "Estadístiques";
            grafsBtn.Click += grafsBtn_Click;
            // 
            // pictureBoxGrafs
            // 
            pictureBoxGrafs.Anchor = AnchorStyles.None;
            pictureBoxGrafs.BackColor = Color.Transparent;
            pictureBoxGrafs.Cursor = Cursors.Hand;
            pictureBoxGrafs.Image = (Image)resources.GetObject("pictureBoxGrafs.Image");
            pictureBoxGrafs.Location = new Point(475, 135);
            pictureBoxGrafs.Name = "pictureBoxGrafs";
            pictureBoxGrafs.Size = new Size(178, 154);
            pictureBoxGrafs.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxGrafs.TabIndex = 14;
            pictureBoxGrafs.TabStop = false;
            pictureBoxGrafs.Click += pictureBoxGrafs_Click;
            // 
            // pictureBoxPay
            // 
            pictureBoxPay.Anchor = AnchorStyles.None;
            pictureBoxPay.BackColor = Color.Transparent;
            pictureBoxPay.Cursor = Cursors.Hand;
            pictureBoxPay.Image = (Image)resources.GetObject("pictureBoxPay.Image");
            pictureBoxPay.Location = new Point(185, 135);
            pictureBoxPay.Name = "pictureBoxPay";
            pictureBoxPay.Size = new Size(178, 154);
            pictureBoxPay.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPay.TabIndex = 16;
            pictureBoxPay.TabStop = false;
            pictureBoxPay.Click += pictureBoxPay_Click;
            // 
            // payBtn
            // 
            payBtn.Anchor = AnchorStyles.None;
            payBtn.AutoSize = true;
            payBtn.BackColor = Color.Transparent;
            payBtn.Cursor = Cursors.Hand;
            payBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            payBtn.ForeColor = Color.FromArgb(107, 55, 35);
            payBtn.Location = new Point(173, 313);
            payBtn.Name = "payBtn";
            payBtn.Size = new Size(206, 32);
            payBtn.TabIndex = 17;
            payBtn.Text = "Afegir Pagament";
            payBtn.Click += payBtn_Click;
            // 
            // labelSeleccio
            // 
            labelSeleccio.Anchor = AnchorStyles.None;
            labelSeleccio.AutoSize = true;
            labelSeleccio.BackColor = Color.Transparent;
            labelSeleccio.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelSeleccio.ForeColor = Color.FromArgb(107, 55, 35);
            labelSeleccio.Location = new Point(243, 57);
            labelSeleccio.Name = "labelSeleccio";
            labelSeleccio.Size = new Size(357, 32);
            labelSeleccio.TabIndex = 18;
            labelSeleccio.Text = "Selecciona una de les opcions";
            labelSeleccio.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelCancelSelecPE
            // 
            labelCancelSelecPE.Anchor = AnchorStyles.None;
            labelCancelSelecPE.AutoSize = true;
            labelCancelSelecPE.BackColor = Color.Transparent;
            labelCancelSelecPE.Cursor = Cursors.Hand;
            labelCancelSelecPE.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelCancelSelecPE.ForeColor = Color.FromArgb(107, 55, 35);
            labelCancelSelecPE.Location = new Point(354, 382);
            labelCancelSelecPE.Name = "labelCancelSelecPE";
            labelCancelSelecPE.Size = new Size(109, 30);
            labelCancelSelecPE.TabIndex = 34;
            labelCancelSelecPE.Text = "Cancel.lar";
            labelCancelSelecPE.Click += labelCancelSelecPE_Click;
            // 
            // User_SelectionPE
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(labelCancelSelecPE);
            Controls.Add(labelSeleccio);
            Controls.Add(payBtn);
            Controls.Add(pictureBoxPay);
            Controls.Add(grafsBtn);
            Controls.Add(pictureBoxGrafs);
            Name = "User_SelectionPE";
            Text = "Selecciona Pagaments o Estadístiques";
            ((System.ComponentModel.ISupportInitialize)pictureBoxGrafs).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label grafsBtn;
        private PictureBox pictureBoxGrafs;
        private PictureBox pictureBoxPay;
        private Label payBtn;
        private Label labelSeleccio;
        private Label labelCancelSelecPE;
    }
}