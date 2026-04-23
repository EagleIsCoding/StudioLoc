namespace StudioLoc
{
    partial class AddStudioForm
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

        #region Code généré par le Concepteur Windows Form

        private void InitializeComponent()
        {
            this.txtNomStudio = new System.Windows.Forms.TextBox();
            this.cbVillages = new System.Windows.Forms.ComboBox();
            this.numPlaces = new System.Windows.Forms.NumericUpDown();
            this.txtPrixSaison = new System.Windows.Forms.TextBox();
            this.txtPrixHorsSaison = new System.Windows.Forms.TextBox();
            this.labelNomStudio = new System.Windows.Forms.Label();
            this.labelPrixSaison = new System.Windows.Forms.Label();
            this.labelVillages = new System.Windows.Forms.Label();
            this.labelNumPlaces = new System.Windows.Forms.Label();
            this.labelPrixHorsSaison = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.titleAddStudio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPlaces)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomStudio
            // 
            this.txtNomStudio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNomStudio.Location = new System.Drawing.Point(40, 110);
            this.txtNomStudio.Name = "txtNomStudio";
            this.txtNomStudio.Size = new System.Drawing.Size(180, 25);
            this.txtNomStudio.TabIndex = 23;
            // 
            // cbVillages
            // 
            this.cbVillages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVillages.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbVillages.Location = new System.Drawing.Point(40, 166);
            this.cbVillages.Name = "cbVillages";
            this.cbVillages.Size = new System.Drawing.Size(180, 25);
            this.cbVillages.TabIndex = 22;
            // 
            // numPlaces
            // 
            this.numPlaces.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numPlaces.Location = new System.Drawing.Point(40, 231);
            this.numPlaces.Name = "numPlaces";
            this.numPlaces.Size = new System.Drawing.Size(180, 25);
            this.numPlaces.TabIndex = 21;
            // 
            // txtPrixSaison
            // 
            this.txtPrixSaison.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPrixSaison.Location = new System.Drawing.Point(40, 295);
            this.txtPrixSaison.Name = "txtPrixSaison";
            this.txtPrixSaison.Size = new System.Drawing.Size(180, 25);
            this.txtPrixSaison.TabIndex = 20;
            // 
            // txtPrixHorsSaison
            // 
            this.txtPrixHorsSaison.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPrixHorsSaison.Location = new System.Drawing.Point(40, 368);
            this.txtPrixHorsSaison.Name = "txtPrixHorsSaison";
            this.txtPrixHorsSaison.Size = new System.Drawing.Size(180, 25);
            this.txtPrixHorsSaison.TabIndex = 19;
            // 
            // labelNomStudio
            // 
            this.labelNomStudio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelNomStudio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelNomStudio.Location = new System.Drawing.Point(36, 84);
            this.labelNomStudio.Name = "labelNomStudio";
            this.labelNomStudio.Size = new System.Drawing.Size(120, 23);
            this.labelNomStudio.TabIndex = 18;
            this.labelNomStudio.Text = "Nom du studio :";
            this.labelNomStudio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelNomStudio.Click += new System.EventHandler(this.labelNomStudio_Click);
            // 
            // labelPrixSaison
            // 
            this.labelPrixSaison.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelPrixSaison.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelPrixSaison.Location = new System.Drawing.Point(36, 269);
            this.labelPrixSaison.Name = "labelPrixSaison";
            this.labelPrixSaison.Size = new System.Drawing.Size(184, 23);
            this.labelPrixSaison.TabIndex = 17;
            this.labelPrixSaison.Text = "Prix en Saison (€) :";
            this.labelPrixSaison.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVillages
            // 
            this.labelVillages.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelVillages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelVillages.Location = new System.Drawing.Point(36, 140);
            this.labelVillages.Name = "labelVillages";
            this.labelVillages.Size = new System.Drawing.Size(120, 23);
            this.labelVillages.TabIndex = 16;
            this.labelVillages.Text = "Village :";
            this.labelVillages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNumPlaces
            // 
            this.labelNumPlaces.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelNumPlaces.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelNumPlaces.Location = new System.Drawing.Point(36, 205);
            this.labelNumPlaces.Name = "labelNumPlaces";
            this.labelNumPlaces.Size = new System.Drawing.Size(150, 23);
            this.labelNumPlaces.TabIndex = 15;
            this.labelNumPlaces.Text = "Nombre de places :";
            this.labelNumPlaces.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPrixHorsSaison
            // 
            this.labelPrixHorsSaison.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelPrixHorsSaison.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelPrixHorsSaison.Location = new System.Drawing.Point(36, 333);
            this.labelPrixHorsSaison.Name = "labelPrixHorsSaison";
            this.labelPrixHorsSaison.Size = new System.Drawing.Size(184, 23);
            this.labelPrixHorsSaison.TabIndex = 14;
            this.labelPrixHorsSaison.Text = "Prix Hors Saison (€) :";
            this.labelPrixHorsSaison.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnEnregistrer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnregistrer.FlatAppearance.BorderSize = 0;
            this.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEnregistrer.ForeColor = System.Drawing.Color.White;
            this.btnEnregistrer.Location = new System.Drawing.Point(40, 413);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(100, 30);
            this.btnEnregistrer.TabIndex = 12;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // titleAddStudio
            // 
            this.titleAddStudio.AutoSize = true;
            this.titleAddStudio.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.titleAddStudio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.titleAddStudio.Location = new System.Drawing.Point(34, 29);
            this.titleAddStudio.Name = "titleAddStudio";
            this.titleAddStudio.Size = new System.Drawing.Size(202, 32);
            this.titleAddStudio.TabIndex = 24;
            this.titleAddStudio.Text = "Ajout d\'un studio";
            this.titleAddStudio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.titleAddStudio.Click += new System.EventHandler(this.titleAddStudio_Click);
            // 
            // AjouterStudioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(770, 520);
            this.Controls.Add(this.titleAddStudio);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.labelPrixHorsSaison);
            this.Controls.Add(this.labelNumPlaces);
            this.Controls.Add(this.labelVillages);
            this.Controls.Add(this.labelPrixSaison);
            this.Controls.Add(this.labelNomStudio);
            this.Controls.Add(this.txtPrixHorsSaison);
            this.Controls.Add(this.txtPrixSaison);
            this.Controls.Add(this.numPlaces);
            this.Controls.Add(this.cbVillages);
            this.Controls.Add(this.txtNomStudio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AjouterStudioForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPlaces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomStudio;
        private System.Windows.Forms.ComboBox cbVillages;
        private System.Windows.Forms.NumericUpDown numPlaces;
        private System.Windows.Forms.TextBox txtPrixSaison;
        private System.Windows.Forms.TextBox txtPrixHorsSaison;
        private System.Windows.Forms.Label labelNomStudio;
        private System.Windows.Forms.Label labelPrixSaison;
        private System.Windows.Forms.Label labelVillages;
        private System.Windows.Forms.Label labelNumPlaces;
        private System.Windows.Forms.Label labelPrixHorsSaison;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Label titleAddStudio;
    }
}