using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public int Produto_Id { get; set; }
        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} de caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} de caracteres")]
        public string Produto_Nome { get; set; }
        [Required(ErrorMessage = "Preencha um valor")]
        [Range(typeof(decimal), "0","999999999999")]
        [DataType(DataType.Currency)]
        public decimal ProdutoValor { get; set; }
        [DisplayName("Disponivel?")]
        public bool Produto_Disponivel { get; set; }
        public int Cliente_id { get; set; }
        public virtual ClienteViewModel Cliente { get; set; }
    }
}