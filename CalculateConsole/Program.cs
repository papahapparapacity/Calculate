using Calculate;

namespace Calculat
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N:");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число K:");
            int k = int.Parse(Console.ReadLine());
            int iterations = 10;
            FunctionCalculator.CalculateFunction(N, k, iterations);
            Console.ReadLine();
        }
    }
}
