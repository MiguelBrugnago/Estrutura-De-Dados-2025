﻿using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> encomendas = new Dictionary<string, int>();

        Console.WriteLine("Quantas encomendas deseja cadastrar?");
        int qtd = int.Parse(Console.ReadLine());

        for (int i = 0; i < qtd; i++)
        {
            Console.WriteLine($"\nCadastro {i + 1}:");

            Console.Write("Informe o código de rastreio: ");
            string rastreio = Console.ReadLine();

            Console.Write("Informe o código de barras: ");
            int codigoBarras = int.Parse(Console.ReadLine());

            if (encomendas.ContainsKey(rastreio))
            {
                Console.WriteLine("Esse código de rastreio já existe. Tente outro.");
                i--; 
                continue;
            }

            if (encomendas.ContainsValue(codigoBarras))
            {
                Console.WriteLine("Esse código de barras já está cadastrado. Tente outro.");
                i--; 
                continue;
            }

            encomendas.Add(rastreio, codigoBarras);
            Console.WriteLine("Cadastro realizado com sucesso!");
        }

        Console.WriteLine("\nDigite o código de barras que deseja buscar:");
        int busca = int.Parse(Console.ReadLine());

        bool encontrado = false;
        foreach (var item in encomendas)
        {
            if (item.Value == busca)
            {
                Console.WriteLine($"Encontrado! Rastreio: {item.Key}");
                encontrado = true;
                break;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("Código de barras não encontrado.");
        }
    }
}