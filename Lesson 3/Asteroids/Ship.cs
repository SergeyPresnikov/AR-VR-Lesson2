using Asteroids.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroids
{
    class Ship : BaseObject
    {
        private int energy = 100;
        private int lastDamage = 0;
        public event EventHandler ShipDie;
        public event EventHandler<ShipDieEventArgs> ShipDieExtended;



        public int Energy
        {
            get { return energy; }
        }

        public Ship(Point pos, Point dir, Size size) : base(pos, dir, size)
        {
        }

        public void EnergyLow(int damage)
        {
           
            energy -= damage;
            lastDamage = damage;
        }

    

        public override void Draw()
        {
            Game.Buffer.Graphics.DrawImage(new Bitmap(Resources.ship, new Size(Size.Width, Size.Height)), Pos.X, Pos.Y);
        }

        public override void Update() { }

        public void Up()
        {
            if (Pos.Y > 0) Pos.Y = Pos.Y - Dir.Y;
        }

        public void Down()
        {
            if (Pos.Y < Game.Height) Pos.Y = Pos.Y + Dir.Y;
        }

        public void Die()
        {
            if (ShipDie != null)
                ShipDie.Invoke(this, new EventArgs());

            if (ShipDieExtended != null)
                ShipDieExtended.Invoke(this, new ShipDieEventArgs(lastDamage));
        }
    
    }

    class ShipDieEventArgs : EventArgs
    {
        public int LastDamage { get; set; }

        public ShipDieEventArgs(int lastDamage)
        {
            LastDamage = lastDamage;
        }
    }
}

