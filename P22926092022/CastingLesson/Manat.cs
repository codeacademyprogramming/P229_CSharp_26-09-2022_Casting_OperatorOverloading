using System;
using System.Collections.Generic;
using System.Text;

namespace CastingLesson
{
    class Manat
    {
        public double AZN;

        public static explicit operator Dollar(Manat manat)
        {
            return new Dollar { USD = manat.AZN / 1.7085 };
        }

        public static Manat operator +(Manat left, Manat right)
        {
            return new Manat { AZN = left.AZN + right.AZN};
        }

        public static Manat operator +(Manat left, Dollar right)
        {
            return new Manat { AZN = left.AZN + right.USD };
        }

        public static bool operator >(Manat left, Manat right)
        {
            return left.AZN > right.AZN;
        }

        public static bool operator <(Manat left, Manat right)
        {
            return left.AZN < right.AZN;
        }

        public static double operator ==(Manat Left, Manat right)
        {
            return 15;
        }

        public static double operator !=(Manat Left, Manat right)
        {
            return 15;
        }

        //public static bool operator &&(bool Left, bool right)
        //{
        //    return true;
        //}

    }
}
