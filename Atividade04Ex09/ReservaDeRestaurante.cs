using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade04Ex09
{
    public class ReservaDeRestaurante
    {
        public DateTime Horario { get; }
        public int Capacidade { get; }
        public int ReservasFeitas { get; private set; }

        public ReservaDeRestaurante(DateTime horario, int capacidade)
        {
            if (capacidade <= 0)
            {
                throw new ArgumentException("A capacidade do restaurante deve ser maior que zero.");
            }

            Horario = horario;
            Capacidade = capacidade;
            ReservasFeitas = 0;
        }

        public void FazerReserva(int quantidadePessoas)
        {
            if (quantidadePessoas <= 0)
            {
                throw new ArgumentException("A quantidade de pessoas na reserva deve ser maior que zero.");
            }

            if (ReservasFeitas + quantidadePessoas > Capacidade)
            {
                throw new InvalidOperationException("A capacidade do restaurante foi excedida. Não é possível fazer mais reservas para este horário.");
            }

            ReservasFeitas += quantidadePessoas;
        }
    }
}
