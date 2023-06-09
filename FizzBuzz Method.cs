using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzbuzz1
{
    public static class FizzBuzz_Method
    {
        public static string GetZero(int num)
        {

            
            if (num % 5 == 0 && num % 3 == 0)
            {
                return $"{num}: fizzbuzz";

            }

            else if (num % 3 == 0)
            {
                return  $"{ num}: fizz";
            }



            else if (num % 5 == 0)
            {
                return $"{num}: buzz";

            }


            else
            {
                return $"{ num}: INVALID!!! Does not divide by 3 or 5 !";

            }
        }
    }
}
