namespace EscuelaIT.TDD.Roman.Runtime
{
    internal class SuffixDecorator : IFizzBuzzFormatter
    {
        readonly string suffix;
        readonly IFizzBuzzFormatter decorated;

        public SuffixDecorator(IFizzBuzzFormatter decorated, string suffix)
        {
            this.suffix = suffix;
            this.decorated = decorated;
        }

        public string Format(int number)
        {
            var result = decorated.Format(number);

            if(!string.IsNullOrEmpty(result))
                result += suffix;
            
            return result;
        }
    }
}