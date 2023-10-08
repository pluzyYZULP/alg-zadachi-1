namespace dz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(1);
            int fufel = Convert.ToInt32(Console.ReadLine());
            Console.Write(2);
            int fufel1 = Convert.ToInt32(Console.ReadLine());
            Console.Write(3);
            int fufel2 = Convert.ToInt32(Console.ReadLine());
            Console.Write(4);
            int fufel3 = Convert.ToInt32(Console.ReadLine());   
            int pipka = fufel + fufel1 + fufel2 + fufel3;
            double faff = (double)pipka / 4;
            Console.Write(faff);
        }
    }
}