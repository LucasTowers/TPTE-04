using Atividade04Ex06;

class Program
{
    static void Main(string[] args)
    {
        GerenciamentoDePlaylists gerenciador = new GerenciamentoDePlaylists();

        gerenciador.CriarPlaylist("Rock Classics");
        gerenciador.CriarPlaylist("Chill Out");

        Musica musica1 = new Musica("Bohemian Rhapsody");
        Musica musica2 = new Musica("Hotel California");
        Musica musica3 = new Musica("Bohemian Rhapsody");

        try
        {
            gerenciador.AdicionarMusicaAPlaylist("Rock Classics", musica1);
            gerenciador.AdicionarMusicaAPlaylist("Chill Out", musica2);
            gerenciador.AdicionarMusicaAPlaylist("Chill Out", musica3); // Tentando adicionar a mesma música novamente
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