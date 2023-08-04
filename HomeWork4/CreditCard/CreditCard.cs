namespace HomeWork4.CreditCard
{
    public class CreditCard
    {
        //приватные поля
        private string cardNumber;
        private string cvcCode;
        private decimal balance;

        
        public CreditCard(string cardNumber, string cvcCode, decimal balance)
        {
            this.cardNumber = cardNumber;
            this.cvcCode = cvcCode;
            this.balance = balance;
        }
      
        public string CardNumber
        {
            get { return cardNumber; }
        }

        public string CvcCode
        {
            get { return cvcCode; }
        }

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public void IncreaseBalance(decimal amount)
        {
            balance += amount;
        }

        public void DecreaseBalance(decimal amount)
        {
            if (balance - amount >= 0)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Баланс не может быть меньше 0.");
            }
        }

        //перегрузка +
        public static CreditCard operator +(CreditCard card, decimal amount)
        {
            card.balance += amount;
            return card;
        }

        //перегрузка -
        public static CreditCard operator -(CreditCard card, decimal amount)
        {
            card.balance -= amount;
            return card;
        }

        //перегрузка ==
        public static bool operator ==(CreditCard card1, CreditCard card2)
        {
            if (ReferenceEquals(card1, null) && ReferenceEquals(card2, null))
                return true;
            if (ReferenceEquals(card1, null) || ReferenceEquals(card2, null))
                return false;

            return card1.CvcCode == card2.CvcCode;
        }

        //перегрузка !=
        public static bool operator !=(CreditCard card1, CreditCard card2)
        {
            return !(card1 == card2);
        }

        //перегрузка Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            CreditCard otherCard = (CreditCard)obj;
            return this.CvcCode == otherCard.CvcCode;
        }

        //перегрузка <
        public static bool operator <(CreditCard card1, CreditCard card2)
        {
            return card1.Balance < card2.Balance;
        }

        //перегрузка >
        public static bool operator >(CreditCard card1, CreditCard card2)
        {
            return card1.Balance > card2.Balance;
        }
    }
}
