﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Exercize
{
    class Program
    {
        static void Main(string[] args)
        {
            CallDivisors();
            //check any integer 
            IsNarcistic();
           
            // Empty list for prime numbers
            List<int> primeNumbers = new List<int>();
            // Array arr for testing purposes
            int[] arr = new int[] { 23, 45, 2, 8, 9, 13, 17, 24, 15, 11, 5 };

            // 1. Function that returns an array of the numbers that are ‘prime’ 
            // numbers who are equal to, or smaller than, the target parameter MaxPrime.
            // If there are no prime numbers smaller than or equal to the MaxPrime, the function should return null.
            GetingPrimeArray(primeNumbers, arr);

            //2. Function CountNumbersLessThan that accepts a sorted array of unique integers
            //and counts the number of array elements that are less than the parameter lessThan.
            //For example, SortedSearch.CountNumbersLessThan(new int[] { 1, 3, 5, 7 }, 4) 
            //should return 2 because there are two array elements less than 4.
            GetSearchedCount(arr);

            //3.Function that takes a decimal data type and write
            //the same number in words(For example, Numbers.DecimalToWords(10)
            //should return the word ten. Assume no numbers would be bigger than 100.
            GetNumberInWords();

            //4.Common regular expression(regex) that would identify(find & capture)
            //all persons that share the same first name or the same last name as you, given a list of 
            //names separated by CR/ LF.Each line has the complete name of one person with First_Name, 
            //optional Middle Initial(s), optional full middle name(s), and last name(s).

            // Create a string of person
            string randomNames = "Piotr Hollis \r\n " + "James Hlushen \r\n" + "Elizabeth Holden \r\n " + "Robert Holdstock \r\n" + "Fred Hoyle \r\n";
            // who are  we looking for
            string lookingForLastName = "Hlushen";
            string lookingForFirstName = "Piotr";
            
            GetNicePersons(randomNames, lookingForLastName,lookingForFirstName);            

            Console.ReadKey();
        }


        private static void CallDivisors()
        {
            Console.WriteLine("Please enter integer bigger then 1 :");
            int number = Convert.ToInt32(Console.ReadLine());            
            Console.WriteLine("yure answer is : {0}" , String.Join(" ,",Divisors(number)));
        }
        public static int[] Divisors(int n)
        {

            if (n > 1)
            {
                List<int> list = new List<int>();

                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        list.Add(i);
                    }
                }
                return list.ToArray();
            }
            return null;
        }

        private static void IsNarcistic() {
            Console.WriteLine("Please enter integer :");
            int number = Convert.ToInt32(Console.ReadLine());
            string status = (!Narcissistic(number)) ? "notNarcissistic" : "Narcissistic";            
            Console.WriteLine("Youre number equal {0} and it is {1}", number, status);
        }
        private static bool Narcissistic(int value)
        {
            //using Linq
            var str = value.ToString();
            return str.Sum(c => Math.Pow(Convert.ToInt16(c.ToString()), str.Length)) == value;
            // next it is mine without Math.Pow()
            //string str = Convert.ToString(value);
            //int length = str.Length;
            //int compareValue = 0;
            //foreach (var item in str )
            //{
            //    int i = Convert.ToInt32(item.ToString());
            //    int result = i;
            //    int will = length;

            //    while (will > 1)
            //    {
            //        result = result * i;
            //        will-- ;
            //    }
            //    compareValue += result;
            //}
            
            //return (compareValue == value) ? true : false;
        }
            private static void GetNicePersons(string randomNames, string lookingForLastName, string lookingForFirstName)
        {           
            string names = FindName.GetRightName(randomNames, lookingForLastName, lookingForFirstName);
            Console.WriteLine(names);
        }

        private static void GetNumberInWords()
        {
            Console.WriteLine("please give me an decimal less than 100:");
            decimal number = Convert.ToDecimal(Console.ReadLine());
            string numbers = DecimalToWords.GetWords(number);
            Console.WriteLine(numbers);
        }

        private static void GetSearchedCount(int[] arr)
        {
            Console.WriteLine("please give me an integer parametr:");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = SortedSearch.CountNumbersLessThan(arr, num);
            Console.WriteLine(count);
        }

        private static void GetingPrimeArray(List<int> primeNumbers, int[] arr)
        {
            Console.WriteLine("please give me a Max Number:");
            int maxNumber = Convert.ToInt32(Console.ReadLine());
            primeNumbers = PrimeArray.GetListOfIntegers(arr, maxNumber);
            // Creating a string with array of prime nubers
            string pn = "";
            foreach (var i in primeNumbers)
            {
                pn += i + ",";
            }
            Console.WriteLine($"Your array of prime numbers:  { pn }");
        }
    }


}
