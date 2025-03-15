using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data.OleDb;

//NuGet UI packages
using ReaLTaiizor;          // Core namespace
using ReaLTaiizor.Manager;
using ReaLTaiizor.Controls; // For custom controls like buttons, labels, etc.
using ReaLTaiizor.Forms;    // For using Taiizor-styled forms
using ReaLTaiizor.Enum;     // For enumerations (e.g., themes, styles)

namespace Peak_Performance_V1._0
{
    internal class SystemManager
    {
        private static readonly string dbPath = @"|DataDirectory|\PeakPerformanceDB.accdb";
        private static readonly string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};Persist Security Info=False;";

        public static int currentUserID = 0; //store logged-in UserID
        public static string? currentUsername = null; //store logged-in Username
        public static string? currentRole = "Vehicle Provider"; //store logged-in Role

        public static OleDbConnection GetConnection() //SUPPORTING METHOD for Database Connection
        {
            return new OleDbConnection(connectionString);
        }

        public static string HashPassword(string password) //SUPPORTING METHOD for Login and Register
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

        public static void LoadMaterialTheme()
        {
            //set realtaiizor materialskin theme
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ReaLTaiizor.Colors.MaterialColorScheme(ReaLTaiizor.Colors.MaterialPrimary.Orange700, ReaLTaiizor.Colors.MaterialPrimary.Orange800, ReaLTaiizor.Colors.MaterialPrimary.Orange900, ReaLTaiizor.Colors.MaterialAccent.Orange700, ReaLTaiizor.Util.MaterialTextShade.WHITE);
        }
        public static Image ResizeImage(Image img)
        {
            // Get the current screen resolution
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            // Calculate a scaling factor (adjust as needed)
            float scaleFactor = Math.Min(screenWidth / 1920f, screenHeight / 1080f); // Use reference resolution

            // Set a base size (e.g., 32x32 for 1080p)
            int newSize = (int)(32 * scaleFactor);

            return new Bitmap(img, new Size(newSize, newSize));
        }

    }
}