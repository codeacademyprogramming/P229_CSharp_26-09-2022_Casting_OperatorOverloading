using System;
using System.Collections.Generic;
using System.Text;

namespace CastingLesson
{
    class Developer : Student
    {
        public string ProgrammingLanguagage;
        public string Experiance;

        public static explicit operator Teacher(Developer developer)
        {
            Teacher teacher = new Teacher
            {
                Name = developer.Name,
                SurName = developer.SurName,
                Age = developer.Age,
                Experiance = developer.Experiance,
                Grade = developer.Grade
            };

            return teacher;
        }
    }
}
