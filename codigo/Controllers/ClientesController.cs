using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using codigo.Models;

namespace codigo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly LocacaoContext _context;

        public ClientesController(LocacaoContext context)
        {
            _context = context;
        }

        // GET: api/Clientes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cliente>>> GetCliente()
        {
            return await _context.Cliente.ToListAsync();
        }

        // GET: api/Clientes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cliente>> GetCliente(int id)
        {
            var cliente = await _context.Cliente.FindAsync(id);

            if (cliente == null)
            {
                return NotFound();
            }

            return cliente;
        }

        // PUT: api/Clientes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCliente(int id, Cliente cliente)
        {
            // Verifica se o ID fornecido na URL corresponde ao ID do cliente na solicitação
            if (id != cliente.ClienteID)
            {
                return BadRequest("O ID fornecido na URL não corresponde ao ID do cliente na solicitação.");
            }

            var clienteExistente = await _context.Cliente.FindAsync(id);
            if (clienteExistente == null)
            {
                return NotFound("Cliente não encontrado.");
            }

            // Atualiza apenas os campos necessários
            clienteExistente.Nome = cliente.Nome;
            clienteExistente.Endereco = cliente.Endereco;
            clienteExistente.Telefone = cliente.Telefone;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        // POST: api/Clientes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Cliente>> PostCliente(Cliente cliente)
        {
            _context.Cliente.Add(cliente);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCliente", new { id = cliente.ClienteID }, cliente);
        }

        // DELETE: api/Clientes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCliente(int id)
        {
            var cliente = await _context.Cliente.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }

            // Verifica se o cliente está associado a alguma reserva
            var clienteTemReserva = _context.Reservas.Any(r => r.ClienteID == id);
            if (clienteTemReserva)
            {
                return BadRequest("Não é possível excluir este cliente pois ele está associado a uma reserva.");
            }

            _context.Cliente.Remove(cliente);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}
