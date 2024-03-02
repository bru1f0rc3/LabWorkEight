using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWorkEight
{
    // Вариант 20
    internal class Program 
    {
        static void Main(string[] args)
        {
            int count = 0;
            double[] h = new double[17];

            for (int i = 0; i < h.Length; i++)
            {
                Console.Write($"Введите h[{++count}]=");
                h[i] = double.Parse(Console.ReadLine());
            }

            foreach (double search in h)
            {
                Console.WriteLine($"h[{++count}]={search}");
            }

            //Первый пункт
            double answer = 1.0;
            double first = 0;
            for (int i = 0; i < h.Length; i++)
            {
                if (h[i] < 0)
                {
                    answer *= h[i];
                    first = h[i];
                    break;
                }
            }
            Console.WriteLine($"(Первый пункт) Ответ: {answer}\nПервый встретившийся массив: {first}");

            //Второй пункт
            double[] r = new double[17];

            for(int i = 0; i < r.Length; i++)
            {
                r[i] = 2 * h[i] + 1;
            }

            string result = string.Join(",", r);
            Console.WriteLine($"(Второй пункт) Ответ: {result}");

            //Третий пункт
            double answers = 1;
            for(int i = 0; i < r.Length; i++)
            {
                if (r[i] > 0)
                {
                    if (r[i] % 2 != 0)
                    {
                        answers *= r[i];
                    }
                }
            }
            Console.WriteLine($"(Третий пункт) Ответ: {answers}");
        }
    }
}
