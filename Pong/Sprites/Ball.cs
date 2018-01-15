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
        public Ball()
        {
        }

        public void Load()
        {
            Texture = Global.Load<Texture2D>("Sprites/Ball");
            Reset();
        }

        /// <summary>
        /// Unloads the sprite call once on game closing.
        /// </summary>
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
        }

        /// <summary>
        /// This reset the ball at her starting position.
        /// </summary>
        public void Reset()
        {
            Position = new Vector2(Global.Resolution.X / 2 - Texture.Width / 2, Global.Resolution.Y / 2 - Texture.Height / 2);
            //Add random speed later
            Speed = new Vector2(-0.4f, -0.4f);
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
