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
    public class SceneObject : Microsoft.Xna.Framework.GameComponent
    {
        Vector2 position;
        public Vector2 Position 
        {
            get { return position; }
            set { position = value; }
        }
        Color color;

        Texture2D texture;
        public Texture2D Texture
        {
            get { return texture; }
            set { texture = value; }
        }
        
        const int DIMENSION = 50;

        public SceneObject(Game game)
            : base(game)
        {
            // TODO: Construct any child components here            
        }

        /// <summary>
        /// Allows the game component to perform any initialization it needs to before starting
        /// to run.  This is where it can query for any required services and load content.
        /// </summary>
        public void Initialize(float rand)
        {
            
            // TODO: Add your initialization code here0
            texture = new Texture2D(Game.GraphicsDevice, DIMENSION, DIMENSION);

            Color[] data = new Color[DIMENSION * DIMENSION];
            for (int i = 0; i < data.Length; ++i) data[i] = Color.Lerp(Color.White, Color.Brown, 0.5f * rand);
            this.texture.SetData(data);

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
    }
}
