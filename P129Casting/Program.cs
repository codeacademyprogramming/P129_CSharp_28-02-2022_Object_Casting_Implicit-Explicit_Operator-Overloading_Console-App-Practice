using P129Casting.Interfaces;
using P129Casting.Models;
using System;

namespace P129Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir Type Oz base Type - na Cevirme Prosesi Ne Adlandi Upcasting (Boxing)

            Eagle eagle1 = new Eagle();
            eagle1.Age = 10;

            Eagle eagle2 = new Eagle();
            eagle2.Age = 20;

            Eagle eagle3 = new Eagle();
            eagle3.Age = 30;


            Shark shark1 = new Shark();
            shark1.Age = 15;

            Shark shark2 = new Shark();
            shark2.Age = 25;

            Shark shark3 = new Shark();
            shark3.Age = 35;

            Object[] animals = { shark3, eagle1, eagle2,shark1, eagle3, shark1, 2, true, "Test", 2.5};

            CheckType(animals);
        }

        //public void CheckType(Eagle[] eagles)
        //{

        //}

        //public void CheckType(Shark[] sharks)
        //{

        //}

        static void CheckType(object[] animals)
        {
            //DownCasting UpCasting Olunmus Bir Type Oz Konkret Typena Cevirme Prosesine DownCasting(UnBoxing)
            //Tehlukeli Yol
            //Eagle eagle = (Eagle)animal2;

            //1-ci Tehlukesiz Yol
            //bool check = animal1 is Eagle;

            //if (animal1 is Eagle)
            //{
            //    Eagle eagle = (Eagle)animal1;
            //}

            //if (animal1 is Shark)
            //{
            //    Shark shark = (Shark)animal1;
            //}

            //foreach (Animal animal in animals)
            //{
            //    if (animal is Eagle)
            //    {
            //        Eagle eagle = (Eagle)animal;
            //        Console.WriteLine(eagle.Age);
            //        eagle.Eat();
            //    }
            //}

            //2-ci Tehlukesiz Yol
            foreach (object animal in animals)
            {
                Shark shark = animal as Shark;

                if (shark != null)
                {
                    Console.WriteLine(shark.Age);
                    shark.Eat();
                }
                else
                {
                    Eagle eagle = (Eagle)animal;
                }
            }

        }
    }
}
