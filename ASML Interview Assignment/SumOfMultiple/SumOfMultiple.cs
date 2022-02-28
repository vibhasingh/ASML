// (C) ASML 2022 Submitted for Interview assignment

using System;
using ASML.InterviewTest.ProblemStrategy;

namespace ASML.InterviewTest.SumOfMultiple
{
    public class SumOfMultiple : IStrategy
    {
        /// <summary>
        ///     Gets the sum of all number from 1 to limit-1 which are divisible by 3 or 5
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public object ExecuteAlgorithm(object data)
        {
            int.TryParse(data.ToString(), out var inputLimit);
            if (inputLimit < 4) return 0;

            var num = inputLimit - 1; //do not include the limit (consider all number below the limit)

            return SumOfNumbersDivisibleByX(num);
        }

        /// <summary>
        ///     Compute sum of numbers divisible by x
        /// </summary>
        private decimal SumOfNumbersDivisibleByX(int num)
        {
            //Sum of all numbers which are divisible by 3
            var sumOf3 = Sum1toNDivisibleByX(num, 3);

            //Sum of all numbers which are divisible by 5
            var sumOf5 = Sum1toNDivisibleByX(num, 5);

            //deduct the number sum which are counted twice i.e. gcd(3,5) = 15
            var sumOf15 = Sum1toNDivisibleByX(num, 15);

            return sumOf3 + sumOf5 - sumOf15;
        }

        //sum of all numbers from 1 to n is equal to n*(n+1)/2.
        //sum of all number from 1 to n which are divisible by x is x*((n/x)*((n/x)+1)/2)
        private decimal Sum1toNDivisibleByX(int n, int x)
        {
            var numByX = Convert.ToDecimal(n / x);
            return x * (numByX * (numByX + 1) / 2);
        }
    }
}