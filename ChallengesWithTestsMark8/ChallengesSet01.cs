using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
<<<<<<< HEAD
            //return num1 == num2;
            //return num1 == num2 ? true : false;
            if (num1 == num2)
                return true;
            else
                return false;
=======
            return num1 == num2;

            //if (num1 == num2)
            //    return true;
            //else
            //    return false;
>>>>>>> 2e42e37bd0d5aa56299064830a04c16a4869e063
        }

        public double Subtract(double minuend, double subtrahend) 
        {
<<<<<<< HEAD
            //return minuend - subtrahend;
             double result = minuend - subtrahend;
                return result;
=======
            return minuend - subtrahend;

        //  double result = minuend - subtrahend;
        //  return result;
>>>>>>> 2e42e37bd0d5aa56299064830a04c16a4869e063
        }

        public int Add(int number1, int number2)
        {
<<<<<<< HEAD
            //return number1 + number2;
            int result = number1 + number2;
            return result;
=======
            return number1 + number2;

            //int result = number1 + number2;
            //return result;
>>>>>>> 2e42e37bd0d5aa56299064830a04c16a4869e063
        }

        public int GetSmallestNumber(int number1, int number2)
        {
<<<<<<< HEAD
            //return number1 < number2 ? number1 : number2;
            if (number1 < number2)
                return number1;
            else
                return number2;
=======
            return number1 < number2 ? number1 : number2;

            //if (number1 < number2)
            //    return number1;
            //else
            //    return number2;
>>>>>>> 2e42e37bd0d5aa56299064830a04c16a4869e063
        }

        public long Multiply(long factor1, long factor2)
        {
<<<<<<< HEAD
            //return factor1 * factor2;
            if (factor1 == 0 || factor2 == 0)
                return 0;
            else
            {
                long result = factor1 * factor2;
                return result;
            }
=======
            return factor1 == 0 || factor2 == 0 ? 0 : factor1 * factor2;

            //if (factor1 == 0 || factor2 == 0)
            //    return 0;
            //else
            //{
            //    long result = factor1 * factor2;
            //    return result;
            //}
>>>>>>> 2e42e37bd0d5aa56299064830a04c16a4869e063
        }

        public string GetGreeting(string nameOfPerson)
        {
            return string.IsNullOrEmpty(nameOfPerson) ? "Hello!" : $"Hello, {nameOfPerson}!";

            //if (nameOfPerson == null)
            //    return "Hello!";
            //else if (nameOfPerson == "")
            //    return "Hello!";
            //else
            //    return $"Hello, {nameOfPerson}!";
        }

        public string GetHey() => "HEY!";
        //{
        //    return "HEY!";
        //}
    }
}
