using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudioLoc
{
    public partial class AddStudioForm : System.Windows.Forms.Form
    {
        public AddStudioForm()
        {
            InitializeComponent();
            btnEnregistrer.MouseEnter += btnEnregistrer_MouseEnter;
            btnEnregistrer.MouseLeave += btnEnregistrer_MouseLeave;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                cbVillages.DataSource = VillageService.GetAll();
                cbVillages.DisplayMember = "Name"; 
                cbVillages.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomStudio.Text) || cbVillages.SelectedValue == null)
            {
                MessageBox.Show("Veuillez remplir les champs obligatoires.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                decimal prixS, prixHS;
                decimal.TryParse(txtPrixSaison.Text.Replace(".", ","), out prixS);
                decimal.TryParse(txtPrixHorsSaison.Text.Replace(".", ","), out prixHS);

                Studio newStudio = new Studio
                {
                    Name = txtNomStudio.Text,
                    VillageId = (int)cbVillages.SelectedValue,
                    Capacity = (int)numPlaces.Value,
                    HighSeasonPrice = decimal.Parse(txtPrixSaison.Text),
                    LowSeasonPrice = decimal.Parse(txtPrixHorsSaison.Text)
                };

                if (StudioService.Create(newStudio))
                {
                    MessageBox.Show("Succès !");
                    ViderChamps();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'enregistrement : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ViderChamps()
        {
            txtNomStudio.Clear();
            if (cbVillages.Items.Count > 0) cbVillages.SelectedIndex = 0;
            numPlaces.Value = 0;
            txtPrixSaison.Clear();
            txtPrixHorsSaison.Clear();
            txtNomStudio.Focus();
        }

        private void btnEnregistrer_MouseEnter(object sender, EventArgs e)
        {
            btnEnregistrer.BackColor = Color.FromArgb(0, 150, 255);
        }

        private void btnEnregistrer_MouseLeave(object sender, EventArgs e)
        {
            btnEnregistrer.BackColor = Color.FromArgb(0, 120, 215);
        }

        private void labelNomStudio_Click(object sender, EventArgs e)
        {

        }

        private void titleAddStudio_Click(object sender, EventArgs e)
        {

        }
    }
}