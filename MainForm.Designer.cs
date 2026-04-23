namespace StudioLoc
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.buttonDeconnexion = new System.Windows.Forms.Button();
            this.buttonInfoResa = new System.Windows.Forms.Button();
            this.buttonInfoStudio = new System.Windows.Forms.Button();
            this.buttonAjouterStudio = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblLogoText = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitrePage = new System.Windows.Forms.Label();
            this.pnlContenu = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.White;
            this.pnlMenu.Controls.Add(this.buttonDeconnexion);
            this.pnlMenu.Controls.Add(this.buttonInfoResa);
            this.pnlMenu.Controls.Add(this.buttonInfoStudio);
            this.pnlMenu.Controls.Add(this.buttonAjouterStudio);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(230, 600);
            this.pnlMenu.TabIndex = 2;
            // 
            // buttonDeconnexion
            // 
            this.buttonDeconnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.buttonDeconnexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeconnexion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonDeconnexion.FlatAppearance.BorderSize = 0;
            this.buttonDeconnexion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.buttonDeconnexion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.buttonDeconnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeconnexion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.buttonDeconnexion.ForeColor = System.Drawing.Color.White;
            this.buttonDeconnexion.Location = new System.Drawing.Point(0, 540);
            this.buttonDeconnexion.Name = "buttonDeconnexion";
            this.buttonDeconnexion.Size = new System.Drawing.Size(230, 60);
            this.buttonDeconnexion.TabIndex = 4;
            this.buttonDeconnexion.TabStop = false;
            this.buttonDeconnexion.Text = "  Se déconnecter";
            this.buttonDeconnexion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeconnexion.UseVisualStyleBackColor = false;
            this.buttonDeconnexion.Click += new System.EventHandler(this.buttonDeconnexion_Click);
            // 
            // buttonInfoResa
            // 
            this.buttonInfoResa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInfoResa.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonInfoResa.FlatAppearance.BorderSize = 0;
            this.buttonInfoResa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.buttonInfoResa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.buttonInfoResa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfoResa.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.buttonInfoResa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonInfoResa.Location = new System.Drawing.Point(0, 200);
            this.buttonInfoResa.Name = "buttonInfoResa";
            this.buttonInfoResa.Size = new System.Drawing.Size(230, 60);
            this.buttonInfoResa.TabIndex = 0;
            this.buttonInfoResa.TabStop = false;
            this.buttonInfoResa.Text = "  Réservations";
            this.buttonInfoResa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInfoResa.Click += new System.EventHandler(this.buttonInfoResa_Click);
            // 
            // buttonInfoStudio
            // 
            this.buttonInfoStudio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInfoStudio.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonInfoStudio.FlatAppearance.BorderSize = 0;
            this.buttonInfoStudio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.buttonInfoStudio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.buttonInfoStudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfoStudio.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.buttonInfoStudio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonInfoStudio.Location = new System.Drawing.Point(0, 140);
            this.buttonInfoStudio.Name = "buttonInfoStudio";
            this.buttonInfoStudio.Size = new System.Drawing.Size(230, 60);
            this.buttonInfoStudio.TabIndex = 1;
            this.buttonInfoStudio.TabStop = false;
            this.buttonInfoStudio.Text = "  Liste des studios";
            this.buttonInfoStudio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInfoStudio.Click += new System.EventHandler(this.buttonInfoStudio_Click);
            // 
            // buttonAjouterStudio
            // 
            this.buttonAjouterStudio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAjouterStudio.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAjouterStudio.FlatAppearance.BorderSize = 0;
            this.buttonAjouterStudio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.buttonAjouterStudio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.buttonAjouterStudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouterStudio.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.buttonAjouterStudio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAjouterStudio.Location = new System.Drawing.Point(0, 80);
            this.buttonAjouterStudio.Name = "buttonAjouterStudio";
            this.buttonAjouterStudio.Size = new System.Drawing.Size(230, 60);
            this.buttonAjouterStudio.TabIndex = 2;
            this.buttonAjouterStudio.TabStop = false;
            this.buttonAjouterStudio.Text = "  Ajouter Studio";
            this.buttonAjouterStudio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAjouterStudio.Click += new System.EventHandler(this.buttonAjouterStudio_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlLogo.Controls.Add(this.lblLogoText);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(230, 80);
            this.pnlLogo.TabIndex = 3;
            // 
            // lblLogoText
            // 
            this.lblLogoText.AutoSize = true;
            this.lblLogoText.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblLogoText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblLogoText.Location = new System.Drawing.Point(35, 30);
            this.lblLogoText.Name = "lblLogoText";
            this.lblLogoText.Size = new System.Drawing.Size(157, 25);
            this.lblLogoText.TabIndex = 0;
            this.lblLogoText.Text = "STUDIOLOC ADM";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnlHeader.Controls.Add(this.lblTitrePage);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(230, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(770, 80);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTitrePage
            // 
            this.lblTitrePage.AutoSize = true;
            this.lblTitrePage.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitrePage.ForeColor = System.Drawing.Color.White;
            this.lblTitrePage.Location = new System.Drawing.Point(25, 25);
            this.lblTitrePage.Name = "lblTitrePage";
            this.lblTitrePage.Size = new System.Drawing.Size(98, 30);
            this.lblTitrePage.TabIndex = 0;
            this.lblTitrePage.Text = "ACCUEIL";
            // 
            // pnlContenu
            // 
            this.pnlContenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlContenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenu.Location = new System.Drawing.Point(230, 80);
            this.pnlContenu.Name = "pnlContenu";
            this.pnlContenu.Size = new System.Drawing.Size(770, 520);
            this.pnlContenu.TabIndex = 0;
            this.pnlContenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContenu_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.pnlContenu);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlMenu);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudioLoc - Administration";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.pnlMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblLogoText;
        private System.Windows.Forms.Button buttonAjouterStudio;
        private System.Windows.Forms.Button buttonInfoStudio;
        private System.Windows.Forms.Button buttonInfoResa;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitrePage;
        private System.Windows.Forms.Panel pnlContenu;
        private System.Windows.Forms.Button buttonDeconnexion;
    }
}