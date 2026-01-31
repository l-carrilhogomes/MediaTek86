using System;
using System.Collections.Generic;
using System.Text;

namespace MediaTek86.model
{
    public class Motif
    {

        /// <summary>
        ///  Modèle Motif   
        /// </summary>
        /// <param name="idMotif"></param>
        /// <param name="libelle"></param>
        public Motif(int idMotif, string libelle)
        {
            this.IdModif = idMotif;
            this.Libelle = libelle;
        }

        public int IdModif { get; }
        public string Libelle { get; set; }
    }
}
