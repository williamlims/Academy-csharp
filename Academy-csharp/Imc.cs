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
            Peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira a sua Altura:");
            Altura = Convert.ToDouble(Console.ReadLine());

            IMC = Peso / (Altura * Altura);

            if (IMC < 20)
            {
                Console.WriteLine("Abaixo do peso!");
            } 
            else if (IMC >= 20 && IMC < 25)
            {
                Console.WriteLine("Peso Ideal!");
            }
            else
            {
                Console.WriteLine("Acima do peso!");
            }
        }
    }
}
