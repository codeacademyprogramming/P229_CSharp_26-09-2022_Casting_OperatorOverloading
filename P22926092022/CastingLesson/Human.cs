using System;
using System.Collections.Generic;
using System.Text;

namespace CastingLesson
{
    class Human
    {
        public string Name;
        public string SurName;
        public byte Age;

        public override string ToString()
        {
            return $"{Name} {SurName}";
        }
    }
}
