using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LSLlib;

namespace SSVEP_Speller_CSharp.LabStreamingLayer
{
    class LSL
    {
        #region Fields
        liblsl.StreamInfo[] EEGstreamInfo;
        #endregion Fields

        //Constructor
        public LSL()
        {
            // resolve EEG stream
            EEGstreamInfo = liblsl.resolve_stream("type", "EEG");

        }
    }
}
