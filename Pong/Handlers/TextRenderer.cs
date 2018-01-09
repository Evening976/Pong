using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong.Handlers
{
    public static class TextRenderer
    {
        private static SpriteFont font;

        public static void Init()
        {
            font = Global.LoadFont("defaultfont");
        }

        public static void Render(SpriteBatch spriteBatch, string Text, Vector2 Position)
        {
            spriteBatch.DrawString(font, Text, Position, Color.White);
        }

    }
}
