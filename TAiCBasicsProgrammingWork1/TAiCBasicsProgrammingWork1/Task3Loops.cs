using System;
using System.Collections.Generic;
using System.Text;

namespace TAiCBasicsProgrammingWork1
{
    public class Task3Loops
    {
        public void Verify()
        {
            Console.WriteLine("=================================== Task 3.1:");
            /// TODO task 3.1:
            /// - Uncomment below
            /// - Write missing code: Print numbers from 1 to 10
            /// - code must be compileable and runnable
            /// - To verify if results are OK, run code;


            for (int i=1; i<=10; i++)
            {
                Console.WriteLine($"This is number: {i}");
            }
            

            ///-----------------------------------------------------------------------------------------------------

            Console.WriteLine("=================================== Task 3.2:");
            /// TODO task 3.2:
            /// - Uncomment below
            /// - Write missing code: Print numbers from 9 to 1
            /// - code must be compileable and runnable
            /// - To verify if results are OK, run code;

            
            int counter = 9;
            while (counter >= 1)
            {
                Console.WriteLine($"Number: {counter}");
                counter--;
            }
            

            ///-----------------------------------------------------------------------------------------------------

            Console.WriteLine("=================================== Task 3.3:");
            /// TODO task 3.3:
            /// - Write code: Print even numbers from 0 to 20;
            /// - code must be compileable and runnable
            /// - To verify if results are OK, run code;

            int even = 0;
            do
            {
                Console.WriteLine($"This is number: {even}");
                even += 2;
            }
            while (even <= 20);
        }
    }
}
