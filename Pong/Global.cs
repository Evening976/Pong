using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    public static class Global
    {
        public static ContentManager gContent;
        public static SpriteFont LoadFont(string fontname)
        {
            try
            {
                return gContent.Load<SpriteFont>(fontname);
            }
            catch
            {
                return gContent.Load<SpriteFont>("defaultfont");
            }

        }
        public static T LoadContent<T>(string filename)
        {
            try
            {
                return gContent.Load<T>(filename);
            }
            catch
            {

                return gContent.Load<T>("Default");
            }
        }

        public static SpriteFont gFont;

        public static KeyboardState glastKeyState;
        public static KeyboardState gkeyState;
        public static void UpdateKeyboard()
        {
            glastKeyState = gkeyState;
            gkeyState = Keyboard.GetState();
        }

        public static Vector2 Resolution;
        public static Vector2 Scale;

        public static float PlayerSensitivity;
    }
}
