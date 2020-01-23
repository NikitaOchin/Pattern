using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lb_2
{
    public partial class Form1 : Form
    {
        Director dir;
        private Dictionary<string, string> detal = new Dictionary<string, string>(4);

        public Form1()
        {
            InitializeComponent();
            dir = new Director();
            detal.Add("wheel", comboBox1.Text);
            detal.Add("color", comboBox2.Text);
            detal.Add("cuzov", comboBox3.Text);
            detal.Add("salon", comboBox4.Text);
        }

        private void СreateCar_Click(object sender, EventArgs e)
        {
            CarBuilder[] bld =  new CarBuilder[(int)numericUpDown1.Value];
            Car[] c = new Car[bld.Length];
            for (int i = 0; i < bld.Length; i++)
            {
                switch (comboBox5.Text)
                {
                    case "Большая машина":
                        bld[i] = new Большая_машина();
                        break;
                    case "Красивая машина":
                        bld[i] = new Красивая_машина();
                        break;
                    case "Некрасивая машина":
                        bld[i] = new Некрасивая_машина();
                        break;
                    default: return;
                }
                dir.Constructor(bld[i], detal);
                c[i] = bld[i].GetCar();
            }
            textBox1.Text += $"Ура! Вы создали {c.Length} {c[0].Name}";
            textBox1.Text += c[0].Show();
            textBox1.Text += "\r\n";
        }

        private void ComboBox1_TextChanged(object sender, EventArgs e)
        {
            detal["wheel"] = comboBox1.Text;
            detal["color"] = comboBox2.Text;
            detal["cuzov"]= comboBox3.Text;
            detal["salon"] = comboBox4.Text;
        }
    }
}
