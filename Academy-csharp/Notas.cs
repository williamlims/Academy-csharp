using System;
using System.Linq;

namespace Academy_csharp
{
    class Notas
    {
        double[] nota = new double[] { };
        public double Media { get; set; }

        public void InsereNotas()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Insira a nota {i+1}:");
                double var = Convert.ToDouble(Console.ReadLine());
                nota.Append(var);
            }

            this.Media = nota.Sum() / 3;

            if(this.Media >= 7)
            {
                Console.WriteLine($"Aprovado. A média obtida foi {this.Media}!");
            } else
            {
                Console.WriteLine("Insira a nota do exame:");
                double var = Convert.ToDouble(Console.ReadLine());
                nota.Append(var);

                this.Media = (this.Media + (nota.Last)) / 2;
                if(this.Media >= 5)
                {
                    Console.WriteLine($"Aprovado em exame. A média obtida foi {this.Media}!");
                } else
                {
                    Console.WriteLine($"Reprovado. A média obtida foi {this.Media}!");
                }

            }
        }
    }
}
