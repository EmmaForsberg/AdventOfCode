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
            fileInput.readline();
            fileInput.compare();
            //fileInput.compareparttwo();
            Console.Read();
        }


    }
}
