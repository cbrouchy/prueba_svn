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
    
    public partial class CategoriaPresupuesto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CategoriaPresupuesto()
        {
            this.Plaza = new HashSet<Plaza>();
            this.PlazaHistorica = new HashSet<PlazaHistorica>();
            this.Presupuesto = new HashSet<Presupuesto>();
            this.ReqSolicitudPrimaria = new HashSet<ReqSolicitudPrimaria>();
            this.ReqSolicitudSecundaria = new HashSet<ReqSolicitudSecundaria>();
        }
    
        public int idCategoriaPresupuesto { get; set; }
        public int idUdeO { get; set; }
        public int idCargoSalarial { get; set; }
        public int idFinalidad { get; set; }
        public int idFuncion { get; set; }
        public string idEscalafon { get; set; }
        public bool estaActivo { get; set; }
        public Nullable<System.DateTime> fechaCaducidad { get; set; }
    
        public virtual CargoSalarial CargoSalarial { get; set; }
        public virtual RefEscalafon RefEscalafon { get; set; }
        public virtual RefFinalidad RefFinalidad { get; set; }
        public virtual RefFuncion RefFuncion { get; set; }
        public virtual RefUdeO RefUdeO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Plaza> Plaza { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlazaHistorica> PlazaHistorica { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Presupuesto> Presupuesto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReqSolicitudPrimaria> ReqSolicitudPrimaria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReqSolicitudSecundaria> ReqSolicitudSecundaria { get; set; }
    }
}
