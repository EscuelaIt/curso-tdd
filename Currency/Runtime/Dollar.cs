namespace EscuelaIT.TDD.Currency.Runtime
{
    public class Dollar : Money
    {
        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public Dollar Times(int times)
        {
            return new Dollar(amount * times);
        }
    }
}

//varias multiplicaciones
//dollar es value object
//no queremos exponer amount
//queremos euros
