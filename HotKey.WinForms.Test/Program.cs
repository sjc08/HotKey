namespace Asjc.HotKey.WinForms.Test
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
            new HotKey(Keys.Space, Modifiers.Ctrl, _ => MessageBox.Show("Ctrl + Space"));
            Application.Run();
        }
    }
}