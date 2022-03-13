namespace EscuelaIT.TDD.Roman.Runtime
{
    internal class UpperDecorator : IFizzBuzzFormatter
    {
        readonly IFizzBuzzFormatter decorated;

        public UpperDecorator(IFizzBuzzFormatter decorated)
        {
            this.decorated = decorated;
        }

        public string Format(int number)
        {
            return decorated.Format(number).ToUpper();
        }
    }
}