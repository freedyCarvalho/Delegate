using System;
using System.Globalization;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo sem o Delegate

            CalculaImposto imposto = new CalculaImposto();

            // Calculo de ICMS

            double icms1 = imposto.RetornaCobrancaICMS(300, false);
            double icms2 = imposto.RetornaCobrancaICMS(343, true);
            double icms3 = imposto.RetornaCobrancaICMS(987, false);
            double icms4 = imposto.RetornaCobrancaICMS(636, false);

            // Calculo de Imposto de renda

            double irrf1 = imposto.RetornaCobrançaIRRF(300, false);
            double irrf2 = imposto.RetornaCobrançaIRRF(343, true);
            double irrf3 = imposto.RetornaCobrançaIRRF(987, false);
            double irrf4 = imposto.RetornaCobrançaIRRF(636, false);

            Console.WriteLine("Exemplo sem Delegate");
            Console.WriteLine();

            Console.WriteLine(icms1.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(icms2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(icms3.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(icms4.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine(irrf1.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(irrf2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(irrf3.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(irrf4.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();

            Console.WriteLine("Exemplo com Delegate");
            Console.WriteLine();

            // Exemplo com Delegate
            // Representa um método que possui exatamente mesma assinatura
            // ( o tipo de retorno do método (neste caso double) e o tipo e quantidade de parâmetros que o método possui) e mesmo retorno.
            // ou seja, é um tipo que permite representar um método que possui determinada "assinatura".


            // Criamos duas “variáveis” do tipo RetornaCobranca, que é o delegate e, a partir de então,
            // podemos utilizá-las como se fossem métodos.

            // Note que o valor das “variáveis” aplica_icms e aplica_irrf atribuídos na sua criação são métodos e não um objeto.
            // Esta abordagem é muito utilizada quando trabalhamos com orientação a eventos, onde um método passa a ser atribuído como valor de retorno.

            CalculaImposto imposto2 = new CalculaImposto();
            RetornaCobranca aplica_icms = imposto.RetornaCobrancaICMS;
            RetornaCobranca aplica_irrf = imposto.RetornaCobrançaIRRF;

            // Calculo de ICMS

            double icms5 = aplica_icms(300, false);
            double icms6 = aplica_icms(343, true);
            double icms7 = aplica_icms(987, false);
            double icms8 = aplica_icms(636, false);

            // Calculo de Imposto de renda

            double irrf5 = aplica_irrf(300, false);
            double irrf6 = aplica_irrf(343, true);
            double irrf7 = aplica_irrf(987, false);
            double irrf8 = aplica_irrf(636, false);

            Console.WriteLine(icms5.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(icms6.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(icms7.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(icms8.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine(irrf5.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(irrf6.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(irrf7.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(irrf8.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
