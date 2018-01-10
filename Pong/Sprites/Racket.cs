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
            layerDepth = 1;
            if(Texture == null) { Load(); }
        }

        private void Load()
        {
            Texture = Global.LoadContent<Texture2D>("Racket");
        }

        public void Unload()
        {
            Texture = null;
        }

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

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }
    }
}
