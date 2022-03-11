using System;

namespace class_methood_task1
{
    class Program
    {
        static void Main(string[] args)
        {





            Student student = new Student();

            student.Name = "Ilkin";
            student.Surname = "Yusubov";

            student.Group = "658a4";

            student.Point = 80;
            student.Graduated = true;


            student.StudentInformation();




        }
    }
    class Student
    {
        public string Name;
        public string Surname;
        public string Group;
        public byte Point;
        public Boolean Graduated;

        public void StudentInformation()
        {
            Console.WriteLine($"Name: { Name}, Surname: { Surname}, Group: { Group}, Point: { Point}, Graduated: { Graduated}");
        }

    }
}
