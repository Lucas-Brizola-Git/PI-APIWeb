using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APILogin.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }
        [Required]
        [StringLength(100)]
        public string? NomeUsuario { get; set; }
        [Required]
        [StringLength(100)]
        public string? Senha { get; set; }
    }
}
