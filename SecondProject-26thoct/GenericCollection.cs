using System;
using System.Collections.Generic;
using System.Text;

namespace SecondProject_26thoct
{
    internal class GenericCollection
    {
        public void test()
        {
            //methods in the list are list.Add() list.Contains(),list.Remove(),list.Reverse(),list.FindAll()
            //declaration of the list
            var evenNumbers = new List<string>();

            //accessing the values
            evenNumbers.Add("Charlie");
            evenNumbers.Add("Bruno");
            evenNumbers.Add("Husky");
            evenNumbers.Add("Blacky");
            evenNumbers.Add("Puppy");
            evenNumbers.Add("Shadow");

            //fetching the values
            for(int i=0; i < evenNumbers.Count; i++)
            {
                Console.WriteLine(evenNumbers[i]);
            }

            foreach(string names in evenNumbers)
            {
                Console.WriteLine(names);
            }

            //Dictionary
            //dictionary is collection of key and value type
            //Add(), Remove(), TryAdd(), ContainsKey(), ContainsValue(), Dictionary.keys
            Dictionary<string, int> evenNumbers3 = new Dictionary<string, int>();

            //accessing the values
            evenNumbers3.Add("Lion", 1);
            evenNumbers3.Add("Tiger", 2);
            evenNumbers3.Add("Chetah", 3);
            evenNumbers3.Add("Monkey", 4);
            evenNumbers3.Add("Elephant", 5);

            //fetching the values
            Console.WriteLine(evenNumbers3.)


        }
    }
}
