using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Wars
{
    internal class DelegateTrn
    {
        public delegate void Message();

        public Message mes;

        public DelegateTrn()
        {
            if (DateTime.Now.Hour < 12)
                mes = GoodMorning;
            else
            mes = new Message(GoodEvening);//same as just GoodEvening
        }

        private static void GoodMorning()
        {
            Console.WriteLine("GoodMorning");
        }

        private static void GoodEvening()
        {
            Console.WriteLine("GoodEvening");
        }

    }

    internal class DelegateMethods
    {
        private delegate int Math(int f, int s);

        private Math dmath;
        private Math dmath2;

        private int Sum(int f, int s) => f + s;

        private int Multiply(int f, int s) => f * s;

        public DelegateMethods(int f, int s)
        {
            dmath = Sum;
            dmath += Multiply;
            Console.WriteLine(dmath(f, s) + "\n");
            //dmath -= Multiply;
            //Console.WriteLine(dmath(f, s));

            dmath2 = dmath;
            dmath2 -= Multiply;
            Console.WriteLine("2\t"+dmath2(f, s));
            Console.WriteLine("1\t" + dmath(f, s)+"\n");

        }
    }
}
