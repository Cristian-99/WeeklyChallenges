using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Count() % 2 == 0 ? true : false;

            //int count = 0;
            //for (int i = 0; i < vals.Length; i++)
            //{
            //    count++;
            //}
            //if (count % 2 == 0)
            //    return true;
            //else
            //    return false;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0 ? true : false;

            //if (number % 2 == 0)
            //    return true;
            //else
            //    return false;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0 ? true : false;

            //if (num % 2 != 0)
            //    return true;
            //else
            //    return false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            return numbers == null || numbers.Count() < 1 ? 0 : numbers.Max() + numbers.Min();

            //if (numbers == null || numbers.Count() == 0)
            //{
            //    return 0;
            //}
            //else
            //    return numbers.Max() + numbers.Min();

        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str1.Length > str2.Length ? str2.Length : str1.Length;

            //if (str1.Length > str2.Length)
            //    return str2.Length;
            //else
            //    return str1.Length;
        }

        public int Sum(int[] numbers)
        {
            return numbers == null ? 0 : numbers.Sum();

            //int sum = 0;
            //if (numbers == null)
            //    return 0;
            //for (int i = 0; i<numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //return sum;
        }

        public int SumEvens(int[] numbers)
        {
            return numbers == null ? 0 : numbers.Where(x => x % 2 == 0).Sum();

            //int sum = 0;
            //if (numbers == null)
            //    return 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //        sum += numbers[i];
            //}
            //return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if(numbers == null)
            {
                return false;
            }

            return numbers.Where(x => x % 2 != 0).Sum() % 2 != 0 ? true : false;

            //if (numbers == null)
            //    return false;
            //int sum = numbers.Sum();
            //if (sum % 2 != 0)
            //    return true;
            //else
            //    return false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            return number <= 0 ? 0 : number / 2;

            //if (number <= 0)
            //    return 0;
            //else
            //    return number / 2;
        }
    }
}
