using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace mother
{
    class Threads
    {
        string phrase;
        int repeats,
            delay;
        static int amount = 0;

        public static int comRepeats = 0;
        public Threads(string phrase, int repeats, int delay)
        {
            this.phrase = phrase;
            this.delay = delay;
            if (comRepeats > repeats)
                this.repeats = repeats;
            else
                this.repeats = comRepeats;
            amount += this.repeats;

        }

        public string Phrase { get { return phrase; } }
        public int Repeats { get { return repeats; } }
        public int Delay { get { return delay; } }
        public static int Amount { get { return amount; } }

    }
}
