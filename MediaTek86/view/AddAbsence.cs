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
    public partial class AddAbsence : Form
    {
        private readonly AbsenceController absenceController;
        private readonly int idPersonnel;

        public AddAbsence(int idPersonnel)
        {
            InitializeComponent();
            absenceController = new AbsenceController();
            this.idPersonnel = idPersonnel;
            LoadMotifs();
        }

        private void LoadMotifs()
        {
            List<Motif> motifs = absenceController.GetAllMotifs();
            motif_dropdown.DataSource = motifs;
            motif_dropdown.DisplayMember = "Libelle";
            motif_dropdown.ValueMember = "IdModif";
        }

        private void addAbsence_button_Click(object sender, EventArgs e)
        {
            DateTime dateDebut = startingdate_datepicker.Value;
            DateTime dateFin = endingdate_datepicker.Value;

            if (dateFin < dateDebut)
            {
                MessageBox.Show("La date de fin ne peut pas être antérieure à la date de début.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (motif_dropdown.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner un motif.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idMotif = (int)motif_dropdown.SelectedValue;

            try
            {
                absenceController.AddAbsence(idPersonnel, dateDebut, dateFin, idMotif);
                MessageBox.Show("Absence ajoutée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
