
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------


namespace BEUEjercicio
{

using System;
    using System.Collections.Generic;
    
public partial class Matricula
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Matricula()
    {

        this.Calificacions = new HashSet<Calificacion>();

    }


    public int idmatricula { get; set; }

    public Nullable<System.DateTime> fecha { get; set; }

    public Nullable<decimal> costo { get; set; }

    public string estado { get; set; }

    public string tipo { get; set; }

    public Nullable<int> idalumno { get; set; }

    public Nullable<int> idmateria { get; set; }



    public virtual Alumno Alumno { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Calificacion> Calificacions { get; set; }

    public virtual Materia Materia { get; set; }

}

}
