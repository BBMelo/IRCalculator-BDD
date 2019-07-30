using IRCalculator.Domain.Model;
using System.Collections.Generic;
using System.Linq;

namespace IRCalculator.Domain
{
    public class ImpostoDeRenda
    {
        private decimal _salarioBaseCalculo { get; set; }     
        public decimal SalarioLiquido { get; private set; }
        private IReadOnlyList<TributacaoIRPF> Tributacoes { get; set; }
       
        public ImpostoDeRenda(decimal salario)
        {
            this._salarioBaseCalculo = salario;
            Tributacoes = new TributacaoIRPF().ObterTributacoesIRPF();
        }
       
        public void AdicionarSalario(decimal salario) => _salarioBaseCalculo = salario;

        public decimal CalcularIRPF()
        {
            var _tributos = Tributacoes
                .Where(x => _salarioBaseCalculo >= x.ValorMinTributavel 
                && _salarioBaseCalculo <= x.ValorMaximoTributavel 
                || (_salarioBaseCalculo > x.ValorMaximoTributavel)).ToList();

            if (_tributos == null || !_tributos.Any())
                return SalarioLiquido;

            var imposto = _tributos.Where(x => x.Aliquota == _tributos.Max(a => a.Aliquota)).FirstOrDefault();
            return SalarioLiquido = (_salarioBaseCalculo - (_salarioBaseCalculo * imposto.Aliquota / 100 - imposto.ValorImposto));                        
        }
    }
}