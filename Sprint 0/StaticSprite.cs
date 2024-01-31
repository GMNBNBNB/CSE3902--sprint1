﻿using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint_0
{
    public class StaticSprite : ISprite
    {
        private Texture2D Character;
        private Vector2 imagePosition;

        public void LoadContent(ContentManager Content, GraphicsDevice graphicsDevice)
        {
            Character = Content.Load<Texture2D>("characters0");
            imagePosition = new Vector2(
           (graphicsDevice.Viewport.Width - Character.Width) / 2,
           (graphicsDevice.Viewport.Height - Character.Height) / 2);
        }
        public void Update(GameTime gameTime)
        {
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Character, imagePosition, Color.White);
        }
    }
}