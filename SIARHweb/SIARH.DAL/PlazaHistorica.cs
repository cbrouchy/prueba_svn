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
    
    public partial class PlazaHistorica
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PlazaHistorica()
        {
            this.Servicio = new HashSet<Servicio>();
        }
    
        public int idPlazaHistorica { get; set; }
        public int idPlaza { get; set; }
        public int idCargoFuncional { get; set; }
        public int idPlanUnidad { get; set; }
        public int idEspacioAsignatura { get; set; }
        public Nullable<int> idDivision { get; set; }
        public Nullable<int> idGrupo { get; set; }
        public int horas { get; set; }
        public System.DateTime fechaAlta { get; set; }
        public int idInstrumentoLegalCreacion { get; set; }
        public Nullable<System.DateTime> fechaBaja { get; set; }
        public Nullable<int> idInstrumentoLegalBaja { get; set; }
        public Nullable<int> idMotivoBaja { get; set; }
        public int idSistemaEducativo { get; set; }
        public int idRegimenLaboral { get; set; }
        public int idFinanciamiento { get; set; }
        public int idCategoriaPresupuesto { get; set; }
        public int idMotivoCreacion { get; set; }
        public int idRegimenSalarial { get; set; }
        public bool admiteSuplente { get; set; }
        public bool esCabeceraDePaquete { get; set; }
        public Nullable<int> idPaquete { get; set; }
        public string observacion { get; set; }
        public int idAfectacion { get; set; }
    
        public virtual CargoFuncional CargoFuncional { get; set; }
        public virtual CategoriaPresupuesto CategoriaPresupuesto { get; set; }
        public virtual Division Division { get; set; }
        public virtual EspacioAsignatura EspacioAsignatura { get; set; }
        public virtual Grupo Grupo { get; set; }
        public virtual InstrumentoLegal InstrumentoLegal { get; set; }
        public virtual InstrumentoLegal InstrumentoLegal1 { get; set; }
        public virtual PlanUnidad PlanUnidad { get; set; }
        public virtual RefAfectacion RefAfectacion { get; set; }
        public virtual RefFinanciamiento RefFinanciamiento { get; set; }
        public virtual RefMotivoBaja RefMotivoBaja { get; set; }
        public virtual RefMotivoBaja RefMotivoBaja1 { get; set; }
        public virtual RefMotivoCreacion RefMotivoCreacion { get; set; }
        public virtual RefRegimenLaboral RefRegimenLaboral { get; set; }
        public virtual RefRegimenSalarial RefRegimenSalarial { get; set; }
        public virtual RefSistemaEducativo RefSistemaEducativo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Servicio> Servicio { get; set; }
    }
}
