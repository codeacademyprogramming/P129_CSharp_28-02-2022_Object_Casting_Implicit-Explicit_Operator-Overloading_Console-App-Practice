using System;
using System.Collections.Generic;
using System.Text;

namespace P129Casting.Models
{
    class Eagle : Bird
    {
        public int LenghtOfQanad { get; set; }

        public override void Eat()
        {
            Console.WriteLine("Eat As Eagle");
        }

        public override void Fly()
        {
            Console.WriteLine("Fly As Eagle");
        }
    }
}
