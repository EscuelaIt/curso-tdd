namespace EscuelaIT.TDD.Currency.Runtime
{
    public sealed class Money
    {
        readonly int amount = 0;
        readonly string currency;

        protected Money(int amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public Money Times(int times)
        {
            return new Money(amount * times, currency);
        }

        public static Money Dollar(int amount)
        {
            return new Money(amount, "USD");
        }

        public static Money Euro(int amount)
        {
            return new Money(amount, "EUR");
        }

        bool Equals(Money other)
        {
            return amount == other.amount && currency == other.currency;
        }

        public override bool Equals(object obj)
        {
            return ReferenceEquals(this, obj) || obj is Money other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (amount * 397) ^ (currency != null ? currency.GetHashCode() : 0);
            }
        }

        public static bool operator ==(Money left, Money right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Money left, Money right)
        {
            return !Equals(left, right);
        }
    }
}