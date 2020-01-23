using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во тел: ");
            int n = Convert.ToInt32(Console.ReadLine());

            List<Telo> t = new List<Telo>();
            t.Add(new TeloC(1));
            for (int i = 1; i < n; i++)
            {
                t.Add(new TeloC(i + 1));
                t[i - 1].t = t[i];
            }

            while (true)
            {
                Console.Write("Введите массу: ");
                int mass = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите размер: ");
                int size = Convert.ToInt32(Console.ReadLine());

                int p = t[0].Curt(mass, size);
                if (p != -1)
                    Console.WriteLine("Тело с масой " + mass + " и развером " + size + " является телом с номером: " + p);
                else Console.WriteLine("Тел с такой массой и таким размером нет");
            }

                Console.ReadLine();
        }
    }
    abstract class Telo
    {
        protected int n, mass, size;
        public Telo t { get; set; }
        public abstract int Curt(int mass, int size);
    }
    class TeloC : Telo
    {     
        public TeloC(int n)
        {
            this.n = n;
            mass = n * 10;
            size = n * 100;
        }
        public override int Curt(int m, int s)
        {
            try
            {
                if (m == mass && s == size) return n;
                else return t.Curt(m, s);
            }
            catch (Exception e) { return -1; }
        }
    }
}
