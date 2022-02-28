using P129ImplicitExplicit.Models;
using System;

namespace P129ImplicitExplicit
{
    class Program
    {
        static void Main(string[] args)
        {
            Manat manat = new Manat();
            manat.AZN = 340;

            //Explicit
            //Dollar dollar = (Dollar)manat;
            
            //Implicit
            Dollar dollar = manat;
            Euro euro = manat;

            Console.WriteLine(dollar.USD);
            Console.WriteLine(euro.EUR);
            Console.WriteLine(manat.AZN);

            Manat manat1 = dollar;
            Euro euro1 = dollar;

            Console.WriteLine(euro1.EUR);
            Console.WriteLine(manat1.AZN);

            //Implicit In Built In Type
            //byte a = 255;

            //int b = a;

            //Explicit in Built In Type
            //int a = 6546;

            //byte b = (byte)a;

            //Console.WriteLine(b);

        }
    }
}
