//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace catologoEm3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tipo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tipo()
        {
            this.Carro1 = new HashSet<Carro>();
            this.Pecas = new HashSet<Pecas>();
        }
    
        public int id_Tipo { get; set; }
        public string descricao { get; set; }
        public int carro { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Carro> Carro1 { get; set; }
        public virtual Carro Carro2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pecas> Pecas { get; set; }
    }
}
