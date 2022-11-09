using System;
using System.Collections.Generic;
using System.Text;

namespace SecondProject_26thoct
{
    //exception is the one which effects the execution flow.
    //avoids the execution flow crash when exception handler is called.

    //exception can be handled by using system.Exception class.
    //system.Application Exception and System.systemException.

    //system exceptions come from the system.exception class.
    //we can also custom our exceptions while coding.

    //when we are creating the custom exceptions we should be aware of the 
    //4 key words-->try,catch,finally,throw.

    //try-->Holds the code which may throw an exception.
    //catch-->Code which will handle exception thrown by try block.
    //finally-->Default code(it will executes finally whether there is an exception or not)
    //throw-->Throws an exception manually.
    internal class Exceptions
    {
        string[] names = new string[] { "avi", "akshata", "namana", "Nayana" };

        public void ThrowException()
        {
            //Console.WriteLine(names[5]);
            //Console.WriteLine(names[2]);
            
            try
            {
                Console.WriteLine(names[5]);
            }
            //Index out of range exception
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("There Was An Exception Occured");
                Console.WriteLine(names[2]);
            }
            //Null reference exception
            //catch (NullReferenceException)
            //{
            //    Console.WriteLine("There was an exception Null Reference Exception");
            //}


            //finally
            //{
            //    Console.WriteLine("An Exception Occured");

            //    Console.WriteLine(names[2]);
            //}
        }
    }
}
