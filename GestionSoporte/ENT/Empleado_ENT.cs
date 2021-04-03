using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionSoporte.ENT
{
    public class Empleado_ENT
    {
        public int idTipoDocumento { get; set; }
        public string numeroDocumento { get; set; }
        public string primerNombre { get; set; }
        public string segundoNombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public string nombreCompleto { get { return primerNombre + " " + segundoNombre + " " + primerApellido + " " + segundoApellido; } }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string correo { get; set; }
        public string estado { get; set; }
        public DateTime fechaRegistro { get; set; }
        public Usuario_ENT usuario { get; set; }
    }
}
