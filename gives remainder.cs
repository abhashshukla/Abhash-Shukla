using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingAlgorithm
{
    
    public class ReturnRemainder
    {
        public static int GetRemainder(int x, int y)
        {
            if (y == 0)
                throw new Exception("Can not divide by zero");

            if (x < y)
                throw new Exception("Number being divided (dividend) can not be less than the divisor");

            else
                return (x % y);
        }
    }
}