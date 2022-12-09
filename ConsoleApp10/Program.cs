using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main()
        {
            TestingAsyncAwait();
            Console.ReadLine();
         //asdasdqq

        }       

        async static void TestingAsyncAwait()
        {
            Console.WriteLine("Loading..");
            int counter = 0;
            while (counter <= 100)
            {
                if (counter % 2 != 0)
                {
                    Console.Write('|');
                }
                else if (counter % 10 == 0)
                    Console.Write($"{counter}%");

                //Thread.Sleep(20);
                await Task.Delay(20);
                counter++;
            }
            Console.WriteLine();
        }

        static void ObjectsParamsMethod(params object[] items)
        {
            double result = 0;

            foreach (var paramsItem in items)
            {
                try
                {
                    result += Convert.ToDouble(paramsItem);
                }
                catch (Exception error)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(error);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(result);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static double SecondParamsMethod(params string[] str)
            => Math.Sqrt(Math.Pow(Convert.ToDouble(str[0]), 2) + Math.Pow(Convert.ToDouble(str[1]), 2) + Math.Pow(Convert.ToDouble(str[2]), 2));

        static double FirstParamsMethod(params double[] a)
        {
            double result = 0;
            for (int i = 0; i < a.Length; i++)
                result += Math.Pow(a[i], 2);

            return Math.Sqrt(result);
        }

        static double TestDoubleMethod(double a, double b, double c) => Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2));
    }
}