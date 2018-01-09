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
        public Sprites.Racket AIRacket;
        public int Score;


        public AI()
        {

        }

        public void Load()
        {
            AIRacket = new Sprites.Racket();
        }

        public void Unload()
        {
            AIRacket.Unload();
        }

        public void Update(GameTime gameTime)
        {
            AIRacket.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            AIRacket.Draw(spriteBatch);
        }
    }
}
