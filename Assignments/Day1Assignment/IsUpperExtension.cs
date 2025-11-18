using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Assignment
{
    static class IsUpperExtension
    {
        public static bool IsUpper(this string str)
        {
            return str == str.ToUpper();
        }
    }
}
