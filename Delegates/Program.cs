using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Program
    {
        public delegate int Operation(int x, int y);
        public static int Add(int x, int y)
        {
            return x + y;

        }
        static void Main(string[] args)
        {
            Operation myobj = new Operation(Add);
            int ans=myobj.Invoke(30,40);
            Console.WriteLine(ans);
           
        }
    }
}
