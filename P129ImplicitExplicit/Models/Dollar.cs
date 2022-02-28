using System;
using System.Collections.Generic;
using System.Text;

namespace P129ImplicitExplicit.Models
{
    class Dollar
    {
        public double USD { get; set; }

        public static implicit operator Manat(Dollar dollar)
        {
            return new Manat { AZN = dollar.USD * 1.69 };
        }

        public static implicit operator Euro(Dollar dollar)
        {
            return new Euro { EUR = dollar.USD * 1.15 };
        }
    }
}
