using System;
using System.Collections.Generic;
using System.Text;

namespace P129OperatorOverloadin.Models
{
    class Student
    {
        public double Grade { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }

        public static double operator +(Student stu1, Student stu2)
        {
            return (stu1.Age+stu1.Grade+stu2.Age+stu2.Grade);
        }

        public static double operator -(Student stu1, Student stu2)
        {
            return (stu1.Age - stu1.Grade - stu2.Age - stu2.Grade);
        }

        public static bool operator >(Student stu1, Student stu2)
        {
            double sum = stu1 + stu2;

            return sum > 100;
        }

        public static bool operator <(Student stu1, Student stu2)
        {
            double sum = stu1 + stu2;

            return sum < 100;
        }

        public static bool operator >=(Student stu1, Student stu2)
        {
            return true;
        }

        public static bool operator <=(Student stu1, Student stu2)
        {
            return true;
        }
    }
}
