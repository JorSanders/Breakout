using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breakout
{
    class Ball : SpriteGameObject
    {
        
        public Ball(Vector2 startPosition, Vector2 velocity)
            : base("spr_ball")
        {
           position = startPosition;
           this.velocity = velocity;
        }

        public override void Update(GameTime gameTime)
        {
            if (position.X < 0 || position.X > Breakout.Screen.X - this.Width)
                velocity.X = -velocity.X;

            if (position.Y < 0)
                velocity.Y = -velocity.Y;
            base.Update(gameTime);
        }
    }
}
