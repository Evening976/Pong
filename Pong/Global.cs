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

        public static KeyboardState lastKeyState;
        public static KeyboardState keyState;
        public static void UpdateKeyboard()
        {
            lastKeyState = keyState;
            keyState = Keyboard.GetState();
        }

        public static Vector2 Resolution;
        public static Vector2 Scale;

        public static int PlayerScore = 0;
        public static int AIScore = 0;
    }
}
