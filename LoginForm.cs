using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudioLoc
{
    public partial class LoginForm : System.Windows.Forms.Form
    {
        public LoginForm()
        {
            InitializeComponent();
            SetupPlaceholders();
        }

        private void SetupPlaceholders()
        {
            if (txtEmail == null || txtPassword == null) return;

            txtEmail.Text = "Email";
            txtEmail.ForeColor = Color.Gray;

            txtEmail.Enter += (s, e) => {
                if (txtEmail.Text == "Email")
                {
                    txtEmail.Text = "";
                    txtEmail.ForeColor = Color.Black;
                }
            };

            txtEmail.Leave += (s, e) => {
                if (string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    txtEmail.Text = "Email";
                    txtEmail.ForeColor = Color.Gray;
                }
            };

            txtPassword.Text = "Mot de passe";
            txtPassword.ForeColor = Color.Gray;
            txtPassword.UseSystemPasswordChar = false;

            txtPassword.Enter += (s, e) => {
                if (txtPassword.Text == "Mot de passe")
                {
                    txtPassword.Text = "";
                    txtPassword.ForeColor = Color.Black;
                    txtPassword.UseSystemPasswordChar = true;
                }
            };

            txtPassword.Leave += (s, e) => {
                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    txtPassword.Text = "Mot de passe";
                    txtPassword.ForeColor = Color.Gray;
                    txtPassword.UseSystemPasswordChar = false;
                }
            };
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string mdp = txtPassword.Text;

            if (email == "Email" || mdp == "Mot de passe" || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Veuillez saisir vos identifiants.", "Champs vides", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (UserService.Login(email, mdp))
                {
                    MainForm monDashboard = new MainForm();
                    monDashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Identifiants incorrects ou accès réservé aux administrateurs.", "Échec", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la connexion : " + ex.Message, "Erreur Critique", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = lblTitre;
        }

        private void LoginForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}