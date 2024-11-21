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
    public class CaminhaoService : ICaminhaoService
    {
        private readonly ICaminhao repository;
        public CaminhaoService(ICaminhao carrinhoRepository)
        {
            repository = carrinhoRepository;
        }

        public void Adicionar(Caminhao carrinho)
        {
            repository.Adicionar(carrinho);
        }

        public Caminhao BuscarTimePorId(int id)
        {
            return repository.BuscarPorId(id);
        }

        public void Editar(Caminhao editPessoa)
        {
            repository.Editar(editPessoa);
        }

        public List<Caminhao> Listar()
        {
            return repository.Listar();
        }

        public void Remover(int id)
        {
            repository.Remover(id);
        }
    }
}
