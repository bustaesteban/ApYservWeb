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
    
    public partial class Recurso
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Recurso()
        {
            this.CursoRecursoes = new HashSet<CursoRecurso>();
        }
    
        public int RecursoID { get; set; }
        public string NombreRecurso { get; set; }
        public string Descripcion { get; set; }
        public Nullable<bool> Activo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CursoRecurso> CursoRecursoes { get; set; }
    }
}
