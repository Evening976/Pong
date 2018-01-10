using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Pong
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Controllables.Player Player;
        Incontrollables.AI Ai;
        Sprites.Ball Ball;
        Texture2D Background;

        public static Vector2 Resolution;
        public static bool isFullscreen;


        bool Pause = true;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            ChangeGraphicsSettings();
            Content.RootDirectory = "Content";
            Global.gContent = Content;         
            Global.Scale = new Vector2(Global.Resolution.X / 1920, Global.Resolution.Y / 1080);
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            Player = new Controllables.Player();
            Ai = new Incontrollables.AI();
            Ball = new Sprites.Ball();
            Global.gFont = Global.LoadFont("defaultfont");
            Handlers.TextRenderer.Init();
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            Background = Global.LoadContent<Texture2D>("Background");
            Ball.Load();
            Player.Load();
            Ai.Load();
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
            Background = null;
            Ball.Unload();
            Player.Unload();
            Ai.Unload();
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            Global.UpdateKeyboard();

            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                graphics.IsFullScreen = false;
                graphics.ApplyChanges();
                Exit();
            }
            if(Global.gkeyState.IsKeyDown(Keys.Space) && Global.glastKeyState.IsKeyUp(Keys.Space))
            {
                if (Pause == true)
                {
                    Pause = false;
                }
                else // (Pause == false)
                {
                    Pause = true;
                }
            }

            if(Pause == false)
            {
                Ball.Update(gameTime);
                Player.Update(gameTime);
                Ai.Update(gameTime);

                Physics.PhysicsHandler.UpdatePhysics(Ball, Player, Ai);
                Handlers.AIHandler.UpdateAI(Ball, Ai.Racket);
            }
            else
            {
                //Draw a pause menu i guess
            }

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            if(Pause == false)
            {
                spriteBatch.Draw(Background,
    Vector2.Zero, null, Color.White, 0, Vector2.Zero, Global.Scale, SpriteEffects.None, 0);
                //Render player's score
                Handlers.TextRenderer.Render(spriteBatch, Player.Score.ToString(),
                    new Vector2((Global.Resolution.X) / 4, (Global.Resolution.Y * 3) / 4)); //Need to add scale to that later.
                //Render Ai's score
                Handlers.TextRenderer.Render(spriteBatch, Ai.Score.ToString(),
                    new Vector2((Global.Resolution.X * 3) / 4, (Global.Resolution.Y * 3) / 4)); //Need to add scale to that too.

                Ball.Draw(spriteBatch);
                Player.Draw(spriteBatch);
                Ai.Draw(spriteBatch);
            }
            else
            {
                Handlers.TextRenderer.Render(spriteBatch, "Press SPACE to unpause the game!",
                    new Vector2((Global.Resolution.X / 2) - (Global.gFont.MeasureString("Press SPACE to unpause the game!").X / 2),
                    (Global.Resolution.Y / 2) - Global.gFont.MeasureString("Press SPACE to unpause the game!").Y));
            }


            spriteBatch.End();

            base.Draw(gameTime);
        }


        private void ChangeGraphicsSettings()
        {
            //All changement to graphics settings should be done here
            Global.Resolution.X = graphics.PreferredBackBufferWidth = (int)Resolution.X;
            Global.Resolution.Y = graphics.PreferredBackBufferHeight = (int)Resolution.Y;
            graphics.IsFullScreen = isFullscreen;
            graphics.ApplyChanges();
        }
    }
}
