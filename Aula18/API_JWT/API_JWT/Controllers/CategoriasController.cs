using API_JWT.Controllers.Data;
using API_JWT.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace API_JWT.Controllers
{
    [Route("[controller]")]
    public class CategoriasController : ControllerBase
    {
        private readonly APICatalogContext _context;

        public CategoriasController(APICatalogContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Authorize]
        [ProducesResponseType(StatusCodes.Status200OK)] // Indicate successful response
        [ProducesResponseType(StatusCodes.Status404NotFound)] // Indicate potential error
        [Description("Retrieves all categories from the database.")] // Description in Swagger
        public async Task<ActionResult<IEnumerable<Categoria>>> GetCategoria()
        {
            var categorias = await _context.categorias.ToListAsync();
            if (categorias == null)
            {
                return NotFound(); // Handle empty results
            }
            return Ok(categorias); // Return the list of categories
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)] // Resposta correta para exclusão bem-sucedida
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Description("Deleta uma categoria do banco de dados.")]
        public async Task<IActionResult> DeletarCategoria(int id)
        {
            var categoria = await _context.categorias.FindAsync(id);

            if (categoria == null)
            {
                return NotFound(); // Retorna 404 Not Found se a categoria não for encontrada
            }

            _context.categorias.Remove(categoria); // Remove a categoria do contexto
            await _context.SaveChangesAsync(); // Salva as alterações no banco de dados

            return NoContent(); // Retorna 204 No Content após a exclusão bem-sucedida
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)] 
        [ProducesResponseType(StatusCodes.Status400BadRequest)] 
        [ProducesResponseType(StatusCodes.Status404NotFound)] 
        [Description("Atualiza uma categoria no banco de dados.")]
        public async Task<IActionResult> AtualizarCategoria(int id, [FromBody] Categoria categoriaAtualizada)
        {
            if (categoriaAtualizada == null || id != categoriaAtualizada.CategoriaId)
            {
                return BadRequest(); 
            }

            _context.categorias.Update(categoriaAtualizada);

            try
            {
                await _context.SaveChangesAsync(); 
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoriaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw; 
                }
            }

            return NoContent(); 
        }

        private bool CategoriaExists(int id)
        {
            return _context.categorias.Any(c => c.CategoriaId == id);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)] // Resposta correta para criação bem-sucedida
        [ProducesResponseType(StatusCodes.Status400BadRequest)] // Requisição inválida (ex: dados inválidos)
        [Description("Adiciona uma nova categoria ao banco de dados.")]
        public async Task<ActionResult<Categoria>> AdicionarCategoria([FromBody] Categoria novaCategoria)
        {
            if (novaCategoria == null)
            {
                return BadRequest(); 
            }

            _context.categorias.Add(novaCategoria); 
            await _context.SaveChangesAsync(); 

            // Retorna 201 Created com a categoria criada e o cabeçalho Location
            return CreatedAtAction(nameof(GetCategoriaById), new { id = novaCategoria.CategoriaId }, novaCategoria);
        }

        // Método auxiliar para obter categoria por ID (deve ser implementado)
        [HttpGet("{id}", Name = "GetCategoriaById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Categoria>> GetCategoriaById(int id)
        {
            var categoria = await _context.categorias.FindAsync(id);

            if (categoria == null)
            {
                return NotFound();
            }

            return Ok(categoria);
        }


    }
}