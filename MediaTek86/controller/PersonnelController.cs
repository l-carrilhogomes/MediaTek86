using MediaTek86.dal;
using MediaTek86.model;
using System.Collections.Generic;

namespace MediaTek86.controller
{
    /// <summary>
    /// Contrôleur pour la gestion du personnel
    /// </summary>
    public class PersonnelController
    {
        private readonly PersonnelAccess personnelAccess;

        public PersonnelController()
        {
            personnelAccess = new PersonnelAccess();
        }

        /// <summary>
        /// Récupère la liste de tout le personnel
        /// </summary>
        /// <returns>Liste du personnel</returns>
        public List<Personnel> GetAllPersonnel()
        {
            return personnelAccess.GetAllPersonnel();
        }

        /// <summary>
        /// Ajoute un nouveau personnel
        /// </summary>
        /// <param name="nom">Nom du personnel</param>
        /// <param name="prenom">Prénom du personnel</param>
        /// <param name="tel">Téléphone du personnel</param>
        /// <param name="mail">Email du personnel</param>
        /// <param name="idService">ID du service</param>
        public void AddPersonnel(string nom, string prenom, string tel, string mail, int idService)
        {
            personnelAccess.AddPersonnel(nom, prenom, tel, mail, idService);
        }

        /// <summary>
        /// Récupère la liste de tous les services
        /// </summary>
        /// <returns>Liste des services</returns>
        public List<Service> GetAllServices()
        {
            return personnelAccess.GetAllServices();
        }

        /// <summary>
        /// Met à jour un personnel existant
        /// </summary>
        /// <param name="idPersonnel">ID du personnel à modifier</param>
        /// <param name="nom">Nouveau nom</param>
        /// <param name="prenom">Nouveau prénom</param>
        /// <param name="tel">Nouveau téléphone</param>
        /// <param name="mail">Nouveau mail</param>
        /// <param name="idService">Nouvel ID de service</param>
        public void UpdatePersonnel(int idPersonnel, string nom, string prenom, string tel, string mail, int idService)
        {
            personnelAccess.UpdatePersonnel(idPersonnel, nom, prenom, tel, mail, idService);
        }

        /// <summary>
        /// Supprime un personnel
        /// </summary>
        /// <param name="idPersonnel">ID du personnel à supprimer</param>
        public void DeletePersonnel(int idPersonnel)
        {
            personnelAccess.DeletePersonnel(idPersonnel);
        }
    }
}
