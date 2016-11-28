using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DojoBank
{
    public static class JurosCompostos
    {
        public static double Calcular(double valor, int meses, double taxa)
            => Math.Round((valor * Math.Pow((1 + taxa), meses)), 2);
    }
}
