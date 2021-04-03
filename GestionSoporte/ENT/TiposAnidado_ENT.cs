using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionSoporte.ENT
{ 
    public class TiposAnidado_ENT
    {
        public static Usuario_ENT usuarioLogueado;

        public enum Estado
        {
            ACTIVA = 1,
            INACTIVA = 2
        }
        public enum TipoHistoria
        {
            CREACION = 1,
            ASIGNACION = 2,//
            LECTURA = 3,
            APLAZADO = 4,//
            PROCESADO = 5,//
            FINALIZADO = 6//
        }

        public enum Perfil
        {
            Null = 0,
            Adminsitrador = 1
        }

        public enum TipoSolicitud
        {
            MANTENIMIENTO_DE_COMPUTO = 1,
            MANTENIMIENTO_ELECTRICO = 2,
            MANTENIMIENTO_ELECTRONICO = 3,
            MANTENIMIENTO_LOCATIVO = 4,
            MANTENIMIENTO_DE_COMUNICACIONES = 5
        }
    }
}
 