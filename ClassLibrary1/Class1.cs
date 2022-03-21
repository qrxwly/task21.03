using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class KU
    {
        /// <summary>
        /// Вычисление квадратного корня 
        /// </summary>
        /// <param name="a">коэф1</param>
        /// <param name="b">коэф2</param>
        /// <param name="c">коэф3</param>
        /// <param name="d">дискриминант</param>
        /// <param name="x1">1корень</param>
        /// <param name="x2">2корень</param>
        /// <param name="message">Сообщение</param>
        public static void KvadrUr(
             double a, double b, double c,
             out double d, out double x1, out double x2,
             out string message)
        {
            d = x1 = x2 = double.NaN;

            if (a == 0)
            {
                LinUr(b, c, out x1, out message);
            }
            else
            {
                d = b * b - 4 * a * c;
                if (d > 0)
                {
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    message = "Дискриминант больше нуля, 2 корня.";
                }
                else if (d == 0)
                {
                    x1 = -b / 2 / a;
                    message = "Дискрименант равен нулю, 1 корня.";
                }
                else
                {
                    message = "Дискрименант меньше нуля, нет корней.";
                }
            }

        }
        public static void LinUr(double k, double b,
    out double x, out string message)
        {
            if (k == 0)
            {
                x = double.NaN;
                if (b == 0) message = "Прямая совпадает с осью, ответ R";
                else message = "Нет решений";
            }
            else
            {
                x = -b / k;
                message = null;
            }
        }
    }
}
