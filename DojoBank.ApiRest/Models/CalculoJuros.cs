using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DojoBank.ApiRest.Models
{
    public class CalculoJuros
    {
        public double Valor { get; private set; }
        public int Meses { get; private set; }
        public double Taxa { get; private set; }
        public double ValorComJuros { get;}

        public CalculoJuros(double valor, int meses, double taxa)
        {
            Valor = valor;
            Meses = meses;
            Taxa = taxa;

            ValorComJuros = JurosCompostos.Calcular(Valor, Meses, Taxa);
        }

    }
}