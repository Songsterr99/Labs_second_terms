using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace mother
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Say);
            Threads.comRepeats = 5;
            t1.Start(new Threads("Hello", 2, 2000));
            Thread t2 = new Thread(Say);
            t2.Start(new Threads("Mother", 30, 3000));
            Thread t3 = new Thread(Say);
            t3.Start(new Threads("Sleep", 10, 2500));
            Console.WriteLine("Amount of messages: {0}", Threads.Amount);
            Console.ReadKey();
        }

        public static void Say(object ob)
        {
            for (int i = 0; i < (ob as Threads).Repeats; i++)
            {
                Thread.Sleep((ob as Threads).Delay);
                Console.Write((ob as Threads).Phrase + " ");
            }

        }
    }
}
