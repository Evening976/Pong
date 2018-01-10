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
        public int layerDepth;
        public Texture2D Texture;
        public Vector2 Position;
        public Vector2 Speed;
        private Vector2 SpeedScale
        {
            get { return new Vector2(Global.Resolution.X / 1280, Global.Resolution.Y / 720); } //Need this too because textures were made for 1080p and speeds for 720p
        }

        public Rectangle HitBox
        {
            get { return new Rectangle((int)Position.X, (int)Position.Y, Texture.Width, Texture.Height); }
        }

        public virtual void Update(GameTime gameTime)
        {          
            Position = new Vector2(Position.X + ((Speed.X * SpeedScale.X) * gameTime.ElapsedGameTime.Milliseconds),
                Position.Y + ((Speed.Y * SpeedScale.Y)* gameTime.ElapsedGameTime.Milliseconds));
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture,
                Position, null, Color.White, 0, Vector2.Zero, Global.Scale, SpriteEffects.None, layerDepth);
        }
    }
}
