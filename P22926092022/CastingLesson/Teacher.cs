using System;
using System.Collections.Generic;
using System.Text;

namespace CastingLesson
{
    class Teacher : Student
    {
        public string Experiance;

        public static implicit operator Developer(Teacher teacher)
        {
            Developer developer = new Developer();
            developer.Name = teacher.Name;
            developer.SurName = teacher.SurName;
            developer.Age = teacher.Age;
            developer.Experiance = teacher.Experiance;
            developer.Grade = teacher.Grade;

            return developer;
        }

        public static implicit operator Enginier(Teacher teacher)
        {
            Enginier enginier = new Enginier();

            return enginier;
        }
    }
}
