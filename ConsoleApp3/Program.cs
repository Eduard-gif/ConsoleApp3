namespace Homework_02._11._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your 4 numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            int num4 = Convert.ToInt32(Console.ReadLine());
            num1 = num1 * 1000;
            num2 = num2 * 100;
            num3 = num3 * 10;
            num4 = num4 * 1;
            Console.WriteLine(num1 + num2 + num3 + num4);



        }
    }
}