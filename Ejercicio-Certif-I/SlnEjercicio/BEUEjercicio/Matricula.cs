//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BEUEjercicio
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Matricula
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Matricula()
        {
            this.Calificacions = new HashSet<Calificacion>();
        }

        [ScaffoldColumn(false)]
        public int idmatricula { get; set; }

        [Display(Name = "Fecha")]
        [DisplayFormat(DataFormatString = "{0:dd/MMM/yyyy}")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> fecha { get; set; }
                
        [Display(Name = "Costo")]
        public Nullable<decimal> costo { get; set; }

        [Display(Name = "Estado")]
        public string estado { get; set; }

        [Display(Name = "Tipo")]
        public string tipo { get; set; }
        public Nullable<int> idalumno { get; set; }
        public Nullable<int> idmateria { get; set; }
                
        public virtual Alumno Alumno { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [JsonIgnore]
        public virtual ICollection<Calificacion> Calificacions { get; set; }        
        public virtual Materia Materia { get; set; }

    }
}