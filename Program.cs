using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("hello world");
            Class1 MCA = new Class1();
            MCA.inputData();
            MCA.showData();
            System.Console.ReadKey();
        }
    }
}
