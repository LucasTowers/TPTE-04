using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade04Ex01
{
    public class EstoqueDeProdutos
    {
        private int quantidadeProdutos;

        public EstoqueDeProdutos()
        {
            quantidadeProdutos = 0; // Inicializa o estoque com 0 produtos.
        }

        public int QuantidadeProdutos
        {
            get { return quantidadeProdutos; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A quantidade de produtos não pode ser negativa.");
                }
                quantidadeProdutos = value;
            }
        }

        // Outros métodos e propriedades relacionados ao estoque podem ser adicionados aqui.
    }
}
