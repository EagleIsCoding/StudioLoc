using System.Drawing;
using System.Windows.Forms;

namespace StudioLoc
{
    partial class StudioDetailsForm
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
            this.dgvStudioList = new System.Windows.Forms.DataGridView();
            this.cbVillages = new System.Windows.Forms.ComboBox();
            this.labelVillages = new System.Windows.Forms.Label();
            this.titleAddStudio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudioList)).BeginInit();
            this.SuspendLayout();
            // 
            // titleAddStudio
            // 
            this.titleAddStudio.AutoSize = true;
            this.titleAddStudio.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.titleAddStudio.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.titleAddStudio.Location = new System.Drawing.Point(40, 30);
            this.titleAddStudio.Name = "titleAddStudio";
            this.titleAddStudio.Size = new System.Drawing.Size(193, 32);
            this.titleAddStudio.Text = "Liste des studios";
            // 
            // labelVillages
            // 
            this.labelVillages.AutoSize = true;
            this.labelVillages.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelVillages.Location = new System.Drawing.Point(42, 110);
            this.labelVillages.Name = "labelVillages";
            this.labelVillages.Size = new System.Drawing.Size(127, 19);
            this.labelVillages.Text = "Filtrer par Village :";
            // 
            // cbVillages
            // 
            this.cbVillages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVillages.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbVillages.Location = new System.Drawing.Point(175, 107);
            this.cbVillages.Name = "cbVillages";
            this.cbVillages.Size = new System.Drawing.Size(220, 25);
            this.cbVillages.SelectedIndexChanged += new System.EventHandler(this.cbVillages_SelectedIndexChanged);
            // 
            // dgvStudioList
            // 
            this.dgvStudioList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudioList.Location = new System.Drawing.Point(45, 160);
            this.dgvStudioList.Name = "dgvStudioList";
            this.dgvStudioList.Size = new System.Drawing.Size(680, 320);
            this.dgvStudioList.TabIndex = 0;
            this.dgvStudioList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudioList_CellContentClick);
            // 
            // StudioInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(770, 520);
            this.Controls.Add(this.titleAddStudio);
            this.Controls.Add(this.labelVillages);
            this.Controls.Add(this.cbVillages);
            this.Controls.Add(this.dgvStudioList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudioInfo";
            this.Load += new System.EventHandler(this.StudioInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudioList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            // Création de la colonne Modifier
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            btnEdit.Name = "btnEdit";
            btnEdit.HeaderText = "";
            btnEdit.Text = "Modifier";
            btnEdit.UseColumnTextForButtonValue = true;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.DefaultCellStyle.BackColor = Color.FromArgb(0, 122, 204);
            btnEdit.DefaultCellStyle.ForeColor = Color.White;
            dgvStudioList.Columns.Add(btnEdit);

            // Création de la colonne Supprimer
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "btnDelete";
            btnDelete.HeaderText = "";
            btnDelete.Text = "Supprimer";
            btnDelete.UseColumnTextForButtonValue = true;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.DefaultCellStyle.BackColor = Color.Crimson;
            btnDelete.DefaultCellStyle.ForeColor = Color.White;
            dgvStudioList.Columns.Add(btnDelete);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudioList;
        private System.Windows.Forms.ComboBox cbVillages;
        private System.Windows.Forms.Label labelVillages;
        private System.Windows.Forms.Label titleAddStudio;
    }
}