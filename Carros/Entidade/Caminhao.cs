using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Veiculos.Entidade
{
    [Table("Caminhoes")]
    public class Caminhao : Veiculo
    {
        public decimal CapacidadeCarga { get; set; }
        public Caminhao(int id, string tipo, string modelo, int ano, decimal capacidadeTanque, decimal consumo, decimal distanciaPercorida, decimal Capacidadecarga)
            : base(id, tipo, modelo, ano, capacidadeTanque, consumo, distanciaPercorida, Capacidadecarga)
        {
            CapacidadeCarga = Capacidadecarga;
        }
        public Caminhao()
            :base()
        {

        }
        public override string ExibirDetalhes()
        {
            string mensagemDetalhes = base.ExibirDetalhes();
            mensagemDetalhes += $"Tipo: {Tipo}" +
                 $"Capacidade de CARGA: {CapacidadeCarga}";

            return mensagemDetalhes;
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