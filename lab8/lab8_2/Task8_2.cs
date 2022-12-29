using System;

namespace Bank_Deposit
{
    class Task8_2
    {
        public static void Run()
        {
            string[] userInput = File.ReadAllLines("input.txt");
            FileReader fileReader = new();
            BankAccount account = fileReader.StructureData(userInput);
            Display display = new();
            display.BeginWork(account);

            Console.ReadKey();
        }

    }

}