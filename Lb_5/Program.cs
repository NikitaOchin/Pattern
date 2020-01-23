using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb_5
{
    class Program
    {
        static void Main(string[] args)
        {
            BetaBank Bb = new BetaBank();
            PrivetBank Pb = new PrivetBank();
            BayBank bayBank = new BayBank();

            PaymentAdapter PA = new BetaBankAdapter();
            PA.pay("Афанасий", 0);

            PA = new PrivetBankAdapter();
            PA.pay("Григорий", 4000);

            PA = new BayBankAdapter();
            PA.pay("Паша",1230);

            Console.Read();
        }
    }
    class BetaBank
    {
        public void SentTo(string s) { Console.WriteLine("BetaBank отправляет все деньги к " + s); }
    }
    class BetaBankAdapter : BetaBank, PaymentAdapter
    {
        public void pay(string s, int l)
        {
            SentTo(s);
        }
    }
    class PrivetBank
    {
        public void transfer(string s, int k) { Console.WriteLine("PrivetBank отправляет " + k +"грн клиенту " + s); }
    }
    class PrivetBankAdapter : PrivetBank, PaymentAdapter
    {
        public void pay(string s, int l)
        {
            transfer(s,l);
        }
    }
    class BayBank
    {
        public void sendMoney(){ Console.WriteLine("BayBank отправляет деньги всем клиентам"); }
    }
    class BayBankAdapter : BayBank, PaymentAdapter
    {
        public void pay(string s, int l)
        {
            sendMoney();
        }
    }
    interface PaymentAdapter
    {
        void pay(string s, int l);
    }
}
