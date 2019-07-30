using IRCalculator.XUnit.Driver;
using System.Globalization;
using Xbehave;

namespace IRCalculator.XUnit
{
    public class IrCalculatorFeature
    {
        private readonly IRCalculatorDriver _driver;

        public IrCalculatorFeature()
        {
            _driver = new IRCalculatorDriver();
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        }

        [Scenario]
        [Example(680, 680)]
        [Example(6357.66, 5478.66)]
        [Example(3152.38, 3034.31)]
        [Example(16837.66, 13076.66)]
        public void CalcularIR(decimal salario, int salarioExperado)
        {
            $"Dado um novo c�lculo de IR"
                 .x(() => { _driver.NewCalc(); });
     
            $"E preencho a propriedade sal�rio com o valor {salario}"
                .x(() => { _driver.AdicionarSalario(salario); });

            "Quando executo o c�lculo do IR"
                .x(() => { _driver.CalcularIR(); });

            $"Ent�o o sal�rio liquido dever� ser {salarioExperado}"
                .x(() => { _driver.ChecarSalario(salarioExperado); });

        }
    }
}
