using Entities.Entities.Enums;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Entities
{
    public class ApplicationUser : IdentityUser<string>
    {
        [Column("USR_CPF")]
        [MaxLength(50)]
        [Display(Name = "CPF")]
        public string CPF { get; set; }

        [Column("USR_IDADE")]
        [Display(Name = "IDADE")]
        public int IDADE { get; set; }

        [Column("USR_NOME")]
        [MaxLength(255)]
        [Display(Name = "NOME")]
        public string Nome{ get; set; }

        [Column("USR_CEP")]
        [MaxLength(15)]
        [Display(Name = "CEP")]
        public string CEP { get; set; }

        [Column("USR_ENDERECO")]
        [MaxLength(255)]
        [Display(Name = "ENDERECO")]
        public string Endereco{ get; set; }

        [Column("USR_COMPLEMENTO_ENDERECO")]
        [MaxLength(450)]
        [Display(Name = "COMPLEMENTO_ENDERECO")]
        public string ComplementoEndereco{ get; set; }

        [Column("USR_CELULAR")]
        [MaxLength(20)]
        [Display(Name = "CELULAR")]
        public string Celular{ get; set; }

        [Column("USR_TELEFONE")]
        [MaxLength(20)]
        [Display(Name = "TELEFONE")]
        public string Telefone{ get; set; }

        [Column("USR_ESTADO")]
        [Display(Name = "ESTADO")]
        public bool Estado{ get; set; }

        [Column("USR_TIPO")]
        [Display(Name = "Tipo")]
        public UserType? Tipo { get; set; }

    }
}
