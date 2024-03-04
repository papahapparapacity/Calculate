using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    public static class FunctionCalculator
    {
        public static void CalculateFunction(int N, int k, int iterations)
        {
            try
            {
                for (double x = 0; x <= k; x += 0.1)
                {
                    if (Math.Abs(x - N) < double.Epsilon)
                    {
                        throw new DivideByZeroException("Division by zero exception.");
                    }
                    if (x == double.PositiveInfinity || x == double.NegativeInfinity)
                    {
                        throw new ArgumentOutOfRangeException("Value out of range exception.");
                    }
                    double result = 1 / (x - N);
                    Console.WriteLine($"f({x}) = {result}");
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Calculation finished.");
            }
        }
    }
}
