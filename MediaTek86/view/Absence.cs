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
    public partial class Absence : Form
    {
        private readonly AbsenceController absenceController;
        private readonly int idPersonnel;

        public Absence(int idPersonnel, string nomComplet)
        {
            InitializeComponent();
            absenceController = new AbsenceController();
            this.idPersonnel = idPersonnel;
            this.Text = $"Absences de {nomComplet}";
            LoadAbsences();
        }

        public void LoadAbsences()
        {
            List<object[]> absences = absenceController.GetAbsencesByPersonnel(idPersonnel);

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Date Début", typeof(DateTime));
            dataTable.Columns.Add("Date Fin", typeof(DateTime));
            dataTable.Columns.Add("Motif", typeof(string));
            dataTable.Columns.Add("ID Motif", typeof(int));  // Colonne pour la modification

            foreach (object[] absence in absences)
            {
                dataTable.Rows.Add(
                    absence[1],
                    absence[2],
                    absence[4],
                    absence[3]
                );
            }

            absence_grid.DataSource = dataTable;
            // Cacher la colonne ID Motif
            if (absence_grid.Columns["ID Motif"] != null)
            {
                absence_grid.Columns["ID Motif"].Visible = false;
            }
        }

        private void modifyabsence_button_Click(object sender, EventArgs e)
        {
            if (absence_grid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une absence à modifier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = absence_grid.SelectedRows[0];
            DateTime dateDebut = (DateTime)selectedRow.Cells["Date Début"].Value;
            DateTime dateFin = (DateTime)selectedRow.Cells["Date Fin"].Value;
            int idMotif = (int)selectedRow.Cells["ID Motif"].Value;

            ModifyAbsence modifyAbsenceForm = new ModifyAbsence(idPersonnel, dateDebut, dateFin, idMotif);
            if (modifyAbsenceForm.ShowDialog() == DialogResult.OK)
            {
                LoadAbsences();
            }
        }

        private void deleteabsence_button_Click(object sender, EventArgs e)
        {
            if (absence_grid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une absence à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = absence_grid.SelectedRows[0];
            DateTime dateDebut = (DateTime)selectedRow.Cells["Date Début"].Value;
            string motif = (string)selectedRow.Cells["Motif"].Value;

            DialogResult confirmation = MessageBox.Show(
                $"Êtes-vous sûr de vouloir supprimer cette absence ({motif}) ?",
                "Confirmation de suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmation == DialogResult.Yes)
            {
                try
                {
                    absenceController.DeleteAbsence(idPersonnel, dateDebut);
                    MessageBox.Show("Absence supprimée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAbsences();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de la suppression : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void addabsence_button_Click(object sender, EventArgs e)
        {
            AddAbsence addAbsenceForm = new AddAbsence(idPersonnel);
            if (addAbsenceForm.ShowDialog() == DialogResult.OK)
            {
                LoadAbsences();
            }
        }
    }
}
