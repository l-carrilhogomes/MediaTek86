using System;
using System.Collections.Generic;
using System.Text;

namespace MediaTek86.model
{
    public class Service
    {

        /// <summary>
        ///  Modèle Motif   
        /// </summary>
        /// <param name="idService"></param>
        /// <param name="nom"></param>
        public Service(int idService, string nom)
        {
            this.IdService = idService;
            this.nom = nom;
        }

        public int IdService { get; }
        public string nom { get; set; }
    }
}
