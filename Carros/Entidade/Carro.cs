using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculos.Entidade;

public class Carro : Veiculo
{
    public string ParteCarro { get; set; }
    public Carro(int id, string tipo, string modelo, int ano, decimal capacidadeTanque, decimal consumo, decimal distanciaPercorida, decimal tempoEstmado, string Partecarro)
        : base(id, tipo, modelo, ano, capacidadeTanque, consumo, distanciaPercorida, tempoEstmado)
    {
        ParteCarro = Partecarro;
    }
    public Carro()
            : base()
    {

    }
    public override string ExibirDetalhes()
    {
        string mensagemDetalhes = base.ExibirDetalhes();
        mensagemDetalhes += 
             $"Parte do Carro: {ParteCarro}";

        return mensagemDetalhes;
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