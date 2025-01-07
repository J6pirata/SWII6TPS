using System.ComponentModel.DataAnnotations;

namespace ProvaFinal2.Model
{
    public class Usuario
    {
        [Required]
        public int Id? { get; set; }
        [Required]
        [StringLength(100)]
        public string Nome? { get; set; }
        [Required,StringLength(100)]
        public string Senha? { get; set; }
        public bool Status { get; set; }

        public Usuario() { }
    }
    
}
