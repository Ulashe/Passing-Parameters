using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingParameters
{
    class Program
    {
        public void ByValue(int x)
        {
            x = 5;
        }
        public void ByReference(ref int x)
        {
            x = 10;
        }
        public void ByOutput(out int x)
        {
            x = 20;
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            int x = 1;
            Console.WriteLine("Default value of \tx: \t{0}", x);
            obj.ByValue(x);
            Console.WriteLine("After value method \tx: \t{0}",x); // The value of x did not change
            obj.ByReference(ref x);
            Console.WriteLine("After reference method \tx: \t{0}", x); // The value of x changed
            obj.ByOutput(out x);
            Console.WriteLine("After output method \tx: \t{0}", x); // The value of x changed
            // More than one value can be returned from a function via passing parameters by Output
            Console.ReadLine();
        }
    }
}
