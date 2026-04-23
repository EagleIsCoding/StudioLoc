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
    public partial class EditReservationForm : Form
    {
        private Reservation _resa; 

        public EditReservationForm(Reservation resaRecue)
        {
            InitializeComponent();
            _resa = resaRecue;

            dtpDebut.Value = _resa.StartDate;
            dtpFin.Value = _resa.EndDate;
            nudPersonnes.Value = _resa.GuestCount;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            _resa.StartDate = dtpDebut.Value;
            _resa.EndDate = dtpFin.Value;
            _resa.GuestCount = (int)nudPersonnes.Value;

            if (ReservationService.Update(_resa))
            {
                MessageBox.Show("Réservation modifiée avec succès !");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Erreur lors de la modification.");
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void EditReservationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
