using Veiculos.Entidade;
using Veiculos.Repository.Interfaces;

Carro carro1 = new Carro("Carro", "Palio", 2007, 10, 10, 50,1, "sedan");
carro1.ExibirDetalhes();
carro1.CalcularConsumo(10, 10);

Caminhao caminhao1 = new Caminhao("Caminhao", "Grande", 2010, 5.0, 2, 15.0, 50.0);
caminhao1.ExibirDetalhes();
caminhao1.CalcularConsumo(15.0, 2, 50);

List<IVeiculo> veiculos= new List<IVeiculo>();
veiculos.Add(carro1);
veiculos.Add(caminhao1);
foreach (IVeiculo p in veiculos)
{
    p.ExibirDetalhes();
}