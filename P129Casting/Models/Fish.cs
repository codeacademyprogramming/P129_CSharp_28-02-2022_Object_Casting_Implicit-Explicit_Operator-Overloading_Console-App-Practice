using System;
using System.Collections.Generic;
using System.Text;

namespace P129Casting.Models
{
    abstract class Fish : Animal
    {
        public int Length { get; set; }

        public bool  IsPullu { get; set; }
    }
}
