using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Lb_2
{
    public class Car
    {
        private Dictionary<string, string> detal = new Dictionary<string, string>(4);
        public Car(string n)
        {
            Name = n;
            detal.Add("wheel", string.Empty);
            detal.Add("color", string.Empty);
            detal.Add("cuzov", string.Empty);
            detal.Add("salon", string.Empty);
        }

        public string Name { get; set; }
        public void Add(string key, string v)
        {
            detal[key] = v;
        }
        public string Get(string key)
        {
            return detal[key];
        }
        public string Show()
        {
            return $" колеса - {detal["wheel"]}, цвет - {detal["color"]}, кузов - {detal["cuzov"]}, салон - {detal["salon"]}";
        }

    }
    public interface CarBuilder
    {
        void Set_details(string detal, string value);
        Car GetCar();
    }
    class Красивая_машина : CarBuilder
    {
        Car car = new Car("Красивая машина");
        public void Set_details(string detal, string value)
        {
            car.Add(detal, value);
        }
        public Car GetCar()
        {
            return car;
        }
    }
    class Некрасивая_машина : CarBuilder
    {
        Car car = new Car("Некрасивая машина");

        public void Set_details(string detal, string value)
        {
            car.Add(detal, value);
        }
        public Car GetCar()
        {
            return car;
        }
    }
    class Большая_машина : CarBuilder
    {
        Car car = new Car("Большая машина");
        public void Set_details(string detal, string value)
        {
            car.Add(detal, value);
        }
        public Car GetCar()
        {
            return car;
        }
    }
    class Director
    {
        public void Constructor(CarBuilder car, Dictionary<string, string> s)
        {
            car.Set_details("wheel", s["wheel"]);
            car.Set_details("color", s["color"]);
            car.Set_details("cuzov", s["cuzov"]);
            car.Set_details("salon", s["salon"]);
        }
    }
}