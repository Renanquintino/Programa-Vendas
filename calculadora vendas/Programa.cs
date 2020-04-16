using System;

namespace calculadora_vendas
{
    class Program
    {
#pragma warning disable IDE0060 // Remover o parâmetro não utilizado
        public static void Main(string[] args)
#pragma warning restore IDE0060 // Remover o parâmetro não utilizado
        {
            Console.WriteLine("                                 Pizante.com         ");

            Console.WriteLine("                                  Nova venda        ");



            Console.WriteLine();
            Console.WriteLine("                               Vendedor             ");

            Console.WriteLine("Digite o codigo do vendedor");

            int Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Nome do vendedor");

            string Nome = Console.ReadLine();
            Vendedor V1 = new Vendedor(Id, Nome);

            Console.WriteLine("                               Produto             ");

            Console.WriteLine("Digite o codigo do produto");

            int Cod = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o modelo do produto");

            string Modelo = Console.ReadLine();
            Console.WriteLine("Digite o tamanho do produto");

            int Tamanho = int.Parse(Console.ReadLine());


            Console.WriteLine("Marca");

            string Marca = Console.ReadLine();

            Produto p1 = new Produto(Cod, Modelo, Tamanho, Marca);
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine();

            Console.WriteLine("Digite o valor do Produto");
            double valor = double.Parse(Console.ReadLine());


            Console.WriteLine("vendedor:" + Nome);


            Console.WriteLine("Produto:  " + " Cod. Produto  " + Cod + " Tamanho  " + Tamanho + "  Modelo   " + Marca + "   " + Modelo);

            Console.WriteLine("Valor" + valor);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                 Forma de pagamento              ");
            Console.WriteLine(" 1) a vista");
            Console.WriteLine("2) cartao de credito");
            Console.WriteLine("3) carnê");

            Console.Write("Digite a opção desejada:");
            int N = int.Parse(Console.ReadLine());
            if (N > 0 && N < 2)
            {
                if (valor > 140 && valor < 160)
                {
                    double desconto = (valor / 100) * 20;
                    Console.WriteLine("valor com desconto: " + (valor - desconto));

                }
                else if (valor > 100 && valor < 140)
                {
                    double desconto = (valor / 100) * 10;
                    Console.WriteLine("valor com desconto: " + (valor - desconto));
                }
                else if (valor > 160)
                {
                    double desconto = (valor / 100) * 30;
                    Console.WriteLine("valor com desconto: " + (valor - desconto)); Console.WriteLine(valor);
                }
                else if (valor < 100)
                {
                    Console.WriteLine(valor);
                }
                else if (N > 1 && N < 3)
                {
                    Console.WriteLine("quantidade de parcelas(todas as compras no carne tem um acrescimo de 9 % de juros)");
                    int P = int.Parse(Console.ReadLine());
                    if (P > 1 && P <= 10)
                    {
                        double juro = (valor / 100) * 5;
                        Console.WriteLine("Total com juros = " + (valor + juro));
                        Console.WriteLine("Quantidade de parcela" + P);
                        Console.WriteLine("valor por pacela:  " + valor / P);
                    }
                    else
                    {
                        Console.WriteLine(valor);
                    }
                }
                else if (N != 0 && N > 2)
                {
                    Console.WriteLine("quantidade de parcelas (todas as compras no carne tem um acrescimo de 9% de juros)");
                    int P = int.Parse(Console.ReadLine());
                    if (P > 1 && P <= 10)
                    {
                        double juro = (valor / 100) * 9;
                        Console.WriteLine("Total com juros = " + (valor + juro));
                        Console.WriteLine("Quantidade de parcela" + P);
                        Console.WriteLine("valor por pacela:  " + valor / P);
                    }
                    else
                    {
                        Console.WriteLine(valor);

                    }


                }

                Console.WriteLine("Obrigado Pela compra");


















            }

        }
    }
}
