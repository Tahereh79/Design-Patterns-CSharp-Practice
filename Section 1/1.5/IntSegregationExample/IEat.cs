using System;
using System.Collections.Generic;
using System.Text;

namespace IntSegregationExample
{
    // Old "fat" interface — violates ISP because not all birds can fly
    public interface IBirdOld
    {
        void Eat(string food);
        void Walk(int distance);
        void Fly(int distance, int altitude);
    }
}
