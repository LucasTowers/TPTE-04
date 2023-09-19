using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade04Ex03
{
    public class ReservaDeVoo
    {
        private int capacidade;
        private int assentosReservados;

        public ReservaDeVoo(int capacidadeInicial)
        {
            if (capacidadeInicial <= 0)
            {
                throw new ArgumentException("A capacidade deve ser maior que zero.");
            }

            capacidade = capacidadeInicial;
            assentosReservados = 0; // Inicializa o número de assentos reservados com zero.
        }

        public int AssentosReservados
        {
            get { return assentosReservados; }
        }

        public int Capacidade
        {
            get { return capacidade; }
        }

        public void ReservarAssentos(int quantidade)
        {
            if (quantidade < 0)
            {
                throw new ArgumentException("A quantidade de assentos a serem reservados não pode ser negativa.");
            }

            if (assentosReservados + quantidade > capacidade)
            {
                throw new InvalidOperationException("A capacidade do avião foi excedida. Não é possível reservar mais assentos.");
            }

            assentosReservados += quantidade;
        }

        // Outros métodos e propriedades relacionados à reserva de voos podem ser adicionados aqui.
    }
}
