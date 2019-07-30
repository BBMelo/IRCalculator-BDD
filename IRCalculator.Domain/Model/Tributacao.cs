using System.Collections.Generic;

namespace IRCalculator.Domain.Model
{
    public class TributacaoIRPF
    {
        public decimal Aliquota { get; private set; }
        public decimal BaseDeCalculo { get; private set; }
        public decimal ValorMinTributavel { get; private set; }
        public decimal ValorMaximoTributavel { get; private set; }
        public decimal ValorImposto { get; private set; }
        
        public List<TributacaoIRPF> ObterTributacoesIRPF()
        {            
            return  new List<TributacaoIRPF>
            {
                new TributacaoIRPF { Aliquota = 0M,    ValorMinTributavel = 0,        ValorMaximoTributavel =  1903.98M, BaseDeCalculo = 1903.98M, ValorImposto =  0},
                new TributacaoIRPF { Aliquota = 7.5M,  ValorMinTributavel = 1903.99M, ValorMaximoTributavel =  2826.65M, BaseDeCalculo = 2826.65M, ValorImposto = 142.80M},
                new TributacaoIRPF { Aliquota = 15M,   ValorMinTributavel = 2826.66M, ValorMaximoTributavel =  3751.05M, BaseDeCalculo = 3751.05M, ValorImposto = 354.80M},
                new TributacaoIRPF { Aliquota = 22.5M, ValorMinTributavel = 3751.06M, ValorMaximoTributavel =  4664.68M, BaseDeCalculo = 4664.68M, ValorImposto = 636.13M},
                new TributacaoIRPF { Aliquota = 27.5M, ValorMinTributavel = 4664.69M, ValorMaximoTributavel =  4664.69M, BaseDeCalculo = 4664.69M, ValorImposto = 869.36M},
            };
        }
    }
}