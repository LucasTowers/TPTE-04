using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade04Ex06
{
    public class Playlist
    {
        private List<Musica> musicas = new List<Musica>();

        public void AdicionarMusica(Musica musica)
        {
            if (MusicaDuplicada(musica))
            {
                throw new InvalidOperationException($"A música '{musica.Titulo}' já está na playlist.");
            }

            musicas.Add(musica);
        }

        private bool MusicaDuplicada(Musica musica)
        {
            return musicas.Exists(m => m.Titulo.Equals(musica.Titulo, StringComparison.OrdinalIgnoreCase));
        }
    }
}
