using ProjetoModeloDDD.Domains.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        public int Cliente_Id { get; set; }
        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} de caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} de caracteres")]
        public string Cliente_Nome { get; set; }
        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} de caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} de caracteres")]
        public string Cliente_Sobrenome { get; set; }
        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} de caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um e-mail válido" )]
        [DisplayName("E-mail")]
        public string Cliente_Email { get; set; }
        [ScaffoldColumn(false)]
        public DateTime Cliente_DataCadastro { get; set; } = DateTime.Now; 
        
        public bool Cliente_Ativo { get; set; }
        public IEnumerable<ProdutoViewModel> Produtos { get; set; }
    }
}