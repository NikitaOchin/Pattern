using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Component meh = new Creplenie("Механика");

            Component kol1 = new Creplenie("Колесо 1");
            meh.Add(kol1);
            Component pod1_kol = new Zveno("Подшипник первого колеса");
            Component zak = new Zveno("Закрепление");
            kol1.Add(pod1_kol);
            kol1.Add(zak);

            Component kol2 = new Creplenie("Колесо 2");
            meh.Add(kol2);
            Component pod2_kol = new Zveno("Подшипник второго колеса");
            kol2.Add(pod2_kol);

            Component kol3 = new Creplenie("Колесо 3");
            meh.Add(kol3);
            Component pod3_kol = new Zveno("Подшипник третьего колеса");
            kol3.Add(pod3_kol);

            Component krivoship = new Creplenie("Кривошип");
            meh.Add(krivoship);
            Component pod1_k = new Zveno("Первый подшипник кривошипа");
            Component pod2_k = new Zveno("Второй подшипник кривошипа");
            Component pod3_k = new Zveno("Третий подшипник кривошипа");
            krivoship.Add(pod1_k);
            krivoship.Add(pod2_k);
            krivoship.Add(pod3_k);
            meh.Draw();
            Console.ReadLine();
        }

        interface Component
        {
            string name { get; set; }
            void Add(Component comp);
            void Remove(Component comp);
            void Draw(int l = 0);
        }

        class Creplenie : Component
        {
            private List<Component> components = new List<Component>();
            public string name { get; set; }

            public Creplenie(string name) { this.name = name; }
            public void Add(Component comp)
            {
                components.Add(comp);
            }

            public void Draw(int l)
            {
                Console.WriteLine("".PadLeft(l*4, ' ') + name);
                foreach (Component c in components)
                {
                    c.Draw(l+1);
                }
                
            }

            public void Remove(Component comp)
            {
                components.Remove(comp);
            }
        }

        class Zveno : Component
        {

            public string name { get; set; }
            public Zveno(string name) { this.name = name; }

            public void Draw(int l)
            {
                Console.WriteLine("".PadLeft(4 * l, ' ') + name);
            }

            public void Add(Component comp)
            {
                throw new NotImplementedException();
            }

            public void Remove(Component comp)
            {
                throw new NotImplementedException();
            }
        }
    }
}
