using System;
using System.Collections.Generic;
using System.Text;

namespace calculadora_vendas
{
    class Produto
    {
        public int Cod;
        public string Modelo;
        public int Tamanho;

        public string Marca;

        public Produto(int cod, string modelo, int tamanho, string marca)
        {
            Cod = cod;
            Modelo = modelo;
            Tamanho = tamanho;
            Marca = marca;
            
        }
    }
}
