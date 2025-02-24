using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data.OleDb;

namespace Peak_Performance_V1._0
{
    internal class SystemManager
    {
        private static readonly string dbPath = @"|DataDirectory|\PeakPerformanceDB.accdb";
        private static readonly string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};Persist Security Info=False;";

        public static int currentUserID; //store logged-in UserID
        public static string? currentUsername; //store logged-in Username
        public static string? currentRole; //store logged-in Role

        //SUPPORTING METHOD for Database Connection
        public static OleDbConnection GetConnection()
        {
            return new OleDbConnection(connectionString);
        }

        //SUPPORTING METHOD for Login and Register
        public static string HashPassword(string password) //SUPPORTING METHOD for Login
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }
    }
}