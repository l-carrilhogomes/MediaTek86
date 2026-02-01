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
    public partial class ModifyAbsence : Form
    {
        private readonly AbsenceController absenceController;
        private readonly int idPersonnel;
        private readonly DateTime oldDateDebut;

        public ModifyAbsence(int idPersonnel, DateTime dateDebut, DateTime dateFin, int idMotif)
        {
            InitializeComponent();
            absenceController = new AbsenceController();
            this.idPersonnel = idPersonnel;
            this.oldDateDebut = dateDebut;

            LoadMotifs();
            LoadAbsenceData(dateDebut, dateFin, idMotif);
        }

        private void LoadMotifs()
        {
            List<Motif> motifs = absenceController.GetAllMotifs();
            motif_dropdown.DataSource = motifs;
            motif_dropdown.DisplayMember = "Libelle";
            motif_dropdown.ValueMember = "IdModif";
        }

        private void LoadAbsenceData(DateTime dateDebut, DateTime dateFin, int idMotif)
        {
            startingdate_datepicker.Value = dateDebut;
            endingdate_datepicker.Value = dateFin;
            
            // Sélectionner le motif correspondant à l'ID
            for (int i = 0; i < motif_dropdown.Items.Count; i++)
            {
                Motif motif = (Motif)motif_dropdown.Items[i];
                if (motif.IdModif == idMotif)
                {
                    motif_dropdown.SelectedIndex = i;
                    break;
                }
            }
        }

        private void modifyAbsence_button_Click(object sender, EventArgs e)
        {
            DateTime newDateDebut = startingdate_datepicker.Value;
            DateTime newDateFin = endingdate_datepicker.Value;

            if (newDateFin < newDateDebut)
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
                absenceController.UpdateAbsence(idPersonnel, oldDateDebut, newDateDebut, newDateFin, idMotif);
                MessageBox.Show("Absence modifiée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la modification : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
