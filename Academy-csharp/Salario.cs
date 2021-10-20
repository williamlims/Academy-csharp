using System;

namespace Academy_csharp
{
    class Salario
    {
        public double SalarioFuncionario { get; set; }
        public double SalarioMinimo { get; set; }
        public double Salarios { get; set; }

        public void VerificaSalarios()
        {
            Console.WriteLine("Qual o salário do funcionário?");
            SalarioFuncionario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual o salário mínimo atual?");
            SalarioMinimo = Convert.ToDouble(Console.ReadLine());

            Salarios = SalarioFuncionario / SalarioMinimo;
            Console.WriteLine($"O Funcionário recebe {Salarios} sálarios mínimo!");
        }

    }
}
