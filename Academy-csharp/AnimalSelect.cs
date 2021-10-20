using System;

namespace Academy_csharp
{
    class AnimalSelect
    {
        Animal[] estimacao = new Animal[5];
        Animal propriedade = new Animal();
        public int numCachorro = 0;
        public int numGato = 0;
        public int numPeixe = 0;
      
        public void InformaAnimais()
        {
            Console.WriteLine("TIPOS DE ANIMAIS PERMITIDOS SÃO: cachorro, gato e peixe.\nDiferente disso será considerado peixe!");
            for (int i = 0; i < 5; i++)
            {
                string tempName;
                Console.WriteLine($"Insira o nome do {i + 1}º Animal:");
                propriedade.Nome = Console.ReadLine();

                Console.WriteLine($"Insira o tipo do {i + 1}º Animal:");
                tempName = Console.ReadLine();

                switch (tempName)
                {
                    case "cachorro":
                        propriedade.Tipo = "cachorro";
                        numCachorro++;
                        break;
                    case "gato":
                        propriedade.Tipo = "gato";
                        numGato++;
                        break;
                    case "peixe":
                        propriedade.Tipo = "peixe";
                        numPeixe++;
                        break;
                    default:
                        propriedade.Tipo = "peixe";
                        numPeixe++;
                        break;
                }
                estimacao[i] = propriedade;
            }

            Console.WriteLine("Lista de Animais:");
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine($"Animal {j}: Nome {estimacao[j].Nome}, Tipo {estimacao[j].Tipo}");
            }      
            Console.WriteLine($"Foram inseridos {numCachorro} cachorros, {numGato} gatos e {numPeixe} peixes!");
        }
    }
}
