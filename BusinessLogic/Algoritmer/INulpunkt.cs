﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BusinessLogic
{
    interface INulpunkt
    {
        NulpunktsjusteringDTO PerformAdjustment(double voltage);
    }
}
