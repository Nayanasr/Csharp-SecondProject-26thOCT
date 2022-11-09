using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    internal class ExceptionEncapsulation
    {
        private string name;
        public string setName(string a)
        {
            if (name == "")
            {
                throw new ArgumentException("Name cannot be null");
            }
            else
            {
                name = a;
                Console.WriteLine("name is {0}", name);
                return name;
            }
        }
        public string getName()
        {
            return name;
        }
    }
}