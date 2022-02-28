using P129Object.Models;
using System;

namespace P129Object
{
    class Program
    {
        static void Main(string[] args)
        {
            Object ob = new Object();

            Human human = new Human();
            human.Name = "Hamid";
            human.SurName = "Mammadov";

            int a = 7;

            Console.WriteLine(human);
        }
    }
}
