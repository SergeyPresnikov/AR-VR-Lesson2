﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroids
{
    abstract class BaseObject:ICollision
    {
        protected Point Pos;
        protected Point Dir;
        protected Size Size;
        

        public BaseObject(Point pos, Point dir, Size size)
        {
            Pos = pos;
            Dir = dir;
            Size = size;
        }

       
        public Rectangle Rect => new Rectangle(Pos, Size);

        public bool Collision(BaseObject obj)
        {
            return obj.Rect.IntersectsWith(Rect);
        }

        public abstract void Draw();


        public virtual void Update()
        {
            Pos.X = Pos.X + Dir.X;
        }


      






    }
}
