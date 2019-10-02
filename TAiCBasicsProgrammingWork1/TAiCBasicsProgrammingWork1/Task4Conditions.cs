using System;
using System.Collections.Generic;
using System.Text;

namespace TAiCBasicsProgrammingWork1
{
    public class Task4Conditions
    {
        public void Verify()
        {
            Console.WriteLine("=================================== Task 4.1:");
            /// TODO task 4.1:
            /// - Uncomment below
            /// - Write missing code to show message: Yes, there're 100 persons
            /// - code must be compileable and runnable
            /// - To verify if results are OK, run code;
            
            
            int persons = 100;

            if (persons != 100)
            {
                Console.WriteLine("No, there's no 100 persons");
            }
            else
            {
                Console.WriteLine("Yes, there're 100 persons");
            }
            
            ///-----------------------------------------------------------------------------------------------------

            Console.WriteLine("=================================== Task 4.2:");
            /// TODO task 4.2:
            /// - Uncomment below
            /// - Write missing code: If integer 'howMuch' is 3, print value "Three". If 2, print "Two". If 1, print "One". If different, print "Undefined"
            /// - Use Switch only
            /// - code must be compileable and runnable
            /// - To verify if results are OK, run code;


            int howMuch = 3;

            switch (howMuch)
            {
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                default:
                    Console.WriteLine("Undefined");
                    break;
            }
        }
    }
}
