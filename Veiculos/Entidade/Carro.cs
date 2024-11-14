using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculos.Entidade;

public class Carro : Veiculo
{
    public string ParteCarro { get; set; }
    public Carro(string tipo, string modelo, int ano, double capacidadeTanque, double consumo, double distanciaPercorida, double tempoEstmado, string Partecarro)
        : base(tipo, modelo, ano, capacidadeTanque, consumo, distanciaPercorida, tempoEstmado)
    {
        ParteCarro = Partecarro;
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Tipo: {Tipo} \n Modelo: {Modelo} \n Ano: {Ano}  \n Capacidade do Tanque: {CapacidadeTanque}  \n Consumo: {Consumo}  \n Distancia Percorrida: {DistanciaPercorida} \n Tempo Estimado:{TempoEstimado} \n Parte do Carro: {ParteCarro}");
    }
    public double CalcularConsumo(double distancia, double Consumo)
    {
        double resultadofinal;

        if (Ano > 2007)
        {
            double resultado = distancia / Consumo;
            resultadofinal = resultado + 10;
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