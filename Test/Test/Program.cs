﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int a = 10;
            changenumber(ref a);

            Console.WriteLine(a);
            Console.ReadLine();        
        }

        static void changenumber(ref int a)
        {
            a = 23;
        }
    }
}
