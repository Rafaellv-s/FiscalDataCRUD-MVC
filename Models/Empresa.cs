using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace FiscalDataCRUD_MVC.Models
{
    public class Empresa
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo CNPJ é obrigatório.")]
        public required string CNPJ { get; set; }

        [Required(ErrorMessage = "O campo Razão Social é obrigatório.")]
        [Display(Name = "Razão Social")]
        public required string RazaoSocial { get; set; }

        // Chave estrangeira para o usuário responsável
        // O tipo 'IdentityUser' é o padrão do ASP.NET Core Identity
        public required string ResponsavelId { get; set; }

        // Propriedade de navegação para a relação com o usuário
        [ForeignKey("ResponsavelId")]
        public required IdentityUser Responsavel { get; set; }
    }
}