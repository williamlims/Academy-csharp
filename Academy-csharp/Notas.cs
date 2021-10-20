using System;
using System.Linq;

namespace Academy_csharp
{
    class Notas
    {
        double[] nota = new double[4];
        public double Media { get; set; }

        public void InsereNotas()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Insira a nota {i+1}:");
                nota[i] = Convert.ToDouble(Console.ReadLine());
            }

            Media = nota.Sum() / 3;

            if(Media >= 7)
            {
                Console.WriteLine($"Aprovado. A média obtida foi {Media}!");
            } else
            {
                Console.WriteLine("Insira a nota do exame:");
                nota[3] = Convert.ToDouble(Console.ReadLine());

                Media = (Media + nota[3]) / 2;
                if(Media >= 5)
                {
                    Console.WriteLine($"Aprovado em exame. A média obtida foi {Media}!");
                } else
                {
                    Console.WriteLine($"Reprovado. A média obtida foi {Media}!");
                }
            }
        }
    }
}
