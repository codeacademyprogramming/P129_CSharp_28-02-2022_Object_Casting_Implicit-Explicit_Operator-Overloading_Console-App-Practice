using P129Casting.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace P129Casting.Models
{
    abstract class Animal : ITest
    {
        public int Age { get; set; }

        public abstract void Eat();

        public void Test()
        {
            throw new NotImplementedException();
        }
    }
}
