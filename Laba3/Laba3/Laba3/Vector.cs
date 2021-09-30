using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3
{
    public class Vector
    {
        static Vector()
        {
            
        }

        public Vector()
        {
            ID = GetHashCode();
            Count++;
            STAT = 808;
        }

        public Vector(int _n, int[] _mass, int _Fix = 404)
        {
            n = _n;
            Fix = _Fix;
            mass = _mass;
            ID = GetHashCode();
            Count++;
        }

        private Vector(int _n)
        {
            n = _n;
        }

        public Vector GetVecotrKol(int n)
        {
            return new Vector(n);
        }
        ~Vector()
        {
            Count--;
        }
        //public protected private  модификаторы доступа
        public int Fix { get; }
        public int n { get; private set; }
        public int[] mass { get; }
        public static int STAT { get; set; }

        public readonly int ID = 478;

        public const int FIXCode = 228;

        public bool Fixed(ref int Fix)
        {
            return true;
        }

        public bool Fixed2()
        {
            return true;
        }

        public static int Count = 0;

        public override string ToString()
        {
            return $"Number = {n}, Fix = {Fix} Массив =  {mass[0]}, {mass[1]}, {mass[2]}";
        }
        public override int GetHashCode()
        {
            return n; // возрощает уникальный индификатор 
        }
        public override bool Equals(object obj)
        {
            if (obj is Vector)
            {
                Vector first = (Vector)obj;
                return (first.n == n && first.Fix == Fix );
            }
            return false;
        }
       
    }
}
