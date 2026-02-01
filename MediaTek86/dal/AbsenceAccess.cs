using MediaTek86.model;
using System;
using System.Collections.Generic;

namespace MediaTek86.dal
{
    /// <summary>
    /// Classe d'accès aux données de la table absence
    /// </summary>
    public class AbsenceAccess
    {
        private readonly Access access;

        public AbsenceAccess()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Récupère la liste des absences d'un personnel
        /// </summary>
        /// <param name="idPersonnel">ID du personnel</param>
        /// <returns>Liste des absences avec le libellé du motif</returns>
        public List<object[]> GetAbsencesByPersonnel(int idPersonnel)
        {
            string query = @"SELECT a.idpersonnel, a.datedebut, a.datefin, m.idmotif, m.libelle 
                             FROM absence a 
                             INNER JOIN motif m ON a.idmotif = m.idmotif 
                             WHERE a.idpersonnel = @idpersonnel 
                             ORDER BY a.datedebut DESC";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@idpersonnel", idPersonnel }
            };
            return access.Manager.ReqSelect(query, parameters);
        }

        /// <summary>
        /// Ajoute une nouvelle absence
        /// </summary>
        public void AddAbsence(int idPersonnel, DateTime dateDebut, DateTime dateFin, int idMotif)
        {
            string query = "INSERT INTO absence (idpersonnel, datedebut, datefin, idmotif) VALUES (@idpersonnel, @datedebut, @datefin, @idmotif)";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@idpersonnel", idPersonnel },
                { "@datedebut", dateDebut },
                { "@datefin", dateFin },
                { "@idmotif", idMotif }
            };
            access.Manager.ReqUpdate(query, parameters);
        }

        /// <summary>
        /// Met à jour une absence existante
        /// </summary>
        public void UpdateAbsence(int idPersonnel, DateTime oldDateDebut, DateTime newDateDebut, DateTime dateFin, int idMotif)
        {
            string query = @"UPDATE absence SET datedebut = @newdatedebut, datefin = @datefin, idmotif = @idmotif 
                             WHERE idpersonnel = @idpersonnel AND datedebut = @olddatedebut";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@idpersonnel", idPersonnel },
                { "@olddatedebut", oldDateDebut },
                { "@newdatedebut", newDateDebut },
                { "@datefin", dateFin },
                { "@idmotif", idMotif }
            };
            access.Manager.ReqUpdate(query, parameters);
        }

        /// <summary>
        /// Supprime une absence
        /// </summary>
        public void DeleteAbsence(int idPersonnel, DateTime dateDebut)
        {
            string query = "DELETE FROM absence WHERE idpersonnel = @idpersonnel AND datedebut = @datedebut";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@idpersonnel", idPersonnel },
                { "@datedebut", dateDebut }
            };
            access.Manager.ReqUpdate(query, parameters);
        }

        /// <summary>
        /// Récupère la liste de tous les motifs
        /// </summary>
        public List<Motif> GetAllMotifs()
        {
            string query = "SELECT idmotif, libelle FROM motif ORDER BY libelle";
            List<object[]> records = access.Manager.ReqSelect(query);

            List<Motif> motifs = new List<Motif>();
            foreach (object[] record in records)
            {
                Motif motif = new Motif(
                    (int)record[0],
                    (string)record[1]
                );
                motifs.Add(motif);
            }
            return motifs;
        }
    }
}
