using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
       
        public static void Main(string[] args)
        {
            Parallel.For(1, 10, MyAction);
            Console.WriteLine("finished");
            Console.ReadLine();

        }

        public  static void MyAction(int obj,ParallelLoopState  state)
        {
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(obj);

            ParallelLoopResult a = new ParallelLoopResult();
          
        }
    }
}
