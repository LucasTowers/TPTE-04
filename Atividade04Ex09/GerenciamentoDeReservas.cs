using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade04Ex09
{
    public class GerenciamentoDeReservas
    {
        private List<ReservaDeRestaurante> reservas = new List<ReservaDeRestaurante>();

        public void AdicionarReserva(DateTime horario, int capacidade)
        {
            if (horario < DateTime.Now)
            {
                throw new ArgumentException("O horário da reserva não pode estar no passado.");
            }

            reservas.Add(new ReservaDeRestaurante(horario, capacidade));
        }

        public void FazerReserva(DateTime horario, int quantidadePessoas)
        {
            ReservaDeRestaurante reserva = EncontrarReservaPorHorario(horario);

            if (reserva == null)
            {
                throw new ArgumentException("Não há uma reserva para o horário especificado.");
            }

            reserva.FazerReserva(quantidadePessoas);
        }

        private ReservaDeRestaurante EncontrarReservaPorHorario(DateTime horario)
        {
            return reservas.Find(r => r.Horario == horario);
        }
    }
}
