using Atividade04Ex04;

class Program
{
    static void Main(string[] args)
    {
        GerenciamentoDeBiblioteca biblioteca = new GerenciamentoDeBiblioteca();

        biblioteca.AdicionarLivro("Dom Casmurro");
        biblioteca.AdicionarLivro("A Moreninha");

        try
        {
            biblioteca.EmprestarLivro("Dom Casmurro");
            biblioteca.DevolverLivro("Dom Casmurro");
            biblioteca.EmprestarLivro("Dom Casmurro"); // Tentando emprestar novamente
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}