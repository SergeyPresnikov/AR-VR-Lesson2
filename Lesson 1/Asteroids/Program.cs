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
        /// 1. Добавить свои объекты в иерархию объектов, чтобы получился красивый задний фон,
        /// похожий на полёт в звёздном пространстве.
        ///2. *Заменить кружочки картинками, используя метод DrawImage.
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
