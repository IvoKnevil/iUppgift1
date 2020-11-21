using System;
using System.Collections.Generic;

namespace iUppgift1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = ("Ivos magic program");
            char answer = 'Y';
            int totalSum = default(int);

            List<int> myList = new List<int>();
           
            while (answer == 'Y' || answer == 'y')
            {
                Console.WriteLine("Hello! Lets do some calculations");
                Console.WriteLine("Lets start by choosing some operators (+ - * /)");
                Console.Write("Please enter the 1st operator:");
                string inputOperatorOne = Console.ReadLine();
                Console.Write("Please enter the 2nd operator:");
                string inputOperatorTwo = Console.ReadLine();
                Console.WriteLine("Please enter a number that will be used with 1st operator: ");
                string inputFirstNr = Console.ReadLine();
                int firstNr = Convert.ToInt32(inputFirstNr);
                Console.WriteLine("Please enter a number that will be used with 2nd operator: ");
                string inputSecondNr = Console.ReadLine();
                int secondNr = Convert.ToInt32(inputSecondNr);
                Console.WriteLine("Please enter a number that will be used with 3rd operator: ");
                string inputThirdNr = Console.ReadLine();
                int thirdNr = Convert.ToInt32(inputThirdNr);

                int sum = default(int);

                Console.Clear();

                if (inputOperatorOne == "+")
                {

                    if (inputOperatorTwo == "+")
                    {
                        sum = firstNr + secondNr + thirdNr;
                        Console.WriteLine(sum + "=" + firstNr + inputOperatorOne + secondNr + inputOperatorTwo + thirdNr);
                    }
                    else if (inputOperatorTwo == "-")
                    {
                        sum = firstNr + secondNr - thirdNr;
                        Console.WriteLine(sum + "=" + firstNr + inputOperatorOne + secondNr + inputOperatorTwo + thirdNr);
                    }
                    else if (inputOperatorTwo == "*")
                    {
                        sum = firstNr + secondNr * thirdNr;
                        Console.WriteLine(sum + "=" + firstNr + inputOperatorOne + secondNr + inputOperatorTwo + thirdNr);
                    }
                    else if (inputOperatorTwo == "/")
                    {
                        sum = firstNr + secondNr / thirdNr;
                        Console.WriteLine(sum + "=" + firstNr + inputOperatorOne + secondNr + inputOperatorTwo + thirdNr);
                    }
                }

                if (inputOperatorOne == "-")
                {

                    if (inputOperatorTwo == "+")
                    {
                        sum = firstNr - secondNr + thirdNr;
                        Console.WriteLine(sum + "=" + firstNr + inputOperatorOne + secondNr + inputOperatorTwo + thirdNr);
                    }
                    else if (inputOperatorTwo == "-")
                    {
                        sum = firstNr - secondNr - thirdNr;
                        Console.WriteLine(sum + "=" + firstNr + inputOperatorOne + secondNr + inputOperatorTwo + thirdNr);
                    }
                    else if (inputOperatorTwo == "*")
                    {
                        sum = firstNr - secondNr * thirdNr;
                        Console.WriteLine(sum + "=" + firstNr + inputOperatorOne + secondNr + inputOperatorTwo + thirdNr);
                    }
                    else if (inputOperatorTwo == "/")
                    {
                        sum = firstNr - secondNr / thirdNr;
                        Console.WriteLine(sum + "=" + firstNr + inputOperatorOne + secondNr + inputOperatorTwo + thirdNr);
                    }
                }

                if (inputOperatorOne == "*")
                {

                    if (inputOperatorTwo == "+")
                    {
                        sum = firstNr * secondNr + thirdNr;
                        Console.WriteLine(sum + "=" + firstNr + inputOperatorOne + secondNr + inputOperatorTwo + thirdNr);
                    }
                    else if (inputOperatorTwo == "-")
                    {
                        sum = firstNr * secondNr - thirdNr;
                        Console.WriteLine(sum + "=" + firstNr + inputOperatorOne + secondNr + inputOperatorTwo + thirdNr);
                    }
                    else if (inputOperatorTwo == "*")
                    {
                        sum = firstNr * secondNr * thirdNr;
                        Console.WriteLine(sum + "=" + firstNr + inputOperatorOne + secondNr + inputOperatorTwo + thirdNr);
                    }
                    else if (inputOperatorTwo == "/")
                    {
                        sum = firstNr * secondNr / thirdNr;
                        Console.WriteLine(sum + "=" + firstNr + inputOperatorOne + secondNr + inputOperatorTwo + thirdNr);
                    }
                }

                if (inputOperatorOne == "/")
                {

                    if (inputOperatorTwo == "+")
                    {
                        sum = firstNr / secondNr + thirdNr;
                        Console.WriteLine(sum + "=" + firstNr + inputOperatorOne + secondNr + inputOperatorTwo + thirdNr);
                    }
                    else if (inputOperatorTwo == "-")
                    {
                        sum = firstNr / secondNr - thirdNr;
                        Console.WriteLine(sum + "=" + firstNr + inputOperatorOne + secondNr + inputOperatorTwo + thirdNr);
                    }
                    else if (inputOperatorTwo == "*")
                    {
                        sum = firstNr / secondNr * thirdNr;
                        Console.WriteLine(sum + "=" + firstNr + inputOperatorOne + secondNr + inputOperatorTwo + thirdNr);
                    }
                    else if (inputOperatorTwo == "/")
                    {
                        sum = firstNr / secondNr / thirdNr;
                        Console.WriteLine(sum + "=" + firstNr + inputOperatorOne + secondNr + inputOperatorTwo + thirdNr);
                    }
                }

                if (sum < 100)
                {
                    Console.WriteLine("The sum is less than a hundred.");
                }

                else if (sum > 100)
                {
                    Console.WriteLine("The sum is more than a hundred.");
                }

                else if (sum == 100)
                {
                    Console.WriteLine("Cool, now you have a hundred, clap clap.");
                }
                totalSum = totalSum + sum;

                myList.Add(sum);

                Console.WriteLine("Another try?");
                string input = Console.ReadLine();
                answer = Convert.ToChar(input);

            }

            Console.Write("The sum of all rounds is: " + totalSum + " = ");
            Console.WriteLine(string.Join("+", myList));
            Console.WriteLine("Thank you for playing. See ya!");

            }
        }
    }
