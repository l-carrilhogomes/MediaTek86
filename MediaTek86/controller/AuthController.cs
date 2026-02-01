using MediaTek86.dal;
using MediaTek86.model;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace MediaTek86.controller
{
    public class AuthController
    {
        public Responsable ControleAuthentification(string login, string password) {
            /// <summary>
            /// Vérification si les paramètres sont non nuls ou vides
            /// </summary>
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                return null;
            }
            
            /// <summary>
            /// Hachage du mot de passe en SHA256
            /// </summary>
            string hashedPassword = HashSha256(password);
            
            /// <summary>
            /// Récupération du responsable
            /// </summary>
            ResponsableAccess responsableAccess = new ResponsableAccess();
            Responsable responsable = responsableAccess.GetResponsable(login, hashedPassword);
            return responsable;
        }

        /// <summary>
        /// Hache une chaîne de caractères en SHA256
        /// </summary>
        /// <param name="input">Chaîne à hacher</param>
        /// <returns>Hash SHA256 en hexadécimal</returns>
        private string HashSha256(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
