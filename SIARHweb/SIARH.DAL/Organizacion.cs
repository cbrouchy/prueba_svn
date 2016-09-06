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
    
    public partial class Organizacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Organizacion()
        {
            this.EdificioOrganizacion = new HashSet<EdificioOrganizacion>();
            this.Grupo = new HashSet<Grupo>();
            this.OrganizacionTurno = new HashSet<OrganizacionTurno>();
            this.PlanUnidad = new HashSet<PlanUnidad>();
            this.ReqSolicitudPrimaria = new HashSet<ReqSolicitudPrimaria>();
            this.Solicitud = new HashSet<Solicitud>();
            this.AlumnosUsuarios = new HashSet<AlumnosUsuarios>();
        }
    
        public int idOrganizacion { get; set; }
        public string organizacion1 { get; set; }
        public string numeroOrganizacion { get; set; }
        public Nullable<int> cue { get; set; }
        public Nullable<int> idTipoOrganizacion { get; set; }
        public string domicilio { get; set; }
        public Nullable<int> idLocalidad { get; set; }
        public Nullable<int> idInstrumentoLegalCreacion { get; set; }
        public Nullable<int> idInstrumentoLegalBaja { get; set; }
        public string email { get; set; }
        public bool estaActivo { get; set; }
        public Nullable<System.DateTime> fechaAlta { get; set; }
        public Nullable<System.DateTime> fechaBaja { get; set; }
        public string observaciones { get; set; }
        public Nullable<int> idOrganizacionDependencia { get; set; }
        public Nullable<int> idZona { get; set; }
        public string telefono { get; set; }
        public Nullable<int> idJornada { get; set; }
        public Nullable<int> idCategoriaOrganizacion { get; set; }
        public Nullable<bool> estaChequeada { get; set; }
        public Nullable<int> idAmbito { get; set; }
        public Nullable<int> idTipoEducacion { get; set; }
        public Nullable<int> idRegion { get; set; }
        public Nullable<int> idPeriodoEscolar { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EdificioOrganizacion> EdificioOrganizacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Grupo> Grupo { get; set; }
        public virtual InstrumentoLegal InstrumentoLegal { get; set; }
        public virtual InstrumentoLegal InstrumentoLegal1 { get; set; }
        public virtual Localidad Localidad { get; set; }
        public virtual RefAmbito RefAmbito { get; set; }
        public virtual RefCategoriaOrganizacion RefCategoriaOrganizacion { get; set; }
        public virtual RefJornada RefJornada { get; set; }
        public virtual RefPeriodoEscolar RefPeriodoEscolar { get; set; }
        public virtual RefRegion RefRegion { get; set; }
        public virtual RefTipoEducacion RefTipoEducacion { get; set; }
        public virtual RefTipoOrganizacion RefTipoOrganizacion { get; set; }
        public virtual RefZona RefZona { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizacionTurno> OrganizacionTurno { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlanUnidad> PlanUnidad { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReqSolicitudPrimaria> ReqSolicitudPrimaria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Solicitud> Solicitud { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlumnosUsuarios> AlumnosUsuarios { get; set; }
    }
}