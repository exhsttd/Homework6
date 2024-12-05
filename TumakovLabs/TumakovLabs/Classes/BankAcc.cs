namespace TumakovLabs.TumakovLabs.Classes;
 public class BankAcc
 {
  // Упражнение 7.1 Упражнение 7.1 Создать класс счет в банке с закрытыми полями: номер счета, баланс, тип
  //банковского счета (использовать перечислимый тип из упр. 3.1). Предусмотреть методы для
  // доступа к данным – заполнения и чтения. Создать объект класса, заполнить его поля и
  // вывести информацию об объекте класса на печать.
   public enum Type
   {
    Сберегательный,
    Текущий
   }

   public class Account
   {
   // Упражнение 7.2 Изменить класс счет в банке из упражнения 7.1 таким образом, чтобы
   // номер счета генерировался сам и был уникальным.
    private static int account;
    private string checkNum; 
    private decimal balance;
    private Type type;

    public Account(decimal balance1, Type checkType)
    {
      account++; // "..метод, который увеличивает значение этого переменной."
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
        // Упражнение 7.3 Добавить в класс счет в банке два метода: снять со счета и положить на счет.
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
        // Метод снять со счета проверяет, возможно ли снять запрашиваемую сумму:
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


