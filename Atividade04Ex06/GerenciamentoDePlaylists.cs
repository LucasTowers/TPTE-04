using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade04Ex06
{
    public class GerenciamentoDePlaylists
    {
        private Dictionary<string, Playlist> playlists = new Dictionary<string, Playlist>();

        public void CriarPlaylist(string nome)
        {
            if (playlists.ContainsKey(nome))
            {
                throw new ArgumentException($"Já existe uma playlist com o nome '{nome}'.");
            }

            playlists[nome] = new Playlist();
        }

        public void AdicionarMusicaAPlaylist(string nomePlaylist, Musica musica)
        {
            if (!playlists.ContainsKey(nomePlaylist))
            {
                throw new ArgumentException($"A playlist '{nomePlaylist}' não existe.");
            }

            playlists[nomePlaylist].AdicionarMusica(musica);
        }
    }
}
