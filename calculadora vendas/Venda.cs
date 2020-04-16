using System;
using System.Collections.Generic;
using System.Text;


namespace calculadora_vendas
{
    class Venda
    {
        public string Vendedor;
        
        public int Produto;

        public double Valor;

        public Venda(string vendedor, string cliente, int produto, double valor)
        {
            Vendedor = vendedor;
        
            Produto = produto;
            Valor = valor;
        }




        public double Porcentagem_Desconto(double Porcentagem, double total)
        {
            Porcentagem = Valor / 100;
            total = Valor - Porcentagem;
            return total;
        }

       
        public override string ToString()
        {
            return  "Vendedor, "
                +Vendedor
                +", "
               
                +", "
                +"Produto"
                +Produto
                +", "
                +"Valor"
                +", R$ "
                +Valor;
        }

    }
}

