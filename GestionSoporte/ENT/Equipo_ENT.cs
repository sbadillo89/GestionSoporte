using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionSoporte.ENT
{
    public class Equipo_ENT
    {
        public Equipo_ENT()
        {
            detalles = new List<EquipoDetalle_ENT>();
        }

        public int codigo { get; set; }
        public int codigoUbicacion { get; set; }
        public string etiqueta { get; set; }
        public string serial { get; set; }
        public string marca { get; set; }
        public string nombreUbicacion { get; set; }
        public int codigoTipoEquipo { get; set; }
        public string tipoEquipo { get; set; }
        public string empleadoEncargado { get; set; }
        public string nombreEmpleado { get; set; }
        public string descripcion { get; set; }
        public string estado { get; set; }
        public DateTime fechaCreacion { get; set; }
        public List<EquipoDetalle_ENT> detalles { get; set; }
    }
}
