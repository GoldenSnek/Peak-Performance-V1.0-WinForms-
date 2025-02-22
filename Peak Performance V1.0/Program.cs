namespace Peak_Performance_V1._0
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }

        //VERSION 1
        //Repository Created: 2/9/2025
        //Date Started: 2/20/2025

        //To Do List:
        //1. Add picture sa creation of vehicle
        //2. Smart ID instead of auto-int. Meaning every deletion, ID will be updated and shifted.
        //3. errpr handling for add vehicle
        //4. vehicle specific type ust dynamically change based on the vehicle general type
        //5. cmd.Parameters.AddWithValue("@imagePath", imagePath); //cons: naay chance i delete and specific file path


    }
}