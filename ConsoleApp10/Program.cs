using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main()
        {
            string[] stringArray = new string[5] {"First", "Second", "Third", "Fourth", "Fifth" };
            int[] intArray = new int[3] { 1, 2, 3 };

            List<string> stringList = new List<string>();
            stringList.Add("I did not hit her, I did not");
            stringList.Add("Oh hi Mark");
            stringList.Add("So anyways, how is your sex life?");

            int x;
            string holder;

            Console.WriteLine("Select for your string array. 0 - 4");
            holder = Console.ReadLine();
            x = Convert.ToInt32(holder);
            Console.WriteLine(stringArray[x]);

            Console.WriteLine("Select for your int array. 0 - 2");
            holder = Console.ReadLine();
            x = Convert.ToInt32(holder);
            Console.WriteLine(intArray[x]);

            Console.WriteLine("Select for your string list. 0 - 2");
            holder = Console.ReadLine();
            x = Convert.ToInt32(holder);
            Console.WriteLine( stringList[x]);

            Console.ReadLine();



        }
    }
}
