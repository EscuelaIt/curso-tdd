namespace EscuelaIT.TDD.Currency.Runtime
{
    public class Euro
    {
        readonly int amount;
        
        public Euro(int amount)
        {
            this.amount = amount;
        }

        public Euro Times(int times)
        {
            return new Euro(times * amount);
        }

        protected bool Equals(Euro other)
        {
            return amount == other.amount;
        }

        public override bool Equals(object obj)
        {
            if(ReferenceEquals(null, obj)) return false;
            if(ReferenceEquals(this, obj)) return true;
            if(obj.GetType() != this.GetType()) return false;
            return Equals((Euro)obj);
        }

        public override int GetHashCode()
        {
            return amount;
        }

        public static bool operator ==(Euro left, Euro right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Euro left, Euro right)
        {
            return !Equals(left, right);
        }
    }
}