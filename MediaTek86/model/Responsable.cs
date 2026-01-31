using System;
using System.Collections.Generic;
using System.Text;

namespace MediaTek86.model
{
  public class Responsable
    {
        /// <summary>
        /// Modèle Responsable   
        /// </summary>
        /// <param name="idResponsable"></param>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        public Responsable(int idResponsable, string login, string pwd)
        {
            this.IdResponsable = idResponsable;
            this.Login = login;
            this.Pwd = pwd;
        }

        public int IdResponsable { get; }
        public string Login { get;  }
        public string Pwd { get;  }
    }
}
