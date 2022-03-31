using System;

namespace EscuelaIT.TDD.Week.Runtime
{
    public interface IRandomGenerator
    {
        int Next(int minInc, int maxExc);
    }

    class SystemRandomAdapter : IRandomGenerator
    {
        readonly Random adaptee = new Random();
        
        public int Next(int minInc, int maxExc)
        {
            return minInc > maxExc ? adaptee.Next(maxExc, minInc) : adaptee.Next(minInc, maxExc);
        }
    }

    class UnityRandomAdapter : IRandomGenerator
    {
        public int Next(int minInc, int maxExc)
        {
            return UnityEngine.Random.Range(minInc, maxExc);
        }
    }
}