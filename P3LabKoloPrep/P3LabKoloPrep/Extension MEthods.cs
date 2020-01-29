using System;
using System.Collections.Generic;
using System.Text;

namespace P3LabKoloPrep
{
    public static class Extension_Methods
    {
        public static (int, int) DivideWithRemainder(this int divisor, int dividend)
        {
            return (divisor / dividend, divisor % dividend);
        }


    }
}
