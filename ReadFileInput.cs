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


        //Part one
        public void compare()
        {
            int previousnumber = 0;
            int count = 0;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (previousnumber < numbers[i] )
                {
                    count++;
                }
                previousnumber = numbers[i];  
            }
            Console.WriteLine(count);
        }

        public void compareparttwo()
        {
           
        }
    }
}
