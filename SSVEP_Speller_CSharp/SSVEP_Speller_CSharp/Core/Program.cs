using System;
using System.Windows.Forms;
using SSVEP_Speller_CSharp.Forms;

namespace SSVEP_Speller_CSharp
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {

            // Start main application GUI
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigUI gui = new ConfigUI();
            Application.Run(gui);

            // Start XNA
            using (Game1 game = new Game1(gui.parms))
            {
                InterceptKeys.Hook();
                game.Run();
                InterceptKeys.Unhook();
            }
        }
    }
#endif
}

