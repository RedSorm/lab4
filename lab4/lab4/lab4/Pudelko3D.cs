using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Pudelko3D:Pudelko,iTransakcje

    {

        /*public void pisz()
        {
            Console.WriteLine("Rysuje pudełko 3D");
        }
        */

        protected double w;
        protected double d;
        protected double s;

        public Pudelko3D(double w)
        {
            this.w = w;
        }

        public Pudelko3D()
        {
            this.w = 0;
            this.s = 0;
            this.d = 0;
        }



        public Pudelko3D(double d, double s, double w)
        {
            this.w = w;
            this.d = d;
            this.s = s;
        }

        public override void pisz()
        {
            //base.pisz();
            Console.WriteLine("Rysuje pudelko 3D");
        }

        public void wlaczMuzyke()
        {
            Console.WriteLine("Gra muzyka dla pudelko 3D");
        }
    }
}
