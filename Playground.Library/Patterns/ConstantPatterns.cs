using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Library.Patterns
{
    public class ConstantPatterns
    {
        public  string GetNumberName(int number)
        {
            var b = number switch
            {
                1 => "One",
                2 => "Two",
                3 => "Three",
                4 => "Four",
                5 => "Five",
                _ => throw new ArgumentException("Too much")
            };

            return b;
        }

    }
}
