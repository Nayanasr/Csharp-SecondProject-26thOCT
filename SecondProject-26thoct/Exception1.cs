using System;
using System.Collections.Generic;
using System.Text;

namespace SecondProject_26thoct
{
    internal class Exception1
    {
        public void ioException()
        {
            //making use of vebartrm literal

            //StreamReader srfile = new StreamReader(@"C:\Users\107012\OneDrive - ThoughtFocus\Documents\BACKEND.ASSIGNMENTS.txt");
            //Console.WriteLine(srfile.ReadToEnd());
            //srfile.Close();

            //in above-->if the file name is changed then the path is wrong
            //then shows an exception...then need to handle. the exception
            //always general exception must be at the last.

            //commented because it,s showing error which effect on other class
            //try
            //{
            //    StreamReader srfile = new StreamReader(@"C:\Users\107012\OneDrive - ThoughtFocus\Documents\BACKEND.ASSIGNMENTS.txt");

            //}
            //catch (FileNotFoundException e)
            //{
            //    Console.WriteLine("file not found-exception occured {0}", e.FileName);
            //}

            //commented because it,s showing error which effect on other class
            //generalised exception
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("finally block");
            //}
            //Errors are because of company laptop
        }
    }
}
