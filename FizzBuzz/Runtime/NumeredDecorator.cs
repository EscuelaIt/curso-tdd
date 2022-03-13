namespace EscuelaIT.TDD.Roman.Runtime
{
    class NumeredDecorator : IFizzBuzzFormatter
    {
        readonly IFizzBuzzFormatter decorated;

        public NumeredDecorator(IFizzBuzzFormatter decorated)
        {
            this.decorated = decorated;
        }

        public string Format(int number)
        {
            var result = decorated.Format(number);

            return !string.IsNullOrEmpty(result)
                ? number.ToString()
                : result;
        }
    }
}