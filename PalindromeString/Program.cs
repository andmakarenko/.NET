using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "slaibhjiwefv";
            string str2 = "JbeYHjjhyeBJ";

            if (!isPalindrome(str1))
            {
                Console.WriteLine("The first string is not a palindrome.");
            }

            if (isPalindrome(str2))
            {
                Console.WriteLine("The second string is a palindrome.");
            }

            Console.Read();
        }

        static bool isPalindrome(string str)
        {
            string[] arr = str.Split(' ');
            string temp = "";

            foreach(var element in arr)
            {
                temp += element.ToLower();
            }


            for (int i = 0, j = temp.Length - 1; i < j; i++, j--)
            {
                if (temp[i] != temp[j])
                {
                    return false;
                }
            }


            return true;
        }
    }


}
