using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroids
{
    class Bullet : BaseObject
    {
        

        public Bullet(Point pos, Point dir, Size size) : base(pos, dir, size)
        {


        }

        public override void Draw()
        {
            Game.Buffer.Graphics.DrawImage(new Bitmap(Properties.Resources.laserRed011, new Size(Size.Width, Size.Height)), Pos.X, Pos.Y);

        }

        public override void Update()
        {

            Pos.X = Pos.X + Dir.X;

        }

        public void Recreate()
        {
            Pos.X = 0;
            Pos.Y = Convert.ToInt32(myRandom.RandomDoubleNumber() * (Game.Height - Size.Height));
        }


    }
}
