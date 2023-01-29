namespace P4U2_Training_Mode_Recording_Input_Parsing_Tool
{
    internal static class Program
    {
        public static string appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public static string saveFilePath = appDataFolder + "\\P4U2\\Save\\save.dat";
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}