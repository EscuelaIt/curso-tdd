using System.Collections.Generic;

namespace EscuelaIT.TDD.Roman.Runtime
{
    internal class RomanSymbol
    {
        readonly char symbol;

        public RomanSymbol(char symbol)
        {
            this.symbol = symbol;
        }

        public static Dictionary<char, int> Symbols =>
            new Dictionary<char, int>
            {
                { 'M', 1000 },
                { 'D', 500 },
                { 'C', 100 },
                { 'L', 50 },
                { 'X', 10 },
                { 'V', 5 },
                { 'I', 1 }
            };

        public static bool IsSymbol(char symbol)
        {
            return Symbols.ContainsKey(symbol);
        }
        
        public static implicit operator int(RomanSymbol rn)
        {
            return Symbols[rn.symbol];
        }
    }
}