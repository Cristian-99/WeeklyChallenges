using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool isTrue = true;

            if (words == null)
                return false;

            if (ignoreCase == true)
            {
                foreach(var item in words)
                {
                    if (item == null)
                        continue;
                    if (item.ToLower() == word)
                    {
                        isTrue = true;
                        break;
                    }
                    else 
                        isTrue = false;
                }
            }
            
            if(ignoreCase == false)
            {
                foreach(var item in words)
                {
                    if (item == null)
                        continue;
                    if (item == word)
                    {
                        isTrue = true;
                        break;
                    }
                    else
                        isTrue = false;
                }
            }
            return isTrue;
        }

        public bool IsPrimeNumber(int num)
        {
            bool isPrime = true;
            int factorCount = 1;
            double count = 1;

            if (num <= 1)
                isPrime = false;
            while (count < num)
            {
                if (num % count == 0)
                {
                    factorCount++;
                }
                count++;
            }
            if (factorCount > 2)
                isPrime = false;

            return isPrime;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int counter = 0;
            int last = 0;
            if (str == "")
                return -1;

            int[] counts = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                foreach(var letter in str)
                {
                    if (str[i] == letter)
                        counts[i]++;
                }
            }

            for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i] == 1)
                    last = i;
                else if (counts[i] > 1)
                    counter++;
            }
            if (counter == str.Length)
                return -1;
            return last;

            /*string distinct = new String(str.Distinct().ToArray());

            int a = str.ToCharArray().Count(z => z == 'a');
            int b = str.ToCharArray().Count(y => y == 'b');
            int c = str.ToCharArray().Count(x => x == 'c');
            int d = str.ToCharArray().Count(w => w == 'd');
            int e = str.ToCharArray().Count(v => v == 'e');
            int f = str.ToCharArray().Count(u => u == 'f');
            int g = str.ToCharArray().Count(t => t == 'g');

            if (str.Distinct().Count() == 7 && a == 1 && g == 1)
                return str.IndexOf('g');
            else if (str.Distinct().Count() == 7 && c == 1 && g == 1)
                return str.IndexOf('g');

            else if (str.Distinct().Count() == 7)
            {
                if (a == 1)
                    return str.IndexOf('a');
                else if (b == 1)
                    return str.IndexOf('b');
                else if (c == 1)
                    return str.IndexOf('c');
                else if (d == 1)
                    return str.IndexOf('d');
                else if (e == 1)
                    return str.IndexOf('e');
                else if (f == 1)
                    return str.IndexOf('f');
                else
                    return str.IndexOf('g');
            }
            else if (str.Distinct().Count() == 6)
            {
                if (a == 1)
                    return str.IndexOf('a');
                else if (b == 1)
                    return str.IndexOf('b');
                else if (c == 1)
                    return str.IndexOf('c');
                else if (d == 1)
                    return str.IndexOf('d');
                else if (e == 1)
                    return str.IndexOf('e');
                else
                    return str.IndexOf('f');
            }
            else if (str.Distinct().Count() == 5)
            {
                if (a == 1)
                    return str.IndexOf('a');
                else if (b == 1)
                    return str.IndexOf('b');
                else if (c == 1)
                    return str.IndexOf('c');
                else if (d == 1)
                    return str.IndexOf('d');
                else
                    return str.IndexOf('e');
            }
            else if (str.Distinct().Count() == 4)
            {
                if (a == 1)
                    return str.IndexOf('a');
                else if (b == 1)
                    return str.IndexOf('b');
                else if (c == 1)
                    return str.IndexOf('c');
                else
                    return str.IndexOf('d');
            }
            else if (str.Distinct().Count() == 3)
            {
                if (a == 1)
                    return str.IndexOf('a');
                else if (b == 1)
                    return str.IndexOf('b');
                else
                    return str.IndexOf('c');
            }
            else if (str.Distinct().Count() == 2 && str.Length > 2)
            {
                if (a == 1)
                    return str.IndexOf('a');
                else
                    return str.IndexOf('b');
            }
            else if (str.Distinct().Count() == 2)
                return str.IndexOf(str.Distinct().Last());
            else if (str.Distinct().Count() == 1 && str.Length > 1)
                return -1;
            else if (str.Length == 1)
                return 0;
            else if (string.IsNullOrEmpty(str))
                return -1;
            else
                return a = 0;   */
            
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int a = 1; int aCount = 1;
            int b = 2; int bCount = 1;
            int c = 3; int cCount = 1;
            int d = 4; int dCount = 1;
            int e = 5; int eCount = 1;
            int j = 10; int jCount = 1;

            List<int> list = new List<int>();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == a && numbers[i] == numbers[i + 1])
                    aCount++; list.Add(aCount);
                if (numbers[i] == b && numbers[i] == numbers[i + 1])
                    bCount++; list.Add(bCount);
                if (numbers[i] == c && numbers[i] == numbers[i + 1])
                    cCount++; list.Add(cCount);
                if (numbers[i] == d && numbers[i] == numbers[i + 1])
                    dCount++; list.Add(dCount);
                if (numbers[i] == e && numbers[i] == numbers[i + 1])
                    eCount++; list.Add(eCount);
                if (numbers[i] == j && numbers[i] == numbers[i + 1])
                    jCount++; list.Add(jCount);
            }

            return list.Max();
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> list = new List<double>();
            int x = n;

            if (elements == null)
                return list.ToArray();

            for(int i = 0; i < elements.Count(); i++)
            {
                if (elements[i] == x)
                {
                    list.Add(elements[i]);
                    x += n;
                }
            }
            return list.ToArray();
        }

    }
}
