//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ENTIDAD
{
    using System;
    using System.Collections.Generic;
    
    public partial class Alumno
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Alumno()
        {
            this.TAsistenciaTAlumno = new HashSet<AsistenciaTAlumno>();
        }
    
        public string DniAlumno { get; set; }
        public string Appaterno { get; set; }
        public string Apmaterno { get; set; }
        public string Nombres { get; set; }
        public string Genero { get; set; }
        public string Direccion { get; set; }
        public System.DateTime FecNacimiento { get; set; }
        public string DniApoderado { get; set; }
        public string CodGrado { get; set; }
    
        public virtual Grado TGrado { get; set; }
        public virtual Apoderado TApoderado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AsistenciaTAlumno> TAsistenciaTAlumno { get; set; }
    }
}
