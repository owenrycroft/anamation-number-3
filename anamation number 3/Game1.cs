using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace anamation_number_3
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;




        Texture2D tribbleGreyTexture;
        Rectangle tribbleGretRect;
        Vector2 tribbleGretspeed;


        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            tribbleGretRect = new Rectangle(300,10,100,100);
            tribbleGretspeed = new Vector2(2, 2);
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            tribbleGreyTexture = Content.Load<Texture2D>("tribbleGrey");
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            tribbleGretRect.X +=(int)tribbleGretspeed.X;
            if (tribbleGretRect.Right>_graphics.PreferredBackBufferHeight||tribbleGretRect.Left<_graphics.PreferredBackBufferHeight)
            {
                tribbleGretspeed.X *= -1;
            }
            tribbleGretRect.Y+=(int)tribbleGretspeed.Y;
            if(tribbleGretRect.Bottom>_graphics.PreferredBackBufferHeight||tribbleGretRect.Top>_graphics.PreferredBackBufferHeight)

            tribbleGretRect.Y+=(int)tribbleGretspeed.Y;
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            _spriteBatch.Draw(tribbleGreyTexture, tribbleGretRect, Color.White);

            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}