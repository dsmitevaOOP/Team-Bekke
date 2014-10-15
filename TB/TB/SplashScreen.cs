using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Graphics.PackedVector;

namespace TB
{

    public class SplashScreen : GameScreen
    {
        Texture2D image;
        public string Path;

        //private float imageAngle = 0;
        //private float imageSpeed = 0.025f;

        //private float distance = 100;

        public override void LoadContent()
       {
           base.LoadContent();
          
           image = content.Load<Texture2D>(Path);
       }
        public override void UnloadContent()
        {
            base.UnloadContent();
        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            // For the logo movement in circle
            //imageAngle += imageSpeed;


            
           
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
           
            // Math Making the Logo go crazy 
            //Vector2 imagePosition = new Vector2(
            //   (float)Math.Cos(imageAngle) * distance,
            //   (float)Math.Sin(imageAngle) * distance);

         
            Vector2 center = new Vector2((512.5f),332.5f );
            
            //spriteBatch.Draw(image, center + imagePosition, Color.White);
            spriteBatch.Draw(image, center, Color.White);

         

        }
    }
}
