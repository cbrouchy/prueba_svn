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
    
    public partial class DetalleTabla
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DetalleTabla()
        {
            this.MenuPlaza = new HashSet<MenuPlaza>();
        }
    
        public int idDetalleTabla { get; set; }
        public string tabla { get; set; }
        public string descripcion { get; set; }
        public Nullable<bool> estaActivo { get; set; }
        public Nullable<System.DateTime> fechaCaducidad { get; set; }
        public Nullable<bool> vinculado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MenuPlaza> MenuPlaza { get; set; }
    }
}