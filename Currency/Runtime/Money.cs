namespace EscuelaIT.TDD.Currency.Runtime
{
    public class Money
    {
        protected int amount = 0;

        protected bool Equals(Dollar other)
        {
            Money o = other;
            return amount == o.amount;
        }
    }
}