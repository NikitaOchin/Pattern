using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb_7
{
    class computer
    {
        CPU c = new CPU();
        memory m = new memory();
        HDD hdd = new HDD();
        screen sc = new screen();

        public string Operator(bool i = false)
        {
            if (i) return "Компьютер уже запущен" + Environment.NewLine;
            else
                return c.zapusk() + Environment.NewLine +
                       m.zapusk() + Environment.NewLine +
                       hdd.zapusk() + Environment.NewLine +
                       sc.zapusk() + Environment.NewLine +
                       sc.Logo() + Environment.NewLine +
                       "Комьютер запущен" + Environment.NewLine;
        }

    }

    class CPU
    {
        public string zapusk()
        {
            return "Запуск процессора";
        }
    }

    class memory
    {
        public string zapusk()
        {
            return "Запуск опертивной памяти";
        }
    }

    class HDD
    {
        public string zapusk()
        {
            return "Чтение данных";
        }
    }

    class screen
    {
        public string zapusk()
        {

            return "Запуск монитора";
        }
        public string Logo()
        {
            return "HP";
        }
    }
}
