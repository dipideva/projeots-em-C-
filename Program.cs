using System;
using System.Collections.Generic;

class cliente
{
    private string nome;
    private string email;

    public void Nome(string nome)
    {
        Console.WriteLine($"Bem vindo {nome}! Esta é a melhor loja de camisetas.");
    }

    public void Email(string email)
    {
        string emailfnl = email;
    }
}

class compra
{
    private int OPC;
    private int CARR;
    private int pagamento;
    private string name;
    private string email;
    private string endereço;

    float somacar;
    List<float> carrinho = new List<float>();
    List<string> opctam = new List<string>();

    public void ende(string endereço)
    {
        this.endereço = endereço;
    }

    public void emai(string email)
    {
        this.email = email;
    }

    public void nam(string name)
    {
        this.name = name;
    }

    public void carr(int CARR)
    {
        Console.WriteLine("VALOR DAS CAMISTAS ESCOLHIDAS");
        Console.WriteLine("");
        foreach (float itenc in carrinho)
        {
            Console.WriteLine($"R$ {itenc}");
            somacar = somacar + itenc;
        }
        Console.WriteLine("");
        Console.WriteLine("VALOR TOTA À PAGAR");
        Console.WriteLine("");
        Console.WriteLine($"--|| R$ {somacar} ||--");
    }

