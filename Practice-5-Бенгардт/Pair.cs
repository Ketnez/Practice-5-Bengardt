using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_5_Бенгардт
{
    class Pair
    {

        public int First { get; private set; }
        public int Second { get; private set; }

        public Pair(int first, int second)
        {
            First = first;
            Second = second;
        }

        public bool IsEuqual() => First == Second;

        public long Multiply() => First * Second;

        public Pair Substract(Pair subtrahend) => new Pair(First - subtrahend.First, Second - subtrahend.Second);

        public Pair Substract(Pair subtrahend1, Pair subtrahend2) => new Pair(First - subtrahend1.First - subtrahend2.First,
                Second - subtrahend1.Second - subtrahend2.Second);
    }
}
