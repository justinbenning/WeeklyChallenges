using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null)
                return false;
            foreach (var item in words)
            {
                if (item == null) 
                    continue;
                if (ignoreCase == false)
                {
                   if (item == word)
                    {
                        return true;
                    }
                }
                else
                {
                    if (item.ToLower() == word) 
                    {
                        return true;
                    }
                }
            }
            return false;
            
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1)
                return false;

            return Enumerable.Range(2, (int)Math.Sqrt(num) - 1).All(i => num % i != 0);
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            if (string.IsNullOrEmpty(str))
                return -1;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                char currentChar = str[i];
                bool isUnique = true;

                for (int j = 0; j < str.Length; j++)
                {
                    if (i != j && str[j] == currentChar)
                    {
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique)
                    return i;
            }
            return -1;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int maxStreak = 1;
            int currentStreak = 1;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentStreak++;
                }
                else
                {
                    if (currentStreak > maxStreak)
                    {
                        maxStreak = currentStreak;
                    }
                    currentStreak = 1;
                }
            }
            if (currentStreak > maxStreak)
            {
                maxStreak = currentStreak;
            }
            return maxStreak;
        }


        public double[] GetEveryNthElement(List<double> elements, int n)
        {

            if (elements == null || n <= 0)
                return new double[0];

            List<double> selectedElements = new List<double>();

            for (int i = n - 1; i < elements.Count; i += n)
            {
                selectedElements.Add(elements[i]);
            }

            return selectedElements.ToArray();

        }
    }
}

