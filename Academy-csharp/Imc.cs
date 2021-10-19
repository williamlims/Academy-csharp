using System;

namespace Academy_csharp
{
    class Imc
    {
        public double IMC { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }

        public void CalculaIMC()
        {
            Console.WriteLine("Insira o seu Peso:");
            this.Peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira a sua Altura:");
            this.Altura = Convert.ToDouble(Console.ReadLine());

            this.IMC = this.Peso / this.Altura;

            if (this.IMC < 20)
            {
                Console.WriteLine("Abaixo do peso!");
            } 
            else if (this.IMC >= 20 && this.IMC < 25)
            {
                Console.WriteLine("Peso Ideal!");
            }
            else
            {
                Console.WriteLine("Acima do peso!");
            }

            static void Main(string[] args)
            {
                Imc Im = new Imc();
                Im.CalculaIMC();
            }
        }
    }
}
