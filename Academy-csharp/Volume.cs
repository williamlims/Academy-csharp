using System;
using System.Collections.Generic;
using System.Text;

namespace Academy_csharp
{
    class Volume
    {
        public double Raio { get; set; }
        public double Vol { get; set; }

        public void CalculaRaio()
        {
            Console.WriteLine("Insira o Raio da Esfera:");
            this.Raio = Convert.ToDouble(Console.ReadLine());

            this.Vol = (4 / 3) * Math.PI * Math.Pow(this.Raio, 3);
            Console.WriteLine($"O raio é {this.Raio} e o volume é {this.Vol}!");
        }
    }
}
