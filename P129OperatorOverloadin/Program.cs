using P129OperatorOverloadin.Models;
using System;

namespace P129OperatorOverloadin
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 7;

            //int b = 8;

            //Console.WriteLine(a+b);
            //Console.WriteLine(a>b);

            Student student1 = new Student();
            student1.Grade = 70;
            student1.Age = 20;

            Student student2 = new Student();
            student2.Grade = 80;
            student2.Age = 25;

            Console.WriteLine(student1 + student2);
            Console.WriteLine(student1 < student2);
        }
    }
}
