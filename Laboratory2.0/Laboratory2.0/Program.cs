using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory2._0
{
    class Program
    {/*lnx-7/(2x+6)*/
        static void Main(string[] args)
        {
            const float e = 0.0001f;
            double x0, x1, x2 = 0, fx0, fx2;
            Console.WriteLine("Введите начало и конец числового промежутка");
            x0 = Convert.ToSingle(Console.ReadLine());
            x1 = Convert.ToSingle(Console.ReadLine());
            while (Math.Abs(x1 - x0) > e)
            {
                x2 = (x0 + x1) / 2;
                fx0 =(Math.Log(x0))-(7/(2*x0+6));
                fx2=(Math.Log(x2))-(7/(2*x2+6));
                if (fx0 * fx2 < 0)
                {
                    x1 = x2;
                }
                else
                {
                    x0 = x2;
                }
                Console.WriteLine("Значение корня уравнения на заданном числовом промежутке = {0}",x2);
                Console.Read();
            }
        }
    }
}
