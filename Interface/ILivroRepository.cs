using SeboPequeri.Models;

public interface ILivroRepository
{
        public Livro Create(LivroDTO livroDTO);
        public IEnumerable<Livro> FindAll();
        public Livro FindById(int id);
        public Livro Update(LivroDTO livroDTO, int id);
         public void Delete(int id);


}