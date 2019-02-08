using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzracunavanjeDuljina_Sish
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int jedinice;
            Jedinice jed;
            List<double> myarray = new List<double>();
          //  IFormatProvider provider;

            Console.WriteLine("U kojim mjernim jedinicama želiš izračun:");
            Console.WriteLine("1 za milimetre\n2 za metre\n3 za kilometre\n4 za inče\n5 za stope\n6 za milje");
            jedinice = Console.Read();
            Console.WriteLine(jedinice);
           // provider = System.Globalization.CultureInfo.CreateSpecificCulture("en-GB");

            while (true)
            {
                Console.WriteLine("Unesi jedinicu(decimalni zarez) i mjernu jedinicu, 0 za prekid");
                string str = Console.ReadLine();
                if (str == "0")
                    break;
                switch (jedinice) {
                    case '1':
                        jed = Jedinice.Parse(str);
                        myarray.Add(jed.Milimetri);
                        break;
                    case '2':
                        jed = Jedinice.Parse(str);
                        myarray.Add(jed.Metri);
                        break;
                    case '3':
                        jed = Jedinice.Parse(str);
                        myarray.Add(jed.Kilometri);
                        break;
                    case '4':
                        jed = Jedinice.Parse(str);
                        myarray.Add(jed.Inči);
                        break;
                    case '5':
                        jed = Jedinice.Parse(str);
                        myarray.Add(jed.Stope);
                        break;
                    case '6':
                        jed = Jedinice.Parse(str);
                        myarray.Add(jed.Milje);
                        break;
                }
            }
            double rezultat=0;
            foreach (double var in myarray)
                rezultat+= var;

            Console.WriteLine("Rezultat je " + rezultat);
            Console.ReadKey(true);
        }
    }
}
