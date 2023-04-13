namespace Homework
{
    public class SixthHomework
    {
        static void Main(string[] args)
        {
            int photos = 52;
            int amoutPhohotosInRow = 3;

            int rowAmount = photos / amoutPhohotosInRow;
            int leftoverPhotos = photos % amoutPhohotosInRow;

            Console.WriteLine($"Количество рядов: {rowAmount}");
            Console.WriteLine($"Картинок сверхмеры: {leftoverPhotos}");
        }
    }
}