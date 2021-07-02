using OOP.Figury;
using OOP.KlasaAbstrakcyjna;
using OOP.KlasaStatyczna;
using OOP.Przeciazanie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Trojkat trojkat1 = new Trojkat(2.5, 3);
            Trojkat trojkat2 = new Trojkat(3, 3, 3);

            Figura figura = new Figura();

            Prostokat prostokat1 = new Prostokat(3, 2);
            Console.WriteLine( prostokat1.CzyKwadrat() );

            Kwadrat kwadrat = new Kwadrat(10);
            Console.WriteLine( kwadrat.CzyKwadrat() );

            //AbstractProduct product = new AbstractProduct();
            Product product = new Product("Kluski", 3.99, "590342342342");
            product.ShowInfo();

            Wektor wektor1 = new Wektor(-1, 1);
            Wektor wektor2 = new Wektor(1, -1);
            Wektor wektor3 = wektor1.Add(wektor2);
            wektor3.Print();
            
            wektor3 = wektor1 + wektor2;
            wektor3.Print();

            wektor3 = wektor1 + 3.5;
            wektor3.Print();

            // korzystanie z klasy statycznej
            Console.WriteLine("{0},{1}", Utils.hostname, Utils.portNumber );
            Console.WriteLine(Utils.GetMaxValue(-1,1,10,12));
            Console.WriteLine(Utils.GetMaxValue(100,99,88));
            Console.WriteLine(Utils.GetMaxValue(100,99));

            Console.ReadKey();
        }
    }
}
