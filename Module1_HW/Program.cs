using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Module1_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz(); //1
            NumPercentage(); //2
            NumByDigits(); //3
            SwapDigits(); //4
            daySeason(); //5
            convertT(); //6
            evenNumbersInRange(); //7


            Console.Read();
        }

        static void FizzBuzz() // 1
        {
            Console.Write("Enter a number from 1 to 100: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num < 1 || num > 100)
            {
                Console.WriteLine("Input number out of range.");
                return;
            }


            if (num%15 == 0)
            {
                Console.WriteLine("Fizz Buzz");
                return;
            }
            else if (num%3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (num%5 == 0) 
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(num);
            }
        }


        static void NumPercentage() //2
        {
            Console.Write("Enter a number: ");
            double num = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter percentage to calculate: ");
            double p = Convert.ToDouble(Console.ReadLine());

            if (p < 0)
            {
                Console.WriteLine("Negative percentage input.");
                return;
            }

            Console.WriteLine("{0} percent of {1} equals {2}.", p, num, p * (num / 100));


        }

        static void NumByDigits() //3
        {

            const int len = 4;
            int numOut = 0;


            for (int i = 0; i < len; i++)
            {
                Console.Write("Enter digit #" + (i + 1) + ": ");
                numOut += Convert.ToInt32(Console.ReadLine()) * (int)(1000 / Math.Pow(10, i));
            }

            Console.WriteLine("Result: {0}", numOut);
        }

        static void SwapDigits() //4
        {
            Console.Write("Enter a 6 digit number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] digits = new int[6];
            int temp;

            if (num < 100000 || num > 999999)
            {
                Console.WriteLine("Number out of range.");
                return;
            }

            Console.Write("Enter digit to swap #1: ");
            int d1 = Convert.ToInt32(Console.ReadLine());

            if (d1 < 1 || d1 > 6)
            {
                Console.WriteLine("Digit 1 out of range.");
                return;
            }

            Console.Write("Enter digit to swap #2: ");
            int d2 = Convert.ToInt32(Console.ReadLine());

            if (d2 == d1 || (d2 < 1 || d2 > 6))
            {
                Console.WriteLine("Digit 2 out of range.");
                return;
            }

            
            for (int i = 5; i >= 0; i--)
            {
                digits[i] += num / (int)Math.Pow(10, i) % 10;
            }

            num = 0;

            temp = digits[d1 - 1];
            digits[d1-1] = digits[d2 - 1];
            digits[d2-1] = temp;

            for(int i = 0; i< 6; i++)
            {
                num += digits[i] * (int)Math.Pow(10, i);
            }

            Console.WriteLine("Result: {0}", num);

        }

        static void daySeason() // 5
        {

            Console.Write("Enter day: ");
            string day = Console.ReadLine();
            Console.Write("Enter month: ");
            string month = Console.ReadLine();
            Console.Write("Enter year: ");
            string year = Console.ReadLine();

            string dateString = day + "." + month + "." + year;
            DateTime date;
            string message = "";

            if (DateTime.TryParse(dateString, out date))
            {

                if (Convert.ToInt32(month) >= 3 && Convert.ToInt32(month) <= 5)
                {
                    message += "Spring ";
                }
                else if (Convert.ToInt32(month) >= 6 && Convert.ToInt32(month) <= 8)
                {
                    message += "Summer ";
                }
                else if(Convert.ToInt32(month) >= 9 && Convert.ToInt32(month) <= 11) 
                {
                    message += "Fall ";
                }
                else
                {
                    message += "Winter ";
                }

                message += date.ToString("dddd");

                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine("Invalid date.");
            }


        }

        static void convertT()// 6
        {
            Console.Write("Enter temperature: ");
            double t = Convert.ToDouble(Console.ReadLine());

            Console.Write("1.C to F\n2.F to C");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Result: {0}", t * 1.8 + 32);
                    break;

                case 2:
                    Console.WriteLine("Result: {0}", (t - 32)*0.5556);
                    break;

                default:
                    Console.WriteLine("Invalid input.");
                    break;

            }
        }

        static void evenNumbersInRange() //7
        {
            Console.Write("Enter start of range: ");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter end of range: ");
            int end = Convert.ToInt32(Console.ReadLine());

            if (start == end)
            {
                if (start%2 == 0)
                {
                    Console.WriteLine(start);
                }
                return;
            }

            if (start > end)
            {
                int temp = start;
                start = end;
                end = temp;
            }

            for (int i = start; i <= end; i++)
            {
                if (i%2 == 0) 
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
