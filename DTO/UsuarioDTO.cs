using System.ComponentModel.DataAnnotations;

public class UsuarioDTO
{
 public int UsuarioId { get; set; }
    public string Nome { get; set; }
    [StringLength(20)]  
    public CargoUsuario Cargo { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
    public bool EstaAtivo { get; set; } = true;   
}