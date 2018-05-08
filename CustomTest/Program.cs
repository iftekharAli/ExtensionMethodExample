using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethodExample;


namespace CustomTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ExtensionMethodCustom onj = new ExtensionMethodCustom();
        }
    }
    public static class xx
    {
        public static void Test3(this ExtensionMethodCustom obj)
        {
            Console.WriteLine("i am test3");
        }
    }
}
