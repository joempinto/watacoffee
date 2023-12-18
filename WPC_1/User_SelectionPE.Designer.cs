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
            deletePagamentBtn = new Button();
            addPagamentBtn = new Button();
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
            grafsBtn.Location = new Point(479, 109);
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
            pictureBoxGrafs.Location = new Point(471, 155);
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
            pictureBoxPay.Location = new Point(181, 155);
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
            payBtn.Location = new Point(196, 109);
            payBtn.Name = "payBtn";
            payBtn.Size = new Size(139, 32);
            payBtn.TabIndex = 17;
            payBtn.Text = "Pagaments";
            payBtn.Click += payBtn_Click;
            // 
            // labelSeleccio
            // 
            labelSeleccio.Anchor = AnchorStyles.None;
            labelSeleccio.AutoSize = true;
            labelSeleccio.BackColor = Color.Transparent;
            labelSeleccio.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelSeleccio.ForeColor = Color.FromArgb(107, 55, 35);
            labelSeleccio.Location = new Point(205, 24);
            labelSeleccio.Name = "labelSeleccio";
            labelSeleccio.Size = new Size(429, 38);
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
            labelCancelSelecPE.Location = new Point(369, 396);
            labelCancelSelecPE.Name = "labelCancelSelecPE";
            labelCancelSelecPE.Size = new Size(109, 30);
            labelCancelSelecPE.TabIndex = 34;
            labelCancelSelecPE.Text = "Cancel.lar";
            labelCancelSelecPE.Click += labelCancelSelecPE_Click;
            // 
            // deletePagamentBtn
            // 
            deletePagamentBtn.Anchor = AnchorStyles.None;
            deletePagamentBtn.Location = new Point(212, 361);
            deletePagamentBtn.Name = "deletePagamentBtn";
            deletePagamentBtn.Size = new Size(123, 34);
            deletePagamentBtn.TabIndex = 65;
            deletePagamentBtn.Text = "Eliminar";
            deletePagamentBtn.UseVisualStyleBackColor = true;
            deletePagamentBtn.Visible = false;
            deletePagamentBtn.Click += deletePagamentBtn_Click;
            // 
            // addPagamentBtn
            // 
            addPagamentBtn.Anchor = AnchorStyles.None;
            addPagamentBtn.Location = new Point(212, 319);
            addPagamentBtn.Name = "addPagamentBtn";
            addPagamentBtn.Size = new Size(123, 34);
            addPagamentBtn.TabIndex = 64;
            addPagamentBtn.Text = "Afegir";
            addPagamentBtn.UseVisualStyleBackColor = true;
            addPagamentBtn.Visible = false;
            addPagamentBtn.Click += addPagamentBtn_Click;
            // 
            // User_SelectionPE
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(deletePagamentBtn);
            Controls.Add(addPagamentBtn);
            Controls.Add(labelCancelSelecPE);
            Controls.Add(labelSeleccio);
            Controls.Add(payBtn);
            Controls.Add(pictureBoxPay);
            Controls.Add(grafsBtn);
            Controls.Add(pictureBoxGrafs);
            Name = "User_SelectionPE";
            Text = "Selecciona Pagaments o Estadístiques";
            WindowState = FormWindowState.Maximized;
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
        private Button deletePagamentBtn;
        private Button addPagamentBtn;
    }
}