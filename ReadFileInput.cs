using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode
{
    internal class ReadFileInput
    {
        string[] lines = System.IO.File.ReadAllLines(@"Days\Day1.txt");

        List<int> numbers = new List<int>();

        public void readline()
        {
            foreach (var item in lines)
            {
                int number = int.Parse(item);
                numbers.Add(number);
            }
        }

        public void compare()
        {
            int numbbs = 0;
            int count = 0;
           

            foreach (var numb in numbers)
            {

                if (numbbs < numb)
                {
                    count++;
                }
                numbbs = numb;
            }
            Console.WriteLine(count - 1);

        }



    }
}
