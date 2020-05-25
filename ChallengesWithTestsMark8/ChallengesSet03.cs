﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            bool isFalse = false;
            foreach (var val in vals)
            {
                if (val == isFalse)
                    isFalse = true;
            }
            return isFalse;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int x = 0;
            bool isOdd;
            if (numbers == null)
                return false;
            else
                foreach (var num in numbers)
                {
                    x += num;
                }
                isOdd = x % 2 == 0 ? false : true;
                return isOdd;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool hasUpLowNum = true;
            var hasUp = password.Any(Char.IsUpper);
            var hasLow = password.Any(Char.IsLower);
            var hasNum = password.Any(Char.IsDigit);
            hasUpLowNum = (hasUpLowNum == hasUp && hasUpLowNum == hasLow && hasUpLowNum == hasNum);
            return hasUpLowNum;

        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
                return 0;
            else
                return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            int[] x = new int[50];
            int count = 0;
            int i = 1;
            while (count < 50)
            {
                x[count] = i;
                count++;
                i += 2;
            }
            return x;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for(int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }


    }
}
