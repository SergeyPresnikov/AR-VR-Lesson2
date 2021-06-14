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
        static Bullet _bullet;
   


        public static int Width { get; set; }
        public static int Height { get; set; }
        public static object Rand { get; internal set; }

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

            Timer timer = new Timer { Interval = 60 };
            timer.Start();
            timer.Tick += Timer_Tick;


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

            foreach (BaseObject obj in _asteroids)
            {
                obj.Draw();
            }
            _bullet.Draw();
           
            Buffer.Render();
        }

        public static void Update()
        {
            foreach (BaseObject obj in _asteroids)
                obj.Update();
            foreach (BaseObject obj in _stars)
                obj.Update();

            _bullet.Update();
           

            foreach (var asteroid in _asteroids)
            {
                if (asteroid.Collision(_bullet))
                {
                    System.Media.SystemSounds.Hand.Play();

                    _bullet.Recreate();
                }
            }   
        }

        public static void Load()
        {

            _bullet = new Bullet(new Point(0, 200), new Point(5, 0), new Size(54, 9));

            var random = new Random();
            _asteroids = new BaseObject[15];
            for (int i = 0; i < _asteroids.Length; i++)
            {
                var size = random.Next(10, 40);
                _asteroids[i] = new Asteroid(new Point(600, i * 20), new Point(-i, -i), new Size(size, size));
            }

            _stars = new BaseObject[20];
            for (int i = 0; i < _stars.Length; i++)
                _stars[i] = new Star(new Point(600, i * 40), new Point(-i, -i), new Size(3, 3));


        }



        


        
    }
}
