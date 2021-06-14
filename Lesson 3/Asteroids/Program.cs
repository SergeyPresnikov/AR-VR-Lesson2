using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asteroids
{
    static class Program
    {
        /// <summary>
        /// 1. Добавить космический корабль, как описано в уроке.
        /// 3. Разработать аптечки, которые добавляют энергию.
        /// Пресников С.А.
        /// </summary>

        static void Main()
        {

            var form = new Form();
            form.MinimumSize = new System.Drawing.Size(800, 600);
            form.MaximumSize = new System.Drawing.Size(800, 600);
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Text = "Asteroids";


            Game.Init(form);
            form.Show();
            Game.Draw();
            Application.Run(form);

           
        }
    }
}
