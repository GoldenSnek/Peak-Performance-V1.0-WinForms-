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
            SystemManager.LoadMaterialTheme(); //initialize material theme
            Application.Run(new Home());
        }

        //VERSION 1
        //Repository Created: 2/9/2025
        //Date Started: 2/20/2025
        //Increment 1: 3/18/2025 (3/22/2025 video)

        //To Do List:
        //(done) 1. Add picture sa creation of vehicle
        //2. Smart ID instead of auto-int. Meaning every deletion, ID will be updated and shifted.
        //(done) 3. errpr handling for add vehicle
        //4. vehicle specific type ust dynamically change based on the vehicle general type
        //(done) 5. cmd.Parameters.AddWithValue("@imagePath", imagePath); //cons: naay chance i delete and specific file path
        //(done) 6. Add picture to the vehicle card
        //7.

        //IMPORTANT: database relationships, like owner sa vehicle sa kani nga specific car/cars
    }
}