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
        /// <summary>
        /// This is the layer depth of the sprites.
        /// </summary>
        public const int SPRITELAYER = 1;
        /// <summary>
        /// This is is the layer depth of the prop
        /// </summary>
        public const int PROPSLAYER = 0;

        public static ContentManager gContent;
        public static SpriteFont LoadFont(string fontname)
        {
            try
            {
                return gContent.Load<SpriteFont>(fontname);
            }
            catch
            {
                return gContent.Load<SpriteFont>("Fonts/defaultfont");
            }

        }

        /// <summary>
        /// This function is where all Loading should occur.
        /// </summary>
        /// <typeparam name="T">The type of object you want to load.</typeparam>
        /// <param name="filename">The name of the file you want to load.</param>
        /// <returns></returns>
        public static T Load<T>(string filename)
        {
            try
            {
                return gContent.Load<T>(filename);
            }
            catch
            {

                return gContent.Load<T>("DefaultSprite");
            }
        }


        /// <summary>
        /// This is a global Font it has some utility i guess.
        /// </summary>
        public static SpriteFont gFont;

        public static KeyboardState glastKeyState;
        public static KeyboardState gkeyState;

        /// <summary>
        /// When called this function will update our Keyboard Input.
        /// </summary>
        public static void UpdateKeyboard()
        {
            glastKeyState = gkeyState;
            gkeyState = Keyboard.GetState();
        }

        /// <summary>
        /// This is the game's current resolution
        /// </summary>
        public static Vector2 Resolution;
        /// <summary>
        /// This is the game's current scale.
        /// </summary>
        public static Vector2 Scale;

        /// <summary>
        /// The sensitivity the player is using
        /// </summary>
        public static float PlayerSensitivity;
    }
}
