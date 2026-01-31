using System;
using System.Collections.Generic;
using System.Text;

namespace MediaTek86.model
{
    public class Personnel
    {

        /// <summary>
        ///  Modèle Personnel
        /// </summary>
        /// <param name="idPersonnel"></param>
        /// <param name="idService"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// <param name="idService"></param>


        public Personnel(int idPersonnel, string nom, string prenom, int tel, string mail, int idService)
        {
            this.IdPersonnel = idPersonnel;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Tel = tel;
            this.Mail = mail;
            this.IdService = idService;
        }

        public int IdPersonnel { get; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Tel { get; set; }
        public string Mail { get; set; }
        public int IdService { get; set; }


    }
}