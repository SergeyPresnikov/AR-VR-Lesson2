using Asteroids.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asteroids
{
    static class Game
    {
        private static BufferedGraphicsContext _context;
        public static BufferedGraphics Buffer;
        static BaseObject[] _asteroids;
        static BaseObject[] _stars;
        static BaseObject[] _energy;
        static Bullet _bullet;
        static Ship _ship;
        static Timer _timer;
        static Random _random = new Random();


        public static int Width { get; set; }
        public static int Height { get; set; }
      

        static Game()
        {
        }

        public static void Init(Form form)
        {
            Graphics g;
            g = form.CreateGraphics();

            _context = BufferedGraphicsManager.Current;

            Width = form.ClientSize.Width;
            Height = form.ClientSize.Height;

            Buffer = _context.Allocate(g, new Rectangle(0, 0, Width, Height));

            Load();

            _timer = new Timer { Interval = 60 };
            _timer.Start();
            _timer.Tick += Timer_Tick;
             form.KeyDown += OnKeyDown;


        }
        private static void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
                _bullet = new Bullet(new Point(_ship.Rect.X + 10, _ship.Rect.Y + 10), new Point(15, 0), new Size(54, 9));

            if (e.KeyCode == Keys.Up)
                _ship.Up();
            if (e.KeyCode == Keys.Down)
                _ship.Down();
        }

        private static void Timer_Tick(object sender, EventArgs e)
        {
            Draw();
            Update();
        }

        public static void Draw()
        {
          
            Buffer.Graphics.DrawImage(Resources.background, new Rectangle(0, 0, 800, 600));

            foreach (BaseObject obj in _stars)
            {
                obj.Draw();
            }
            Buffer.Graphics.DrawImage(Resources.planet, new Rectangle(100, 100, 200, 200));

            foreach (var asteroid in _asteroids)
                if (asteroid != null)
                    asteroid.Draw();

            foreach (var energy in _energy)
                if (energy != null && _ship.Energy <= 70)
                    energy.Draw();


            if (_bullet != null)
                _bullet.Draw();

            _ship.Draw();
            

            Buffer.Graphics.DrawString($"Energy: {_ship.Energy}", SystemFonts.DefaultFont, Brushes.White, 0, 0);
            
            Buffer.Render();
        }



        public static void Update()
        {
            for (var i = 0; i < _asteroids.Length; i++)
            {
                if (_asteroids[i] == null) continue;
                _asteroids[i].Update();
                if (_bullet != null && _bullet.Collision(_asteroids[i]))
                {
                    System.Media.SystemSounds.Hand.Play();
                    _asteroids[i] = null;
                    _bullet = null;
                    continue;
                }
                if (_ship.Collision(_asteroids[i]))
                {
                    _asteroids[i] = null;
                    _ship.EnergyLow(_random.Next(15, 30));
                    System.Media.SystemSounds.Asterisk.Play();
                    if (_ship.Energy <= 0)
                        _ship.Die();
                }
            }

            for (var e = 0; e < _energy.Length; e++)
            {
                if (_energy[e] == null) continue;
                _energy[e].Update();
                if (_bullet != null && _bullet.Collision(_energy[e]))
                {
                    
                    System.Media.SystemSounds.Hand.Play();
                    _energy[e] = null;
                    _bullet = null;
                    continue;
                    
                }
                
            }

            foreach (var obj in _stars)
                obj.Update();

            if (_bullet != null)
                _bullet.Update();
        }

        public static void Load()
        {
         
            _ship = new Ship(new Point(10, 400), new Point(5, 5), new Size(50, 30));
            _ship.ShipDieExtended += OnShipDieExtended;


            _random = new Random();
            _asteroids = new Asteroid[15];
            for (int i = 0; i < _asteroids.Length; i++)
            {
                var size = _random.Next(10, 40);
                _asteroids[i] = new Asteroid(new Point(600, i * 20), new Point(-i, -i), new Size(size, size));
            }

            _energy = new KitEnergy[1];
            for (int i = 0; i < _energy.Length; i++)
            {
                var size = _random.Next(1, 3);
                _energy[i] = new KitEnergy(new Point(600, i * 50), new Point(-i, -i), new Size(40, 30));
            }

            _stars = new Star[20];
            for (int i = 0; i < _stars.Length; i++)
                _stars[i] = new Star(new Point(600, i * 40), new Point(-i, -i), new Size(3, 3));
        }

        private static void OnShipDieExtended(object sender, ShipDieEventArgs e)
        {
            _timer.Stop();
            Buffer.Graphics.DrawString("Game Over!", new Font(FontFamily.GenericSansSerif, 60, FontStyle.Underline), Brushes.White, 200, 100);
            Buffer.Graphics.DrawString($"Last damage: {e.LastDamage}", new Font(FontFamily.GenericSansSerif, 40, FontStyle.Underline), Brushes.White, 220, 200);
            Buffer.Render();
        }






    }
}
