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
        #endregion Fields

        //Constructor
        public Speller(Game game, Speller_Parms parms, SpriteBatch spritebatch)
            : base(game)
        {
            //Create a new directX spritebatch
            this.spritebatch = spritebatch;
            this.parms = parms;

            stimDesign = new StimulusDesign(parms);

            // create a single pixel texture (for rendering stimuli)
            pixel = new Texture2D(game.GraphicsDevice, 1, 1, false, SurfaceFormat.Color);
            pixel.SetData(new[] { Color.White });
        }

        // Update Logic 
        public override void Update(GameTime gameTime)
        {

            base.Update(gameTime);
        }

        // Screen Rendering Logic
        int cnt = 0;
        public override void Draw(GameTime gameTime)
        {

            // draw speller stimuli
            if (parms.debug)
            {
                foreach (Rectangle rect in stimDesign.stim.rect)
                {
                    spritebatch.Draw(pixel, rect, Color.White);
                }
            }
            else
            {
                for (int i = 0; i < stimDesign.parms.num_targets; i++)
                {
                    spritebatch.Draw(pixel, stimDesign.stim.rect[i],
                        stimDesign.stim.color[i, cnt]);
                }

                cnt++;
                if (cnt == parms.code_length)
                    cnt = 0;
            }

            base.Draw(gameTime);
        }
    }
}
