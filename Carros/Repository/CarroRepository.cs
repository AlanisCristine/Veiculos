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
    public class CarroRepository : ICarro
    {
        private readonly string ConnectionString;

        public CarroRepository(IConfiguration config)
        {
            ConnectionString = config.GetConnectionString("DefaultConnection");
        }

        public void Adicionar(Carro carro)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Carro>(carro);
        }
        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Carro carrinho = BuscarPorId(id);
            connection.Delete<Carro>(carrinho);
        }
        public void Editar(Carro carrinho)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Carro>(carrinho);
        }
        public List<Carro> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Carro>().ToList();
        }
        public Carro BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Carro>(id);
        }
    }
}
