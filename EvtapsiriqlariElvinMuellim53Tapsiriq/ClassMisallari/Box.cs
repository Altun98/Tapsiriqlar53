using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvtapsiriqlariElvinMuellim53Tapsiriq.ClassMisallari
{
    public class Box
    {
        public int a;
        public int b;
        public Box()
        {
            a = 10;
            b = 10;
        }

        public static Box operator +(Box a, Box b)
        {
            Box c = new Box();
            c.a = a.a + b.a;
            c.b = a.b + b.b;
            return c;
        }
        public static Box operator -(Box a, Box b)
        {
            Box c = new Box();
            c.a = a.a - b.a;
            c.b = a.b - b.b;
            return c;
        }
        public static bool operator <(Box a, Box b)
        { return a.a < b.a; }
        public static bool operator >(Box a, Box b)
        { return a.a > b.a; }
    }
}