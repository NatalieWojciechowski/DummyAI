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
        Vector2 _position;
        EnvironmentType _environmentType;
        Color _color;
        Texture2D _texture;
        const int DIMENSION = 50;
        float _temp;

        private enum EnvironmentType
        {
            TUNDRA,
            GRASSLAND
        }

        public Vector2 Position 
        {
            get { return _position; }
            set { _position = value; }
        }
        public Texture2D Texture
        {
            get { return _texture; }
            set { _texture = value; }
        }
        

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
            Color targetColor;
            if (rand < 0.5f)
            {
                _environmentType = EnvironmentType.TUNDRA;
                targetColor = Color.LightSteelBlue;
                _temp = 12f;
            }
            else if (rand > 0.50f)
            {
                _environmentType = EnvironmentType.GRASSLAND;
                targetColor = Color.LawnGreen;
                _temp = 50f;
            }
            else
            {
                targetColor = Color.Brown;
            }
            
            // TODO: Add your initialization code here0
            _texture = new Texture2D(Game.GraphicsDevice, DIMENSION, DIMENSION);

            Color[] data = new Color[DIMENSION * DIMENSION];
            for (int i = 0; i < data.Length; ++i) data[i] = Color.Lerp(Color.SaddleBrown, targetColor, rand);
            this._texture.SetData(data);

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
