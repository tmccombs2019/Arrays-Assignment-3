 // Date 1/29/2019
 // Tracey McCombs
 // This C# console will demonstrate the execution of arrays with no input from user

 
using System;

namespace Arrays_Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {

            //declaring the array
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
            
            //the following try catch block will execute a manually populated array that is of size 25 elements
            try
            {
                
                Console.WriteLine("");
                Console.WriteLine("First, let's manually populate an array with integers.");

                Console.WriteLine("Then, let's iterate through the elements in the array with a foreach loop");

                //Iterate through the array with a foreach loop

                foreach (int i in numbers)
                {
                    Console.WriteLine("Element Value = {0}", + i);
                }//end of foreach

                Console.WriteLine("");
                Console.WriteLine("________________________________________________");
                Console.WriteLine("Press any key to exit the program...");

                // Pause the program and wait for user to press any key to exit the program 
                Console.ReadKey(true);
                          
                                         
                }//end of try
            
            catch
            {
                Console.WriteLine("Please press any key to exit the program and try again...");
                Console.ReadKey(true);
            }// end of catch
        }// end of main
    }// end of class
}//end of namespace
