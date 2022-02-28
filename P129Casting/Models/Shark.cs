using System;
using System.Collections.Generic;
using System.Text;

namespace P129Casting.Models
{
    class Shark : Fish
    {
        public int TeethCount { get; set; }

        public override void Eat()
        {
            Console.WriteLine("Eat As Shark");
        }
    }
}
