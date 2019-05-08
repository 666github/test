using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入用户名和ID");
            string name = Console.ReadLine();
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("User Name is {0} \nThe id is {1}", name, id);
            Console.ReadKey();
        }
    }
}
}
