using Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace TAiCBasicsProgrammingWork1
{
    public class Task1DataTypes
    {
        /// TODO:
        /// 1.1 Uncomment all 
        /// 1.2 Fill all missing data types below. Code must be compileable

       
        public  int a = 1;
        public  uint b = 2147483649;
        public  long c = -2147483650;
        public  float d = 5.5f;
        public  string e = "test";
        public  char f = 'p';
        public  DateTime g = ReturnMethods.ReturnCurrent();

        public  int h { get; set; }
        public  bool i { get; set; }
        public  object j { get; set; }

        public void Verify()
        {
            h = Guid.NewGuid().ToString().Length;
            i = Console.CapsLock;
            j = ReturnMethods.ReturnRandom();
        }
    }
}
