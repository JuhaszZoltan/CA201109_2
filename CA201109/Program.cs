using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA201109
{
    struct EmberS
    {
        public string Nev;
        public int Kor;
    }

    class EmberC
    {
        private string _nev;
        public string Nev
        {
            set
            {
                if (value == "Lóci") throw new Exception("nem lehet Lóci :(");
                _nev = value;
            }
            get
            {
                return _nev;
            }
        }

        private int _kor;
        public int Kor
        {
            set
            {
                if (value < 0) throw new Exception("a kor nem lehet negatív");
                _kor = value;
            }
            get { return _kor; }
        }

        private int X = 0;
        private int Y = 0;

        public void Mozog(int ujX, int ujY)
        {
            X = ujX;
            Y = ujY;
        }

        public string HolVan()
        {
            return $"X:{X};Y:{Y}";
        }

        public EmberC(string nev, int kor)
        {
            Nev = nev;
            Kor = kor;
        }
    }

    class Program
    {
        static void Main()
        {
            //struct => ÉRTÉK típus
            var s1 = new EmberS() { Nev = "Zoli", Kor = 30, };
            //class  => REFERENCIA típus
            var c1 = new EmberC("Zoli", 30);

            //DEKLARÁL egy ÚJ változót, majd 
            //MÁSOL minden értéket az eredeti memóriaterületről
            var s2 = s1;
            //létrehoz egy ALIAST, ami
            //UGYAN ARRA a memória területre mutat
            var c2 = c1;

            //AZ ÚJ megváltozik, az EREDETI marad
            s2.Nev = "Jolánka";
            Console.WriteLine($"sNev: {s1.Nev}\nsKor: {s1.Kor}");

            //mivel ez csak egy REFERENCIA, 
            //ezért akár c1-et, akár c2-t kérdezem le
            //ugyan az lenne az eredmény
            c2.Nev = "Jolánka";
            //Console.WriteLine($"cNev: {c1.Nev}\ncKor: {c1.Kor}");


            var ember = new EmberC("Zoli", 30);
            ember.Kor = -200;

            Console.ReadKey();
        }
    }
}
