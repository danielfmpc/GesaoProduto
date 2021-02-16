using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace GestaoProduto
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

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
