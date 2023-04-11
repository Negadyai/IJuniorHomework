namespace HomeWork
{
    public class FourthHomework
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как вас зовут?");
            string name = Console.ReadLine();

            Console.WriteLine("Сколько вам лет?");
            string age = Console.ReadLine();

            Console.WriteLine("В каком городе вы живете?");
            string city = Console.ReadLine();

            Console.WriteLine("Какой у вас знак зодиака?");
            string zodiacSign = Console.ReadLine();

            Console.WriteLine($"Вас зовут {name}, вам {age} лет, вы живете в городе {city}, ваш знак зодиака {zodiacSign}.");
        }
    }
}
