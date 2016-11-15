using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SSVEP_Speller_CSharp.Forms
{
    public partial class ConfigUI : Form
    {
        //Fields
        public Speller_Parms parms = new Speller_Parms();

        public ConfigUI()
        {

            // Initialize speller parameters with default parms
            parms.num_targets = 40;
            parms.stimulus_duration = 4;
            parms.DEFAULT_PHASE = 0;
            parms.SCREEN_WIDTH = 1920;
            parms.SCREEN_HEIGHT = 1080;
            parms.refresh_rate = 60;
            parms.code_length = parms.refresh_rate * parms.stimulus_duration;
            parms.min_freq = 8.0f;
            parms.freq_resol = 0.2f;
            parms.min_phase = 0.0f;
            parms.phase_resol = 0.5d * Math.PI;
            parms.waveform = "square";
            parms.stim_shape = "rect";
            parms.num_column = Math.Min(parms.num_targets, 10);
            parms.num_row = (int) (parms.num_targets / parms.num_column);
            parms.left_right_margin = 10;
            parms.inter_stimulus_spacing = 20;


            InitializeComponent();
        }
    }
}
