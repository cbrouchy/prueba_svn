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
    
    public partial class AlumnosUsuarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AlumnosUsuarios()
        {
            this.Organizacion = new HashSet<Organizacion>();
        }
    
        public int idUsuario { get; set; }
        public string usuario { get; set; }
        public Nullable<int> dni { get; set; }
        public string apellido { get; set; }
        public string nombre { get; set; }
        public Nullable<int> idOrganizacion { get; set; }
        public string idMembership { get; set; }
        public string telCelular { get; set; }
        public string telFijo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Organizacion> Organizacion { get; set; }
    }
}
