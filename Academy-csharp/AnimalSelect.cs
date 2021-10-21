using System;
using System.Collections.Generic;

namespace Academy_csharp
{
    class AnimalSelect
    {
        List<Animal> estimacao = new List<Animal>();

        public int numCachorro = 0;
        public int numGato = 0;
        public int numPeixe = 0;
      
        public void InformaAnimais()
        {
            Console.WriteLine("TIPOS DE ANIMAIS PERMITIDOS SÃO: cachorro, gato e peixe.\nDiferente disso será considerado peixe!");
            for (int i = 0; i < 5; i++)
            {
                string tempName;
                string nome;
                string tipo;
                Console.WriteLine($"Insira o nome do {i + 1}º Animal:");
                nome = Console.ReadLine();

                Console.WriteLine($"Insira o tipo do {i + 1}º Animal:");
                tempName = Console.ReadLine();

                switch (tempName)
                {
                    case "cachorro":
                        tipo = "cachorro";
                        numCachorro++;
                        break;
                    case "gato":
                        tipo = "gato";
                        numGato++;
                        break;
                    case "peixe":
                        tipo = "peixe";
                        numPeixe++;
                        break;
                    default:
                        tipo = "peixe";
                        numPeixe++;
                        break;
                }
                estimacao.Add(new Animal(nome, tipo));
            }

            Console.WriteLine("Lista de Animais:");
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine($"Animal {j+1}: Nome {estimacao[j].Nome}, Tipo {estimacao[j].Tipo}");
            }      
            Console.WriteLine($"Foram inseridos {numCachorro} cachorros, {numGato} gatos e {numPeixe} peixes!");

            numCachorro = numGato = numPeixe = 0;

        }
    }
}
