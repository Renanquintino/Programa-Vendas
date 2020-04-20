using System;
using System.Collections.Generic;
using System.Text;

namespace calculadora_vendas
{
    class Produto
    {
        public int Cod;
        public string Modelo;
       
        public string Marca;

        public Produto(int cod, string modelo,  string marca)
        {
            Cod = cod;
            Modelo = modelo;
          
            Marca = marca;
            
        }
    }
}
