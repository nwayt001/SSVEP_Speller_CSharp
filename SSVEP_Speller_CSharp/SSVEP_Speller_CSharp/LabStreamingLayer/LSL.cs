using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LSLlib;
using System.Windows.Forms;

namespace SSVEP_Speller_CSharp.LabStreamingLayer
{
    class LSL
    {
        #region Fields
        liblsl.StreamInfo[] EEGstreamInfo;
        liblsl.StreamInlet inlet;
        #endregion Fields

        //Constructor
        public LSL()
        {
            // resolve EEG stream
            EEGstreamInfo = liblsl.resolve_stream("type", "EEG");
            if(EEGstreamInfo.Length < 1)
            {
                MessageBox.Show("No EEG Stream Found");
                Environment.Exit(0);
            }
            inlet = new liblsl.StreamInlet(EEGstreamInfo[0]);

            liblsl.local_clock();
        }
    }
}
