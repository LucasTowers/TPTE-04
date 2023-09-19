using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividadeo04Ex05
{
    public class Funcionario
    {
        public int Id { get; }
        public string Nome { get; }

        public Funcionario(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
