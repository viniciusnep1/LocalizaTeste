﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.utils
{
    public static class DivisorsHelper
    {
        public static List<int> GetDivisors(this int number)
        {
            var listDivisors = new List<int>();
            for (int i = 1; i <= number; i++)
            {
                var rest = number % i;
                if (rest == 0)
                {
                    listDivisors.Add(i);
                }
            }

            return listDivisors.OrderBy(x => x).ToList();
        }

        public static List<int> GetPrimeNumers(this List<int> numbers)
        {
            var listPrime = new List<int>();
            numbers.ForEach(num =>
            {
                bool isPrime = true;
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    listPrime.Add(num);
                }
            });

            return listPrime.OrderBy(x => x).ToList();
        }
    }
}
