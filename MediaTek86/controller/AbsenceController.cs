using MediaTek86.dal;
using MediaTek86.model;
using System;
using System.Collections.Generic;

namespace MediaTek86.controller
{
    /// <summary>
    /// Contrôleur pour la gestion des absences
    /// </summary>
    public class AbsenceController
    {
        private readonly AbsenceAccess absenceAccess;

        public AbsenceController()
        {
            absenceAccess = new AbsenceAccess();
        }

        /// <summary>
        /// Récupère la liste des absences d'un personnel
        /// </summary>
        public List<object[]> GetAbsencesByPersonnel(int idPersonnel)
        {
            return absenceAccess.GetAbsencesByPersonnel(idPersonnel);
        }

        /// <summary>
        /// Ajoute une nouvelle absence
        /// </summary>
        public void AddAbsence(int idPersonnel, DateTime dateDebut, DateTime dateFin, int idMotif)
        {
            absenceAccess.AddAbsence(idPersonnel, dateDebut, dateFin, idMotif);
        }

        /// <summary>
        /// Met à jour une absence existante
        /// </summary>
        public void UpdateAbsence(int idPersonnel, DateTime oldDateDebut, DateTime newDateDebut, DateTime dateFin, int idMotif)
        {
            absenceAccess.UpdateAbsence(idPersonnel, oldDateDebut, newDateDebut, dateFin, idMotif);
        }

        /// <summary>
        /// Supprime une absence
        /// </summary>
        public void DeleteAbsence(int idPersonnel, DateTime dateDebut)
        {
            absenceAccess.DeleteAbsence(idPersonnel, dateDebut);
        }

        /// <summary>
        /// Récupère la liste de tous les motifs
        /// </summary>
        public List<Motif> GetAllMotifs()
        {
            return absenceAccess.GetAllMotifs();
        }
    }
}
