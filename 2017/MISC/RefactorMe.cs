using System;
using System.Diagnostics;
using System.Drawing;

namespace RefactorMe
{
    // ## Прочитайте! ##
    //
    // Ваша задача привести код в этом файле в порядок. 
    // Для начала запустите эту программу.
    // Переименуйте всё, что называется неправильно. Это можно делать комбинацией клавиш Ctrl+R, Ctrl+R (дважды нажать Ctrl+R).
    // Повторяющиеся части кода вынесите во вспомогательные методы. Это можно сделать выделив несколько строк кода и нажав Ctrl+R, Ctrl+M
    // Избавьтесь от всех зашитых в коде числовых констант — положите их в переменные с понятными именами.
    // 
    // После наведения порядка проверьте, что ваш код стал лучше. 
    // На сколько проще после ваших переделок стало изменить размер фигуры? Повернуть её на некоторый угол? 
    // Научиться рисовать невозможный треугольник, вместо квадрата?

    class ImageCreator
    {
        static Bitmap image = new Bitmap(800, 600);
        static float x, y;
        static Graphics graphics;

        public static void Initialize()
        {
            image = new Bitmap(800, 600);
            graphics = Graphics.FromImage(image);
        }

        public static void SetPos(float x0, float y0)
        {
            x = x0;
            y = y0;
        }

        public static void Go(double step, double angle)
        {
            //Делает шаг длиной L в направлении angle и рисует пройденную траекторию
            var x1 = (float)(x + step * Math.Cos(angle));
            var y1 = (float)(y + step * Math.Sin(angle));
            graphics.DrawLine(Pens.Yellow, x, y, x1, y1);
            x = x1;
            y = y1;
        }

        public static void Draw(float x, float y, double z)
        {
            ImageCreator.SetPos(x, y);
            ImageCreator.Go(100, z);
            ImageCreator.Go(10 * Math.Sqrt(2), z + Math.PI / 4);
            ImageCreator.Go(100, z + Math.PI);
            ImageCreator.Go(100 - (double)10, z + Math.PI / 2);
        }

        public static void ShowResult()
        {
            image.Save("result.bmp");
            Process.Start("result.bmp");
        }
    }

    public class Square
    {
        public static void Main()
        {
            ImageCreator.Initialize();

            ImageCreator.Draw(10, 0, 0);
            ImageCreator.Draw(120, 10, Math.PI / 2);
            ImageCreator.Draw(110, 120, Math.PI);
            ImageCreator.Draw(0, 110, -Math.PI/2);

            ImageCreator.ShowResult();
        }
    }
}