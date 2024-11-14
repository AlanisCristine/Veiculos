using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veiculos.Repository.Interfaces;

namespace Veiculos.Entidade
{
    public class Veiculo : IVeiculo
    {
        public string Tipo { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public double CapacidadeTanque { get; set; }
        public double Consumo { get; set; }
        public double DistanciaPercorida { get; set; }
        public double TempoEstimado { get; set; }

        public Veiculo(string tipo, string modelo, int ano, double capacidadeTanque, double consumo, double distanciaPercorida, double tempoEstmado)
        {
            Tipo = tipo;
            Modelo = modelo;
            Ano = ano;
            CapacidadeTanque = capacidadeTanque;
            Consumo = consumo;
            DistanciaPercorida = distanciaPercorida;
            TempoEstimado = tempoEstmado;

        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Tipo: {Tipo} \n Modelo: {Modelo} \n Ano: {Ano}  \n Capacidade do Tanque: {CapacidadeTanque}  \n Consumo: {Consumo}  \n Distancia Percorrida: {DistanciaPercorida} \nTempo Estimado:{TempoEstimado}");
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
