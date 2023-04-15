namespace Homework
{
    public class SixthHomework
    {
        static void Main(string[] args)
        {
            int photos = 52;
            int amountPhohotosInRow = 3;

            int amountFilledRows = photos / amountPhohotosInRow;
            int leftoverPhotos = photos % amountPhohotosInRow;

            Console.WriteLine($"Количество рядов: {amountFilledRows}");
            Console.WriteLine($"Картинок сверхмеры: {leftoverPhotos}");
        }
    }
}