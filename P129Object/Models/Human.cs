using System;
using System.Collections.Generic;
using System.Text;

namespace P129Object.Models
{
    class Human
    {
        public string Name { get; set; }
        public string SurName { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
