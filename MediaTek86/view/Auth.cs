using MediaTek86.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MediaTek86.model;

namespace MediaTek86.view
{
    public partial class Auth : Form
    {
        private AuthController controller = new AuthController();

        public Auth()
        {
            InitializeComponent();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextbox.Text;
            string password = passwordTextbox.Text;

            // Vérification des champs vides
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tentative d'authentification
            Responsable responsable = controller.ControleAuthentification(username, password);
            
            if (responsable != null)
            {
                // Authentification réussie : ouvrir le formulaire Personnel
                this.Hide();
                Personnel personnelForm = new Personnel();
                personnelForm.ShowDialog();
                // Quand Personnel se ferme (déconnexion), réafficher Auth
                this.Show();
                usernameTextbox.Text = "";
                passwordTextbox.Text = "";
            }
            else
            {
                // Échec de l'authentification
                MessageBox.Show("Identifiant ou mot de passe incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordTextbox.Text = "";  // Vider le champ mot de passe
                passwordTextbox.Focus();
            }
        }
    }
}
