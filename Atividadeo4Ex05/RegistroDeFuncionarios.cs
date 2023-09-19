using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividadeo04Ex05
{
    public class RegistroDeFuncionarios
    {
        private List<Funcionario> funcionarios = new List<Funcionario>();

        public void AdicionarFuncionario(int id, string nome)
        {
            if (FuncionarioComIdDuplicado(id))
            {
                throw new InvalidOperationException($"Já existe um funcionário com o ID {id}.");
            }

            funcionarios.Add(new Funcionario(id, nome));
        }

        private bool FuncionarioComIdDuplicado(int id)
        {
            return funcionarios.Exists(funcionario => funcionario.Id == id);
        }
    }
}
