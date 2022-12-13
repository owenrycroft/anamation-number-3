using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace anamation_number_3
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;


        Texture2D tribbleBrownTexture;
        Rectangle tribbleBrownRect;
        Vector2 tribbleBrownSpeed;




        Texture2D tribbleCreamTexture;
        Rectangle tribbleCreamRect;
        Vector2 tribbleCreamspeed;


        Texture2D tribbleGreyTexture;
        Rectangle tribbleGretRect;
        Vector2 tribbleGretSpeed;


        Texture2D tribbleOrangeTexture;
        Rectangle tribbleOrangeRect;
        Vector2 tribbleOrangeSpeed;




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
            tribbleGretSpeed = new Vector2(0, 3);



            tribbleBrownRect = new Rectangle(300, 10, 100, 100);
            tribbleBrownSpeed = new Vector2(-3, 3);



            tribbleCreamRect = new Rectangle(300, 10, 100, 100);
            tribbleCreamspeed = new Vector2(3, 3);



            tribbleOrangeRect = new Rectangle(300, 10, 100, 100);
            tribbleOrangeSpeed = new Vector2(3, 0);


            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            tribbleGreyTexture = Content.Load<Texture2D>("tribbleGrey");
            tribbleCreamTexture = Content.Load<Texture2D>("tribbleCream");
            tribbleOrangeTexture = Content.Load<Texture2D>("tribbleOrange");
            tribbleBrownTexture = Content.Load<Texture2D>("tribbleBrown");
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            



            tribbleCreamRect.X += (int)tribbleCreamspeed.X;
            if (tribbleCreamRect.Right > _graphics.PreferredBackBufferWidth || tribbleCreamRect.Left < 0)
            {
                tribbleCreamspeed.X *= -1;
            }
            tribbleCreamRect.Y += (int)tribbleCreamspeed.Y;
            if (tribbleCreamRect.Bottom > _graphics.PreferredBackBufferHeight || tribbleCreamRect.Top < 0)
            {
                tribbleCreamspeed.Y *= -1;
            }






           




            tribbleGretRect.X +=(int)tribbleGretSpeed.X;
            if (tribbleGretRect.Right > _graphics.PreferredBackBufferWidth || tribbleGretRect.Left <0)
            {
                tribbleGretSpeed.X *= -1;
            }
            tribbleGretRect.Y+=(int)tribbleGretSpeed.Y;
            if (tribbleGretRect.Bottom > _graphics.PreferredBackBufferHeight || tribbleGretRect.Top < 0)
            {
                tribbleGretSpeed.Y*= -1;
            }



            tribbleBrownRect.X += (int)tribbleBrownSpeed.X;
            if (tribbleBrownRect.Right > _graphics.PreferredBackBufferWidth || tribbleBrownRect.Left < 0)
            {
                tribbleBrownSpeed.X *= -1;
            }

            tribbleBrownRect.Y += (int)tribbleBrownSpeed.Y;
            if (tribbleBrownRect.Bottom > _graphics.PreferredBackBufferHeight || tribbleBrownRect.Top < 0)
            {
                tribbleBrownSpeed.Y*= -1;
            }



            tribbleOrangeRect.X += (int)tribbleOrangeSpeed.X;
            if (tribbleOrangeRect.Right > _graphics.PreferredBackBufferWidth || tribbleOrangeRect.Left < 0)
            {
                tribbleOrangeSpeed.X *= -1;
            }
            tribbleOrangeRect.Y += (int)tribbleOrangeSpeed.Y;
            if (tribbleOrangeRect.Bottom > _graphics.PreferredBackBufferHeight || tribbleOrangeRect.Top < 0)
            {
                tribbleOrangeSpeed.Y *= -1;
            }





            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            _spriteBatch.Draw(tribbleGreyTexture, tribbleGretRect, Color.White);
            _spriteBatch.Draw(tribbleOrangeTexture, tribbleOrangeRect, Color.White);
            _spriteBatch.Draw(tribbleCreamTexture, tribbleCreamRect, Color.White);
            _spriteBatch.Draw(tribbleBrownTexture, tribbleBrownRect, Color.White);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}