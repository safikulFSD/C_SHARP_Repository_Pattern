using Ex._01.DI;
using Ex._01.Models;
using Ex._01.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestAll t = new TestAll();
            t.DisplayOptions();
            Console.ReadKey();           
        }
 
    }
}
