using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace GestaoProduto
{
    class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = 0;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1) ;
            }
        }     

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProduto(int qte)
        {
            Quantidade = Quantidade + qte;
        }

        public void RemoverProduto(int qte)
        {
            Quantidade = Quantidade - qte;
        }

        public override string ToString()
        {
            return $"{Nome}, R${Preco.ToString("F2", CultureInfo.InvariantCulture)}, " +
                $"{Quantidade} unidades, Total: R$ R${ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
