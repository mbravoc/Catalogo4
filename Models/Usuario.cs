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
    using System.ComponentModel.DataAnnotations;

    public partial class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            this.Cliente = new HashSet<Cliente>();
        }

        public int id_Usuario { get; set; }
        [Display(Name = "Usuario ")]
        [Required(ErrorMessage = "digite o nome do usuario")]
        public string nome_Usuario { get; set; }
        [Display(Name = "Senha ")]
        [Required(ErrorMessage = "digite a senha do usuario")]
        [DataType(DataType.Password)]

        public string senha_Usuario { get; set; }

        public string LoginErrorMessage { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cliente> Cliente { get; set; }
    }
}
