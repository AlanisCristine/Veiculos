using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carros.Repository.Data;

public static class InicializadorBd
{
    private const string ConnectionString = "Data Source=Concessionaria.db";

    public static void Inicializar()
    {
        using (var connection = new SQLiteConnection(ConnectionString))
        {
            connection.Open();
            string commandoSQL = @"   
                 CREATE TABLE IF NOT EXISTS Carros(
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 Tipo TEXT NOT NULL,
                 Modelo TEXT NOT NULL,
                 Ano INTEGER NOT NULL,
                 CapacidadeTanque DECIMAL NOT NULL,
                 Consumo DECIMAL NOT NULL,
                 DistanciaPercorrida DECIMAL NOT NULL,
                 TempoEstimado DECIMAL NOT NULL,
                 ParteCarro TEXT NOT NULL
                );";

            commandoSQL += @"   
                 CREATE TABLE IF NOT EXISTS Caminhoes(
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 Tipo TEXT NOT NULL,
                 Modelo TEXT NOT NULL,
                 Ano INTEGER NOT NULL,
                 CapacidadeTanque DECIMAL NOT NULL,
                 Consumo DECIMAL NOT NULL,
                 DistanciaPercorrida DECIMAL NOT NULL,
                 CapacidadeCarga DECIMAL NOT NULL,
                 TempoEstimado DECIMAL NOT NULL
                );";

            connection.Execute(commandoSQL);
        }
    }
}