using System;

namespace IzracunavanjeDuljina_Sish
{
    public class Jedinice
    {
        private double my_value;
  
        public static Jedinice Parse(string str)
        {
            Jedinice jed = new Jedinice();
            string msg = "Duljina nije dobro unešena";
            try
            {
                if (str.TrimEnd(null).EndsWith("mm"))
                {
                    jed.Milimetri = Double.Parse(str.Remove(str.IndexOf('m')));
                }
                else if (str.TrimEnd(null).EndsWith("in"))
                {
                    jed.Inči = Double.Parse(str.Remove(str.IndexOf('i'))); 
                }
                else if (str.TrimEnd(null).EndsWith("km"))
                {
                    jed.Kilometri = Double.Parse(str.Remove(str.IndexOf('k')));
                }
                else if (str.TrimEnd(null).EndsWith("m"))
                {
                    jed.Metri = Double.Parse(str.Remove(str.IndexOf('m')));
                }
                else if (str.TrimEnd(null).EndsWith("ft"))
                {
                    jed.Stope = Double.Parse(str.Remove(str.IndexOf('f')));
                }
                else if (str.TrimEnd(null).EndsWith("mi"))
                {
                    jed.Milje = Double.Parse(str.Remove(str.IndexOf('m')));
                }
                else
                    throw new FormatException(msg);
            }
            catch (FormatException e){
                Console.WriteLine(e.Message);
                
            }
            return jed;
        }
        private Jedinice() { }

        public double Inči
        {
            get { return my_value/0.0254; }
            private set { my_value = value*0.0254; }
        }

        public double Metri
        {
            get { return my_value; }
            private set { my_value = value; }
        }

        public double Milje
        {
            get { return my_value/1609.344; }
            private set { my_value = value*1609.344; }
        }

        public double Kilometri
        {
            get { return my_value/1000; }
            private set { my_value = value*1000; }
        }

        public double Milimetri

        {
            get { return my_value*1000; }
            private set { my_value = value/1000; }
        }

       public double Stope
        {
            get { return my_value/0.3048; }
            private set { my_value = value*0.3048; }
        }

        
    }
}
