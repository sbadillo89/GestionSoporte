using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionSoporte.ENT
{
    public class Usuario_ENT
    {
        public int codigoUsuario { get; set; }
        public int idPerfil { get; set; }
        public string perfil { get; set; }
        public string numeroDocumento { get; set; }
        public string nombreCompleto { get; set; }
        public string contraseña { get; set; }
        public string estado { get; set; }
    }
}
