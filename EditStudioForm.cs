using StudioLoc;
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
    public partial class EditStudioForm : System.Windows.Forms.Form
    {
        private int _idStudio;

        public EditStudioForm(Studio studio)
        {
            InitializeComponent();

            _idStudio = studio.Id;
            txtNom.Text = studio.Name;
            nudPlaces.Value = studio.Capacity;
            txtPrixSaison.Text = studio.HighSeasonPrice.ToString();
            txtPrixHS.Text = studio.LowSeasonPrice.ToString();
        }

        private void btnEnregistrer_Click_1(object sender, EventArgs e)
        {
            string nom = txtNom.Text;
            int places = (int)nudPlaces.Value;

            if (decimal.TryParse(txtPrixSaison.Text.Replace(".", ","), out decimal pS) &&
                decimal.TryParse(txtPrixHS.Text.Replace(".", ","), out decimal pHS))
            {
                Studio editedStudio = new Studio
                {
                    Id = _idStudio, 
                    Name = nom,
                    Capacity = places,
                    HighSeasonPrice = pS,
                    LowSeasonPrice = pHS
                };

                if (StudioService.Update(editedStudio))
                {
                    MessageBox.Show("Modification réussie !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Veuillez saisir des prix valides.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ModifierStudioForm_Load(object sender, EventArgs e)
        {

        }
    }
}


