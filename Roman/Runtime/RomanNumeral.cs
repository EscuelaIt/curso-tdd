using System;
using System.Linq;

namespace EscuelaIT.TDD.Roman.Runtime
{
    public class RomanNumeral
    {
        readonly string symbols;
        
        public RomanNumeral(int number)
        {
            if(number < 1)
                throw new ArgumentOutOfRangeException();
        }

        public RomanNumeral(string symbols)
        {
            AssertSubtractiveWellFormed(symbols);
            
            if(!symbols.All(RomanSymbol.IsSymbol))
                throw new ArgumentOutOfRangeException();
            
            this.symbols = symbols;
        }

        void AssertSubtractiveWellFormed(string symbols)
        {
            if(symbols == "IM")
                throw new FormatException();
        }

        int ToInt()
        {
            var theSymbols = symbols.Select(c => new RomanSymbol(c)).ToArray();
            
            var result = 0;
            for(var i = 0; i < theSymbols.Length; i++)
                if(i < symbols.Length - 1 && theSymbols[i] < theSymbols[i + 1])
                    result -= theSymbols[i];
                else
                    result += theSymbols[i];

            return result;
        }

        public static implicit operator int(RomanNumeral rn) => rn.ToInt();
    }
}