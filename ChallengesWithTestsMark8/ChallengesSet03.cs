using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (bool val in vals)
            {
                if (!val)
                {
                    return true;
                }

            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            if (numbers.Sum() % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool hasAllThree = password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsNumber);
            return hasAllThree;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.First();
        }

        public char GetLastLetterOfString(string val)
        {
            return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            else
            {
                return dividend / divisor;
            }
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length -1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            List<int> odds = new List<int>();
            for (int start = 1; start <= 100; start++)
            {
                if (start % 2 !=0)
                {
                    odds.Add(start);
                }
            }
            int[] ints = odds.ToArray();
            return ints;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            int i;
            for (i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
