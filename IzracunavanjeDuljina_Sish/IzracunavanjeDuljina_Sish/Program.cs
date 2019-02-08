using System;
using System.Collections.Generic;

namespace IzracunavanjeDuljina_Sish
{
    public enum E_jedinice
    {
        mm=49,
        m=50,
        km=51,
        @in=52,
        ft=53,
        mi=54
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            int jedinice;
            Jedinice jed;
            List<double> myarray = new List<double>();
          //  IFormatProvider provider;

            Console.WriteLine("U kojim mjernim jedinicama želiš izračun:");
            Console.WriteLine("1 za milimetre (mm)\n2 za metre (m)\n3 za kilometre (km)\n4 za inče(in)\n5 za stope (ft)\n6 za milje (mi)");
            jedinice = Console.Read();
            Console.ReadLine();
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
                        if (jed.Metri == 0)
                            break;
                        myarray.Add(jed.Milimetri);
                        break;
                    case '2':
                        jed = Jedinice.Parse(str);
                        if (jed.Metri == 0)
                            break;
                        myarray.Add(jed.Metri);
                        break;
                    case '3':
                        jed = Jedinice.Parse(str);
                        if (jed.Metri == 0)
                            break;
                        myarray.Add(jed.Kilometri);
                        break;
                    case '4':
                        jed = Jedinice.Parse(str);
                        if (jed.Metri == 0)
                            break;
                        myarray.Add(jed.Inči);
                        break;
                    case '5':
                        jed = Jedinice.Parse(str);
                        if (jed.Metri == 0)
                            break;
                        myarray.Add(jed.Stope);
                        break;
                    case '6':
                        jed = Jedinice.Parse(str);
                        if (jed.Metri == 0)
                            break;
                        myarray.Add(jed.Milje);
                        break;
                }
            }
            double rezultat=0;
            Console.WriteLine("Rezultat je :");
            foreach (double var in myarray)
            {
                if (var < 0)
                {
                    Console.Write(String.Format("{0:0.000}", var) + " + ");
                    rezultat += var;
                    continue;
                }
                    Console.Write(String.Format("{0:0.000}",var) + " + ");
                rezultat += var;
            }
            Console.Write(String.Format("= {0:0.000}", rezultat) + " "+(E_jedinice)jedinice );
            Console.ReadKey(true);
        }
    }
}
