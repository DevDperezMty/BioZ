﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntBioZ.Modelo.BioZ
{
    
    public class EntJornada
    {
        public int id_jornada { get; set; }
        public string desc_jornada { get; set; }
        public List<EntTurnoJornada> turnoJornadas { get; set; }

    }
}
