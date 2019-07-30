using FluentAssertions;

namespace IRCalculator.XUnit.Driver
{
    public class IRCalculatorDriver
    {
        private Domain.ImpostoDeRenda _calculator;

        public void NewCalc()
        {
            _calculator = new Domain.ImpostoDeRenda(default);
        }

        public void AdicionarSalario(decimal salario) => _calculator.AdicionarSalario(salario);

        public void CalcularIR() => _calculator.CalcularIRPF();        

        public void ChecarSalario(decimal salarioEsperado) => _calculator.SalarioLiquido.Should().BeApproximately(salarioEsperado, 1);
    }
}
