using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using BuscaCep.WebApi.Data;
using BuscaCep.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BuscaCep.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class EnderecoController : ControllerBase
    {
        private readonly BuscaContext _context;

        public EnderecoController(BuscaContext context)
        {
            _context = context;
        }



        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Enderecos);

        }


        // /api/endereco/id
        [HttpGet("byId/{id}")]

        public IActionResult GetById(int id){
           var endereco = _context.Enderecos.FirstOrDefault(e => e.Id == id);
           return endereco == null ? BadRequest("Não encontrado") : Ok(endereco);
        }


        // /api/endereco/byCep?cep=12500000

        [HttpGet("byCep")]
        public IActionResult GetByCep(string cep)
        {
            var endereco = _context.Enderecos.FirstOrDefault(e => e.Cep.Contains(cep));

            return endereco == null ? NotFound() : Ok(endereco);

        }

        [HttpPost]
        public IActionResult Post(Endereco endereco)
        {
            _context.Add(endereco);
            _context.SaveChanges();
            return Ok(endereco);
        }


        [HttpPut("{id}")]
        public IActionResult Put(int id, Endereco endereco)
        {
            var end = _context.Enderecos.AsNoTracking().FirstOrDefault(e => e.Id == id);
            if (end == null) return BadRequest("Endereço não encontrado");

            _context.Update(endereco);
            _context.SaveChanges();
            return Ok(endereco);
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Endereco endereco)
        {
            var end = _context.Enderecos.AsNoTracking().FirstOrDefault(e => e.Id == id);
            if (end == null) return BadRequest("Endereço não encontrado");
            _context.Update(endereco);
            _context.SaveChanges();
            return Ok(endereco);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var endereco = _context.Enderecos.AsNoTracking().FirstOrDefault(a => a.Id == id);
            if (endereco == null) return BadRequest("Endereço não encontrado");
            _context.Remove(endereco);
            _context.SaveChanges();
            return Ok("Removido com sucesso");
        }
    }
}
