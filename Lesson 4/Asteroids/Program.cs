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
        /// Добавить в программу коллекцию астероидов. Как только она заканчивается (все астероиды сбиты), 
        /// формируется новая коллекция, в которой на 1 астероид больше.
        /// Пресников С.А.
        /// </summary>

        static void Main()
        {

            var form = new Form()
            {
                MinimumSize = new System.Drawing.Size(800, 600),
                MaximumSize = new System.Drawing.Size(800, 600),
                MaximizeBox = false,
                MinimizeBox = false,
                StartPosition = FormStartPosition.CenterScreen,
                Text = "Asteroids"
            };

            Game.Init(form);
            form.Show();
            Game.Draw();
            Application.Run(form);


        }
    }
}
