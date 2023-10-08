namespace dz_7
using System;

class HelloWorld
{
    static void Main()
    {


        for (int i = 1; i <= 9; i++)
        {
            for (int j = 1; j <= 9; j++)
            {
                Console.Write(i * j + " ");
            }
            Console.WriteLine();
        }
    }
}