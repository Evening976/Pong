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
            //Score = 0;
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
            Input = Global.keyState;
            lastInput = Global.lastKeyState;

            if (Input.IsKeyDown(Keys.Up) && Position.Y > 0)
            {
                Speed.Y = -0.3f;
            }
            if (Input.IsKeyDown(Keys.Down) && Position.Y + (Texture.Height * Global.Scale.Y) < Global.Resolution.Y)
            {
                Speed.Y = 0.3f;
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
