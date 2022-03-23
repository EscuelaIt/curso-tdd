namespace EscuelaIT.TDD.FizzBuzz.Runtime
{
    public static class NumberExtensions
    {
        public static bool IsMultipleOf(this int number, int divisor)
        {
            return number % divisor == 0;
        }
    }
}