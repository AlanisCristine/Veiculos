using Carros.Repository.Interfaces;
using Carros.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veiculos.Entidade;

namespace Carros.Service
{
    public class CarroService : ICarroService
    {
        private readonly ICarro repository;
        public CarroService(ICarro carrinhoRepository)
        {
            repository = carrinhoRepository;
        }

        public void Adicionar(Carro carrinho)
        {
            repository.Adicionar(carrinho);
        }

        public void Remover(int id)
        {
            repository.Remover(id);
        }

        public List<Carro> Listar()
        {
            return repository.Listar();
        }
        public Carro BuscarTimePorId(int id)
        {
            return repository.BuscarPorId(id);
        }
        public void Editar(Carro editPessoa)
        {
            repository.Editar(editPessoa);
        }

        public string ExibirDetalhes(int id)
        {
            return repository.ExibirDetalhes(id);
        }
    }
}
