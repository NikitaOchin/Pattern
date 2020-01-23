using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb_4
{
    class Program
    {
        static void Main(string[] args)
        {
            System s1 = new ShallowClone(new TELO("A",1));
            System s2 = s1.Clone();
            s1.telo.Lenght = 4;
            Console.WriteLine(s1.telo.Lenght + "  " + s2.telo.Lenght);

            System s3 = new DeepClone(new TELO("B", 2));
            System s4 = s3.Clone();
            s3.telo.Lenght = 5;
            Console.WriteLine(s3.telo.Lenght + "  " + s4.telo.Lenght);
            Console.Read();
        }

        public class TELO
        {
            public TELO(string n = "", int l = 0)
            {
                Name = n; Lenght = l;
            }
            public string Name { get; set; }
            public int Lenght { get; set; }
        }

        public interface System
        {
            TELO telo { get; set; }
            System Clone();
        }

        public class ShallowClone : System
        {
            public ShallowClone(TELO t)
            {
                telo = t;
            }
            public TELO telo { get; set; }

            public System Clone()
            {
                return this.MemberwiseClone() as System;
            }
        }

        public class DeepClone : System
        {
            public DeepClone(TELO t)
            {
                telo = t;
            }
            public DeepClone(DeepClone d)
            {
                telo = new TELO();
                telo.Lenght = d.telo.Lenght;
                telo.Name = d.telo.Name;
            }
            public TELO telo { get; set; }

            public System Clone()
            {
                return new DeepClone(this);
            }
        }
    }
}