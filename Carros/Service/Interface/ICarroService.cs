using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veiculos.Entidade;

namespace Carros.Service.Interface
{
    public interface ICarroService
    {
        void Adicionar(Carro carrinho);
        void Remover(int id);
        List<Carro> Listar();
        Carro BuscarTimePorId(int id);
        void Editar(Carro editPessoa);
        string ExibirDetalhes(int id);
    }
}
