using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Powtorka
{
    class Ulamek : IEquatable<Ulamek>,IComparable<Ulamek>
    {
        private int licznik;

        public int Licznik { get => licznik;protected set => licznik = value; }

        private int mianownik;

        public int Mianownik { get => licznik;protected set => mianownik = value; }


        /// <summary>
        /// 
        /// </summary>
        public Ulamek() {}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public Ulamek(int a,int b)
        {
            a = this.licznik;
            b = this.mianownik;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="prev"></param>
        public Ulamek(Ulamek prev)
        {
            licznik = prev.licznik;
            mianownik = prev.mianownik;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int Gora()
        {
            return (int)Math.Floor((double)licznik / (double)mianownik);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int Dol()
        {
            return (int)Math.Ceiling((double)licznik / (double)mianownik);
        }

        public bool Equals(Ulamek other)
        {
            if (other == null) return false;
            if (other == this) return true;

            return Object.Equals(this.licznik,this.mianownik) && Object.Equals(other.licznik,other.mianownik);
        }

        public int CompareTo(Ulamek other)
        {
            if (other == null) return -1;
            if (other == this) return 0;        
            if (this.licznik - other.licznik < 0)
                return -1; 
            else
            {
                return 0;
            }

        }

        public override string ToString()
        {
            return $"{licznik}/{mianownik}".ToString();
        }

        public static Ulamek operator -(Ulamek a, Ulamek b)
        {
            return new Ulamek(a.licznik - b.licznik, a.mianownik);
        }


    }
}
