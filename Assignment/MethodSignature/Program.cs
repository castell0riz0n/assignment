using System;
using System.Threading.Tasks;

namespace MethodSignature
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var (averageSalary, numberOfEmployee) = await SomeCalculation(0L, 10, 0L == 10L);
            Console.WriteLine($"{averageSalary}, {numberOfEmployee}");

            Console.WriteLine("Return Type is: Modern Tuple");
            Console.ReadLine();
        }

        public static async Task<(float averageSalary, int numberOfEmployee)> SomeCalculation(float salary, int number, bool biggerThan)
        {
            if (biggerThan)
            {
                return await Task.Run(() => SomeOtherPrivateCalculation(salary, number + 2));
            }
            else
            {
                return await Task.Run(() => SomeOtherPrivateCalculation(salary, number - 3));
            }
        }

        private static (float averageSalary, int numberOfEmployee) SomeOtherPrivateCalculation(float salary, int number)
        {
            return ((salary * number) / 2, number);
        }
    }
}