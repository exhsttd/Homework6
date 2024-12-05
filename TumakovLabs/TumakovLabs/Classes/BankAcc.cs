namespace TumakovLabs.TumakovLabs.Classes;
   public class BankAcc
{
        // Упражнение 7.1 Создать класс счет в банке с закрытыми полями: номер счета, баланс, тип
        // банковского счета.
        public enum Type
        {
            Сберегательный,
            Текущий
        }

        public class Account
        {
            private static int account;
            private string checkNum;
            private decimal balance;
            private Type type;

            public Account(decimal balance1, Type checkType)
            {
                account++;
                this.checkNum = account.ToString("D5");
                this.balance = balance1;
                this.type = checkType;
            }

            public void GetAccountDetails()
            {
                Console.WriteLine($"Номер счета: {checkNum}");
                Console.WriteLine($"Баланс: {balance}");
                Console.WriteLine($"Тип банковского счета: {type}");
            }

            public void Money(decimal amount)
            {
                if (amount > 0)
                {
                    balance += amount;
                    Console.WriteLine($"На счет c номером {checkNum} положено {amount}. Текущий баланс: {balance}");
                }
                else
                {
                    Console.WriteLine("Сумма пополнения должна быть больше нуля.");
                }
            }

            public void Drop(decimal amount)
            {
                if (amount > 0 && amount <= balance)
                {
                    balance -= amount;
                    Console.WriteLine($"Со счета с номером {checkNum} снято {amount}. Текущий баланс: {balance}");
                }
                else if (amount > balance)
                {
                    Console.WriteLine("Недостаточно средств для снятия суммы");
                }
                else
                {
                    Console.WriteLine("Сумма снятия должна быть больше нуля!!!");
                }
            }
        }
    
}


