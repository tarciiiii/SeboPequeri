using SeboPequeri.Models;

public class LivroRepository : ILivroRepository
{
    public AppDbContext _context;
    public LivroRepository(AppDbContext appDbContext)
    {
        _context = appDbContext;
    }
    public Livro Create(LivroDTO livroDTO)
    {
        var livro = new Livro
        {
            Titulo = livroDTO.Titulo,
            Autor = livroDTO.Autor,
            ImgUrl = livroDTO.ImgUrl,
            Genero = livroDTO.Genero,
            Preco = livroDTO.Preco,
            Avaliacao = livroDTO.Avaliacao,
            Descricao = livroDTO.Descricao,
            Quantidade = livroDTO.Quantidade,
            ISBN = livroDTO.ISBN,
            AnoPublicacao = livroDTO.AnoPublicacao,
            Editora = livroDTO.Editora
        };

        _context.Livros.Add(livro);
        _context.SaveChanges();
        return livro;
    }

    public IEnumerable<Livro> FindAll()
    {
        return _context.Livros.ToList();
    }

    public Livro FindById(int id)
    {
        if (id == 0)
        {
            throw new Exception("Erro na consulta do banco de dados");
        }
        return _context.Livros.Find(id);
    }

    public Livro Update(LivroDTO livroDTO, int id)
    {

        Console.WriteLine(livroDTO);

        if (livroDTO == null)
        {
            throw new Exception("erro na alteração dos dados do livro. Livro não enviado");
        }

        var dblivro = _context.Livros.Find(id);

        if (dblivro == null)
        {
            throw new Exception("erro na alteração dos dados do livro. Livro não encontrado");
        }

        dblivro.Titulo = livroDTO.Titulo;
        dblivro.Autor = livroDTO.Autor;
        dblivro.ImgUrl = livroDTO.ImgUrl;
        dblivro.Genero = livroDTO.Genero;
        dblivro.Preco = livroDTO.Preco;
        dblivro.Avaliacao = livroDTO.Avaliacao;
        dblivro.Descricao = livroDTO.Descricao;
        dblivro.Quantidade = livroDTO.Quantidade;
        dblivro.ISBN = livroDTO.ISBN;
        dblivro.AnoPublicacao = livroDTO.AnoPublicacao;
        dblivro.Editora = livroDTO.Editora;

        _context.Livros.Update(dblivro);
        _context.SaveChanges();
        return dblivro;
    }
    public void Delete(int id)
    {
        var livro = _context.Livros.Find(id);
        if (livro == null)
        {
            throw new Exception("O livro informado não existe no banco de dados");
        }
        _context.Livros.Remove(livro);
        _context.SaveChanges();
    }

}

