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
    
    public partial class RefTipoFuncion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefTipoFuncion()
        {
            this.CargoFuncional = new HashSet<CargoFuncional>();
        }
    
        public int idTipoFuncion { get; set; }
        public string tipoFuncion { get; set; }
        public bool estaActivo { get; set; }
        public Nullable<System.DateTime> fechaCaducidad { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CargoFuncional> CargoFuncional { get; set; }
    }
}
