using System;
using System.Collections.Generic;
using System.Text;

namespace MediaTek86.model
{
    public class Absence
    {

        /// <summary>
        ///  Modèle Absence
        /// </summary>
        /// 
        /// <param name="idPersonnel"></param>
        /// <param name="dateDebut"></param>
        /// <param name="dateFin"></param>
        /// <param name="idMotif"></param>

        public Absence(int idPersonnel, DateOnly dateDebut, DateOnly dateFin, int idMotif)
        {
            this.IdPersonnel = IdPersonnel;
            this.DateDebut = DateDebut;
            this.DateFin = DateFin;
            this.IdMotif = idMotif;
        }

        public int IdPersonnel { get; }
        public DateOnly DateDebut { get; set; }
        public DateOnly DateFin { get; set; }
        public int IdMotif { get; set; }

    }
}
