using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade04Ex02
{
    public class AvaliacaoDeAluno
    {
        private double nota;

        public AvaliacaoDeAluno()
        {
            nota = 0; // Inicializa a nota com 0.
        }

        public double Nota
        {
            get { return nota; }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("A nota deve estar entre 0 e 10.");
                }
                nota = value;
            }
        }
    }
}
