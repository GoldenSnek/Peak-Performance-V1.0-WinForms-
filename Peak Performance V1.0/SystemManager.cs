using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography; //password hashing
using System.Data.OleDb; //database connections

//NuGet UI packages
using ReaLTaiizor;
using ReaLTaiizor.Manager;

namespace Peak_Performance_V1._0
{
    internal class SystemManager
    {
        private static readonly string dbPath = @"|DataDirectory|\PeakPerformanceDB.accdb";
        private static readonly string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};Persist Security Info=False;";

        public static int currentUserID = 0; //store logged-in UserID
        public static string? currentUsername = null; //store logged-in Username
        public static string? currentRole = "Admin"; //store logged-in Role

        public static OleDbConnection GetConnection() //METHOD: Database Connection
        {
            return new OleDbConnection(connectionString);
        }

        public static void LoadMaterialTheme() //METHOD: Setup ReaLTaiizor MaterialSkin UI
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ReaLTaiizor.Colors.MaterialColorScheme(ReaLTaiizor.Colors.MaterialPrimary.Orange700, ReaLTaiizor.Colors.MaterialPrimary.Orange800, ReaLTaiizor.Colors.MaterialPrimary.Orange900, ReaLTaiizor.Colors.MaterialAccent.Orange700, ReaLTaiizor.Util.MaterialTextShade.WHITE);
        }

        public static string HashPassword(string password) //SUPPORTING METHOD: Hash password for Login and Register 
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

        public static Image ResizeImage(Image img) //SUPPORTING METHOD: Dynamically resize icons
        {
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            float scaleFactor = Math.Min(screenWidth / 1920f, screenHeight / 1080f);
            int newSize = (int)(32 * scaleFactor);

            return new Bitmap(img, new Size(newSize, newSize));
        }
    }
}