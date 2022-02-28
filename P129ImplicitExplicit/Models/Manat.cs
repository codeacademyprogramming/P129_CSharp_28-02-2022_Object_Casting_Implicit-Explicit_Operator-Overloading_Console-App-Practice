using System;
using System.Collections.Generic;
using System.Text;

namespace P129ImplicitExplicit.Models
{
    class Manat
    {
        public double AZN { get; set; }

        public static implicit operator Dollar(Manat manat)
        {
            Dollar dollar = new Dollar();
            dollar.USD = manat.AZN / 1.7;
            return dollar;
        }

        public static implicit operator Euro(Manat manat)
        {
            Euro euro = new Euro();
            euro.EUR = manat.AZN / 1.92;
            return euro;
        }

        //public static explicit operator Dollar(Manat manat)
        //{
        //    Dollar dollar = new Dollar();
        //    dollar.USD = manat.AZN / 1.7;
        //    return dollar;
        //}

        //public static implicit operator int(Manat manat)
        //{
        //    return (int)manat.AZN;
        //}
    }
}
