using MediaTek86.model;
using System.Collections.Generic;

namespace MediaTek86.dal
{
    /// <summary>
    /// Classe d'accès aux données de la table personnel
    /// </summary>
    public class PersonnelAccess
    {
        private readonly Access access;

        public PersonnelAccess()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Récupère la liste de tout le personnel
        /// </summary>
        /// <returns>Liste du personnel</returns>
        public List<Personnel> GetAllPersonnel()
        {
            string query = "SELECT idpersonnel, nom, prenom, tel, mail, idservice FROM personnel ORDER BY nom, prenom";
            List<object[]> records = access.Manager.ReqSelect(query);

            List<Personnel> personnels = new List<Personnel>();
            foreach (object[] record in records)
            {
                Personnel personnel = new Personnel(
                    (int)record[0],           // idPersonnel
                    (string)record[1],        // nom
                    (string)record[2],        // prenom
                    (string)record[3],        // tel
                    (string)record[4],        // mail
                    (int)record[5]            // idService
                );
                personnels.Add(personnel);
            }
            return personnels;
        }

        /// <summary>
        /// Ajoute un nouveau personnel dans la base de données
        /// </summary>
        /// <param name="nom">Nom du personnel</param>
        /// <param name="prenom">Prénom du personnel</param>
        /// <param name="tel">Téléphone du personnel</param>
        /// <param name="mail">Email du personnel</param>
        /// <param name="idService">ID du service</param>
        public void AddPersonnel(string nom, string prenom, string tel, string mail, int idService)
        {
            string query = "INSERT INTO personnel (nom, prenom, tel, mail, idservice) VALUES (@nom, @prenom, @tel, @mail, @idservice)";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@nom", nom },
                { "@prenom", prenom },
                { "@tel", tel },
                { "@mail", mail },
                { "@idservice", idService }
            };
            access.Manager.ReqUpdate(query, parameters);
        }

        /// <summary>
        /// Récupère la liste de tous les services
        /// </summary>
        /// <returns>Liste des services</returns>
        public List<Service> GetAllServices()
        {
            string query = "SELECT idservice, nom FROM service ORDER BY nom";
            List<object[]> records = access.Manager.ReqSelect(query);

            List<Service> services = new List<Service>();
            foreach (object[] record in records)
            {
                Service service = new Service(
                    (int)record[0],           // idService
                    (string)record[1]         // nom
                );
                services.Add(service);
            }
            return services;
        }

        /// <summary>
        /// Met à jour un personnel existant dans la base de données
        /// </summary>
        /// <param name="idPersonnel">ID du personnel à modifier</param>
        /// <param name="nom">Nouveau nom</param>
        /// <param name="prenom">Nouveau prénom</param>
        /// <param name="tel">Nouveau téléphone</param>
        /// <param name="mail">Nouveau mail</param>
        /// <param name="idService">Nouvel ID de service</param>
        public void UpdatePersonnel(int idPersonnel, string nom, string prenom, string tel, string mail, int idService)
        {
            string query = "UPDATE personnel SET nom = @nom, prenom = @prenom, tel = @tel, mail = @mail, idservice = @idservice WHERE idpersonnel = @idpersonnel";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@idpersonnel", idPersonnel },
                { "@nom", nom },
                { "@prenom", prenom },
                { "@tel", tel },
                { "@mail", mail },
                { "@idservice", idService }
            };
            access.Manager.ReqUpdate(query, parameters);
        }

        /// <summary>
        /// Supprime un personnel de la base de données
        /// </summary>
        /// <param name="idPersonnel">ID du personnel à supprimer</param>
        public void DeletePersonnel(int idPersonnel)
        {
            string query = "DELETE FROM personnel WHERE idpersonnel = @idpersonnel";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@idpersonnel", idPersonnel }
            };
            access.Manager.ReqUpdate(query, parameters);
        }
    }
}
