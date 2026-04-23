namespace StudioLoc
{
    partial class EditReservationForm
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
            this.lbDateFin = new System.Windows.Forms.Label();
            this.lbDateDebut = new System.Windows.Forms.Label();
            this.lbNbPersonnes = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.nudPersonnes = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudPersonnes)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDateFin
            // 
            this.lbDateFin.AutoSize = true;
            this.lbDateFin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbDateFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbDateFin.Location = new System.Drawing.Point(130, 217);
            this.lbDateFin.Name = "lbDateFin";
            this.lbDateFin.Size = new System.Drawing.Size(90, 19);
            this.lbDateFin.TabIndex = 18;
            this.lbDateFin.Text = "Date de fin :";
            // 
            // lbDateDebut
            // 
            this.lbDateDebut.AutoSize = true;
            this.lbDateDebut.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbDateDebut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbDateDebut.Location = new System.Drawing.Point(130, 142);
            this.lbDateDebut.Name = "lbDateDebut";
            this.lbDateDebut.Size = new System.Drawing.Size(112, 19);
            this.lbDateDebut.TabIndex = 17;
            this.lbDateDebut.Text = "Date de début :";
            // 
            // lbNbPersonnes
            // 
            this.lbNbPersonnes.AutoSize = true;
            this.lbNbPersonnes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbNbPersonnes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbNbPersonnes.Location = new System.Drawing.Point(130, 68);
            this.lbNbPersonnes.Name = "lbNbPersonnes";
            this.lbNbPersonnes.Size = new System.Drawing.Size(166, 19);
            this.lbNbPersonnes.TabIndex = 16;
            this.lbNbPersonnes.Text = "Nombre de personnes :";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAnnuler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAnnuler.Location = new System.Drawing.Point(234, 313);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(100, 35);
            this.btnAnnuler.TabIndex = 15;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnEnregistrer.FlatAppearance.BorderSize = 0;
            this.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEnregistrer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEnregistrer.Location = new System.Drawing.Point(100, 313);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(100, 35);
            this.btnEnregistrer.TabIndex = 14;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // dtpFin
            // 
            this.dtpFin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpFin.Location = new System.Drawing.Point(134, 240);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(200, 25);
            this.dtpFin.TabIndex = 12;
            // 
            // dtpDebut
            // 
            this.dtpDebut.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDebut.Location = new System.Drawing.Point(134, 165);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(200, 25);
            this.dtpDebut.TabIndex = 11;
            // 
            // nudPersonnes
            // 
            this.nudPersonnes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.nudPersonnes.Location = new System.Drawing.Point(134, 91);
            this.nudPersonnes.Name = "nudPersonnes";
            this.nudPersonnes.Size = new System.Drawing.Size(100, 25);
            this.nudPersonnes.TabIndex = 10;
            // 
            // EditReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(434, 400);
            this.Controls.Add(this.lbDateFin);
            this.Controls.Add(this.lbDateDebut);
            this.Controls.Add(this.lbNbPersonnes);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpDebut);
            this.Controls.Add(this.nudPersonnes);
            this.Name = "EditReservationForm";
            this.Text = "Modifier une réservation - StudioLoc";
            this.Load += new System.EventHandler(this.EditReservationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPersonnes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDateFin;
        private System.Windows.Forms.Label lbDateDebut;
        private System.Windows.Forms.Label lbNbPersonnes;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.NumericUpDown nudPersonnes;
    }
}