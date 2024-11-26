using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veiculos.Entidade;

namespace Carros.Service.Interface
{
    public interface ICaminhaoService
    {
        void Adicionar(Caminhao carrinho);
        void Remover(int id);
        List<Caminhao> Listar();
        Caminhao BuscarTimePorId(int id);
        void Editar(Caminhao editPessoa);
        string ExibirDetalhes(int id);
    }
}
