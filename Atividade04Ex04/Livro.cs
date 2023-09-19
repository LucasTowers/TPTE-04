using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade04Ex04
{
    public class Livro
    {
        public string Titulo { get; }
        public bool EstaDisponivel { get; set; }

        public Livro(string titulo)
        {
            Titulo = titulo;
            EstaDisponivel = true; // Inicializa o livro como disponível.
        }
    }
}
