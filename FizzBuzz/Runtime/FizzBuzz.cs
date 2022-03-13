using System.Collections.Generic;

namespace EscuelaIT.TDD.Roman.Runtime
{
    public class FizzBuzz
    {
        IFizzBuzzFormatter Formatter { get; }

        public FizzBuzz()
        {
            var composite = new CompositeFormatter(new List<IFizzBuzzFormatter>
            {
                new ByMultipleFormatter(3, "Fizz"),
                new ByMultipleFormatter(5, "Buzz")
            });
            
            Formatter = new NumeredDecorator(new UpperDecorator(new SuffixDecorator(composite, "!")));
        }

        internal string Of(int number)
        {
            return Formatter.Format(number);
        }

        public string UpTo(int number)
        {
            return string.Join(", ", Sequence(number));
        }

        IEnumerable<string> Sequence(int number)
        {
            var result = new List<string>();
            
            for(var i = 1; i <= number; i++)
                result.Add(Of(i));

            return result;
        }
    }
}