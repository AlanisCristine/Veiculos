using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculos.Repository.Interfaces
{
    public interface IVeiculo
    {
        void ExibirDetalhes();
        double CalcularConsumo(double distancia, double consumo);
    }
}
