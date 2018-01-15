using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    public class Sprite
    {
        public Texture2D Texture;
        public Vector2 Position;
        public Vector2 Speed;

        /// <summary>
        /// This will scale our sprite's moving speed according to the game's resolution.
        /// </summary>
        private Vector2 SpeedScale
        {
            get { return new Vector2(Global.Resolution.X / 1280, Global.Resolution.Y / 720); } //Need this too because textures were made for 1080p and speeds for 720p
        }

        /// <summary>
        /// This will return the hitbox of the sprite *NOT WORKING ATM*
        /// </summary>
        public Rectangle HitBox
        {
            get { return new Rectangle((int)Position.X, (int)Position.Y, Texture.Width, Texture.Height); }
        }

        public Sprite()
        {

        }

        ~Sprite()
        {
            if (Texture != null) Texture.Dispose(); Texture = null;
        }

        /// <summary>
        /// This is the fonction wich is called to Update sprites every sprites has it.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public virtual void Update(GameTime gameTime)
        {          
            Position = new Vector2(Position.X + ((Speed.X * SpeedScale.X) * gameTime.ElapsedGameTime.Milliseconds),
                Position.Y + ((Speed.Y * SpeedScale.Y)* gameTime.ElapsedGameTime.Milliseconds));
        }

        /// <summary>
        /// This is the fonction wich is called to Render a sprite to the screen, every sprites has it.
        /// </summary>
        /// <param name="spriteBatch">Helper class for drawing texts strings and sprites in one or more optimized batches.</param>
        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture,
                Position, null, Color.White, 0, Vector2.Zero, Global.Scale, SpriteEffects.None, Global.SPRITELAYER);
        }
    }
}
