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


        /// <summary>
        /// This function draws our text to the screen when called.
        /// </summary>
        /// <param name="spriteBatch">Helper class for drawing texts strings and sprites in one or more optimized batches.</param>
        /// <param name="Text">The text wich is going to be drawn.</param>
        /// <param name="Position">The position where the text will be drawn.</param>
        public static void Render(SpriteBatch spriteBatch, string Text, Vector2 Position)
        {
            spriteBatch.DrawString(font, Text, Position, Color.White);
        }

    }
}
