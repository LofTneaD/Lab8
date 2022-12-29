namespace Bank_Deposit
{
    public class BankAccount
    {
        public int Balance { get; private set; }
        public BankOperation[] OperationHistory { get; }

        public BankAccount(int balance, BankOperation[] operationHistory)
        {
            Balance = balance;
            OperationHistory = operationHistory;
        }

        public bool CheckHistory()
        {
            for (int i = 0; i < OperationHistory.Length; i++)
            {
                if (OperationHistory[i].OperationType == "in")
                    Balance += OperationHistory[i].MoneyAmount;
                else if (OperationHistory[i].OperationType == "out")
                    Balance -= OperationHistory[i].MoneyAmount;
                else if (OperationHistory[i].OperationType == "revert")
                {
                    if (OperationHistory[i - 1].OperationType == "in")
                        Balance -= OperationHistory[i - 1].MoneyAmount;
                    else if (OperationHistory[i - 1].OperationType == "out")
                        Balance += OperationHistory[i - 1].MoneyAmount;
                }
                OperationHistory[i].CurrentBalance = Balance;
            }

            if (Balance < 0) return false;
            return true;
        }

    }

}