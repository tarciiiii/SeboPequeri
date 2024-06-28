public class LivroDTO
{

    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string? ImgUrl { get; set; }
    public EGeneroLiterario? Genero { get; set; }
    public decimal Preco { get; set; }
    public int? Avaliacao { get; set; }
    public string? Descricao { get; set; }
    public int Quantidade { get; set; }
    public string ISBN { get; set; }
    public int AnoPublicacao { get; set; }
    public string Editora { get; set; }

    // DTO

}