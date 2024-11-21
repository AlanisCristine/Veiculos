using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veiculos.Entidade;

namespace Carros.Repository.Interfaces
{
    public interface ICaminhao
    {
        void Adicionar(Caminhao carro);
        void Remover(int id);
        void Editar(Caminhao carrinho);
        List<Caminhao> Listar();
        Caminhao BuscarPorId(int id);
    }
}
