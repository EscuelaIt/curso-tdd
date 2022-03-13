namespace EscuelaIT.TDD.Roman.Runtime
{
    public static class NumericExtensions
    {
        public static bool IsMultipleOf(this int number, int divisor)
        {
            return number % divisor == 0;
        }
    }
}