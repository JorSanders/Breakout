using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breakout
{
    class Paddle : SpriteGameObject
    {
        public Paddle()
            : base("spr_paddle")
        {
            position.X = 400 - this.Width/2;
            position.Y = 550;
            

        }
        public override void HandleInput(InputHelper inputHelper)
        {

            position.X = inputHelper.MousePosition.X;
            base.HandleInput(inputHelper);
        }
        public override void Update(GameTime gameTime)
        {
            position.X = MathHelper.Clamp(position.X, 0, Breakout.Screen.X - this.Width);
            base.Update(gameTime);
        }
        
    }
}
