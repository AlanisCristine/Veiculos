using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Veiculos.Entidade
{
    public class Caminhao : Veiculo
    {
        public double CapacidadeCarga { get; set; }
        public Caminhao(string tipo, string modelo, int ano, double capacidadeTanque, double consumo, double distanciaPercorida, double Capacidadecarga)
            : base(tipo, modelo, ano, capacidadeTanque, consumo, distanciaPercorida, Capacidadecarga)
        {
            CapacidadeCarga = Capacidadecarga;
        }
        public void ExibirDetalhes()
        {
            Console.WriteLine($"Tipo: {Tipo} \n Modelo: {Modelo} \n Ano: {Ano}  \n Capacidade do Tanque: {CapacidadeTanque}  \n Consumo: {Consumo}  \n Distancia Percorrida: {DistanciaPercorida} \nTempo Estimado:{TempoEstimado}  \n Capacidade Carga:{CapacidadeCarga}");
        }

        public double CalcularConsumo(double distancia, double Consumo, double capacidadecarga)
        {
            double resultadofinal;

            if (CapacidadeCarga > 2)
            {
                double resultado = distancia * Consumo;
                resultadofinal = resultado / capacidadecarga;
                Console.WriteLine($" o Consumo foi de: {resultadofinal}");
            }
            else
            {
                resultadofinal = distancia / Consumo;
                Console.WriteLine($" o Consumo foi de: {resultadofinal}");
            }
            return resultadofinal;
        }

    }

}