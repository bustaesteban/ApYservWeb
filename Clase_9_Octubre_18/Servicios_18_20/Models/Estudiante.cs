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
    
    public partial class Estudiante
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Estudiante()
        {
            this.Calificaciones = new HashSet<Calificacione>();
            this.Inscripciones = new HashSet<Inscripcione>();
        }
    
        public int EstudianteID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Nullable<System.DateTime> FechaNacimiento { get; set; }
        public string Email { get; set; }
        public Nullable<bool> Activo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Calificacione> Calificaciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inscripcione> Inscripciones { get; set; }
    }
}