using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvtapsiriqlariElvinMuellim53Tapsiriq.ClassMisallari
{
    public class Misal12 : Misal11
    {
        int salary;
        public int Salary
        {
            get { return salary; }
            set
            {
                if (value > 400)
                {
                    salary = value;
                }
            }
        }
        public Misal12() : base()
        {
            Console.WriteLine("Buxalter klasinin bos konustruktoru");
        }
        public Misal12(string name, string surname, int age, int salary) : base(name, surname, age)
        {
            this.salary = salary;
        }
        public override double MasHesabati(int issati, int staj)
        {
            return base.MasHesabati(issati, staj) +(base.MasHesabati(issati,staj)*10)/100;
        }
        public override string ToString()
        {
            return base.ToString()+$" maasi: {salary}";
        }
    }
}
