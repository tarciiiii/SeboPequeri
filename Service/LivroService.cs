using Microsoft.AspNetCore.Http.HttpResults;
using SeboPequeri.Models;

public class LivroService : ILivroService
{
    public ILivroRepository _livroRepository;
    public LivroService(ILivroRepository livroRepository)
    {
        _livroRepository = livroRepository;
    }
    public Livro Create(LivroDTO livroDTO)
    {
        return _livroRepository.Create(livroDTO);
    }
    public IEnumerable<Livro> FindAll()
    {
        return _livroRepository.FindAll();
    }

    public Livro FindById(int id)
    {
        return _livroRepository.FindById(id);
    }
    public Livro Update(LivroDTO livroDTO, int id)
    {
        return _livroRepository.Update(livroDTO, id);
    }

    public void Delete(int id)
    {
        _livroRepository.Delete(id);
    }


}