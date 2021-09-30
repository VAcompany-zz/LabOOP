using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    class Program
    {
        private static (int min, int max, int sum, char first) LocFunc(int[] arr, string str)
        {
            int min = arr.Min();
            int max = arr.Max();
            int sum = arr.Sum();
            char first = str.First();
            return (min,max,sum,first);
        }
         static void checked1(int numbers)
        {
            Console.WriteLine(checked(numbers));
        }
        static void unchecked1(int numbers)
        {
            Console.WriteLine(unchecked(numbers));
        }
        static void Main(string[] args)
        {
            byte bt = 1;
            short s = 1;
            int i = 1;
            uint ui = 1;
            long l = 15;
            float f = 15.16f; // f - говорит о ципе float
            double d = 123.1;
            decimal dec = 2.4m; // m - говорит о ципе decimal
            bool b = true;

            char c = 'x';
            string str = "string";

            object x = 2;
            dynamic dynam = "ada";

            i = s;
            f = l;
            d = f;
            i = bt;
            s = bt;

            s = (short)i;
            dec = (decimal)f;
            f = (float)d;
            l = (long)f;
            c = (char)ui;

            str = Convert.ToString(i);

            /////////////////////////////////////////
            int box = 154;
            object kil = box;
            int ad = (int)kil;
            /////////////////////////////////////////
            dynamic dyn = 48.2;
            dyn = "world";
            dyn = true;

            /////////////////////////////////////////
            string strs = null;
            object a = null;

            int? i2 = null;

            if (strs == null)
            {
                Console.WriteLine("Null");
            }
            /////////////////////////////////////////
            var h = "privet";
            //h = 1;
            /////////////////////////////////////////

            var ads1 = "privet";
            var ads2 = "gpi";
            if (ads1 == ads2)
            {
                Console.WriteLine("yes");
            }
            string str1 = "first";
            string str2 = "second";
            string str3 = "third";

            str1 = String.Concat(str2, str3);
            str2 = String.Copy(str3);
            str1 = str3.Substring(0, 3);
            string[] str4 = str1.Split(',');

            string str5 = null;
            bool strBool = String.IsNullOrEmpty(str5);

            StringBuilder stringBulder = new StringBuilder();
            stringBulder.Append(15).Append("ad");
            stringBulder.Remove(1, 2);
            stringBulder.Insert(2, true);
            stringBulder.ToString();

            Console.WriteLine($"world{str1},{str2}");

            ///////////////////////////////////////////////
            int[,] mat = {
                { 1,2,3},
                { 1,2,3},
                { 1,2,3},
            };
            for (int k = 0; k < 3; k++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(mat[i, j]);
                    Console.Write(' ');

                }
                Console.WriteLine();
            }
            string[] arrStr = { "Vetalik", "Roma" };
            for (int hs = 0; hs < arrStr.Length; hs++)
            {
                Console.WriteLine(arrStr[hs]);

            }
            Console.WriteLine(arrStr.Length);
            int xa = Convert.ToInt32((Console.ReadLine()));
            string xa2 = ((Console.ReadLine()));
            arrStr[xa] = xa2;
            for (int hs = 0; hs < arrStr.Length; hs++)
            {
                Console.WriteLine(arrStr[hs]);

            }
            int[][] arr = new int[3][];
            arr[0] = new int[2];
            arr[1] = new int[3];
            arr[2] = new int[4];

            for (int kx = 0; kx < 2; kx++)
            {
                arr[0][kx] = Convert.ToInt32(Console.ReadLine());
            }
            for (int kx = 0; kx < 3; kx++)
            {
                arr[1][kx] = Convert.ToInt32(Console.ReadLine());
            }
            for (int kx = 0; kx < 4; kx++)
            {
                arr[2][kx] = Convert.ToInt32(Console.ReadLine());
            }
            for (int kx = 0; kx < 2; kx++)
            {
                Console.Write(arr[0][kx]);
                Console.Write(" ");
            }
            Console.WriteLine();
            for (int kx = 0; kx < 3; kx++)
            {
                Console.Write(arr[1][kx]);
                Console.Write(" ");
            }
            Console.WriteLine();
            for (int kx = 0; kx < 4; kx++)
            {
                Console.Write(arr[2][kx]);
                Console.Write(" ");
            }
            Console.WriteLine();

            dynamic arrD = new int[] { 1, 2, 3, 4, 5 };
            dynamic arrDD = new string[] { "ad", "ad", "ad", "ad" };

            (int, string, char, string, ulong) korteg = (1540, "korteg", '9', "korteg2", 498541);
            Console.WriteLine($"1:{korteg.Item1},3:{korteg.Item3},2:{korteg.Item2},4:{korteg.Item4},5:{korteg.Item5}");

            (int, string, char, string, ulong) korteg2 = (1540, "korteg", '9', "korteg2", 498541);
            var (x1, x2, x3, x4, x5) = korteg;
            var (z1, _, z3, _, z5) = korteg;
            if (korteg == korteg2)
            {
                Console.WriteLine("True");
            }
            int[]arr3 = {1,2,3,4,5,6,7,8,9};
            Console.WriteLine(LocFunc(arr3,"World"));
            checked1(int.MaxValue);
            unchecked1(int.MaxValue);
            Console.ReadKey();
        }
        
    }
   
}
