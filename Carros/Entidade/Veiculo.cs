using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carros.Repository.Interfaces;

namespace Veiculos.Entidade
{
    public class Veiculo : IVeiculo
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public decimal CapacidadeTanque { get; set; }
        public decimal Consumo { get; set; }
        public decimal DistanciaPercorrida { get; set; }
        public decimal TempoEstimado { get; set; }

        public Veiculo(int id, string tipo, string modelo, int ano, decimal capacidadeTanque, decimal consumo, decimal distanciaPercorida, decimal tempoEstmado)
        {
            Id = id;
            Tipo = tipo;
            Modelo = modelo;
            Ano = ano;
            CapacidadeTanque = capacidadeTanque;
            Consumo = consumo;
            DistanciaPercorrida = distanciaPercorida;
            TempoEstimado = tempoEstmado;

        }
        public Veiculo()
        {

        }
        public virtual string ExibirDetalhes()
        {
            string MensagemExibirDetalhes = $"Modelo: {Modelo}" +
            $"\n Ano: {Ano}  " +
            $"\n Capacidade do Tanque: {CapacidadeTanque}L " +
            $"\n Consumo: {Consumo}km/l";
           
            return MensagemExibirDetalhes;
        }

        public double CalcularConsumo(double distancia, double Consumo)
        {
            double resultadofinal;

            if (Ano > 2007)
            {
                double resultado = distancia / Consumo;
                resultadofinal = resultado + 10;
                Console.WriteLine(resultadofinal);
            }
            else
            {
                 resultadofinal = distancia / Consumo;
                Console.WriteLine(resultadofinal);
            }
            return resultadofinal;
        }
    }
}
