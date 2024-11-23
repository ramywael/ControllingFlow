namespace Sessionn2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int upper=20,lower = 10,num=0;
            Console.WriteLine($"Enter an intger the bounds are {lower} and {upper} :");
            num=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((num >= lower && num <= upper));



        }
    }
}
