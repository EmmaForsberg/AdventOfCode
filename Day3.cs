using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdventOfCode
{
    internal class Day3
    {
        public void Main()
        {  
            ReadFileInput fileInput = new ReadFileInput();
            string[] lines = fileInput.ReadFile();

            var lengthofline = lines[0].Length;

            char[] gamma = new char[lengthofline];
            char[] epilson = new char[lengthofline];

            for (int i = 0; i < lengthofline; i++) 
            {
                var number0 = lines.Select(x => x[i]).Count(x => x == '0');
                var number1 = lines.Select(x => x[i]).Count(x => x == '1');

                gamma[i] += (number0 > number1) ? '0' : '1';
                epilson[i] += (number0 < number1) ? '0' : '1';

            }
            var gammarate = Convert.ToInt32(new String(gamma), 2);
            var epilsonrate = Convert.ToInt32(new String(epilson), 2);

            var result = gammarate * epilsonrate;
            Console.WriteLine(result);

        }
    }
}
