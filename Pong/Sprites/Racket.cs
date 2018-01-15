using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong.Sprites
{
    public class Racket : Sprite
    {
        KeyboardState Input, lastInput;

        public Racket()
        {          
            if(Texture == null) { Load(); }
        }

        private void Load()
        {
            Texture = Global.Load<Texture2D>("Sprites/Racket");
        }

        public void Unload()
        {
            if(Texture != null)Texture.Dispose();
            Texture = null;
        }

        /// <summary>
        /// This is the fonction wich is called to Update sprites every sprites has it.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            Input = Global.gkeyState;
            lastInput = Global.glastKeyState;

            if (Input.IsKeyDown(Keys.Up) && Position.Y > 0)
            {
                Speed.Y = -Global.PlayerSensitivity;
            }
            if (Input.IsKeyDown(Keys.Down) && Position.Y + (Texture.Height * Global.Scale.Y) < Global.Resolution.Y)
            {
                Speed.Y = Global.PlayerSensitivity;
            }
            if(Input.IsKeyUp(Keys.Up) && Input.IsKeyUp(Keys.Down))
            {
                Speed = Vector2.Zero;
            }
        }


        /// <summary>
        /// This is the fonction wich is called to Render a sprite to the screen, every sprites has it.
        /// </summary>
        /// <param name="spriteBatch">Helper class for drawing texts strings and sprites in one or more optimized batches.</param>
        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }
    }
}
