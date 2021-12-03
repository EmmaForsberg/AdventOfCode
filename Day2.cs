using System.Text.RegularExpressions;

namespace AdventOfCode
{
    internal class Day2
    {

        public void PartOne()
        {
            int up =0;          
            int forward=0;

            ReadFileInput fileInput = new ReadFileInput();
            string[] lines = fileInput.ReadFile();

            foreach (var line in lines)
            {
                string[] array = Regex.Split(line, "\\s");

                if (array[0].Contains("forward"))
                {
                   forward += int.Parse(array[1]);
                }
                else if (array[0].Contains("up"))
                {
                    up -= int.Parse(array[1]);
                }
                else if (array[0].Contains("down"))
                {
                    up += int.Parse(array[1]);
                }
            }
            System.Console.WriteLine(forward*up);
        }

        public void PartTwo()
        {
            int up =0;
            int aim=0;
            int forward=0;
            int depths=0;

            ReadFileInput fileInput = new ReadFileInput();
            string[] lines = fileInput.ReadFile();

            foreach (var line in lines)
            {
                string[] array = Regex.Split(line, "\\s");

                if (array[0].Contains("forward"))
                {
                    forward += int.Parse(array[1]);

                    if (aim != 0)
                    {
                        depths += int.Parse(array[1]) * aim;
                    }
                }
                else if (array[0].Contains("up"))
                {
                    aim -= int.Parse(array[1]);
                }
                else if (array[0].Contains("down"))
                {
                    aim += int.Parse(array[1]);
                }
            }
            System.Console.WriteLine(forward * depths);
        }
    }
}
