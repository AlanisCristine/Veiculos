using AutoMapper;
using Carros.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using Veiculos.Entidade;

namespace API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class CarroController : ControllerBase
    {
        private readonly ICarroService _service;


        public CarroController(ICarroService service)
        {
            _service = service;

        }

        [HttpPost("adicionar-carro")]
        public void AdicionarAluno(Carro carro)
        {
            _service.Adicionar(carro);
        }
        [HttpGet("listar-Carro")]
        public List<Carro> ListarAluno()
        {
            return _service.Listar();
        }

        [HttpPut("editar-Carro")]
        public void EditarCarrinho(Carro p)
        {
            _service.Editar(p);
        }
        [HttpDelete("deletar-Carro")]
        public void DeletarCarrinho(int id)
        {
            _service.Remover(id);
        }

    }
}
