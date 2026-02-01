using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MediaTek86.controller;
using MediaTek86.model;

namespace MediaTek86.view
{
    public partial class AddPersonnel : Form
    {
        private readonly PersonnelController personnelController;

        public AddPersonnel()
        {
            InitializeComponent();
            personnelController = new PersonnelController();
            LoadServices();
        }

        /// <summary>
        /// Charge la liste des services dans le dropdown
        /// </summary>
        private void LoadServices()
        {
            List<Service> services = personnelController.GetAllServices();
            service_dropdown.DataSource = services;
            service_dropdown.DisplayMember = "nom";
            service_dropdown.ValueMember = "IdService";
        }

        /// <summary>
        /// Ajoute un nouveau personnel lors du clic sur le bouton
        /// </summary>
        private void addPersonnel_button_Click(object sender, EventArgs e)
        {
            // Récupération des valeurs
            string nom = lastname_textbox.Text.Trim();
            string prenom = firstname_textbox.Text.Trim();
            string tel = tel_textbox.Text.Trim();
            string mail = mail_textbox.Text.Trim();

            // Validation des champs obligatoires
            if (string.IsNullOrEmpty(nom) || string.IsNullOrEmpty(prenom))
            {
                MessageBox.Show("Le nom et le prénom sont obligatoires.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (service_dropdown.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner un service.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idService = (int)service_dropdown.SelectedValue;

            // Ajout du personnel
            try
            {
                personnelController.AddPersonnel(nom, prenom, tel, mail, idService);
                MessageBox.Show("Personnel ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout du personnel : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
