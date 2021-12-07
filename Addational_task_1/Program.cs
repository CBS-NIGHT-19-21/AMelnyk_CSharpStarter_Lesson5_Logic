using System;
// Известно, что у чисел, которые являются степенью двойки, только один бит имеет значение 1. 
// Используя Visual Studio, создать проект по шаблону Console Application. 
// Написать программу, которая будет выполнять проверку – является ли указанное число степенью 
// двойки или нет.
namespace Addational_task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Oбъявление переменних.
            long operandNumber;
            bool checkForParity;
            {
                // Ивестно что все числа в степени 2 будут положительными, за сиключением 2 в степени 0. 
                // Ввод данных пользователем.     
                Console.WriteLine("Введите произвольное целочисленное число");

                // Инициализация переменных.
                operandNumber = Convert.ToInt64(Console.ReadLine());

                // Для расчета и вывода в консоль результатов используем оператор условного выбора (if-else).
                // Ести введенное чило равно единице то это число является степенью.
                if (operandNumber == 1)
                {
                    Console.WriteLine($"Введеное число является степенью двойки");
                }
                // Если в результате операции получен результат False то чиcло четное.
                else if (checkForParity = Convert.ToBoolean((operandNumber) % 2))
                {
                    Console.WriteLine($"Введеное число не является степенью двойки");
                }
                // Иначе результат True.
                else
                {
                    Console.WriteLine($"Введеное число является степенью двойки");
                }

                Console.ReadKey();
            }
        }
    }
}
