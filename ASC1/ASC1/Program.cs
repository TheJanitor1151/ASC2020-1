using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASC1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World of C#!\n");
            string line=Console.ReadLine();

            int numarpant;
            try
            {
                //numarpant = int.Parse(line);
                int.TryParse(line, out numarpant);
                Console.WriteLine($"aveti {numarpant} numarul la pantof");
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            
        }
    }
}
