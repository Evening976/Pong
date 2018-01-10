using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong.Physics
{
    public static class PhysicsHandler
    {
        private const float HITBOXSCALE = .5f;

        //Collision ::
        //if (this.x + this.texture.Width * this.scale * HITBOXSCALE / 2 < otherSprite.x - otherSprite.texture.Width * otherSprite.scale / 2) return false;

        public static void UpdatePhysics(Sprites.Ball Ball, Controllables.Player Player,Incontrollables.AI AI)
        {
            #region Collision
            if (Player.Position.X + (Player.Texture.Width * Global.Scale.X) >= Ball.Position.X + (Ball.Texture.Width * Global.Scale.X)
                && Player.Position.Y + (Player.Texture.Height * Global.Scale.Y) <= Ball.Position.Y + (Ball.Texture.Height * Global.Scale.Y)
                && Player.Position.Y >= Ball.Position.Y)
            {
                Ball.Speed = -Ball.Speed; 
            }
            else
            {
                
            }
            #endregion
            #region BallHandling

            if (Ball.Position.Y  <= 0)
            {
                Ball.Speed.Y = -Ball.Speed.Y;
                Global.AIScore++;
            }

            if (Ball.Position.Y + Ball.Texture.Height >= Global.Resolution.Y)
            {
                Ball.Speed.Y = -Ball.Speed.Y;
                Global.PlayerScore++;
            }

            if (Ball.Position.X + (Ball.Texture.Width * Global.Scale.X) / 2 < 0)
            {
                Ball.Reset();
                Global.AIScore++;
            }

            if (Ball.Position.X - (Ball.Texture.Width * Global.Scale.X) / 2 > Global.Resolution.X + Ball.Texture.Width)
            {
                Ball.Reset();
                Global.PlayerScore++;
            }

            #endregion
            #region RacketsHandling
            
            #endregion

        }
    }
}
