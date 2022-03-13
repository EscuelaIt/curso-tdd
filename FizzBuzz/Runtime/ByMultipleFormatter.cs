namespace EscuelaIT.TDD.Roman.Runtime
{
    internal class ByMultipleFormatter : IFizzBuzzFormatter
    {
        readonly int divisor;
        readonly string toFormat;

        public ByMultipleFormatter(int divisor, string toFormat)
        {
            this.divisor = divisor;
            this.toFormat = toFormat;
        }

        public string Format(int number)
        {
            return number.IsMultipleOf(divisor)
                ? toFormat
                : string.Empty;
        }
    }
}