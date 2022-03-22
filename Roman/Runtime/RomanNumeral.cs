using System;
using System.Linq;

namespace EscuelaIT.TDD.Roman.Runtime
{
    public class RomanNumeral
    {
        internal readonly string symbols;
        
        public RomanNumeral(int number)
        {
            if(number < 1)
                throw new ArgumentOutOfRangeException();
        }

        public RomanNumeral(string symbols)
        {
            this.symbols = symbols;
        }

        public static implicit operator int(RomanNumeral rn)
        {
            return rn.symbols.Count(c => c == 'I');
        }
    }
}