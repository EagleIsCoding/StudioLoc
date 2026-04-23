using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace StudioLoc
{
    public partial class ReservationDetailsForm : System.Windows.Forms.Form
    {
        public ReservationDetailsForm()
        {
            InitializeComponent();
        }

        private void ResaInfo_Load(object sender, EventArgs e)
        {
            dgvResaList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResaList.RowHeadersVisible = false;
            dgvResaList.BackgroundColor = Color.White;
            dgvResaList.BorderStyle = BorderStyle.None;
            dgvResaList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResaList.RowHeadersVisible = false;
            dgvResaList.AllowUserToAddRows = false;
            dgvResaList.ReadOnly = true;
            dgvResaList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            RefreshReservations();
        }

        private void RefreshReservations()
        {
            try
            {
                var liste = ReservationService.GetAll();
                dgvResaList.DataSource = liste;

                dgvResaList.Columns["Id"].HeaderText = "N°";
                dgvResaList.Columns["StudioName"].HeaderText = "Studio";
                dgvResaList.Columns["ClientName"].HeaderText = "Client";
                dgvResaList.Columns["StartDate"].HeaderText = "Arrivée";
                dgvResaList.Columns["EndDate"].HeaderText = "Départ";
                dgvResaList.Columns["GuestCount"].HeaderText = "Pers.";
                dgvResaList.Columns["CreatedAt"].HeaderText = "Réservé le";

                if (dgvResaList.Columns["UserId"] != null) dgvResaList.Columns["UserId"].Visible = false;
                if (dgvResaList.Columns["StudioId"] != null) dgvResaList.Columns["StudioId"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement : " + ex.Message);
            }
        }

        private void dgvResaList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            Reservation resaSelectionnee = (Reservation)dgvResaList.Rows[e.RowIndex].DataBoundItem;

            if (dgvResaList.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                var result = MessageBox.Show($"Supprimer la réservation n°{resaSelectionnee.Id} ?",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    if (ReservationService.Delete(resaSelectionnee.Id))
                    {
                        RefreshReservations();
                        MessageBox.Show("Supprimé !");
                    }
                }
            }

            if (dgvResaList.Columns[e.ColumnIndex].Name == "btnEdit")
            {
                using (EditReservationForm frm = new EditReservationForm(resaSelectionnee))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        RefreshReservations();
                    }
                }
            }
        }

    }
}