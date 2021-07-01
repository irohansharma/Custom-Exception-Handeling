using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandeling
{
   public class PerformOperations
    {

        public static void Perform(int task)
        {
            /* 1)	Enter even number
            2)	Enter odd number
            3)	Enter a prime number
            4)	Enter a negative number
            5)	Enter zero*/
            try
            {
                if (task == 1)
                {
                    Console.WriteLine("Enter Even Number");
                    int userInput = int.Parse(Console.ReadLine());
                    if (userInput % 2 != 0)
                    {
                        throw new CustomException("Input is not Even");
                    }
                    else
                    {
                        Console.WriteLine("Success!");
                    }


                }

                else if (task == 2)
                {
                    Console.WriteLine("Enter ODD Number");
                    int userInput = int.Parse(Console.ReadLine());
                    if (userInput % 2 != 1)
                    {
                        throw new CustomException("Input is not ODD");
                    }
                    else
                    {
                        Console.WriteLine("Success!");
                    }
                }
                else if (task == 3)
                {
                    Console.WriteLine("Enter a Prime Number");
                    int userInput = int.Parse(Console.ReadLine());
                    bool isPrime = true;
                    for (int i = 2; i * i <= userInput; i++)
                    {
                        if (userInput % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                        Console.WriteLine("Success!");
                    else
                        throw new CustomException("Input is not prime");
                }
                else if (task == 4)
                {
                    Console.WriteLine("Enter Negative Number");
                    int userInput = int.Parse(Console.ReadLine());
                    if (userInput >= 0)
                    {
                        throw new CustomException("Input is not Negative");
                    }
                    else
                    {
                        Console.WriteLine("Success!");
                    }
                }
                else
                {
                    Console.WriteLine("Enter Zero");
                    int userInput = int.Parse(Console.ReadLine());
                    if (userInput != 0)
                    {
                        throw new CustomException("Input is not Zero");
                    }
                    else
                    {
                        Console.WriteLine("Success!");
                    }
                }

            }
            catch (CustomException E)
            {
                Console.WriteLine(E.Message);
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
            }
        }
    }
}

