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

            Console.WriteLine("U kojim jedinicama želiš izračun:");
            Console.WriteLine("1 za milimetre\n2 za metre\n3 za kilometre\n4 za inče\n5 za stope\n6 za milje");
            jedinice = Console.Read();
            Console.WriteLine(jedinice);
            StringBuilder jedinica= new StringBuilder();

            switch (jedinice)
            {
                case '1':
                    break;
                case '2':
                    break;
                case '3':
                    break;
                case '4':
                    break;
                case '5':
                    break;
                case '6':
                    break;


            }
            Console.ReadKey(true);
        }
    }
}
