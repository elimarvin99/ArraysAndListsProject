using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:     DONE

            // Create an int Array and populate numbers 1-10

            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */                                            //Done

            var evens = new List<int>();
            var odds = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */                                                               //done

            foreach (var num in myArray)
            {
                if (num %2 == 0)
                {
                    evens.Add(num);
                }
                else
                {
                    odds.Add(num);
                }
            }
            //for (int i = 0; i < 10; i++)
            //{
            //    if (myArray[i] % 2 == 0)
            //    {
            //        evens.Add(myArray[i]);
            //    }
            //    else
            //    {
            //        odds.Add(myArray[i]);
            //    }
            //}
            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */                                                          //done
            foreach (var num in evens)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("---------------------");

            foreach (var num in odds)
            {
                Console.WriteLine(num);
            }
        }
    }
}
