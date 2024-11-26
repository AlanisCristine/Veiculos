using AutoMapper;
using Carros.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using Veiculos.Entidade;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CaminhaoController : ControllerBase
    {
        private readonly ICaminhaoService _service;

        public CaminhaoController(ICaminhaoService service)
        {
            _service = service;
        }

        [HttpPost("Adicionar-caminhao")]
        public void AdicionarAluno(Caminhao carrinho)
        {
            _service.Adicionar(carrinho);
        }
        [HttpGet("Listar-Caminhao")]
        public List<Caminhao> ListarAluno()
        {
            return _service.Listar();
        }

        [HttpGet("Exibir-Detalhes-Caminhao")]
        public string ExibirDetalhes(int id)
        {
            return _service.ExibirDetalhes(id);
        }


        [HttpPut("Editar-Caminhao")]
        public void EditarCarrinho(Caminhao p)
        {
            _service.Editar(p);
        }
        [HttpDelete("Deletar-Caminhao")]
        public void DeletarCarrinho(int id)
        {
            _service.Remover(id);
        }
    }
}
