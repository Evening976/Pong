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

        protected enum GameState { Starting, Playing, Paused};
        GameState currentGameState = GameState.Starting;


        static Splashscreen splashScreen;

        Controllables.Player Player;
        Incontrollables.AI Ai;
        Sprites.Ball Ball;
        Texture2D Background;

        public static Vector2 Resolution;
        public static bool isFullscreen;
        public static float Sensitivity;


        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);

            ChangeGraphicsSettings();
            Content.RootDirectory = "Content";
            Global.gContent = Content;         
            Global.Scale = new Vector2(Global.Resolution.X / 1920, Global.Resolution.Y / 1080);


            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        /// <param name="gameState">Specifies wich GameState to load</param>
        protected override void Initialize()
        {
            switch (currentGameState)
            {
                //--------------------------------------------------------------------------------------------------//
                case GameState.Starting:
                    this.IsMouseVisible = true;
                    splashScreen = new Splashscreen();
                    splashScreen.Init();
                    base.Initialize();
                    break;
                //--------------------------------------------------------------------------------------------------//
                case GameState.Playing:
                    this.IsMouseVisible = false;
                    Player = new Controllables.Player();
                    Ai = new Incontrollables.AI();
                    Ball = new Sprites.Ball();
                    Global.gFont = Global.LoadFont("Fonts/defaultfont");
                    Handlers.TextRenderer.Init();
                    LoadContent();
                    break;
                //--------------------------------------------------------------------------------------------------//
                case GameState.Paused:
                    this.IsMouseVisible = true;
                    Player = new Controllables.Player();
                    Ai = new Incontrollables.AI();
                    Ball = new Sprites.Ball();
                    Global.gFont = Global.LoadFont("Fonts/defaultfont");
                    Handlers.TextRenderer.Init();
                    LoadContent();
                    break;
            }

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        /// <param name="gameState">Specifies wich GameState to load</param>
        protected override void LoadContent()
        {
            base.LoadContent();
            switch (currentGameState)
            {
                //--------------------------------------------------------------------------------------------------//
                case GameState.Starting:
                    splashScreen.Load();
                    break;
                //--------------------------------------------------------------------------------------------------//
                case GameState.Playing:
                    Background = Global.Load<Texture2D>("Background/Playing");
                    Ball.Load();
                    Player.Load();
                    Ai.Load();
                    break;
                //--------------------------------------------------------------------------------------------------//
                case GameState.Paused:
                    Background = Global.Load<Texture2D>("Background/Playing");
                    Ball.Load();
                    Player.Load();
                    Ai.Load();
                    break;
            }
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {

                  splashScreen.Unload();
            if (Background != null) { Background.Dispose(); }                  
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

            //Manages the game's exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                graphics.IsFullScreen = false;
                graphics.ApplyChanges();
                Exit();
            }

            //Update splashscreen
            if(currentGameState == GameState.Starting)
            {
                splashScreen.Update(gameTime);

                if (splashScreen.Ended)
                {
                    currentGameState = GameState.Paused;
                    Initialize();
                }
            }
            //Update playing state
            else if(currentGameState == GameState.Playing)
            {
                // Manage the Paused/Playing state
                if (Global.gkeyState.IsKeyDown(Keys.Space) && Global.glastKeyState.IsKeyUp(Keys.Space))
                {
                        currentGameState = GameState.Paused;
                }
                // Manage the Paused/Playing state

                //Update all objects
                Ball.Update(gameTime);
                Player.Update(gameTime);
                Ai.Update(gameTime);

                Physics.PhysicsHandler.UpdatePhysics(Ball, Player, Ai);
                Handlers.AIHandler.UpdateAI(Ball, Ai.Racket);
            }
            //Update paused state
            else if(currentGameState == GameState.Paused)
            {
                // Manage the Paused/Playing state
                if (Global.gkeyState.IsKeyDown(Keys.Space) && Global.glastKeyState.IsKeyUp(Keys.Space))
                {
                    currentGameState = GameState.Playing;
                }
                // Manage the Paused/Playing state
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
            //Draw splashscreen
            if (currentGameState == GameState.Starting)
            {
                //Obviously render the Splashscreen lul
                splashScreen.Render(spriteBatch);
            }
            //Draw playing state
            else if(currentGameState == GameState.Playing)
            {
                //Render the game's background
                spriteBatch.Draw(Background,
                Vector2.Zero, null, Color.White, 0, Vector2.Zero, Global.Scale, SpriteEffects.None, Global.PROPSLAYER);
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
            //Draw paused state
            else if (currentGameState == GameState.Paused)
            {
                //Render the paused text
                Handlers.TextRenderer.Render(spriteBatch, "Press SPACE to unpause the game!",
                    new Vector2((Global.Resolution.X / 2) - (Global.gFont.MeasureString("Press SPACE to unpause the game!").X / 2),
                    (Global.Resolution.Y / 2) - Global.gFont.MeasureString("Press SPACE to unpause the game!").Y));
            }


            spriteBatch.End();

            base.Draw(gameTime);
        }

        /// <summary>
        /// This is where all changes to the graphics settings will occur.
        /// </summary>
        private void ChangeGraphicsSettings()
        {
            //All changement to graphics settings should be done here
            Global.Resolution.X = graphics.PreferredBackBufferWidth = (int)Resolution.X;
            Global.Resolution.Y = graphics.PreferredBackBufferHeight = (int)Resolution.Y;
            graphics.IsFullScreen = isFullscreen;
            graphics.SynchronizeWithVerticalRetrace = false;
            graphics.ApplyChanges();
        }
    }
}
