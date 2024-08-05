using System.Collections.Generic;
class cliente
{
    public string nome;
    public string email;

}
class compra
{
    private int OPC;

    public void opc(int OPC)
    {
        int cont = 1;
        List<float> carrinho = new List<float>();
        List<string> opctam = new List<string>();
        float camiseta_1 = 20.5f;
        float camiseta_2 = 30.5f;
        float camiseta_3 = 30.5f;
        float camiseta_4 = 40.0f;
        float camiseta_5 = 70.0f;
        if (OPC == 1)
        {
            while (cont == 1)
            {
                Console.WriteLine("Qual deseja comprar 1,2,3,4, ou 5 ?");
                int opc1 = int.Parse(Console.ReadLine());
                Console.WriteLine($"A camiseta {opc1} possui os tamanhos P,M,G,GG e EGG. Qual tamanho você deseja ?");
                string opctamanho = Console.ReadLine();
                if (opc1 == 1)
                {
                    carrinho.Add(camiseta_1);
                    opctam.Add(opctamanho);
                    Console.WriteLine($"A camiseta 1, tamanho {opctamanho} foi adicionada ao carrinho foi adicionado ao carrinho");
                    Console.WriteLine("Você deseja escolher outra camisa ? 1 - Sim // 2 - Não");
                    int resp1 = int.Parse(Console.ReadLine());
                    if (resp1 == 1)
                    {
                        cont = cont + 1;
                    }
                    else
                    {
                        cont = cont - 1;
                        break;
                    }
                }
                else if (opc1 == 2)
                {
                    carrinho.Add(camiseta_2);
                    Console.WriteLine($"A camiseta 2, tamanho {opctamanho} foi adicionada ao carrinho foi adicionado ao carrinho");
                    Console.WriteLine("Você deseja escolher outra camisa ? 1 - Sim // 2 - Não");
                    int resp2 = int.Parse(Console.ReadLine());
                    if (resp2 == 1)
                    {
                        cont = cont + 1;
                    }
                    else
                    {
                        cont = cont - 1;
                        break;
                    }
                }
                else if (opc1 == 3)
                {
                    carrinho.Add(camiseta_3);
                    Console.WriteLine($"A camiseta 3, tamanho {opctamanho} foi adicionada ao carrinho foi adicionado ao carrinho");
                    Console.WriteLine("Você deseja escolher outra camisa ? 1 - Sim // 2 - Não");
                    int resp3 = int.Parse(Console.ReadLine());
                    if (resp3 == 1)
                    {
                        cont = cont + 1;
                    }
                    else
                    {
                        cont = cont - 1;
                        break;
                    }
                }
                else if (opc1 == 4)
                {
                    carrinho.Add(camiseta_4);
                    Console.WriteLine($"A camiseta 4, tamanho {opctamanho} foi adicionada ao carrinho foi adicionado ao carrinho");
                    Console.WriteLine("Você deseja escolher outra camisa ? 1 - Sim // 2 - Não");
                    int resp4 = int.Parse(Console.ReadLine());
                    if (resp4 == 1)
                    {
                        cont = cont + 1;
                    }
                    else
                    {
                        cont = cont - 1;
                        break;
                    }
                }
                else if (opc1 == 5)
                {
                    carrinho.Add(camiseta_5);
                    Console.WriteLine($"A camiseta 5, tamanho {opctamanho} foi adicionada ao carrinho foi adicionado ao carrinho");
                    Console.WriteLine("Você deseja escolher outra camisa ? 1 - Sim // 2 - Não");
                    int resp5 = int.Parse(Console.ReadLine());
                    if (resp5 == 1)
                    {
                        cont = cont + 1;
                    }
                    else
                    {
                        cont = cont - 1;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Valor invalido. escolha o numero da camiseta equivalente aos numeros fornecidos como opçôes. ");
                }
            }
        }
        else { Console.WriteLine("Sua compra foi finalizada"); }
    }


    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine();
            Console.WriteLine($"Bem vindo {nome}! Esta é a melhor loja de camisetas.");
            Console.WriteLine();
            Console.WriteLine("Deseja ver nosso catalogo de camisetas? 1 - Sim // 2 - Não");
            int resp = int.Parse(Console.ReadLine());

            while (resp == 1)
            {

                Console.WriteLine(
                    "Camiseta 1 R$ 20,5 " +
                    "Camiseta 2 R$ 30,5" +
                    "Camiseta 3 R$ 30,5" +
                    "Camiseta 4 R$ 40,0" +
                    "Camiseta 5 R$ 70,0");


                compra c = new compra();

                Console.WriteLine("Deseja comprar alguma camiseta ? 1 - Sim // 2 - Não ");
                int opc = int.Parse(Console.ReadLine());
                c.opc(opc);

            }
