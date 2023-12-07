using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Pudelko2D:Pudelko, iTransakcje
    {

        /* public void pisz()
        {
            Console.WriteLine("Rysuje pudełko 2D");
        }
        */

        private double d;
        private double s;

        public Pudelko2D(double d, double s)
        {
            this.d = d;
            this.s = s;
        }
        public Pudelko2D()
        {
            this.d = 0;
            this.s = 0;
        }

        public override void pisz()
        {
            //base.pisz();
            Console.WriteLine("Rysuje pudelko 2D o szerokosci "+ s + " i dlugosci "+ d);
        }

        public void wlaczMuzyke()
        {
            Console.WriteLine("Gra muzyka dla pudelko 2D");
        }

        public static Pudelko2D operator +(Pudelko2D pud1, Pudelko2D pud2)
        {
            Pudelko2D pud3 = new Pudelko2D();
            pud3.s = pud1.s + pud2.s;
            pud3.d = pud1.d + pud2.d;

            return pud3;


        }

        public static bool operator == (Pudelko2D pud1, Pudelko2D pud2)
        {
            return (pud1.s == pud2.s && pud1.d == pud2.d);
        }

        public static bool operator != (Pudelko2D pud1, Pudelko2D pud2)
        {
            return (pud1.s == pud2.s && pud1.d == pud2.d);
        }



    }
}
