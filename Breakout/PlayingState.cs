using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breakout
{
    class PlayingState : GameObjectList
    {
        private SpriteGameObject background = null;
        private Paddle paddle;
        private Ball ball;
        public PlayingState()
        {
            background = new SpriteGameObject("spr_background");
            paddle = new Paddle();
            ball = new Ball(new Vector2(paddle.Position.X, paddle.Position.Y - 50), new Vector2(-150,-140));

            Add(background);
            Add(paddle);
            Add(ball);
        }
        public override void Update(GameTime gameTime)
        {
            if (ball.CollidesWith(paddle))
                velocity.Y = -velocity.Y;
            base.Update(gameTime);
        }
    }
}
