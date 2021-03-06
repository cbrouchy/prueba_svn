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
    
    public partial class CargoSalarial
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CargoSalarial()
        {
            this.CategoriaPresupuesto = new HashSet<CategoriaPresupuesto>();
        }
    
        public int idCargoSalarial { get; set; }
        public string cargoSalarial1 { get; set; }
        public Nullable<int> idJornada { get; set; }
        public Nullable<int> equivalenciaHoraria { get; set; }
        public Nullable<int> ordenVisual { get; set; }
        public bool estaActivo { get; set; }
        public Nullable<System.DateTime> fechaAlta { get; set; }
        public Nullable<System.DateTime> fechaCaducidad { get; set; }
    
        public virtual RefJornada RefJornada { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CategoriaPresupuesto> CategoriaPresupuesto { get; set; }
    }
}
