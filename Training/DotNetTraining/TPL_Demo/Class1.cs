using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPL_Demo
{
    internal class Class1
    {
        public void NonParellel()
        {
            // runs slower
            // does not library
            // i want to keep track. how much time it took to run the loop

            Stopwatch sw = new Stopwatch();
            sw.Start();// timer starts
            for (int i = 0; i < 16; i++)
            {
                // by default it uses single thread to do the job
                // by default it uses single processor to do the job
                Console.WriteLine("Non Parallel Method Running" + Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(1000);
            }
            sw.Stop();// timer ends
            Console.WriteLine("Total MilliSeconds took is " + sw.ElapsedMilliseconds);// 16 seconds
        }

        public void Parellel()
        {
            // runs faster
            // uses library

            Stopwatch sw = new Stopwatch();
            sw.Start();// timer starts
            Parallel.For(0, 16, i =>
            {
                Console.WriteLine("Parallel Method Running" + Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(1000);
            });

            sw.Stop();// timer ends
            Console.WriteLine("Total MilliSeconds took is " + sw.ElapsedMilliseconds);// 2seconds

            // 1. it uses multiple threads behind the scene
            //2. the loop broken into mutiple parts, each part runs simultenesouly from differet cors
            // 3. each part of the loop is called as task
            //4. internally it uses task class , to run simultenously
            //5. each task have its own thread 
            //6. task always uses threadpoool
            //7. threadpool is pool of threads already running the memory


            // realtime usage:
            // you have send a mail for 10000 people simulenously
            // you want to logging to database
            // send alerts or sms for many people simultenously

        }

        public async void TASKDEMO()
        {
            //job-1
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Method1 Called");
                    Thread.Sleep(1000);
                }
            });

            // await : is a simplified way to wait for task to be completed

            // job -2
            await Task.Run(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Method2 Called");
                    Thread.Sleep(1000);
                }

            });

            //Task.WaitAll(t1,t2);//dont continue with next line until t1 and t2 are done with job
            //Task.WaitAny(t1,t2);// continue next line , if any 1 task completed
            Console.WriteLine("Both The task Completed successfully");
        }
    
    }
}
