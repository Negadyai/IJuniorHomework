namespace Homework
{
    public class SixthHomework
    {
        static void Main(string[] args)
        {
            int photos = 52;
            int amountPhohotosInRow = 3;

            int rowAmount = photos / amountPhohotosInRow;
            int leftoverPhotos = photos % amountPhohotosInRow;

            Console.WriteLine($"Количество рядов: {rowAmount}");
            Console.WriteLine($"Картинок сверхмеры: {leftoverPhotos}");
        }
    }
}