using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Client.Pokaz(new Kvadrat());

            Client.Pokaz(new Krug());

            Console.Read();
        }
    }

    interface Fabric
    {
        Product_A CreateProductA();
        Product_B CreateProductB();
    }

    class Kvadrat : Fabric
    {
        public Product_A CreateProductA()
        {
            Product_A A = new C_Product_A1();
            A.Name = "Kvadrat";
            return A;
        }

        public Product_B CreateProductB()
        {
            Product_B B = new C_Product_B1();
            B.Name = "Kvadrat";
            return B;
        }
    }
    class Krug : Fabric
    {
        public Product_A CreateProductA()
        {
            Product_A A = new C_Product_A2();
            A.Name = "Krug";
            return A;
        }

        public Product_B CreateProductB()
        {
            Product_B B = new C_Product_B2();
            B.Name = "Krug";
            return B;
        }
    }

    interface Product_A
    {
        string Name { get; set; }
        double Mass { get; set; }
        double V { get; set; }
        double W { get; set; }
        void POST_DVISHENIE();
    }
    interface Product_B
    {
        string Name { get; set; }
        double Mass { get; set; }
        double Corn_V { get; set; }
        double Corn_W { get; set; }
        void CORN_DVISHENIE();

    }

    class C_Product_A1 : Product_A
    {
        public string Name {get; set; }
        public double Mass { get; set; }
        public double V { get; set; }
        public double W { get; set; }

        public void POST_DVISHENIE()
        {
            Console.WriteLine($"Я {Name}, я двигаюсь поступательно");
        }
    }

    class C_Product_B1 : Product_B
    {
        public string Name { get; set; }
        public double Mass   { get; set; }
        public double Corn_V { get; set; }
        public double Corn_W { get; set; }

        public void CORN_DVISHENIE()
        {
            Console.WriteLine($"Я {Name}, я вращаюсь");
        }
    }

    class C_Product_A2 : Product_A
    {
        public string Name { get; set; }
        public double Mass { get; set; }
        public double V { get; set; }
        public double W { get; set; }

        public void POST_DVISHENIE()
        {
            Console.WriteLine($"Я {Name}, я двигаюсь поступательно");
        }
    }

    class C_Product_B2 : Product_B
    {
        public string Name { get; set; }
        public double Mass { get; set; }
        public double Corn_V { get; set; }
        public double Corn_W { get; set; }

        public void CORN_DVISHENIE()
        {
            Console.WriteLine($"Я {Name}, я вращаюсь");
        }
    }

    class Client
    {
        public static void Pokaz(Fabric f)
        {
            Product_A a = f.CreateProductA();
            a.POST_DVISHENIE();
            Product_B b = f.CreateProductB();
            b.CORN_DVISHENIE();
        }
    }
}