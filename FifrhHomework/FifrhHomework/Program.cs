namespace Homework
{
    public class FifrhHomeWork
    {
        static void Main(string[] args)
        {
            string name = "Ivanov";
            string surname = "Maxim";

            Console.WriteLine($"{name} {surname}");

            (name, surname) = (surname, name);

            Console.WriteLine($"{name} {surname}");
        }
    }
}
