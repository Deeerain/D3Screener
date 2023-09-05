namespace D3Screener
{
    internal static class Program
    {
        public static Form MainForm { get; set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
       {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            MainForm = new MainForm();
            Application.Run(MainForm);
        }
    }
}