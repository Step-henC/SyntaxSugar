using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyntaxSugar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var answer = 4;
            string response;
            if (answer < 9)
            {
                response = ($"{answer} is less than 9");
            }
            else
            {
                response = ($"{answer} is greater than or equal to nine");
            }
        }
    }
}
