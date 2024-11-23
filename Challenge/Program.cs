namespace Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const int windSpeedForCoat = 25;
            const int temperatureForCoat = 22;
            bool wearCoat = false;
            double temperature = 0;
            double windSpeed = 0;
            Console.WriteLine("Please Enter wind speed");

            windSpeed=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Enter temperature");
            temperature = Convert.ToDouble(Console.ReadLine());

            wearCoat = (windSpeed>windSpeedForCoat || temperature <temperatureForCoat);
            Console.WriteLine(wearCoat);
        }
    }
}
