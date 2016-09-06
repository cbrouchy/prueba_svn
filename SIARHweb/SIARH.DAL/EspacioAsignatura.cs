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
    
    public partial class EspacioAsignatura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EspacioAsignatura()
        {
            this.Plaza = new HashSet<Plaza>();
            this.PlazaHistorica = new HashSet<PlazaHistorica>();
            this.ReqSolicitudPrimaria = new HashSet<ReqSolicitudPrimaria>();
            this.ReqSolicitudSecundaria = new HashSet<ReqSolicitudSecundaria>();
        }
    
        public int idEspacioAsignatura { get; set; }
        public int idEspacioCurricular { get; set; }
        public int idAsignatura { get; set; }
        public bool estaActivo { get; set; }
        public Nullable<System.DateTime> fechaCaducidad { get; set; }
    
        public virtual EspacioCurricular EspacioCurricular { get; set; }
        public virtual RefAsignatura RefAsignatura { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Plaza> Plaza { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlazaHistorica> PlazaHistorica { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReqSolicitudPrimaria> ReqSolicitudPrimaria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReqSolicitudSecundaria> ReqSolicitudSecundaria { get; set; }
    }
}
