using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Color_Switch.Core
{
    class MenuScreen : Microsoft.Xna.Framework.Game

    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        //KeyboardState ks;
        Color col;

        public const int menu = 0, play = 1, gameover = 2, score = 3;
        public bool choice = false;
       // public int CurrentScreen = menu;
        public Texture2D scoresgame, playgame;
        //public Button playButton, scoreButton;
        public float screenwidth, screenheight;
        public Texture2D bgimage;
        private SpriteFont font;
        public MenuScreen()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            this.IsMouseVisible = true;
            choice = false;
            //bgimage= Content.Load<Texture2D>("bgColor");
            //playgame = Content.Load<Texture2D>("play");
          //  playButton = new Button();
           // scoreButton = new Button();
        }
       /*
        public int Choice
        {
            get { return false; }
            set { choice = true; }
        }
        */

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            col = Color.White;
            //screenheight = graphics.GraphicsDevice.Viewport.Height;
           // screenwidth = graphics.GraphicsDevice.Viewport.Width;
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
      /*  protected override void LoadContent()
        {
           
            spriteBatch = new SpriteBatch(GraphicsDevice);

          
            scoresgame = Content.Load<Texture2D>("scores");
          
            playgame = Content.Load<Texture2D>("play");
            bgimage = Content.Load<Texture2D>("bgColor");

            scoreButton = new Button(new Rectangle(300, 300, scoresgame.Width, scoresgame.Height), true);
            scoreButton.load(Content, "scores");


            playButton = new Button(new Rectangle(300, 100, playgame.Width, playgame.Height), true);
            playButton.load(Content, "play");

            font = Content.Load<SpriteFont>("choice");
            //Things we want to load in the GAME screen.

            //Things we want to load in the GAME OVER screen.

        } 
*/
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        /*
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();
            //Checking the state of our mouse.
            mouseState = Mouse.GetState();
            ks = Keyboard.GetState();
           

            switch (CurrentScreen)
            {
                case menu:
                    //pour aller dans le jeux
                    if (playButton.update(new Vector2(mouseState.X, mouseState.Y)) == true && mouseState != previousMouseState && mouseState.LeftButton == ButtonState.Pressed)
                    {
                        ChangeParty();
                        CurrentScreen = play;

                    }

                    //pour aller dans les scores
                    if (scoreButton.update(new Vector2(mouseState.X, mouseState.Y)) == true && mouseState != previousMouseState && mouseState.LeftButton == ButtonState.Pressed)
                    {
                        CurrentScreen = score;
                    }

                    break;

                case score:
                    if (ks.IsKeyDown(Keys.A))
                    {
                        CurrentScreen = menu;
                    }
                    break;

                case play:
                    //What we want to happen when we play our GAME goes in here.
                    if (ks.IsKeyDown(Keys.A))
                    {
                        ChangeParty();
                        CurrentScreen = menu;
                     
                    }
                    break;

            }
            previousMouseState = mouseState;
            base.Update(gameTime);
        }
        */
           void ChangeParty()
        {
            if(choice ==false)
             choice = true;
            
        }

         /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            base.Draw(gameTime);
            /*
            switch (CurrentScreen)
            {
               case menu:
                    DrawMenu(gameTime);
                   spriteBatch.DrawString(font, "choice"+choice, new Vector2(100, 100), Color.Black);
                    break;
                case play:
                    DrawGamePlay(gameTime);
                    spriteBatch.DrawString(font, "choice"+choice, new Vector2(100, 100), Color.Black);
                    break;
           
            }
          */
             spriteBatch.End();
            
        }
      /*  public void DrawMenu(GameTime gameTime)
        {
            spriteBatch.Draw(bgimage, new Rectangle(0, 0, bgimage.Width, bgimage.Height), Color.White);
            spriteBatch.Draw(playgame, new Rectangle(300, 100, playgame.Width, playgame.Height), Color.White);
            spriteBatch.Draw(scoresgame, new Rectangle(300, 200, scoresgame.Width, scoresgame.Height), Color.White);
            //ChangeParty();
        }
        */
        public void DrawGamePlay(GameTime gametime)
        {
            //ChangeParty();

           /// spriteBatch.DrawString(font, "choice"+choice, new Vector2(100, 100), Color.Black);
            /*
            spriteBatch.Draw(playgame, new Rectangle(300, 100, playgame.Width, playgame.Height), Color.White);
            spriteBatch.Draw(playgame, new Rectangle(300, 200, playgame.Width, playgame.Height), Color.White);
            spriteBatch.Draw(playgame, new Rectangle(300, 300, playgame.Width, playgame.Height), Color.White);
            */
        }
    }
}
