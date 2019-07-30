using System;

namespace IRCalculator.IRConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal salario1 = 16837.66m;
            decimal salario2 = 2000.25m;
            decimal salario3 = 2999.30m;
            decimal salario4 = 4005.00m;
            decimal salario5 = 6357.66m;

            Console.WriteLine(string.Format("Salário de R$ {0} ficará R$ {1}",salario1, new Domain.ImpostoDeRenda(salario1).CalcularIRPF().ToString("n2")));
            Console.WriteLine(string.Format("Salário de R$ {0} ficará R$ {1}",salario2, new Domain.ImpostoDeRenda(salario2).CalcularIRPF().ToString("n2")));
            Console.WriteLine(string.Format("Salário de R$ {0} ficará R$ {1}",salario3, new Domain.ImpostoDeRenda(salario3).CalcularIRPF().ToString("n2")));
            Console.WriteLine(string.Format("Salário de R$ {0} ficará R$ {1}",salario4, new Domain.ImpostoDeRenda(salario4).CalcularIRPF().ToString("n2")));
            Console.WriteLine(string.Format("Salário de R$ {0} ficará R$ {1}",salario5, new Domain.ImpostoDeRenda(salario5).CalcularIRPF().ToString("n2")));            
           
            Console.ReadLine();
        }
    }
}