using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            names.Add("Dalton");
            names.Add("Emily");
            names.Add("Kayci");
            
            /* standard for loop
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }
            */

            foreach (var currName in names)
            {
                Console.WriteLine(currName);
            }


            Computer myDesktop = new Computer();
            myDesktop.brand = "ASUS";
            myDesktop.CPUCores = 4;
            myDesktop.CPUSpeed = 3.9;
            myDesktop.HardDriveSize = 1280;
            myDesktop.IsOverClocked = true;

            Console.WriteLine(myDesktop.brand);


            Console.ReadKey();
        }

        static void Concat(string wordOne, string wordTwo)
        {
            Console.WriteLine(wordOne + wordTwo);
        }
    }
}
