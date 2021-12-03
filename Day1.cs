using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    internal class Day1
    {
        public void comparepartone(List<int> numbers)
        {
            int count = 0;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] < numbers[i + 1])
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        //part two
        public void compareparttwo(List<int> numbers)
        {
            int count = 0;

            for (int i = 0; i < numbers.Count - 3; i++)
            {
                var position1 = numbers[i] + numbers[i + 1] + numbers[i + 2];

                var position2 = numbers[i + 1] + numbers[i + 2] + numbers[i + 3];

                if (position1 < position2)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
