using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong.Incontrollables
{
    public class AI
    {
        public Sprites.Racket Racket;
        public int Score;


        public AI()
        {

        }

        public void Load()
        {
            Racket = new Sprites.Racket();
            Racket.Position = new Vector2
                (Global.Resolution.X - (Racket.Texture.Width * Global.Scale.X),
                (Global.Resolution.Y / 2) - (Racket.Texture.Height * Global.Scale.Y) / 2);
        }

        public void Unload()
        {
            Racket.Unload();
        }

        public void Update(GameTime gameTime)
        {
            Racket.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Racket.Draw(spriteBatch);
        }
    }
}
