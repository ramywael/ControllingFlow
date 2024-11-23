namespace Challenge3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i= 0; i <= 15; i++){
                if(i % 2 != 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
