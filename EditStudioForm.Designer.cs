namespace StudioLoc
{
    partial class EditStudioForm
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
            this.txtNom = new System.Windows.Forms.TextBox();
            this.nudPlaces = new System.Windows.Forms.NumericUpDown();
            this.txtPrixSaison = new System.Windows.Forms.TextBox();
            this.txtPrixHS = new System.Windows.Forms.TextBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.lbNom = new System.Windows.Forms.Label();
            this.lbPlaces = new System.Windows.Forms.Label();
            this.lbPrix = new System.Windows.Forms.Label();
            this.lbPrixHorsSaison = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlaces)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(129, 90);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(180, 25);
            this.txtNom.TabIndex = 0;
            // 
            // nudPlaces
            // 
            this.nudPlaces.Location = new System.Drawing.Point(129, 164);
            this.nudPlaces.Margin = new System.Windows.Forms.Padding(4);
            this.nudPlaces.Name = "nudPlaces";
            this.nudPlaces.Size = new System.Drawing.Size(180, 25);
            this.nudPlaces.TabIndex = 1;
            // 
            // txtPrixSaison
            // 
            this.txtPrixSaison.Location = new System.Drawing.Point(129, 239);
            this.txtPrixSaison.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrixSaison.Name = "txtPrixSaison";
            this.txtPrixSaison.Size = new System.Drawing.Size(180, 25);
            this.txtPrixSaison.TabIndex = 2;
            // 
            // txtPrixHS
            // 
            this.txtPrixHS.Location = new System.Drawing.Point(129, 305);
            this.txtPrixHS.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrixHS.Name = "txtPrixHS";
            this.txtPrixHS.Size = new System.Drawing.Size(180, 25);
            this.txtPrixHS.TabIndex = 3;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnEnregistrer.FlatAppearance.BorderSize = 0;
            this.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEnregistrer.Location = new System.Drawing.Point(56, 362);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(100, 30);
            this.btnEnregistrer.TabIndex = 4;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click_1);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAnnuler.Location = new System.Drawing.Point(268, 362);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(100, 30);
            this.btnAnnuler.TabIndex = 5;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbNom.Location = new System.Drawing.Point(125, 67);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(116, 19);
            this.lbNom.TabIndex = 6;
            this.lbNom.Text = "Nom du studio :";
            // 
            // lbPlaces
            // 
            this.lbPlaces.AutoSize = true;
            this.lbPlaces.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbPlaces.Location = new System.Drawing.Point(125, 141);
            this.lbPlaces.Name = "lbPlaces";
            this.lbPlaces.Size = new System.Drawing.Size(140, 19);
            this.lbPlaces.TabIndex = 7;
            this.lbPlaces.Text = "Nombre de places :";
            // 
            // lbPrix
            // 
            this.lbPrix.AutoSize = true;
            this.lbPrix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbPrix.Location = new System.Drawing.Point(125, 216);
            this.lbPrix.Name = "lbPrix";
            this.lbPrix.Size = new System.Drawing.Size(133, 19);
            this.lbPrix.TabIndex = 8;
            this.lbPrix.Text = "Prix en Saison (€) :";
            // 
            // lbPrixHorsSaison
            // 
            this.lbPrixHorsSaison.AutoSize = true;
            this.lbPrixHorsSaison.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbPrixHorsSaison.Location = new System.Drawing.Point(125, 282);
            this.lbPrixHorsSaison.Name = "lbPrixHorsSaison";
            this.lbPrixHorsSaison.Size = new System.Drawing.Size(149, 19);
            this.lbPrixHorsSaison.TabIndex = 9;
            this.lbPrixHorsSaison.Text = "Prix Hors Saison (€) :";
            // 
            // ModifierStudioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(434, 461);
            this.Controls.Add(this.lbPrixHorsSaison);
            this.Controls.Add(this.lbPrix);
            this.Controls.Add(this.lbPlaces);
            this.Controls.Add(this.lbNom);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.txtPrixHS);
            this.Controls.Add(this.txtPrixSaison);
            this.Controls.Add(this.nudPlaces);
            this.Controls.Add(this.txtNom);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ModifierStudioForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modifier un studio - StudioLoc";

            this.Load += new System.EventHandler(this.ModifierStudioForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPlaces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.NumericUpDown nudPlaces;
        private System.Windows.Forms.TextBox txtPrixSaison;
        private System.Windows.Forms.TextBox txtPrixHS;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.Label lbPlaces;
        private System.Windows.Forms.Label lbPrix;
        private System.Windows.Forms.Label lbPrixHorsSaison;
    }
}