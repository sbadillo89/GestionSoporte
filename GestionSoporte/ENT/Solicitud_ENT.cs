using System;
using System.Collections.Generic;

namespace GestionSoporte.ENT
{
    public class Solicitud_ENT
    {
        public Solicitud_ENT()
        {
            historia = new HistoriaSolicitud_ENT();
        }

        public int codigo { get; set; }
        public int idEquipo { get; set; }
        public int idTipoSolicitud { get; set; }
        public string TipoSolicitud { get; set; }
        public string descripcion { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime? fechaFin { get; set; }
        public string ubicacion { get; set; }
        public string idUsuarioAsignado { get; set; }
        public string estado { get; set; }
        public string empleadoCrea { get; set; }
        public string empleadoAsignado { get; set; }
        public Equipo_ENT Equipo { get; set; }
        public HistoriaSolicitud_ENT historia { get; set; }
    }
}
