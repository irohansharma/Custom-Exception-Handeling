using System;

namespace ExceptionHandeling
{
    class Program
    {
        static void Main(string[] args)
        {
            int attempt = 0;

            while (attempt < 5)
            {
                try
                {
                    Console.WriteLine("Enter a Number from 1 To 5");
                    int option = int.Parse(Console.ReadLine());
                    if (option >= 1 && option <= 5)
                    {
                        PerformOperations.Perform(option);
                        attempt++;
                    }
                    else
                    {
                        throw new CustomException("Input Not in range 1 to 5");
                    }
                }
                catch (CustomException E)
                {
                    Console.WriteLine(E.Message);
                    continue;
                }
                catch (Exception E)
                {
                    Console.WriteLine(E.Message);
                    continue;
                }

            }

            Console.WriteLine("Maximum Attempt Reached...");
        }
    }
}
