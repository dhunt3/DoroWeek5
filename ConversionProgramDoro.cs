using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionDoro
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            Console.WriteLine("Please input 8 numbers (Combo of 1s and/ 0s");
            line = Console.ReadLine();
            
            char[] array = line.ToCharArray();
            Array.Reverse(array);
            int answer = 0;
            int counter = 0;
            foreach (char item in array)
            {
                string chNum = item.ToString();
                int lineNum = Convert.ToInt32(chNum);
                //Console.WriteLine(lineNum);
                double power = Math.Pow(2, counter);
                int powerNum = Convert.ToInt32(power);
                answer += (lineNum * powerNum);
                //Console.WriteLine(answer);
                counter++;
            }
            Console.WriteLine(answer);

            Console.ReadLine();
        }
    }
}
