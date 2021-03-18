using System;
using System.Threading;

namespace ConsoleApp
{
    class Program
    {
        static void Start(object num)
        {
            int n = (int)num;
            if (n <= 0)
                return;
            Thread t = new Thread(Start);
            t.Name = "Thread " + n;
            Console.WriteLine(t.Name);
            t.Start(n - 1);
        }
        private static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Введите количество потоков:");
            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Ошибка! Введите целое число:");
            }
            Start(x);
            Console.ReadKey();
        }
    }
}
