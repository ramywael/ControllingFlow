namespace Shipping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length =0, width=0, height = 0, volume=0;
            int smallPackage = 100;
            int largePackage = 500;
            double totalPrice = 0;
            double bestCase = 2.50;
            Console.WriteLine("Please Enter Your Length,Width,Height");
            length=Convert.ToInt32(Console.ReadLine());
            width=Convert.ToInt32(Console.ReadLine());
            height=Convert.ToInt32(Console.ReadLine());
            volume= height *length * width;
            if (volume > smallPackage)
            {
                totalPrice = bestCase * 1.01;
            }
            else if (volume > largePackage)
            {
                totalPrice = bestCase * 1.25;

            }
            else
            {
                totalPrice = bestCase;
            }

            Console.WriteLine(totalPrice);


            }
        }
    }
