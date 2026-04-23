using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudioLoc
{
    public partial class StudioDetailsForm : System.Windows.Forms.Form
    {
        public StudioDetailsForm()
        {
            InitializeComponent();
        }

        private void StudioInfo_Load(object sender, EventArgs e)
        {
            cbVillages.DataSource = VillageService.GetAll();

            cbVillages.DisplayMember = "Name"; 
            cbVillages.ValueMember = "Id";     

            if (cbVillages.Items.Count > 0)
            {
                cbVillages.SelectedIndex = 0;
            }

            dgvStudioList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudioList.RowHeadersVisible = false;
            dgvStudioList.BackgroundColor = Color.White;
            dgvStudioList.BorderStyle = BorderStyle.None;

            RefreshGrid();
        }

        /// <summary>
        /// Rafraîchit la grille d'affichage des studios selon le village sélectionné.
        /// </summary>
        private void RefreshGrid()
        {
            // Vérification de la sélection du village
            if (cbVillages.SelectedValue != null && cbVillages.SelectedValue is int villageId)
            {
                // Récupération de la liste d'objets (plus propre qu'une DataTable)
                List<Studio> studios = StudioService.GetStudiosByVillage(villageId);

                // Liaison de la liste à la DataGridView
                dgvStudioList.DataSource = null; // Reset pour forcer la mise à jour
                dgvStudioList.DataSource = studios;

                // Configuration de l'affichage
                dgvStudioList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvStudioList.AllowUserToAddRows = false;
                dgvStudioList.ReadOnly = true;
                dgvStudioList.RowHeadersVisible = false; // Plus esthétique

                // --- Traduction des entêtes (Mapping Code EN -> Interface FR) ---
                if (dgvStudioList.Columns["Id"] != null) dgvStudioList.Columns["Id"].Visible = false;
                if (dgvStudioList.Columns["VillageId"] != null) dgvStudioList.Columns["VillageId"].Visible = false;

                // On renomme les colonnes pour l'utilisateur final
                dgvStudioList.Columns["Name"].HeaderText = "Nom du Studio";
                dgvStudioList.Columns["VillageName"].HeaderText = "Commune";
                dgvStudioList.Columns["Capacity"].HeaderText = "Places";
                dgvStudioList.Columns["HighSeasonPrice"].HeaderText = "Prix Haute Saison (€)";
                dgvStudioList.Columns["LowSeasonPrice"].HeaderText = "Prix Basse Saison (€)";
            }
        }
        private void cbVillages_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void dgvStudioList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // On ignore les clics sur l'en-tête
            if (e.RowIndex < 0) return;

            // MAGIE DU BINDING : On récupère l'objet Studio complet directement depuis la ligne
            // Plus besoin de faire Cells["Id"].Value, on a l'objet entier !
            Studio selectedStudio = dgvStudioList.Rows[e.RowIndex].DataBoundItem as Studio;

            if (selectedStudio == null) return;

            // --- ACTION : SUPPRIMER ---
            if (dgvStudioList.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                var result = MessageBox.Show($"Voulez-vous vraiment supprimer le studio {selectedStudio.Name} ?",
                                           "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // On utilise la propriété Id de notre objet
                        if (StudioService.Delete(selectedStudio.Id))
                        {
                            RefreshGrid();
                            MessageBox.Show("Studio supprimé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (MySqlException ex)
                    {
                        // Erreur de clé étrangère (ex: réservations liées)
                        if (ex.Number == 1451)
                        {
                            MessageBox.Show("Impossible de supprimer ce studio car il possède des réservations enregistrées.\n\nVeuillez d'abord supprimer les réservations associées.",
                                            "Action impossible", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else
                        {
                            MessageBox.Show("Une erreur SQL est survenue : " + ex.Message);
                        }
                    }
                }
            }

            // --- ACTION : MODIFIER ---
            if (dgvStudioList.Columns[e.ColumnIndex].Name == "btnEdit")
            {
                // On passe directement l'objet récupéré au formulaire
                // Plus besoin de recréer un "new Studio { ... }" manuellement !
                using (EditStudioForm frm = new EditStudioForm(selectedStudio))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        RefreshGrid();
                    }
                }
            }
        }
    }
}
