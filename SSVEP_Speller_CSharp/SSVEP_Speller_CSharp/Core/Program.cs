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
            // LSL version
            var version = liblsl.library_version();
            Console.WriteLine(version.ToString());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Visualize EEG signals
            Application.Run(new LSL_Visualizer());

            // Start configuration gui
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

