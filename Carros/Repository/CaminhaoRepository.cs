using Carros.Repository.Interfaces;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veiculos.Entidade;

namespace Carros.Repository
{
    public class CaminhaoRepository: ICaminhao
    {
        private readonly string ConnectionString;

        public CaminhaoRepository(IConfiguration config)
        {
            ConnectionString = config.GetConnectionString("DefaultConnection");
        }

        public void Adicionar(Caminhao carro)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Caminhao>(carro);
        }

        public string ExibirDetalhes(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Caminhao caminhao = BuscarPorId(id);
            return caminhao.ExibirDetalhes();
        }
      
        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Caminhao carrinho = BuscarPorId(id);
            connection.Delete<Caminhao>(carrinho);
        }
        public void Editar(Caminhao carrinho)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Caminhao>(carrinho);
        }
        public List<Caminhao> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Caminhao>().ToList();
        }
        public Caminhao BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Caminhao>(id);
        }

    }
}
