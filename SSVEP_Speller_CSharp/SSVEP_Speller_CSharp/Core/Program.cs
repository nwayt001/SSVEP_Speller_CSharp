using System;
using System.Windows.Forms;
using SSVEP_Speller_CSharp.Forms;
using LSLlib;
using SSVEP_Speller_CSharp.LabStreamingLayer.Visualizer;

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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Run Main Form
            MainForm gui = new MainForm();
            Application.Run(gui);

            // Start XNA
            if (!gui.KillApplication)
            {
                using (Game1 game = new Game1(gui.config.parms))
                {
                    InterceptKeys.Hook();
                    game.Run();
                    InterceptKeys.Unhook();
                }
            }
        }
    }
#endif
}

