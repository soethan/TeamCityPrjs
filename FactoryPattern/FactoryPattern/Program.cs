using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("test");
            var child = new Child();
            Console.Read();
        }
    }

    public class Parent
    {
        private string strParent = "aaa";
        public Parent()
        {
            Console.WriteLine("Parent Constructor");
        }
    }
    public class Child : Parent
    {
        private string strChild = "bbb";
        public Child():this("haha")
        {
            Console.WriteLine("Child Constructor");
        }
        public Child(string param1)
        {
            Console.WriteLine("Child Constructor 2 " + param1);
        }
    }
}
