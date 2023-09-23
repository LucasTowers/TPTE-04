using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade04Ex08
{
    public class GerenciamentoDeEstacionamento
    {
        private int capacidade;
        private int vagasDisponiveis;

        public GerenciamentoDeEstacionamento(int capacidadeEstacionamento)
        {
            if (capacidadeEstacionamento <= 0)
            {
                throw new ArgumentException("A capacidade do estacionamento deve ser maior que zero.");
            }

            capacidade = capacidadeEstacionamento;
            vagasDisponiveis = capacidadeEstacionamento; // Inicializa todas as vagas como disponíveis.
        }

        public void EstacionarCarro()
        {
            if (vagasDisponiveis == 0)
            {
                throw new InvalidOperationException("O estacionamento está lotado. Não é possível estacionar mais carros.");
            }

            vagasDisponiveis--;
        }

        public void SairDoEstacionamento()
        {
            if (vagasDisponiveis == capacidade)
            {
                throw new InvalidOperationException("O estacionamento já está vazio. Não é possível sair.");
            }

            vagasDisponiveis++;
        }

        public int VagasDisponiveis
        {
            get { return vagasDisponiveis; }
        }
    }
}
