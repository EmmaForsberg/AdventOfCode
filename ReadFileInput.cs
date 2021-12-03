using System;
using System.Collections.Generic;

namespace AdventOfCode
{
    internal class ReadFileInput
    {
        string[] lines = System.IO.File.ReadAllLines(@"Days\Day1.txt");

        public List<int> numbers = new List<int>();

        public List<int> readline()
        {
            foreach (var item in lines)
            {
                int number = int.Parse(item);

                numbers.Add(number);

            }
            return numbers;
        }
    }
}
