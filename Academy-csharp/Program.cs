using System;

namespace Academy_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Imc imc = new Imc();
            Salario salario = new Salario();
            Volume volume = new Volume();
            Notas notas = new Notas();
            AnimalSelect animal = new AnimalSelect();
            int controle = 1000;

            while(controle != 0)
            {
                Console.WriteLine("######## Escolha uma opção: #################");
                Console.WriteLine("Digite 1 para rodar CALCULAR O IMC <");
                Console.WriteLine("Digite 2 para rodar CALCULAR O SALÁRIO <");
                Console.WriteLine("Digite 3 para rodar CALCULAR O VOLUME <");
                Console.WriteLine("Digite 4 para rodar CALCULAR A NOTA <");
                Console.WriteLine("Digite 5 para rodar INSERIR LISTA DE ANIMAIS <");
                Console.WriteLine("Digite 0 para SAIR >");
                controle = Convert.ToInt32(Console.ReadLine());

                switch (controle)
                {
                    case 1:
                        Console.Clear();
                        imc.CalculaIMC();
                        Console.WriteLine("Clique em qualquer tecla para voltar ao menu principal!");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        salario.VerificaSalarios();
                        Console.WriteLine("Clique em qualquer tecla para voltar ao menu principal!");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        volume.CalculaRaio();
                        Console.WriteLine("Clique em qualquer tecla para voltar ao menu principal!");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        notas.InsereNotas();
                        Console.WriteLine("Clique em qualquer tecla para voltar ao menu principal!");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        Console.Clear();
                        animal.InformaAnimais();
                        Console.WriteLine("Clique em qualquer tecla para voltar ao menu principal!");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 0:
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("OPÇÃO INVALIDA.");
                        Console.WriteLine("Clique em qualquer tecla para voltar ao menu principal!");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }

            Console.WriteLine("OPERAÇÃO CONCLUÍDA!");

        }
    }
}
