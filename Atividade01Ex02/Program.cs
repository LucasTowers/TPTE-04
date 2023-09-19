using Atividade04Ex02;

class Program
{
    static void Main(string[] args)
    {
        AvaliacaoDeAluno aluno = new AvaliacaoDeAluno();

        try
        {
            Console.Write("Digite a nota do aluno: ");
            double nota = Convert.ToDouble(Console.ReadLine());

            aluno.Nota = nota;

            Console.WriteLine($"A nota do aluno é: {aluno.Nota}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}