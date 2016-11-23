using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SSVEP_Speller_CSharp
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Game
    {

        #region Fields
        Speller_Parms parms;
        //Game
        GraphicsDeviceManager graphics;
        SpriteBatch spritebatch;

        //Windows Forms
        public System.Windows.Forms.Form form;

        #endregion Fields
        //Constructor
        public Game1(Speller_Parms parms)
        {
            this.parms = parms;   //reference to speller parms
            //directX graphics 
            graphics = new GraphicsDeviceManager(this)
            {
                //Configure DirectX graphics device
                SynchronizeWithVerticalRetrace = true,
                PreferredBackBufferFormat = SurfaceFormat.Color,
                PreferredDepthStencilFormat = DepthFormat.None,
            };
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            IsFixedTimeStep = true;
            TargetElapsedTime = new TimeSpan(10000000L / 60L); //frame rate (30 or 60 Hz only)
            InactiveSleepTime = TimeSpan.Zero;

            //automatically size the window based on screen dimensions
            User32.SetWindowPos((uint)this.Window.Handle, 1, 0, 0, graphics.PreferredBackBufferWidth, graphics.PreferredBackBufferHeight, 0);
        }

        //Initialize
        protected override void Initialize()
        {
            System.Diagnostics.Process.GetCurrentProcess().PriorityClass = System.Diagnostics.ProcessPriorityClass.RealTime;

            //Set the windows forms, and directX graphics buffer to match the screen of the host computer
            int maxHeight = 0; int maxWidth = 0; // vars to choose the max width and height
            GraphicsAdapter g = graphics.GraphicsDevice.Adapter;
            foreach (DisplayMode dm in g.SupportedDisplayModes)
            {
                if (maxHeight < dm.Height)
                {
                    maxHeight = dm.Height;
                }
                if (maxWidth < dm.Width)
                {
                    maxWidth = dm.Width;
                }
            }
            graphics.PreferredBackBufferHeight = maxHeight;
            graphics.PreferredBackBufferWidth = maxWidth;

            //Configure DirectX graphics device
            graphics.GraphicsDevice.DepthStencilState = DepthStencilState.None;
            graphics.PreferMultiSampling = false;  //Set to true to have smooth texture edges
            GraphicsDevice.PresentationParameters.PresentationInterval = PresentInterval.One;
            graphics.ApplyChanges();

            //Merge directX drawing buffer with GDI+ drawing surface
            int[] margins = new int[] { 0, 0, graphics.PreferredBackBufferWidth, graphics.PreferredBackBufferHeight };
            User32.DwmExtendFrameIntoClientArea(Window.Handle, ref margins);
            //xna game form
            form = System.Windows.Forms.Control.FromHandle(Window.Handle).FindForm();
            form.Visible = true;
            //form.AllowTransparency = true;
            //form.BackColor = System.Drawing.Color.Transparent;
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.TransparencyKey = form.BackColor;
            form.TopMost = true;
            form.DesktopLocation = new System.Drawing.Point(0, 0);
            form.ClientSize = new System.Drawing.Size(GraphicsDevice.DisplayMode.Width, GraphicsDevice.DisplayMode.Height);
            
            // TEST DELETE THIS
            System.Windows.Forms.Label label1 = new System.Windows.Forms.Label();
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(39, 44);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "Subject ID";
            label1.BackColor = System.Drawing.Color.LightGray;
            this.form.Controls.Add(label1);

            spritebatch = new SpriteBatch(GraphicsDevice);

            Speller.Speller speller = new Speller.Speller(this,parms, spritebatch, form);
            Components.Add(speller);
            base.Initialize();
        }

        // Update Logic 
        protected override void Update(GameTime gameTime)
        {
           
            base.Update(gameTime);
        }

        // Screen Rendering Logic
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.LightGray);
            spritebatch.Begin();
            
            base.Draw(gameTime);
            spritebatch.End();
        }

        //Memory CleanUp
        protected override void Dispose(bool disposing)
        {
            try
            {
                foreach (GameComponent gc in Components)
                {
                    gc.Dispose();
                }
            }
            catch (Exception) { }
            base.Dispose(disposing);
        }

    }
}
