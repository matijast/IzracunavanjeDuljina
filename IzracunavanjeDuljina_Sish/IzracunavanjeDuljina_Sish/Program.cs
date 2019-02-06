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

            Console.WriteLine("U kojim jedinicama želiš izračun:");
            Console.WriteLine("1 za milimetre\n2 za metre\n3 za kilometre\n4 za inče\n5 za stope\n6 za milje");
            jedinice = Console.Read();
            Console.WriteLine(jedinice);
            while(true)
            {
                Console.WriteLine("Unesi jedinicu i mjernu jedinicu");
                string str = Console.ReadLine();
                jed.Parse(str);
                
            }
             


            
            Console.ReadKey(true);
        }
    }
}
