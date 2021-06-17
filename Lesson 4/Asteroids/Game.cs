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
        static List<BaseObject> _asteroids = new List<BaseObject>();
        private static int _countAsteroids = 15;
        static List<BaseObject> _energy = new List<BaseObject>();
        static BaseObject[] _stars;
        static List<Bullet> _bullets = new List<Bullet>();
        private static Ship _ship = new Ship(new Point(10, 400), new Point(5, 5), new Size(50, 30));
        static Random random = new Random();
        private static BufferedGraphicsContext _context;
        public static BufferedGraphics Buffer;
        private static Timer timer;


        public static int Width { get; set; }
        public static int Height { get; set; }


        static Game()
        {
        }

        public static void Init(Form form)
        {
            Graphics g;
            _context = BufferedGraphicsManager.Current;
            g = form.CreateGraphics();
            Width = form.ClientSize.Width;
            Height = form.ClientSize.Height;
            Buffer = _context.Allocate(g, new Rectangle(0, 0, Width, Height));
            Load();

            timer = new Timer { Interval = 100 };
            timer.Start();
            timer.Tick += Timer_Tick;

            form.KeyDown += Form_KeyDown;

            Ship.MessageDie += Finish;


        }
        private static void Finish()
        {
            timer.Stop();
            Buffer.Graphics.DrawString("The End!", new Font(FontFamily.GenericSansSerif, 60, FontStyle.Underline), Brushes.White, 200, 100);
            Buffer.Render();
        }

        private static void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
                if (_bullets.Count < 5)
                    _bullets.Add(new Bullet(new Point(_ship.Rect.X + 10, _ship.Rect.Y + 10), new Point(5, 0), new Size(54, 9)));
            if (e.KeyCode == Keys.Up) _ship.Up();
            if (e.KeyCode == Keys.Down) _ship.Down();
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

            foreach (var bullet in _bullets)
                bullet.Draw();

            if (_ship != null)
                _ship.Draw();

            if (_ship != null)
                Buffer.Graphics.DrawString("Energy:" + _ship.Energy, SystemFonts.DefaultFont, Brushes.White, 0, 0);
            Buffer.Graphics.DrawString("Bullets:" + _bullets.Count, SystemFonts.DefaultFont, Brushes.White, 0, 30);

            Buffer.Render();
        }

        public static void Load()
        {
            var random = new Random();
            for (int i = 0; i < 15; i++)

            {
                var size = random.Next(10, 40);
                _asteroids.Add(new Asteroid(new Point(600, i * 20), new Point(-i, -i), new Size(size, size)));
            }

            for (int i = 0; i < 1; i++)
            {
                var size = random.Next();
                _energy.Add(new KitEnergy(new Point(500, i*40), new Point(-i, -i), new Size(40, 30)));
            }

            _stars = new Star[20];
            for (int i = 0; i < _stars.Length; i++)
                _stars[i] = new Star(new Point(600, i * 40), new Point(-i, -i), new Size(3, 3));
        }

        public static void Update()
        {
            for (var i = _asteroids.Count - 1; i >= 0; i--)
            {
                if (_asteroids[i].Collision(_ship))
                {
                    System.Media.SystemSounds.Asterisk.Play();
                    _ship.EnergyLow(random.Next(10, 15));
                    if (_ship.Energy <= 0)
                        _ship.Die();
                    _asteroids.RemoveAt(i);
                }
                else
                {
                    for (var j = _bullets.Count - 1; j >= 0; j--)
                    {
                        if (_asteroids[i].Collision(_bullets[j]))
                        {
                            System.Media.SystemSounds.Hand.Play();
                            _asteroids.RemoveAt(i);
                            _bullets.RemoveAt(j);
                            break;
                        }
                    }
                }

                if (_asteroids.Count == 0)
                {
                    _countAsteroids++;

                    for (int c = 0; c < _countAsteroids; c++)
                    {
                        _asteroids.Add(new Asteroid(new Point(600, c * 20), new Point(-c, -c), new Size(40, 40)));
                    }
                }
            }

            for (var e = _energy.Count - 1; e >= 0; e--)
            {
                for (var j = _bullets.Count - 1; j >= 0; j--)
                {
                    if (_energy[e].Collision(_bullets[j]))
                    {
                        System.Media.SystemSounds.Hand.Play();
                        _ship.EnergyLow(-30);
                        _energy.RemoveAt(e);
                        _bullets.RemoveAt(j);
                        break;
                    }
                }
            }

            for (var j = _bullets.Count - 1; j >= 0; j--)
            {
                if (_bullets[j].Rect.X > Game.Width)
                {
                    _bullets.RemoveAt(j);
                }
            }

            foreach (var stars in _stars)
                stars.Update();

            foreach (var asteroids in _asteroids)
                asteroids.Update();

            foreach (var bullet in _bullets)
                bullet.Update();

            foreach (var energy in _energy)
                energy.Update();

        }
    }
}
