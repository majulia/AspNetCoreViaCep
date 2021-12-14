using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using BuscaCep.WebApi.Data;
using BuscaCep.WebApi.Models;
using BuscaCep.WebApi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BuscaCep.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EnderecoController : ControllerBase
    {
        private readonly ViaCepService _viaCepService;

        private readonly IRepository _repo;

        public EnderecoController(
            ViaCepService viaCepService,
            IRepository repo
        )
        {
            _viaCepService = viaCepService;
            _repo = repo;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _repo.GetEnderecos();
            return Ok(result);
        }

         [HttpGet("{cep}")]
        public IActionResult GetByCep(string cep)
        {
            Endereco endereco = _viaCepService.GetEnderecoByCep(cep);
            return Ok(endereco);
        }

        [HttpPost]
        public IActionResult Post(Endereco endereco)
        {
            _repo.Add (endereco);
            if (_repo.SaveChanges())
            {
                return Ok(endereco);
            }
            return BadRequest("Endereço não cadastrado.");
        }
    }
}
      
