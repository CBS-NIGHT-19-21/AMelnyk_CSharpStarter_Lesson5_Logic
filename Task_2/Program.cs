using System;
// Имеется 3 переменные типа int x = 5, y = 10, и z = 15;
// Выполните и рассчитайте результат следующих операций для этих переменных: 
// x += y >> x++ * z; 
// z = ++x & y * 5; 
// y /= x + 5 | z; 
// z = x++ & y * 5; 
// x = y << x++ ^ z.

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Oбъявление и инициализация переменних.
            int x = 5, y = 10, z = 15;

            {
                x += y >> x++ * z; 
                // Вывод результатов расчетов на экран.
                Console.WriteLine($"Результат вычисленияx выражения х+= y >> x++ * z; равно {x}");
            }
            {
                // Возвращение значений переменным.
                x = 5;
                y = 10;
                z = 15;
                z = ++x & y * 5;
                // Вывод результатов расчетов на экран.
                Console.WriteLine($"Результат вычисленияx выражения z=++x & y * 5; равно {z}");
            }
                // Возвращение значений переменным.
                x = 5;
                y = 10;
                z = 15;
                y /= x + 5 | z;
                // Вывод результатов расчетов на экран.
                Console.WriteLine($"Результат вычисленияx выражения y /= x + 5 | z; равно {y}");
            {
                // Возвращение значений переменным.
                x = 5;
                y = 10;
                z = 15;
                z = x++ & y * 5;
                // Вывод результатов расчетов на экран.
                Console.WriteLine($"Результат вычисленияx выражения z = x++ & y * 5; равно {z}");
                {
                // Возвращение значений переменным.
                x = 5;
                y = 10;
                z = 15;
                x = y << x++ ^ z;
                // Вывод результатов расчетов на экран.
                Console.WriteLine($"Результат вычисленияx выражения x = y << x++ ^ z; равно {x}");
                }

                Console.ReadKey();
            }
        }
    }
}
