using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace SSVEP_Speller_CSharp.Speller
{
    
    class StimulusDesign
    {
        #region Fields
        public Speller_Parms parms;
        public Stim_Design_Matrix stim = new Stim_Design_Matrix();
        public SpriteFont font;
        #endregion Fields
        
        
        // Constructor
        public StimulusDesign(Speller_Parms parms, SpriteFont font)
        {
            this.parms = parms;
            this.font = font;
            // Generate stimulus design based on specified speller parms
            GenStimulusDesign();
        }

        // Generate Stimulus Design
        protected void GenStimulusDesign()
        {
            // Set stimulus frequency and phase locations in the stimulus grid
            stim.phase = new double[parms.num_targets];
            stim.freq = new double[parms.num_targets];

            for (int r=0; r<parms.num_row; r++)
            {
                for (int c=0; c<parms.num_column; c++)
                {
                    stim.freq[(parms.num_column * (r)) + c] = parms.min_freq + parms.freq_resol * (parms.num_column * r + c);
                    stim.phase[(parms.num_column * (r)) + c] = wrapto2pi(parms.min_phase + parms.phase_resol * (parms.num_column * r + c));
                }
            }

            // set additional design parms
            stim.vBlocksize = parms.SCREEN_WIDTH / 10;
            stim.hBlocksize = parms.SCREEN_WIDTH / 10;
            stim.blocksize = Math.Min(stim.vBlocksize, stim.hBlocksize);
            
            // generate flicker codes
            stim.flicker_code = new int[parms.num_targets, parms.code_length];
            stim.color = new Color[parms.num_targets, parms.code_length];
            double tmp;
            for (int c = 0; c < parms.num_targets; c++)
            {
                for (int i = 0; i < parms.code_length; i++)
                {
                    tmp= Math.Sin(2 * Math.PI * stim.freq[c] * ((double)i / (double)parms.refresh_rate) + stim.phase[0]);
                    if (tmp >= 0.0)
                    {
                        stim.flicker_code[c, i] = 1;
                        stim.color[c, i] = Color.White;
                    }
                    else
                    {
                        stim.flicker_code[c, i] = 0;
                        stim.color[c, i] = Color.Black;
                    }
                }
            }

            // generate stimuli locations
            stim.rect = new Rectangle[parms.num_targets];
            if (parms.num_column % 2 == 0)
            {
                for (int row = 0; row < parms.num_row; row++)
                {
                    for (int col = 0; col < parms.num_column; col++)
                    {
                        stim.rect[parms.num_column * row + col] = new Rectangle
                            (stim.hBlocksize*col+parms.left_right_margin, stim.vBlocksize*row + stim.vBlocksize+80,
                            stim.hBlocksize-parms.inter_stimulus_spacing, stim.vBlocksize-parms.inter_stimulus_spacing);
                    }
                }
            }


            // Define stimulus text properties (based on number of targets)
            stim.text = new string[parms.num_targets];
            stim.text_offset = new Vector2[parms.num_targets];
            stim.text_loc = new Vector2[parms.num_targets];
            for (int i = 0; i < parms.num_targets; i++)
            {
                stim.text[i] = parms.alphanumeric[i];
                stim.text_offset[i] = font.MeasureString(stim.text[i]);
                stim.text_loc[i].X = stim.rect[i].Center.X - (stim.text_offset[i].X / 2.0f);
                stim.text_loc[i].Y = stim.rect[i].Center.Y - (stim.text_offset[i].Y / 2.0f);
            }
            
            // add in the stimulus design matrix
            parms.stim_design_matrix = stim;
        }

        // wrap radians to 2*pi
        protected double wrapto2pi(double lambda)
        {
            bool ispositive = false;
            if (lambda > 0)
                ispositive = true;
            lambda = lambda % (2 * Math.PI);

            if (lambda == 0 & ispositive)
                lambda = 2 * Math.PI;

            return lambda;
        }

    }
}
