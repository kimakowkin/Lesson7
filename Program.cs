namespace Lesson7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreditCard card1 = new CreditCard("101", 12433.5);
            CreditCard card2 = new CreditCard("102", 12433.5);
            CreditCard card3 = new CreditCard("103", 12433.5);

            // Тестовый сценарий для проверки:
            // Положите деньги на первые две карточки и снимите с третьей.
            // Выведите на экран текущее состояние всех трех карточек.

            card1.Deposit(500);
            card2.Deposit(1233);
            card3.Withdraw(13000);

            // Тестовый сценарий для проверки:
            // создать объект "компьютер 1" с помощью первого конструктора и
            // вывести информацию на экран;
            // создать объект "компьютер 2" с помощью второго конструктора и
            // вывести информацию на экран.

            card1.PrintInfo();
            card2.PrintInfo();
            card3.PrintInfo();

            ComputerClass computer1 = new ComputerClass(50000, "AlienWare");
            computer1.PrintInfo();

            ComputerClass computer2 = new ComputerClass(20000, "HP", new RAM(), new HDD());
            computer2.PrintInfo();

        }
    }
}