using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudioLoc
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        private Button currentButton;

        public MainForm()
        {
            InitializeComponent();
            buttonAjouterStudio.NotifyDefault(false);
            buttonInfoStudio.NotifyDefault(false);
            buttonInfoResa.NotifyDefault(false);
        }

        private void HighlightButton(object btnSender)
        {
            if (btnSender is Button btn)
            {
                if (currentButton != btn)
                {
                    if (currentButton != null)
                    {
                        currentButton.ForeColor = Color.FromArgb(64, 64, 64);
                        currentButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
                        currentButton.BackColor = Color.White;
                    }
                    currentButton = btn;
                    currentButton.ForeColor = Color.FromArgb(0, 122, 204);
                    currentButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
                }
            }
        }

        private void ChargerFormulaire(System.Windows.Forms.Form childForm, object btnSender, string titre)
        {
            if (pnlContenu.Controls.Count > 0) pnlContenu.Controls[0].Dispose();
            HighlightButton(btnSender);
            lblTitrePage.Text = titre.ToUpper();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlContenu.Controls.Add(childForm);
            childForm.Show();
        }

        private void buttonAjouterStudio_Click(object sender, EventArgs e) => ChargerFormulaire(new AddStudioForm(), sender, "Ajouter Studio");
        private void buttonInfoStudio_Click(object sender, EventArgs e) => ChargerFormulaire(new StudioDetailsForm(), sender, "Liste des Studios");
        private void buttonInfoResa_Click(object sender, EventArgs e) => ChargerFormulaire(new ReservationDetailsForm(), sender, "Réservations");
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();

        private void pnlContenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonDeconnexion_Click(object sender, EventArgs e)
        {
            LoginForm loginPage = new LoginForm();
            loginPage.Show();
            this.Hide();
        }
    }
}