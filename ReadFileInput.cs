using System.Collections.Generic;
using System;
using System.Text.RegularExpressions;

namespace AdventOfCode
{
    internal class ReadFileInput
    {
        string[] line = System.IO.File.ReadAllLines(@"Days\Day3.txt");

        public string[] ReadFile()
        {
            return line;        
        }

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
