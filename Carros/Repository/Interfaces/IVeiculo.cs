using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carros.Repository.Interfaces
{
    public interface IVeiculo
    {
        string ExibirDetalhes();
        double CalcularConsumo(double distancia, double consumo);
    }
}
