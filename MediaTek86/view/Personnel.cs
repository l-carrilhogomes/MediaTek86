using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MediaTek86.controller;

namespace MediaTek86.view
{
    public partial class Personnel : Form
    {
        private readonly PersonnelController personnelController;

        public Personnel()
        {
            InitializeComponent();
            personnelController = new PersonnelController();
            LoadPersonnel();
        }

        /// <summary>
        /// Charge la liste du personnel dans le DataGridView
        /// </summary>
        private void LoadPersonnel()
        {
            List<model.Personnel> personnels = personnelController.GetAllPersonnel();
            Dictionary<int, string> services = GetServicesDict();
            
            // Créer une DataTable pour le DataGridView
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Nom", typeof(string));
            dataTable.Columns.Add("Prénom", typeof(string));
            dataTable.Columns.Add("Téléphone", typeof(string));
            dataTable.Columns.Add("Email", typeof(string));
            dataTable.Columns.Add("Service", typeof(string));

            foreach (model.Personnel personnel in personnels)
            {
                string serviceName = services.ContainsKey(personnel.IdService) ? services[personnel.IdService] : "";
                dataTable.Rows.Add(
                    personnel.IdPersonnel,
                    personnel.Nom,
                    personnel.Prenom,
                    personnel.Tel,
                    personnel.Mail,
                    serviceName
                );
            }

            personnel_grid.DataSource = dataTable;
        }

        /// <summary>
        /// Récupère un dictionnaire des services (ID => Nom)
        /// </summary>
        private Dictionary<int, string> GetServicesDict()
        {
            List<model.Service> services = personnelController.GetAllServices();
            Dictionary<int, string> dict = new Dictionary<int, string>();
            foreach (model.Service service in services)
            {
                dict[service.IdService] = service.nom;
            }
            return dict;
        }

        /// <summary>
        /// Ouvre le formulaire d'ajout de personnel
        /// </summary>
        private void addpersonnel_button_Click(object sender, EventArgs e)
        {
            AddPersonnel addPersonnelForm = new AddPersonnel();
            if (addPersonnelForm.ShowDialog() == DialogResult.OK)
            {
                // Rafraîchir la liste après l'ajout
                LoadPersonnel();
            }
        }

        /// <summary>
        /// Ouvre le formulaire de modification de personnel
        /// </summary>
        private void modifypersonnel_button_Click(object sender, EventArgs e)
        {
            // Vérifier qu'une ligne est sélectionnée
            if (personnel_grid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un personnel à modifier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Récupérer les données du personnel sélectionné
            DataGridViewRow selectedRow = personnel_grid.SelectedRows[0];
            model.Personnel selectedPersonnel = new model.Personnel(
                (int)selectedRow.Cells["ID"].Value,
                (string)selectedRow.Cells["Nom"].Value,
                (string)selectedRow.Cells["Prénom"].Value,
                (string)selectedRow.Cells["Téléphone"].Value,
                (string)selectedRow.Cells["Email"].Value,
                (int)selectedRow.Cells["ID Service"].Value
            );

            // Ouvrir le formulaire de modification
            ModifyPersonnel modifyPersonnelForm = new ModifyPersonnel(selectedPersonnel);
            if (modifyPersonnelForm.ShowDialog() == DialogResult.OK)
            {
                // Rafraîchir la liste après la modification
                LoadPersonnel();
            }
        }

        /// <summary>
        /// Supprime le personnel sélectionné après confirmation
        /// </summary>
        private void deletepersonnel_button_Click(object sender, EventArgs e)
        {
            // Vérifier qu'une ligne est sélectionnée
            if (personnel_grid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un personnel à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Récupérer les données du personnel sélectionné
            DataGridViewRow selectedRow = personnel_grid.SelectedRows[0];
            int idPersonnel = (int)selectedRow.Cells["ID"].Value;
            string nom = (string)selectedRow.Cells["Nom"].Value;
            string prenom = (string)selectedRow.Cells["Prénom"].Value;

            // Demander confirmation
            DialogResult confirmation = MessageBox.Show(
                $"Êtes-vous sûr de vouloir supprimer {prenom} {nom} ?",
                "Confirmation de suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmation == DialogResult.Yes)
            {
                try
                {
                    personnelController.DeletePersonnel(idPersonnel);
                    MessageBox.Show("Personnel supprimé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPersonnel();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de la suppression : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Déconnexion : ferme le formulaire Personnel pour revenir à Auth
        /// </summary>
        private void disconnect_button_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show(
                "Êtes-vous sûr de vouloir vous déconnecter ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmation == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Ouvre le formulaire de gestion des absences du personnel sélectionné
        /// </summary>
        private void gestionabsences_button_Click(object sender, EventArgs e)
        {
            if (personnel_grid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un personnel.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = personnel_grid.SelectedRows[0];
            int idPersonnel = (int)selectedRow.Cells["ID"].Value;
            string nom = (string)selectedRow.Cells["Nom"].Value;
            string prenom = (string)selectedRow.Cells["Prénom"].Value;
            string nomComplet = $"{prenom} {nom}";

            Absence absenceForm = new Absence(idPersonnel, nomComplet);
            absenceForm.ShowDialog();
        }
    }
}


