using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvtapsiriqlariElvinMuellim53Tapsiriq.GenericClass
{
    public class Misal24<T> where T : struct
    {
        public T Value { get; private set; }

        public Misal24(T value)
        {
            Value = value;
        }
        public void Incirment(T value)
        {
            dynamic temp = value;
            temp += 1;
            Value = (T)temp;
        }
    }
}
