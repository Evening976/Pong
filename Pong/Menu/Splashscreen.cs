using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    /// <summary>
    /// Draw a thing on the screen before starting the game and maybe add a main menu omagad
    /// </summary>
    class Splashscreen
    {
        private Texture2D SplashScreen;
        private float Opacity;
        private bool OpIncreasing = true;
        public bool Ended = false;

        public void Init()
        {      
            Opacity = 0;        
        }

        public void Load()
        {
            SplashScreen = Global.Load<Texture2D>("Background/SplashScreen");
        }

        public void Unload()
        {

           if(SplashScreen != null) SplashScreen.Dispose();
            SplashScreen = null;
        }


        /// <summary>
        /// This is where all Updates to our Splashscreen occur.
        /// </summary>
        /// <param name="gameTime"></param>
        public void Update(GameTime gameTime)
        {
            if(Opacity >= 255)
            {
                OpIncreasing = false;
            }

            if(OpIncreasing)
            {
                Opacity++;
            }
            else
            {
                Opacity--;
            }

            if(OpIncreasing == false && Opacity==0)
            {
                Ended = true;
            }
        }

        /// <summary>
        /// This function draws our splashscreen to the screen when needed.
        /// </summary>
        /// <param name="spriteBatch"></param>
        public void Render(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(SplashScreen, Vector2.Zero, null, Color.White * (Opacity / 255), 0,
                Vector2.Zero, Global.Scale, SpriteEffects.None, 1);
        }
    }
}
