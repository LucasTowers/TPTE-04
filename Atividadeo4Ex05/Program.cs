using Atividadeo04Ex05;

class Program
{
    static void Main(string[] args)
    {
        RegistroDeFuncionarios registro = new RegistroDeFuncionarios();

        try
        {
            registro.AdicionarFuncionario(1, "João");
            registro.AdicionarFuncionario(2, "Maria");
            registro.AdicionarFuncionario(1, "Pedro"); // Tentando adicionar um funcionário com ID duplicado
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}