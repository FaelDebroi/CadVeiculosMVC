using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadVeiculos
{
    class VeiculoController
    {
        internal string Salvar(string placa, string modelo)
        {
            Veiculo v = new Veiculo();
            v.Placa = placa;
            v.Modelo = modelo;

            return v.Inserir();            
        }

        internal string Excluir(string placa)
        {
            Veiculo v = new Veiculo();
            v.Placa = placa;

            return v.Excluir();
        }

        internal List<Veiculo> Listar()
        {
            return Veiculo.listaVeiculos();
        }
    }
}
