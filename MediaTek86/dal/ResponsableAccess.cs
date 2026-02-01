using MediaTek86.model;
using System.Collections.Generic;

namespace MediaTek86.dal {
    public class ResponsableAccess {
        private readonly Access access;

        public ResponsableAccess() {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Recherche un responsable par login et mot de passe
        /// </summary>
        /// <param name="login">Login du responsable</param>
        /// <param name="password">Mot de passe du responsable</param>
        /// <returns>Le responsable si trouvé, null sinon</returns>
        public Responsable GetResponsable(string login, string password) {
            string query = "SELECT idresponsable, login, pwd FROM responsable WHERE login = @login AND pwd = @password";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@login", login },
                { "@password", password }
            };

            List<object[]> records = access.Manager.ReqSelect(query, parameters);

            if (records.Count > 0) {
                object[] record = records[0];
                return new Responsable(
                    (int)record[0],      // idResponsable
                    (string)record[1],   // login
                    (string)record[2]    // pwd
                );
            }
            return null;
        }
    }
}