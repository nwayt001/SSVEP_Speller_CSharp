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
            parms.feedback = "Feedback (online)";
            parms.classifier = "CCA";
            parms.twitter_account = "Columbia";
            parms.subject_id = "NRW";
            parms.group_num = "1";
            parms.run_num = "1";
            parms.session_num = "1";
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
            parms.debug = false;
            parms.alphanumeric = new string[] {
            "1","2","3","4","5","6","7","8","9","0",
            "Q","W","E","R","T","Y","U","I","O","P",
            "A","S","D","F","G","H","J","K","L","L","?",
            "Z","X","C","V","B","N","M","!",".","<"};
            parms.alphabet = new string[] {
            "Q","W","E","R","T","Y","U","I","O","P",
            "A","S","D","F","G","H","J","K","L","_",
            "Z","X","C","V","B","N","M","!",".","<","!","_"};

            // Initialize the gui components
            InitializeComponent();

            // Initialize default configuration
            InitializeDefaultConfig();

        }

        protected void InitializeDefaultConfig()
        {
            subject_id.Text = parms.subject_id;
            group_num.Text = parms.group_num;
            run_num.Text = parms.run_num;
            session_num.Text = parms.session_num;
            num_targets.Text = parms.num_targets.ToString();
            speller_mode.SelectedText = parms.speller_mode;
            target_text.Text = parms.target_text;
            feedback.SelectedText = parms.feedback;
            classifier.SelectedText = parms.classifier;
            twitter_account.SelectedText = parms.twitter_account;
            stimulus_duration.Text = parms.stimulus_duration.ToString();
            min_freq.Text = parms.min_freq.ToString();
            freq_resol.Text = parms.freq_resol.ToString();
            refresh_rate.Text = parms.refresh_rate.ToString();
            SCREEN_WIDTH.Text = parms.SCREEN_WIDTH.ToString();
            SCREEN_HEIGHT.Text = parms.SCREEN_HEIGHT.ToString();   
        }

        
        // Update parameters and start speller
        private void StartBtn_Click(object sender, EventArgs e)
        {
            int throwaway;
            double throwaway2;

            // save subject info
            parms.subject_id = subject_id.Text;
            parms.group_num = group_num.Text;
            parms.session_num = session_num.Text;
            parms.run_num = run_num.Text;
            
            // save speller config
            parms.speller_mode = speller_mode.SelectedText;
            parms.target_text = target_text.Text;
            parms.feedback = feedback.SelectedText;
            parms.classifier = classifier.SelectedText;
            parms.twitter_account = twitter_account.SelectedText;
            if(int.TryParse(num_targets.Text,out throwaway))
                parms.num_targets = int.Parse(num_targets.Text);
            if (int.TryParse(stimulus_duration.Text, out throwaway))
                parms.stimulus_duration = int.Parse(stimulus_duration.Text);
            if (double.TryParse(min_freq.Text, out throwaway2))
                parms.min_freq = double.Parse(min_freq.Text);
            if (double.TryParse(freq_resol.Text, out throwaway2))
                parms.freq_resol = double.Parse(freq_resol.Text);
            if (int.TryParse(refresh_rate.Text, out throwaway))
                parms.refresh_rate = int.Parse(refresh_rate.Text);
            if (int.TryParse(SCREEN_WIDTH.Text, out throwaway))
                parms.SCREEN_WIDTH = int.Parse(SCREEN_WIDTH.Text);
            if (int.TryParse(SCREEN_HEIGHT.Text, out throwaway))
                parms.SCREEN_HEIGHT = int.Parse(SCREEN_HEIGHT.Text);

            // parms are saved, close window to start speller
            this.Close();
        }

        private void ConfigUI_Load(object sender, EventArgs e)
        {
            
        }

        
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
