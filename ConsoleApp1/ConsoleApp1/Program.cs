namespace ConsoleApp1
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите операцию");
            String operation = Console.ReadLine();
            switch (operation)
            {
                case "+":
                    Console.WriteLine(a+b);
                    break;
                case "-":
                    Console.WriteLine(a-b);
                    break;
                case "*":
                    Console.WriteLine(a*b);
                    break;
                case "/":
                    Console.WriteLine(a/b);
                    break;
                case "%":
                    Console.WriteLine(a%b);
                    break;

            }
        }
    }
}