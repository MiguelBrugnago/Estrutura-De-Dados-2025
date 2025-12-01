using System;

class Program
{
    static void Main()
    {
        string[] vetor = { "10", "4", "53", "12", "67", "60", "234", "1", "87", "100" };

        Console.Write("Digite o número a ser pesquisado: ");
        string entrada = Console.ReadLine() ?? "";

        bool encontrado = false;

        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] == entrada)
            {
                Console.WriteLine("Encontrado na posição: " + i);
                encontrado = true;
                break;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("não encontrado");
        }
    }
}
