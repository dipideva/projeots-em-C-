using System;
using System.Collections.Generic;

class Cliente
{
    public string Nome { get; set; }
    public string Email { get; set; }
}

class Compra
{
    public void AdicionarItens(int opcaoDeCompra)
    {
        List<float> carrinho = new List<float>();
        List<string> opctam = new List<string>();

        float[] precosCamisetas = { 20.5f, 30.5f, 30.5f, 40.0f, 70.0f };

        while (opcaoDeCompra == 1)
        {
            Console.WriteLine("Qual deseja comprar 1, 2, 3, 4, ou 5?");
            int opcaoCamiseta = int.Parse(Console.ReadLine());
            if (opcaoCamiseta < 1 || opcaoCamiseta > 5)
            {
                Console.WriteLine("Valor inválido. Escolha o número da camiseta equivalente aos números fornecidos como opções.");
                continue;
            }

            Console.WriteLine($"A camiseta {opcaoCamiseta} possui os tamanhos P, M, G, GG e EGG. Qual tamanho você deseja?");
            string tamanho = Console.ReadLine();

            carrinho.Add(precosCamisetas[opcaoCamiseta - 1]);
            opctam.Add(tamanho);

            Console.WriteLine($"A camiseta {opcaoCamiseta}, tamanho {tamanho}, foi adicionada ao carrinho.");
            Console.WriteLine("Você deseja escolher outra camisa? 1 - Sim // 2 - Não");
            int resposta = int.Parse(Console.ReadLine());
            if (resposta != 1)
            {
                break;
            }
        }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite seu nome:");
        string nome = Console.ReadLine();
        Console.WriteLine($"Bem vindo {nome}! Esta é a melhor loja de camisetas.");
        Console.WriteLine();
        Console.WriteLine("Deseja ver nosso catálogo de camisetas? 1 - Sim // 2 - Não");
        int resp = int.Parse(Console.ReadLine());

        while (resp == 1)
        {
            Console.WriteLine(
                "Camiseta 1 R$ 20,5\n" +
                "Camiseta 2 R$ 30,5\n" +
                "Camiseta 3 R$ 30,5\n" +
                "Camiseta 4 R$ 40,0\n" +
                "Camiseta 5 R$ 70,0\n"
            );

            Compra compra = new Compra();

            Console.WriteLine("Deseja comprar alguma camiseta? 1 - Sim // 2 - Não ");
            int opc = int.Parse(Console.ReadLine());
            compra.AdicionarItens(opc);

            Console.WriteLine("Deseja continuar vendo o catálogo? 1 - Sim // 2 - Não");
            resp = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Sua compra foi finalizada. Obrigado!");
    }
}
