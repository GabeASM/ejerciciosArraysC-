using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, };
            int[] b = { 10, 2, 3, 9, 7 , 8};

            ResolverArray r1 = new ResolverArray();
            //r1.MostarArreglo(r1.Mezclar(a, b));
           // r1.MostarArreglo(r1.Union(a, b));
            r1.Interseccion(a, b);


            Console.ReadLine();

        }
        class ResolverArray
        {
            public int [] Mezclar(int [] a ,int [] b)
            {
                int [] c = new int[a.Length + b.Length];
                Array.Copy(a, c, a.Length);
                Array.Copy(b, 0,c,a.Length, b.Length);
                Array.Sort(c);
                return c;
            } 

            public int [] Union(int []a , int [] b)
            {
                int[] c = a.Union(b).ToArray();
                return c;
            }
            public void Interseccion(int [] a , int[] b)
            {   
                  IEnumerable<int> c = a.Intersect(b);
                   foreach (int i in c) Console.WriteLine(i);
            }

            public void MostarArreglo(int [] c)
            {
                foreach(var i in c) Console.WriteLine(i);
            }
        }
    }
}
