using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvtapsiriqlariElvinMuellim53Tapsiriq.ClassMisallari
{
    public class Misal11
    {
        string name;
        string surname;
        int age;
        public string Name
        {
            get { return name.ToUpper(); }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value.ToUpper();
                }
            }
        }
        public string Surname
        {
            get { return surname.ToUpper(); }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    surname = value.ToUpper();
                }
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (int.TryParse(value.ToString(), out int result) && value > 0)
                {
                    age = result;
                }
                else
                {
                    Console.WriteLine("yas sahesine 0 dan boyuk sadece reqem daxil ede bilersiniz");
                }
            }
        }
        public Misal11()
        {
        }
        public Misal11(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;          
        }

        public virtual double MaasHesabati()
        {
            return 100;
        }
        public virtual double MaasHesabati(int issaati)
        {
            return 100 + issaati * 0.03;
        }
        public virtual double MasHesabati(int issati, int staj)
        {
            return 100 + issati * 0.03 + staj * 0.3;
        }
        public override string ToString()
        {
            return $"{name} {surname} {age}";
        }
    }
}
