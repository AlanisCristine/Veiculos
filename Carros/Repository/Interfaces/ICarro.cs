using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veiculos.Entidade;

namespace Carros.Repository.Interfaces
{
    public interface ICarro
    {
        void Adicionar(Carro carro);
        void Remover(int id);
        void Editar(Carro carrinho);
        List<Carro> Listar();
        Carro BuscarPorId(int id);
    }
}
