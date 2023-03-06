using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._02hm1
{
    class Num<Z>
    {
        private Z x;
        private Z c;

        public Num(Z x, Z c)
        {
            this.x = x;
            this.c = c;
        }
        public void Swap()
        {
            Z v = x;
            x = c;
            c = v;
        }
        public void Print()
        {
            Console.WriteLine($"a = {x}\nb = {c}");
        }
    }
    internal class Program
    {
        public static Z Swap<Z>(Z x, Z c) where Z : IComparable<Z>
        {
            Z v = x;
            x = c;
            c = v;
            return default(Z);
        }
        static void Main(string[] args)
        {
            Num<int> num = new Num<int>(1, 5);
            num.Swap();
            num.Print();
        }
    }
}