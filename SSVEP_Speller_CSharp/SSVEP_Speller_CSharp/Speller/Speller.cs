using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SSVEP_Speller_CSharp.Speller
{
    class Speller : DrawableGameComponent
    {
        #region Fields
        Speller_Parms parms;
        SpriteBatch spritebatch;
        Texture2D pixel;
        StimulusDesign stimDesign;
        SpriteFont font;
        System.Windows.Forms.Form form;
        #endregion Fields

        //Constructor
        public Speller(Game game, Speller_Parms parms, SpriteBatch spritebatch, System.Windows.Forms.Form form)
            : base(game)
        {
            //Create a new directX spritebatch
            this.spritebatch = spritebatch;
            this.parms = parms;
            this.form = form; 

            // load spritefont from content pipeline
            font = game.Content.Load<SpriteFont>("TextFont");
            
            // generate stimulus design object
            stimDesign = new StimulusDesign(parms, font);

            // create a single pixel texture (for rendering stimuli)
            pixel = new Texture2D(game.GraphicsDevice, 1, 1, false, SurfaceFormat.Color);
            pixel.SetData(new[] { Color.White });

            // Add UI elements to speller
            addUIelements();
            
        }

        // Add windows forms UI elements to the speller screen
        protected void addUIelements()
        {
            // add exit button
            form.Controls.Add(stimDesign.Exit_btn);

            // add subject info
            form.Controls.Add(stimDesign.SubID_text);
            form.Controls.Add(stimDesign.SessionID_text);
            form.Controls.Add(stimDesign.Instruction_text);
            form.Controls.Add(stimDesign.Feedback_text);
        }

        // Update Logic 
        public override void Update(GameTime gameTime)
        {
            // put paradigm here?
            base.Update(gameTime);
        }

        // Screen Rendering Logic
        int cnt = 0;
        public override void Draw(GameTime gameTime)
        {

            // draw speller stimuli
            if (parms.debug) // for debuggin only
            {
                for (int i = 0; i < parms.num_targets; i++)
                {
                    spritebatch.Draw(pixel, stimDesign.stim.rect[i], Color.Black);
                    spritebatch.DrawString(font, stimDesign.stim.text[i], stimDesign.stim.text_loc[i],
                        Color.White, 0, Vector2.Zero, 1.0f, SpriteEffects.None, 1.0f);
                }
            }
            else
            {
                for (int i = 0; i < parms.num_targets; i++)
                {
                    spritebatch.Draw(pixel, stimDesign.stim.rect[i],
                        stimDesign.stim.color[i, cnt]);
                    spritebatch.DrawString(font, stimDesign.stim.text[i], stimDesign.stim.text_loc[i],
                        Color.Black);
                }

                cnt++;
                if (cnt == parms.code_length)
                    cnt = 0;
            }

            base.Draw(gameTime);
        }
    }
}
