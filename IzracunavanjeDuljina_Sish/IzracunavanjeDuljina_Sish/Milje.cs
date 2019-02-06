using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzracunavanjeDuljina_Sish
{
    class Milje 
    {
        public double jedinica
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public double U_ft()
        {
            return jedinica * 5280;
        }

        public double U_in()
        {
            return jedinica * 63360;
        }

        public double U_km()
        {
            return jedinica * 1.6093;
        }

        public double U_m()
        {
            return jedinica * 1609.3;
        }

        public double U_mi()
        {
            return jedinica;
        }

        public double U_mm()
        {
            return jedinica * 1609300;
        }
    }
}
