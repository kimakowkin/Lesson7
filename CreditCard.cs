namespace Lesson7
{
    // Создать класс CreditCard c полями номер счета, текущая сумма на счету.
    // Добавьте метод, который позволяет начислять сумму на кредитную карточку.
    // Добавьте метод, который позволяет снимать с карточки некоторую сумму.
    // Добавьте метод, который выводит текущую информацию о карточке.
    // Напишите программу, которая создает три объекта класса CreditCard у
    // которых заданы номер счета и начальная сумма

    internal class CreditCard
    {
        internal string AccountNumber { get; set; }
        internal double AccountSum { get; set; }

        internal CreditCard(string accountNumber, double accountSum)
        {
            AccountNumber = accountNumber;
            AccountSum = accountSum;
        }

        internal void Deposit(double Sum)
        {
            AccountSum += Sum;
        }

        internal void Withdraw(double Sum)
        {
            if (AccountSum >= Sum)
            {
                AccountSum -= Sum;
            }
            else
            {
                Console.WriteLine($"Не удалось снять деньги со счёта {AccountNumber}\nНедостаточно средств на счёте");
                Console.ReadKey();
                Console.Clear();
            }
        }

        internal void PrintInfo()
        {
            Console.WriteLine($"Номер счёта: \n{AccountNumber} \nОстаток на счету: \n{AccountSum}");
        }
    }
}
