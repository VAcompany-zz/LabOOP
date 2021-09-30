using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laba3;
namespace Laba3
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Vector first = new Vector(3,new int[]{1,2,3});
            var user = new { Name = "Tom", Age = 34 };
            Console.WriteLine($"{ user.Name} {user.Age}"); // Анонимный 
            Console.WriteLine(first.Fixed2());
            Console.WriteLine(first.n);
            Console.WriteLine(first.Equals(user));
           
            Console.WriteLine(first.GetType());
            Console.WriteLine(first is Vector);
           

            Vector[] tue = new Vector[] { new Vector(1, new int[] { 1, 2, 0 }, 845), new Vector(1, new int[] { 1, 2, 3 }, 845), new Vector(1, new int[] { 1, 2, 3 }, 845) };
            foreach (var item in tue)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (item.mass[i] == 0)
                    {
                        Console.WriteLine(item.ToString());
                    }
                 
                }

            }
            double max = 0;
            Vector maxItem = null;
            foreach (var item in tue)
            {
                int sum = 0;
                for (int i = 0; i < 3; i++)
                {
                    sum += item.mass[i] * item.mass[i];
                }
                double module = Math.Sqrt(sum);
                if(module > max)
                {
                    max = module;
                    maxItem = item;
                }
            }
            Console.Write("max: ");
            Console.WriteLine(maxItem.ToString());
            Console.ReadKey();
        }
    }
}
