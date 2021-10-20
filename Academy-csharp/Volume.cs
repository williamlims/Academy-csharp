using System;

namespace Academy_csharp
{
    class Volume
    {
        public double Raio { get; set; }
        public double Vol { get; set; }

        public void CalculaRaio()
        {
            Console.WriteLine("Insira o Raio da Esfera:");
            Raio = Convert.ToDouble(Console.ReadLine());

            Vol = (4 / 3) * Math.PI * Math.Pow(Raio, 3);
            Console.WriteLine($"O raio é {Raio} e o volume é {Vol}!");
        }
    }
}
