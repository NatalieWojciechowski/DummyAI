using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


namespace DummyAI
{
    /// <summary>
    /// This is a game component that implements IUpdateable.
    /// </summary>
    public class GameScene : Microsoft.Xna.Framework.GameComponent
    {
        Vector2 _sceneDimensions;
        //List<SceneObject> _sceneObjects;
        SceneObject[,] sObjects;

        public GameScene(Game game, GraphicsDeviceManager graphics)
            : base(game)
        {
            _sceneDimensions = new Vector2(50, 50);
            //_sceneObjects = new List<SceneObject>();
            sObjects = new SceneObject[5,5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    SceneObject obj = new SceneObject(game);
                    obj.Position = new Vector2(j, i) * 55;
                    //_sceneObjects.Add(obj);
                    sObjects[j, i] = obj;
                }                
            }
        }

        /// <summary>
        /// Allows the game component to perform any initialization it needs to before starting
        /// to run.  This is where it can query for any required services and load content.
        /// </summary>
        public override void Initialize()
        {
            // TODO: Add your initialization code here
            Random rand = new Random();
            foreach (SceneObject obj in sObjects)
            {
                obj.Initialize((float)rand.NextDouble());
            }

            checkNeighbors();
            base.Initialize();
        }

        /// <summary>
        /// Allows the game component to update itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Update(GameTime gameTime)
        {
            // TODO: Add your update code here

            base.Update(gameTime);
        }


        public void checkNeighbors() {     
            int count = sObjects.Length;
            int xBounds = 5;
            int yBounds = 5;

            for (int i = 0; i < yBounds; i++)
            {
                for (int j = 0; j < xBounds; j++)
                {
                    if (j > 0 && j < xBounds)
                    {
                        Console.WriteLine(i + " " + j + sObjects[j, i].Position.ToString());                        
                    }
                }
            }
          

        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public void Draw(SpriteBatch spriteBatch, GraphicsDeviceManager graphics)
        {
            Vector2 coor = new Vector2(10, 10);

            foreach (SceneObject obj in sObjects)
            {
                spriteBatch.Draw(obj.Texture, obj.Position, Color.White);
            }

            //for (int x = 0; x < 5; x++)
            //{
            //    for (int y = 0; y < 5; y++)
            //    {
            //        Vector2 offsetCoor = coor + (DIMENSION + 1) * new Vector2(x, y);
            //        spriteBatch.Draw(rect, offsetCoor, Color.White);
            //    }
            //}
        }
    }
}
