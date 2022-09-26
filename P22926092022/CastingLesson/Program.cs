using System;

namespace CastingLesson
{
    class Program
    {
        static void Main(string[] args)
        {

            //Teacher obj1 = new Teacher();
            //obj1.Name = "Hamid 1";
            //obj1.SurName = "Mammadov";
            //obj1.Experiance = "Experiance";
            //obj1.Grade = 100;

            //Teacher obj3 = new Teacher();
            //obj3.Name = "Hamid 3";
            //obj3.SurName = "Mammadov";
            //obj3.Experiance = "Experiance";
            //obj3.Grade = 100;

            //Teacher obj4 = new Teacher();
            //obj4.Name = "Hamid 4";
            //obj4.SurName = "Mammadov";
            //obj4.Experiance = "Experiance";
            //obj4.Grade = 100;

            //Developer obj2 = new Developer();
            //obj2.Name = "Obj2 Name";
            //obj2.SurName = "Obj2 SurName";
            //obj2.ProgrammingLanguagage = "CSharp";

            //Developer obj5 = new Developer();
            //obj5.Name = "Obj5 Name";
            //obj5.SurName = "Obj5 SurName";
            //obj5.ProgrammingLanguagage = "CSharp - 5";

            //Developer obj6 = new Developer();
            //obj6.Name = "Obj6 Name";
            //obj6.SurName = "Obj6 SurName";
            //obj6.ProgrammingLanguagage = "CSharp - 6";

            //object[] humen = { obj1, obj2, obj3, obj4, obj5, obj6, 15 ,"Test"};

            //Test(obj1);
            //Test(obj2);

            //var a = "Test";

            //Console.WriteLine(teacher);
            //Test(humen);

            //byte a = 45;
            //double b = 546;

            //a = (byte)b;

            //b = a;

            //Teacher teacher = new Teacher();
            //teacher.Name = "Hamid";
            //teacher.SurName = "Mammadov";
            //teacher.Age = 32;
            //teacher.Grade = 95;
            //teacher.Experiance = "5-il";

            //Developer developer = teacher;
            //developer.ProgrammingLanguagage = "CSharp";
            ////developer.Age += 10;

            //Console.WriteLine($"{developer.Name} {developer.SurName} {developer.Age} {developer.Grade} {developer.Experiance} {developer.ProgrammingLanguagage}");

            //Teacher catedTeacher = (Teacher)developer;

            //Console.WriteLine(catedTeacher.Age);

            //Student student = teacher;

            //Developer developer = (Developer)student;

            Manat manat = new Manat
            {
                AZN = 200
            };

            Dollar dollar = (Dollar)manat;
            //Console.WriteLine(dollar.USD);
            Manat manat1 = (Manat)dollar;
            //Console.WriteLine(manat1.AZN);

            Manat manat2 = manat + manat1;

            Console.WriteLine(manat2.AZN);

            Console.WriteLine((manat2 + dollar).AZN);

            Console.WriteLine(manat1 > manat2);
        }

        static void Test(object[] arr)
        {
            //DownCasting
            //Ver 1. Wrong Way;
            //Developer teacher = (Developer)human;

            //Ver 2. True Way With 'Is' Operator
            //bool check = human is Teacher;

            //if (check == true)
            //{
            //    Teacher teacher = (Teacher)human;
            //    Console.WriteLine($"{teacher.Name} {teacher.SurName} {teacher.Experiance}");

            //}

            //if (human is Teacher)
            //{
            //    Teacher teacher = (Teacher)human;
            //    Console.WriteLine($"{teacher.Name} {teacher.SurName} {teacher.Experiance}");
            //}
            //else if (human is Developer)
            //{
            //    Developer teacher = (Developer)human;
            //    Console.WriteLine($"{teacher.Name} {teacher.SurName} {teacher.ProgrammingLanguagage}");
            //}

            //Ver 3. True way With 'as' Operator
            //Developer developer = human as Developer;
            //Teacher teacher = human as Teacher;

            //if (developer != null)
            //{
            //    Console.WriteLine(developer.ProgrammingLanguagage);

            //}
            //else if (teacher != null)
            //{
            //    Console.WriteLine($"{teacher.Name} {teacher.SurName} {teacher.Experiance}");
            //}

            foreach (var item in arr)
            {
                if (item is Teacher)
                {
                    Teacher teacher = (Teacher)item;
                    Console.WriteLine(teacher.Experiance);
                }
                else if (item is Developer)
                {
                    Developer developer = (Developer)item;
                    Console.WriteLine(developer.ProgrammingLanguagage);
                }
                else if (item is int)
                {
                    int num = (int)item;
                    Console.WriteLine(num * num);
                }
                else if(item is string)
                {
                    string str = (string)item;
                    Console.WriteLine(str+" P229");
                }
            }
        }
    }
}
