using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionSoporte.ENT
{
    public class EquipoDetalle_ENT
    {
        public int codigo { get; set; }
        public int codigoEquipo { get; set; }
        public int codigoComponente { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string serial { get; set; }
        public string datoAdicional { get; set; }
        public string estado { get; set; }
        public bool isNuevo { get; set; }
    }
}
