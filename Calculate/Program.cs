using System;

namespace Calculate
{
    class Operation
    {

        public int Result { get; set; }
        public void Add(int x, int y)
        {
            Result = x + y;
        }
        public void Sub(int x, int y)
        {
            Result = x - y;
        }
        public void Mul(int x, int y)
        {
            Result = x * y;
        }
        public void Div(int x, int y)
        {
            if (y == 0)
                Console.WriteLine("На 0 делить нельзя!!");
            else
                Result = x / y;
        }
    }

    class Program
    {   
        static void Main(string[] args)
        {
            Operation op = new Operation();
            int x, y;
            Console.WriteLine("Введите первое число!");
            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Ошибка ввода! Введите целое число");
            }
            Console.WriteLine("Введите второе число!");
            while (!int.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Ошибка ввода! Введите целое число");
            }
            Console.WriteLine("Выберите операцию: '+' '-' '*' '/'");
                string a = Console.ReadLine();
                switch (a)
                {
                    case "+":
                        op.Add(x,y);
                        Console.WriteLine("Ответ: " + op.Result);
                        break;
                    case "-":
                        op.Sub(x, y);
                        Console.WriteLine("Ответ: " + op.Result);
                        break;
                    case "*":
                        op.Mul(x, y);
                        Console.WriteLine("Ответ: " + op.Result);
                        break;
                    case "/":                        
                        op.Div(x, y);
                        Console.WriteLine("Ответ: " + op.Result);
                        break;
                    default:
                        Console.WriteLine("Выбрана ошибочная операция!");
                        break;
                }
            Console.ReadKey();
        }
    }
}
