using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HalloTPL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Hallo TPL ***");

            //Parallel.Invoke(Zähle, Zähle, Zähle, Zähle, Zähle);
            //Parallel.For(0, 1000000, i => Console.WriteLine($"[{Thread.CurrentThread.ManagedThreadId}]: {i}"));


            Task t1 = new Task(() =>
            {
                Console.WriteLine("T1 gestartet");

                //throw new EncoderFallbackException();
                Thread.Sleep(800);
            });

            var t1c = t1.ContinueWith(t =>
            {
                Console.WriteLine("T1 fertig");
            });

            var t1err = t1.ContinueWith(t =>
            {
                Console.WriteLine($"T1 ERROR {t.Exception.InnerException.Message}");
            }, TaskContinuationOptions.OnlyOnFaulted);

            var t1ok = t1.ContinueWith(t =>
            {
                Console.WriteLine($"T1 OK");
            }, TaskContinuationOptions.OnlyOnRanToCompletion);


            Task<long> t2 = new Task<long>(() =>
            {
                Console.WriteLine("T2 gestartet");
                Thread.Sleep(600);
                Console.WriteLine("T2 fertig");
                return 9849846546543;
            });



            t1.Start();
            t2.Start();


            Console.WriteLine($"Result t2: {t2.Result}");

            Console.WriteLine("Ende");
            Console.ReadLine();
        }

        private static void Zähle()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"[{Thread.CurrentThread.ManagedThreadId}]: {i}");
            }
        }
    }
}
