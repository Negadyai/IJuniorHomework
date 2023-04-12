namespace Homework
{
    public class SixthHomework
    {
        static void Main(string[] args)
        {
            int maxAmountOfPhotos = 52;
            int currentAmountOfPhotos = 0;
            int amoutPhohotosInRow = 3;

            int rowCounter = 0;

            for (int i = 0; i < maxAmountOfPhotos; i++)
            {
                currentAmountOfPhotos++;
                if (currentAmountOfPhotos == amoutPhohotosInRow)
                {
                    rowCounter++;
                    currentAmountOfPhotos = 0;
                }
            }

            Console.WriteLine(rowCounter);
            Console.WriteLine($"Картинок сверхмеры: {maxAmountOfPhotos - rowCounter * amoutPhohotosInRow}");
        }
    }
}