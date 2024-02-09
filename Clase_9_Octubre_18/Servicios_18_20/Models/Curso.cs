//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Servicios_18_20.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    
    public partial class Curso
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Curso()
        {
            this.Calificaciones = new HashSet<Calificacione>();
            this.CursoCategorias = new HashSet<CursoCategoria>();
            this.CursoHorarios = new HashSet<CursoHorario>();
            this.CursoRecursoes = new HashSet<CursoRecurso>();
            this.CursosMaterias = new HashSet<CursosMateria>();
            this.Inscripciones = new HashSet<Inscripcione>();
            this.Requisitos = new HashSet<Requisito>();
        }
    
        public int CursoID { get; set; }
        public string NombreCurso { get; set; }
        public Nullable<int> Creditos { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> ProfesorID { get; set; }
        public Nullable<bool> Activo { get; set; }
        [JsonIgnore]
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Calificacione> Calificaciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CursoCategoria> CursoCategorias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CursoHorario> CursoHorarios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CursoRecurso> CursoRecursoes { get; set; }
        public virtual Profesore Profesore { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CursosMateria> CursosMaterias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inscripcione> Inscripciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Requisito> Requisitos { get; set; }
    }
}