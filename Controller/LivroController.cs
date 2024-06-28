using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using SeboPequeri.Models;
namespace SeboPequeri.Controller;   // incorporar o arquivo no projeto

[Route("api/[controller]")]
[ApiController]
public class LivroController : ControllerBase
{

    private readonly ILivroService _service;

    public LivroController(ILivroService service)
    {
        _service = service;
    }

    [HttpPost]
    [EnableCors("AllowAllOrigins")]
    public ActionResult<Livro> Create(LivroDTO livroDTO)
    {

        try
        {
            Console.WriteLine("Recebendo dados para criação do livro:");
            Console.WriteLine("Título: " + livroDTO.Titulo);
            Console.WriteLine("Autor: " + livroDTO.Autor);
            Console.WriteLine("ISBN: " + livroDTO.ISBN);
            // Log outros campos conforme necessário

            return Ok(_service.Create(livroDTO));
        }
        catch (Exception e)
        {
            Console.WriteLine("Erro na criação do livro: " + e.Message);
            return BadRequest(new { message = "Erro na criação do livro: " + e.Message });
        }
    }



    [HttpGet]
    public ActionResult<IEnumerable<Livro>> FindAll()
    {
        try
        {
            var livros = _service.FindAll();
            if (!livros.Any())
            {
                return NoContent();
            }
            return Ok(livros);

        }
        catch (Exception e)
        {
            throw new Exception("Erro na consulta dos livros: " + e);
        }

    }
    [HttpGet("{id}")]

    public ActionResult FindById(int id)
    {
        try
        {
            var livro = _service.FindById(id);
            if (livro == null)
            {
                return NoContent();
            }
            return Ok(livro);
        }
        catch (Exception e)
        {
            throw new Exception("não foi possível realizar a ação: " + e.Message);
        }

    }

    [HttpPatch("{id}")]
    public ActionResult<LivroDTO> Update([FromBody] LivroDTO livroDTO, int id)
    {
        try
        {
            _service.Update(livroDTO, id);
            return Ok(livroDTO);
        }
        catch (Exception e)
        {
            return BadRequest(new { Message = "Não foi possível realizar a ação", Error = e.Message });
        }
    }
    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        try
        {
            var livro = _service.FindById(id);
            if (livro == null)
            {
                return NoContent();
            }
            _service.Delete(id);
            return Ok("Deletado com sucesso");
        }
        catch (Exception e)
        {
            throw new Exception("não foi possível realizar a ação" + e);
        }
    }

}

