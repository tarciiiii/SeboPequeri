namespace SeboPequeri.Models
{
    public class Livro
    {
        public int LivroId { get; set; }
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

        public bool EstaAtivo { get; set; } = true;

        public Livro() { }

        public Livro
        (
            string titulo,
            string autor,
            string imgUrl,
            EGeneroLiterario genero,
            decimal preco,
            int avaliacao,
            string descricao,
            int quantidade,
            string isbn,
            int anoPublicacao,
            string editora,
            bool estaAtivo
        )
        {
            Titulo = titulo;
            Autor = autor;
            ImgUrl = imgUrl;
            Genero = genero;
            Preco = preco;
            Avaliacao = avaliacao;
            Descricao = descricao;
            Quantidade = quantidade;
            ISBN = isbn;
            AnoPublicacao = anoPublicacao;
            Editora = editora;
            EstaAtivo = estaAtivo;
        }
    }
}
