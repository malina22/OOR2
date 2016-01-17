using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadStart testThread1Start = new ThreadStart(new Program().testThread1);
            ThreadStart testThread2Start = new ThreadStart(new Program().testThread2);

            Thread[] testThread = new Thread[2];
            testThread[0] = new Thread(testThread1Start);
            testThread[1] = new Thread(testThread2Start);

            foreach (Thread myThread in testThread)
            {
                myThread.Start();
            }

            Console.ReadLine();
        }

        public void testThread1()
        {
            //executing in thread
            int count = 0;
            while (count++ < 10)
            {
                Console.WriteLine("Thread 1 Executed " + count + " times");
                Thread.Sleep(1);
            }
        }

        public void testThread2()
        {
            //executing in thread
            int count = 0;
            while (count++ < 10)
            {
                Console.WriteLine("Thread 2 Executed " + count + " times");
                Thread.Sleep(1);
            }
        }
    }
}
