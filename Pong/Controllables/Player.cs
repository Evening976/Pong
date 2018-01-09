using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong.Controllables
{
    public class Player
    {
        Sprites.Racket pRacket;
        public int Score;

        public Texture2D Texture
        {
            get { return pRacket.Texture; }
        }
        public Vector2 Position
        {
            get { return pRacket.Position; }
        }

        public Player()
        {
            
        }

        public void Load()
        {
            pRacket = new Sprites.Racket();
        }

        public void Update(GameTime gameTime)
        {
            pRacket.Update(gameTime);
        }

        public void Unload()
        {
            pRacket.Unload();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            //Draw score here then Racket
            pRacket.Draw(spriteBatch);          
        }
    }
}
