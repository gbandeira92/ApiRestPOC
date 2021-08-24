
using System;
using System.Threading.Tasks;
using AR.Data.Interfaces;
using AR.Domain;
using Microsoft.AspNetCore.Mvc;

namespace AR.Apresentacao.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepository _repository;

        public ClienteController(IClienteRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetAll());
        }

        [HttpPost]
        public async Task<IActionResult> Add(Cliente cliente)
        {
            try
            {
                await _repository.Add(cliente);
                return StatusCode(201);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

    }
}
