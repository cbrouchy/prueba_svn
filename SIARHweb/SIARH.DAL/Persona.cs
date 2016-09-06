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
    
    public partial class Persona
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Persona()
        {
            this.Agente = new HashSet<Agente>();
        }
    
        public int idPersona { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public Nullable<int> idSexo { get; set; }
        public string domicilio { get; set; }
        public int idLocalidad { get; set; }
        public Nullable<System.DateTime> fechaNacimiento { get; set; }
        public Nullable<int> preCuil { get; set; }
        public Nullable<int> sufCuil { get; set; }
        public Nullable<bool> estaChequeadoCuil { get; set; }
        public string telefono { get; set; }
        public string mail { get; set; }
        public Nullable<int> idEstadoCivil { get; set; }
        public System.DateTime fechaFallecimiento { get; set; }
        public Nullable<int> documento { get; set; }
        public Nullable<int> idTipoDocumento { get; set; }
        public Nullable<int> idPaisNacionalidad { get; set; }
        public int idNivelEducativo { get; set; }
        public Nullable<bool> estaActivo { get; set; }
        public System.DateTime fechaCaducidad { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Agente> Agente { get; set; }
        public virtual Localidad Localidad { get; set; }
        public virtual RefEstadoCivil RefEstadoCivil { get; set; }
        public virtual RefNivelEducativo RefNivelEducativo { get; set; }
        public virtual RefPaisNacionalidad RefPaisNacionalidad { get; set; }
        public virtual RefSexo RefSexo { get; set; }
        public virtual RefTipoDocumento RefTipoDocumento { get; set; }
    }
}
