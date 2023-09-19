using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade04Ex04
{
    public class GerenciamentoDeBiblioteca
    {
        private List<Livro> acervo = new List<Livro>();

        public void AdicionarLivro(string titulo)
        {
            acervo.Add(new Livro(titulo));
        }

        public void EmprestarLivro(string titulo)
        {
            Livro livro = EncontrarLivroPorTitulo(titulo);

            if (livro == null)
            {
                throw new ArgumentException($"O livro '{titulo}' não está no acervo da biblioteca.");
            }

            if (!livro.EstaDisponivel)
            {
                throw new InvalidOperationException($"O livro '{titulo}' já está emprestado.");
            }

            livro.EstaDisponivel = false;
        }

        public void DevolverLivro(string titulo)
        {
            Livro livro = EncontrarLivroPorTitulo(titulo);

            if (livro == null)
            {
                throw new ArgumentException($"O livro '{titulo}' não está no acervo da biblioteca.");
            }

            if (livro.EstaDisponivel)
            {
                throw new InvalidOperationException($"O livro '{titulo}' já está disponível na biblioteca.");
            }

            livro.EstaDisponivel = true;
        }

        private Livro EncontrarLivroPorTitulo(string titulo)
        {
            return acervo.Find(livro => livro.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
        }
    }
}
