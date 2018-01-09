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
    public class Ball : Sprite
    {
        private bool isStopped = true;

        public Ball()
        {         
            
        }

        public void Load()
        {
            Texture = Global.LoadContent<Texture2D>("Ball");
            Reset();
        }

        public void Unload()
        {
            Texture = null;
        }

        public override void Update(GameTime gameTime)
        {

            base.Update(gameTime);

            //Gère la pause

        }

        public void Reset()
        {
            Position = new Vector2(Global.Resolution.X / 2 - Texture.Width / 2, Global.Resolution.Y / 2 - Texture.Height / 2);
            isStopped = true;
            Speed = new Vector2(-0.4f, -0.4f);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }
    }
}
