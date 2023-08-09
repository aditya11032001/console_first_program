using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console1
{
    internal class Class1
    {
        String[] names = new string[4];
        public void inputData()
        {
            Console.WriteLine("enter members names:");
            for(int i = 0;i <4; i++)
            {
                Console.WriteLine("enter name of member{0}", (i + 1));
                names[i]=Console.ReadLine();
            }
        }
        public void showData()
        {
            Console.WriteLine("enter members names:");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("enter name of member{0} is {1}", (i + 1), names[i]);
            }
        }
    }
}
