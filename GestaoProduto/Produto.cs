using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace GestaoProduto
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public Produto(string nome, double preco)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = 0;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1) ;
            }
        }

        public double Preco
        {
            get { return _preco; }
           
        }

        public int Quantidade
        {
            get { return _quantidade; }

        }


        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProduto(int qte)
        {
            _quantidade = _quantidade + qte;
        }

        public void RemoverProduto(int qte)
        {
            _quantidade = _quantidade - qte;
        }

        public override string ToString()
        {
            return $"{Nome}, R${_preco.ToString("F2", CultureInfo.InvariantCulture)}, " +
                $"{_quantidade} unidades, Total: R$ R${ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
