namespace Bank_Deposit
{
    public class FileReader
    {
        public BankAccount StructureData(string[] input)
        {
            int balance = int.Parse(input[0]);
            BankOperation[] operations = new BankOperation[input.Length - 1];
            for (int i = 1; i < input.Length; i++)
            {
                DateTime dateTime = GetDateTime(input[i].Split(" | ")[0]);
                int moneyAmount = 0;
                string operationType = "";
                if (input[i].Contains("revert"))
                {
                    moneyAmount = 0;
                    operationType = input[i].Split(" | ")[1];
                }
                else
                {
                    moneyAmount = int.Parse(input[i].Split(" | ")[1]);
                    operationType = input[i].Split(" | ")[2];
                }
                operations[i - 1] = new BankOperation(dateTime, moneyAmount, operationType);
            }
            Sort(operations, new DateTimeComparer());
            return new BankAccount(balance, operations);
        }


        private DateTime GetDateTime(string input)
        {
            string date = input.Split(' ')[0];
            int year = int.Parse(date.Split('-')[0]);
            int month = int.Parse(date.Split('-')[1]);
            int day = int.Parse(date.Split('-')[2]);
            string time = input.Split(' ')[1];
            int hours = int.Parse(time.Split(':')[0]);
            int minutes = int.Parse(time.Split(':')[1]);
            DateTime dateTime = new DateTime(year, month, day, hours, minutes, 0);
            return dateTime;
        }

        private static void Sort(Array array, DateTimeComparer comparer)
        {
            for (int i = array.Length - 1; i > 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    object element1 = array.GetValue(j - 1);
                    object element2 = array.GetValue(j);
                    if (comparer.Compare(element1, element2) < 0)
                    {
                        object temporary = array.GetValue(j);
                        array.SetValue(array.GetValue(j - 1), j);
                        array.SetValue(temporary, j - 1);
                    }

                }

            }

        }

    }

}