using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    // o tipo delegate possui a sintaxe semelhante a de um método, mas não possui implementação (corpo)
    // o retorno continua sendo double e os parâmetros são do mesmo tipo e quantidade dos métodos
    // RetornaCobrancaICMS e RetornaCobrancaIRRF

    // com isso, tornamos o nosso código mais fácil de ler e também para que digitemos menos linhas de código

    // O Delegate chamado RetornaCobranca, representará um ou vários métodos de cálculo de imposto

    delegate double RetornaCobranca(double montante, bool isento);

    class CalculaImposto
    {
        public double RetornaCobrancaICMS(double montante, bool isento)
        {
            double valorCobrado = 0.0;

            if (!isento)
            {
                valorCobrado = montante * 0.20;
            }

            return valorCobrado;
        }

        public double RetornaCobrançaIRRF(double montante, bool isento)
        {
            double valorCobrado = 0.0;

            if (!isento)
            {
                if (montante >= 2000.0 && montante <= 4000.0)
                {
                    valorCobrado = montante * 0.15;
                }

                if (montante > 4000.0)
                {
                    valorCobrado = montante * 0.35;
                }

            }

            return valorCobrado;
        }
    }
}
