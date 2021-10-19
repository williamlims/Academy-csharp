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
            this.SalarioFuncionario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual o salário mínimo atual?");
            this.SalarioMinimo = Convert.ToDouble(Console.ReadLine());

            this.Salarios = this.SalarioFuncionario / this.SalarioMinimo;
            Console.WriteLine($"O Funcionário recebe {this.Salarios} sálarios mínimo!");
        }

    }
}
