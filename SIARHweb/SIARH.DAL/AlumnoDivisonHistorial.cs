//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIARH.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class AlumnoDivisonHistorial
    {
        public int idAlumnoDivisionHistorial { get; set; }
        public int idAlumno { get; set; }
        public int idDivision { get; set; }
        public int anioLectivo { get; set; }
        public Nullable<int> idEstadoAlumno { get; set; }
        public string observacion { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public Nullable<int> idMotivoBajaAlumno { get; set; }
        public Nullable<int> idAlumnoDivision { get; set; }
    }
}