//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaPresentacionAdmin.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public partial class Defecto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Defecto()
        {
            this.Alerta = new HashSet<Alerta>();
        }

        public int IdDefecto { get; set; }
        public string TipoDefecto { get; set; }
        public string Descripcion { get; set; }
        public string Pie { get; set; }
        public Nullable<System.DateTime> FechaRegistro { get; set; }
        public int IdModelo { get; set; }
        public int Cantidad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [JsonIgnore]
        public virtual ICollection<Alerta> Alerta { get; set; }

        public virtual Modelo Modelo { get; set; }
    }
}
