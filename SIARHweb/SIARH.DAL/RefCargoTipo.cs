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
    
    public partial class RefCargoTipo
    {
        public byte idTipoCargo { get; set; }
        public string tipoCargo { get; set; }
        public string observacion { get; set; }
        public bool estaActivo { get; set; }
        public Nullable<System.DateTime> fechaCaducidad { get; set; }
    }
}
