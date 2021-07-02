using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Figury
{
    class Trojkat : Figura, IFigura
    {
        private double? bokA = null; // dopuszczalna wartosc NULL dla zm. typu double
        private double? bokB = null; // dopuszczalna wartosc NULL dla zm. typu double
        private double? bokC = null; // dopuszczalna wartosc NULL dla zm. typu double
        private double? wysokosc = null; // dopuszczalna wartosc NULL dla zm. typu double


        public Trojkat(double a, double b, double c)
        {
            bokA = a; bokB = b; bokC = c;
            liczbaBokow = 3;
        }

        public Trojkat(double a, double h)
        {
            bokA = a; wysokosc = h;
            liczbaBokow = 3;
        }

        public double ObliczObwod()
        {
            throw new NotImplementedException();
        }

        public double ObliczPole()
        {
            throw new NotImplementedException();
        }
    }
}
