namespace MidExaminatin1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int total = 0;

            for (int i = 0; i < 10; i++)
            {
                total = total + numbers[i];

            }
            double average = total / 10;
            Console.WriteLine("total = " + total);
            Console.WriteLine("average = " + average);
        }
    }
}
