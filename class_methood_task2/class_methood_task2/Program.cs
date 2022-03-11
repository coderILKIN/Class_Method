using System;

namespace class_methood_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci Telebe");

            Student student = new Student();

            student.Name = "Ilkin";
            student.Surname = "Yusubov";
            student.Group = "658a4";
            student.Point = 91;
            student.Graduated = true;


            student.Fullname();

            student.StudentInformation1();
          
            student.StudentInformation2();


            Console.WriteLine("Ikinci telebe");
            Student student2 = new Student();

            student.Name = "Perviz";
            student.Surname = "Muradov";
            student.Group = "672a3";
            student.Point = 90;
            student.Graduated = true;

            student.Fullname();

            student.StudentInformation1();

            student.StudentInformation2();



        }

    }

    class Student
    {
        public string Name;
        public string Surname;
        public string Group;
        public byte Point;
        public Boolean Graduated;


        public void Fullname()
        {
            Console.WriteLine($"Name: {Name}, Surname: {Surname}");

        }

        public void StudentInformation1()
        {
            
            Console.WriteLine($"Name: { Name}, Surname: { Surname}, Group: { Group}, Point: { Point}, Graduated: { Graduated}");
            
            byte point = 91;
            if ( Point > 90 && Point <= 100)
            {
                Console.WriteLine("Mezun olub");

            }
            else if (Point <= 90)
            {
                Console.WriteLine("Mezun olmayib");
            }

        }

        public void StudentInformation2()
        {
            
            byte Point = Convert.ToByte(Console.ReadLine());
           
            if (Point > 80 && Point <= 100)
            {
                
                Console.WriteLine("ikinci imtahana gire biler");
            }

            else if (Point <= 80)
            {

                Console.WriteLine("ikinci imtahana gire bilmez");

            }

            else
            {
                Console.WriteLine("Max bal 100-dur");
            }
           
        }






    }


}
