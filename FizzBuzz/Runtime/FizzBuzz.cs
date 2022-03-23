using System.Collections.Generic;
using System.Linq;
using EscuelaIT.TDD.FizzBuzz.Runtime;

namespace System
{

    public static class FizzBuzz
    {
        static Dictionary<int, string> Formats => new Dictionary<int, string>
        {
            { 3, "Fizz" },
            { 5, "Buzz" }
        };

        public static string Of(int number)
        {
            var result = Formats
                .Where(pair => number.IsMultipleOf(pair.Key))
                .Aggregate(string.Empty, (current, pair) => current + pair.Value);
            
            return result.Any() ? result : number.ToString();
        }
    }
}