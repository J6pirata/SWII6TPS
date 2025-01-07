using ProvaFinal2.Model;
using System.ComponentModel.DataAnnotations;

namespace ProvaFinal2.Model
{
    public class Produto
    { [Required]
        public int Id? { get; set; }
        [Required]
        [StringLength(100)]
        public string Nome { get; set; }
        [Required]
        public decimal Preco? { get; set; }
        public bool Status { get; set; }
        [Required]
        public int IdUsuarioCadastro { get; set; }
        [Required]
        public int IdUsuarioUpdate { get; set; }

          public Produto() { }
   
    }
     

}
