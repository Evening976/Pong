using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong.Handlers
{
    /// <summary>
    /// Creating this because i don't to make a static public ball even tho i should
    /// </summary>
    public static class AIHandler
    {

        public static void UpdateAI(Sprites.Ball Ball, Sprites.Racket AIRacket)
        {
            if(AIRacket.Position.Y + ((AIRacket.Texture.Height / 2) * Global.Scale.Y) < Ball.Position.Y)
            {
                AIRacket.Speed.Y = 0.3f;
            }

            if(AIRacket.Position.Y + ((AIRacket.Texture.Height / 2) * Global.Scale.Y) > Ball.Position.Y)
            {
                AIRacket.Speed.Y = -0.3f;
            }

            if(AIRacket.Position.Y + ((AIRacket.Texture.Height / 2) * Global.Scale.Y) == Ball.Position.Y)
            {
                AIRacket.Speed.Y = 0f;
            }
        }
        
    }
}
