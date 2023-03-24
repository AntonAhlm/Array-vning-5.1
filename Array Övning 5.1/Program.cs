using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] i = new string[3];

            i[0] = "Borås";
            Console.WriteLine("Stad 1 = " + i[0]);

            i[1] = "Växjö";
            Console.WriteLine("Stad 2 = " + i[1]);

            Console.Write("Skriv namnet på tredje stad : ");
            i[2] = Console.ReadLine();
            Console.WriteLine(i[0] + " " + i[1] + " " + i[2]);

        }
    }
}
