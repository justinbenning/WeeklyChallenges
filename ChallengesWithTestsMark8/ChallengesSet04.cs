using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;
            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
                else
                {
                    sum -= i;
                }
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            string[] list = new string[4] { str1, str2, str3, str4 };
            return list.Min(x => x.Length);

        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] ints = new int[4] { number1, number2, number3, number4 };
            return ints.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            int[] arr = new int[3] {sideLength1, sideLength2, sideLength3};
            int[] arr2 = arr.OrderByDescending(x => x).ToArray();
            if (arr2[0] < arr2[1] + arr2[2])
            { 
                return true; 
            }
            else
            {
                return false;
            }




        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out double number);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullCount = objs.Count(x => x == null);
            if (nullCount > objs.Length * .5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {
            
            List<int> list = new List<int>();
            if (numbers == null)
            {
                return 0;
            }
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    list.Add(number);
                }
            }
            if (list.Count == 0)
            {
                return 0;
            }
            else
            {
                return (double)list.Sum() / (double)list.Count();
            }
        }

        public int Factorial(int number)
        {
            int total = 1;
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            for (int i = 1; i <= number; i++)
            {
                total *= i;
            }
            return total;

        }
    }
}
