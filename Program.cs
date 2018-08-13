/*
Happy Numbers - Hard from Coding Challenges
by Silvio Duka

Last modified date: 2018-03-12

If the repeated sum of squares of the digits of a number is equal to 1, it is considered to be happy. 

For Example: 
23 is a happy number, as: 
2 ^ 2 + 3 ^ 2 = 13 
1 ^ 2 + 3 ^ 2 = 10 
1 ^ 2 + 0 ^ 2 = 1 

Sequence of happy numbers: 1, 7, 10, 13, 19, 23, ... 

Tasks: 
(Easy) Write a program to verify whether a given number is happy or not. 
(Medium) Write a program to find all the happy numbers in a range. 
(Hard) Given a number, write a program to verify whether it's happy or not and to display every sum of squares operation performed till the result is obtained. 

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 23; // Insert a number to verify whether is happy or not

            Console.WriteLine($"\nThe number {number} {((IsHappyNumber(number)) ? "is" : "is NOT")} a Happy Number...\n");
        }

        static bool IsHappyNumber(int n)
        {
            int h = 0;

            while (true)
            {
                string s = String.Empty;

                while (true)
                {
                    int d = n % 10;

                    s = String.Format($"+ {d} ^ 2 {s}");

                    h += (int)Math.Pow(d, 2);
                    n /= 10;
                    if (n == 0) break;
                }

                Console.WriteLine((String.Format($"{s}= {h}")).Remove(0, 2));

                if (h == 1) return true;
                if (h == 4) return false;

                n = h;
                h = 0;
            }
        }
    }
}