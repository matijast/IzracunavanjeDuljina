﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzracunavanjeDuljina_Sish
{
    public interface IJedinice
    {
        double jedinica { get; set; }
        double U_mm();
        double U_m();
        double U_km();
        double U_in();
        double U_ft();
        double U_mi();

    }
}
