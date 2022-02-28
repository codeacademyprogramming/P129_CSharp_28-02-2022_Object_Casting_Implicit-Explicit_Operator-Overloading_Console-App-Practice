using System;
using System.Collections.Generic;
using System.Text;

namespace P129Casting.Models
{
    abstract class Bird : Animal
    {
        public bool IsFly { get; set; }
        public abstract void Fly();
    }
}
