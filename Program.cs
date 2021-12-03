using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReadFileInput fileInput = new ReadFileInput();
            List<int> numberlist = fileInput.readline();

            Day1 day1 = new Day1();
            day1.comparepartone(numberlist);
            day1.compareparttwo(numberlist);

            Console.Read();
        }
    }
}
