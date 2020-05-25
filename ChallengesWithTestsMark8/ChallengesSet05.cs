using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            startNumber++;
            while (startNumber % n != 0)
            {
                startNumber++;
                if (startNumber % n == 0)
                    break;
            }
            return startNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var biz in businesses)
            {
                if (biz.TotalRevenue == 0)
                    biz.Name = "CLOSED";
                if (biz.TotalRevenue < biz.TotalExpenses)
                    biz.Name = "CLOSED";
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            bool isTrue = true;
            if (numbers == null)
                isTrue = false;
            else if (numbers.Length == 0)
                isTrue = false;
            else
            {
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    int num = numbers[i];
                    if (num > numbers[i + 1])
                    {
                        isTrue = false;
                        break;
                    }
                }
            }
            return isTrue;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int sum = 0;
            if (numbers == null)
                return 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] % 2 == 0)
                    sum += numbers[i + 1];
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            string str = "";
            if (words == null || words.Length < 1)
                return str;
            foreach(var word in words)
            {
                if (string.IsNullOrWhiteSpace(word))
                    continue;
                else
                    str += word.Trim() + " ";
            }
            if(str == "")
            {
                return "";
            }
            return str.TrimEnd() + ".";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            double[] empty = new double[0];
            List<double> list = new List<double>();

            if (elements == null)
                return empty;

            for(int i = 3; i < elements.Count; i+=4)
            {
                list.Add(elements[i]);
            }

            int size = list.Count;
            double[] arr = new double[size];

            for(int i = 0; i < size; i++)
            {
                arr[i] = list[i];
            }
            return arr;
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
           
            if (nums.Length == 0)
                return false;
            bool isTrue = false;

            for (int i = 0; i < nums.Length; i++)
            {
                int result1 = nums[i];
                for(int j = 0; j < nums.Length; j++)
                {
                    if (i == j)
                        continue;
                    int result2 = nums[j];
                    if (result1 + result2 == targetNumber)
                    {
                        isTrue = true;
                        break;
                    }
                }
            }
            return isTrue;
        }
    }
}
