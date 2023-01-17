using System;
using System.Security.Cryptography;
using System.Text;

namespace MosEnergo2._0
{
    internal class HasherMD5
    {
        // Метод который возвращает захешированный пароль 
        public static string HashPassword(string password)
        {
            MD5 md5 = MD5.Create();

            byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(password));

            return Convert.ToBase64String(hash);
        }
    }
}
