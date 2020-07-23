using System;
using System.Linq;
using SmallTasksWithReact.Core;

namespace SmallTasksWithReact.Services
{
    public class NumberService : INumberService
    {
        public int SumOfEverySecondOddNumber(int[] array)
        {
            if (array == null || array.Length == 0) return 0;
            var oddNumbers = array.Where(number => number % 2 == 1);
            var halfNumbers = oddNumbers.Where((number, index) => index % 2 == 1);
            var sum =  halfNumbers.Sum();
            return Math.Abs(sum);
        }
    }
}