using Asteroids.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroids
{
    class Star : Asteroid
    {
       
        public Star (Point pos, Point dir, Size size) : base(pos, dir, size)
        {
          
        }

        public override void Draw()
        {

            Game.Buffer.Graphics.DrawImage(Resources.star2, Pos.X + Size.Height, Pos.Y + Size.Width);

            Game.Buffer.Graphics.DrawImage(Resources.star1, Pos.Y + Size.Width, Pos.X + Size.Height);
        }

        public override void Update()
        {
            Pos.X = Pos.X + Dir.X;
            Pos.Y = Pos.Y + Dir.Y;

            if (Pos.X < 0) Dir.X = -Dir.X;
            if (Pos.X > Game.Width) Dir.X = -Dir.X;

            if (Pos.Y < 0) Dir.Y = -Dir.Y;
            if (Pos.Y > Game.Height) Dir.Y = -Dir.Y;
        }
    }
}