    public void pagment(int pagamento)
    {
        int cont = 1;

        while (cont >= 1)
        {
            if (pagamento == 1)
            {
                Console.WriteLine("Pagamento via PIX é feito pelo CNPJ da BrezzOn, sendo ele  1234560001");
                Console.WriteLine($"Pagamento realizado com sucesso, agradecemos por comprar conosco, tmj {this.name}. mais informações serão mandadas para o seu Email, {this.email}. Sua compra sera enviado para o endereço ({this.endereço})");
                cont = cont - 1;
            }

            else if (pagamento == 2)
            {
                Console.WriteLine("Faça o cadastro do seu cartão de crédito");
                int cartao = int.Parse(Console.ReadLine());
                Console.WriteLine($"Pagamento realizado com sucesso, agradecemos por comprar conosco, tmj {this.name}. mais informações serão mandadas para o seu Email, {this.email}.Sua compra sera enviado para o endereço ({this.endereço}) ");
                cont = cont - 1;
            }

            else
            {
                Console.WriteLine("Opção escolhida invalida, você so pode escolher entre 1 - pix 2 - Cartão de credito ");
                cont = cont + 1;
                Console.WriteLine("COMO DESEJA FAZER O PAGAMENTO ? 1 - Pix // 2 - Cartão de credito");
                pagamento = int.Parse(Console.ReadLine());

            }
        }

    }
    public void opc(int OPC)
    {
        int cont = 1;

        float camiseta_1 = 169.5f;
        float camiseta_2 = 179.5f;
        float camiseta_3 = 159.5f;
        float camiseta_4 = 200.0f;
        float camiseta_5 = 250.0f;
        if (OPC == 1)
        {
            while (cont == 1)
            {
                Console.WriteLine("Licença pra chegar! Está na hora de escoher a sua camiseta preferida! Escolha a camiseta: 1, 2, 3, 4 ou 5?");
                int opc1 = int.Parse(Console.ReadLine());
                Console.WriteLine($"A camiseta {opc1} possui os tamanhos  P, M, G, GG e EGG. Qual tamanho você deseja?");
                string opctamanho = Console.ReadLine();
                if (opctamanho == "P" || opctamanho == "M" || opctamanho == "G" || opctamanho == "GG" || opctamanho == "EGG")
                {
                    if (opc1 == 1)
                    {
                        carrinho.Add(camiseta_1);
                        opctam.Add(opctamanho);
                        Console.WriteLine($"A camiseta 1, tamanho {opctamanho} foi adicionada ao carrinho");
                        Console.WriteLine("Você deseja escolher outra camisa? 1 - Sim // 2 - Não");
                        int resp1 = int.Parse(Console.ReadLine());
                        if (resp1 == 1)
                        {
                            cont = cont + 0;
                        }
                        else
                        {
                            Console.WriteLine("Suas compras foram adicionadas ao carrinho, agora é só pagar meu cria");
                            cont = cont - 1;
                        }
                    }
                    else if (opc1 == 2)
                    {
                        carrinho.Add(camiseta_2);
                        Console.WriteLine($"A camiseta 2, tamanho {opctamanho} foi adicionada ao carrinho");
                        Console.WriteLine("Você deseja escolher outra camisa? 1 - Sim // 2 - Não");
                        int resp2 = int.Parse(Console.ReadLine());
                        if (resp2 == 1)
                        {
                            cont = cont + 0;
                        }
                        else
                        {
                            Console.WriteLine("Suas compras foram adicionadas ao carrinho, agora é só pagar meu cria");
                            cont = cont - 1;
                        }
                    }
                    else if (opc1 == 3)
                    {
                        carrinho.Add(camiseta_3);
                        Console.WriteLine($"A camiseta 3, tamanho {opctamanho} foi adicionada ao carrinho");
                        Console.WriteLine("Você deseja escolher outra camisa? 1 - Sim // 2 - Não");
                        int resp3 = int.Parse(Console.ReadLine());
                        if (resp3 == 1)
                        {
                            cont = cont + 0;
                        }
                        else
                        {
                            Console.WriteLine("Suas compras foram adicionadas ao carrinho, agora é só pagar meu cria");
                            cont = cont - 1;
                        }
                    }
                    else if (opc1 == 4)
                    {
                        carrinho.Add(camiseta_4);
                        Console.WriteLine($"A camiseta 4, tamanho {opctamanho} foi adicionada ao carrinho");
                        Console.WriteLine("Você deseja escolher outra camisa? 1 - Sim // 2 - Não");
                        int resp4 = int.Parse(Console.ReadLine());
                        if (resp4 == 1)
                        {
                            cont = cont + 0;
                        }
                        else
                        {
                            Console.WriteLine("Suas compras foram adicionadas ao carrinho, agora é só pagar meu cria");
                            cont = cont - 1;
                        }
                    }
                    else if (opc1 == 5)
                    {
                        carrinho.Add(camiseta_5);
                        Console.WriteLine($"A camiseta 5, tamanho {opctamanho} foi adicionada ao carrinho");
                        Console.WriteLine("Você deseja escolher outra camisa? 1 - Sim // 2 - Não");
                        int resp5 = int.Parse(Console.ReadLine());
                        if (resp5 == 1)
                        {
                            cont = cont + 0;
                        }
                        else
                        {
                            Console.WriteLine("Suas compras foram adicionadas ao carrinho, agora é só pagar meu cria");
                            cont = cont - 1;

                        }
                    }
                }

                else
                {
                    Console.WriteLine("Tamanho invalido. Escolha o número da camiseta equivalente aos números fornecidos como opções. ");
                }
            }
        }
        else
        {
            Console.WriteLine("Sua compra foi finalizada!");
        }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        cliente i = new cliente();
        compra c = new compra();

        Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine();
        i.Nome(nome);
        c.nam(nome);
        Console.WriteLine("Digite seu email para cadastro: ");
        string email = Console.ReadLine();
        i.Email(email);
        c.emai(email);
        Console.WriteLine("Deseja ver nosso catalogo de camisetas? 1 - Sim // 2 - Não");
        int resp = int.Parse(Console.ReadLine());

        while (resp == 1)
        {
            Console.WriteLine("Camiseta 1 R$ 169,5 ");
            Console.WriteLine();
            Console.WriteLine("Camiseta 2 R$ 179,5");
            Console.WriteLine();
            Console.WriteLine("Camiseta 3 R$ 159,5");
            Console.WriteLine();
            Console.WriteLine("Camiseta 4 R$ 200,0");
            Console.WriteLine(); 
            Console.WriteLine("Camiseta 5 R$ 250,0");
            Console.WriteLine();



            Console.WriteLine("Deseja comprar alguma camiseta? 1 - Sim // 2 - Não ");
            int opc = int.Parse(Console.ReadLine());
            c.opc(opc);
            Console.WriteLine("Você deseja ver seu carrinho ? 1 - Sim // 2 - Não");
            int carrin = int.Parse(Console.ReadLine());
            c.carr(carrin);
            Console.WriteLine("Digite seu indereço para enviarmos seu pedido");
            string ender = Console.ReadLine();
            c.ende(ender);
            Console.WriteLine("COMO DESEJA FAZER O PAGAMENTO ? 1 - Pix // 2 - Cartão de credito");
            int formapag = int.Parse(Console.ReadLine());
            c.pagment(formapag);

            resp = resp - 1;
        }
    }
}
