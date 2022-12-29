namespace Bank_Deposit
{
    public class BankOperation
    {
        public DateTime DateTime { get; }
        public int MoneyAmount { get; }
        public string OperationType { get; }
        public int CurrentBalance { get; set; }

        public BankOperation(DateTime time, int moneyAmount, string operationType)
        {
            DateTime = time;
            MoneyAmount = moneyAmount;
            OperationType = operationType;
        }

    }

}