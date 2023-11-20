namespace WPC_1
{
    partial class User_addGrup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_addGrup));
            labelCancelAddGrup = new Label();
            confirmaAddGrupBtn = new Button();
            nomGrup = new TextBox();
            label3 = new Label();
            memberAdminGrup = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // labelCancelAddGrup
            // 
            labelCancelAddGrup.Anchor = AnchorStyles.None;
            labelCancelAddGrup.AutoSize = true;
            labelCancelAddGrup.BackColor = Color.Transparent;
            labelCancelAddGrup.Cursor = Cursors.Hand;
            labelCancelAddGrup.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelCancelAddGrup.ForeColor = Color.FromArgb(107, 55, 35);
            labelCancelAddGrup.Location = new Point(230, 315);
            labelCancelAddGrup.Name = "labelCancelAddGrup";
            labelCancelAddGrup.Size = new Size(109, 30);
            labelCancelAddGrup.TabIndex = 40;
            labelCancelAddGrup.Text = "Cancel.lar";
            // 
            // confirmaAddGrupBtn
            // 
            confirmaAddGrupBtn.Anchor = AnchorStyles.None;
            confirmaAddGrupBtn.BackColor = Color.FromArgb(107, 55, 35);
            confirmaAddGrupBtn.FlatStyle = FlatStyle.Popup;
            confirmaAddGrupBtn.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            confirmaAddGrupBtn.ForeColor = Color.FromArgb(64, 0, 0);
            confirmaAddGrupBtn.Location = new Point(193, 238);
            confirmaAddGrupBtn.Name = "confirmaAddGrupBtn";
            confirmaAddGrupBtn.Size = new Size(192, 67);
            confirmaAddGrupBtn.TabIndex = 39;
            confirmaAddGrupBtn.Text = "Confirmar";
            confirmaAddGrupBtn.UseVisualStyleBackColor = false;
            confirmaAddGrupBtn.Click += confirmaAddGrupBtn_Click;
            // 
            // nomGrup
            // 
            nomGrup.Anchor = AnchorStyles.None;
            nomGrup.Location = new Point(233, 163);
            nomGrup.Name = "nomGrup";
            nomGrup.Size = new Size(274, 31);
            nomGrup.TabIndex = 38;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.FromArgb(107, 55, 35);
            label3.Location = new Point(48, 166);
            label3.Name = "label3";
            label3.Size = new Size(124, 25);
            label3.TabIndex = 37;
            label3.Text = "Nom del grup";
            // 
            // memberAdminGrup
            // 
            memberAdminGrup.Anchor = AnchorStyles.None;
            memberAdminGrup.Location = new Point(233, 109);
            memberAdminGrup.Name = "memberAdminGrup";
            memberAdminGrup.Size = new Size(274, 31);
            memberAdminGrup.TabIndex = 36;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.FromArgb(107, 55, 35);
            label2.Location = new Point(48, 112);
            label2.Name = "label2";
            label2.Size = new Size(169, 25);
            label2.TabIndex = 35;
            label2.Text = "Administrador grup";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(107, 55, 35);
            label1.Location = new Point(154, 6);
            label1.Name = "label1";
            label1.Size = new Size(282, 60);
            label1.TabIndex = 34;
            label1.Text = "Afegir Grup";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // User_addGrup
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(568, 367);
            Controls.Add(labelCancelAddGrup);
            Controls.Add(confirmaAddGrupBtn);
            Controls.Add(nomGrup);
            Controls.Add(label3);
            Controls.Add(memberAdminGrup);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "User_addGrup";
            Text = "User_addGrup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCancelAddGrup;
        private Button confirmaAddGrupBtn;
        private TextBox nomGrup;
        private Label label3;
        private TextBox memberAdminGrup;
        private Label label2;
        private Label label1;
    }
}