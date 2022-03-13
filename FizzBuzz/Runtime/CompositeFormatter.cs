using System.Collections.Generic;
using System.Linq;

namespace EscuelaIT.TDD.Roman.Runtime
{
    class CompositeFormatter : IFizzBuzzFormatter
    {
        IEnumerable<IFizzBuzzFormatter> OrderedFormatters { get; }
        
        public CompositeFormatter(IEnumerable<IFizzBuzzFormatter> components)
        {
            OrderedFormatters = components;
        }
        
        public string Format(int number)
        {
            return OrderedFormatters.Aggregate
            (
                string.Empty, (s, format) => s + format.Format(number)
            );
        }
    }
}