using System;

namespace GestionSoporte.ENT
{
    public class HistoriaSolicitud_ENT
    {
        public HistoriaSolicitud_ENT()
        {

        }

        public int codigo { get; set; }
        public int idSolicitud { get; set; }
        public TiposAnidado_ENT.TipoHistoria tipo { get; set; }
        public DateTime fechaRegistro { get; set; }
        public string idEmpleado { get; set; }
        public string nombreEmpleado { get; set; }
        public string observacion { get; set; }
        public decimal costo { get; set; }
    }
}
