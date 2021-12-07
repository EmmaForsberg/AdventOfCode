using System.Collections.Generic;

namespace AdventOfCode
{
    internal class Day6
    {
        public void Main()
        {
            var six = 6;
            var fish = 0;
            var days = 1;

            ReadFileInput fileInput = new ReadFileInput();
            List<int> numberlist = fileInput.readline();

            while (days < 80)
            {
                for (int i = 0; i < numberlist.Count; i++)
                {
                    numberlist[i]--;
                    if (numberlist[i] == 0)
                    {
                        numberlist[i] = six;
                        fish++;

                        numberlist.Add(8);
                        six = numberlist.Count + 1;

                    }

                   // var r = numberlist.Count + 1;


                }
                days++;


            }

        }
    }
}
