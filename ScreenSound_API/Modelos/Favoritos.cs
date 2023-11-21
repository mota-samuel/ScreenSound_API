using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
namespace ScreenSound_API.Modelos;

internal class Favoritos
{
    public string? Nome { get; set; }
    public List<Musica> ListaDeMusicas { get; set; }

    public Favoritos(string nome)
    {
        Nome = nome;
        ListaDeMusicas = new List<Musica>(); 
    }

    public void AdicionarMusicasFavoritas(Musica musica)
    {
        ListaDeMusicas.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Essas sao as musicas favoritas --> {Nome}");
        foreach(var musicas in ListaDeMusicas)
        {
            Console.WriteLine($"-{musicas.Nome} do artista {musicas.Artista}");
        }
        Console.WriteLine("");
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musica = ListaDeMusicas
        });
        string nomeDoArquivo = $"musica_favoritas-{Nome}.json";

        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"O arquivo Json foi criado com sucesso. -- {Path.GetFullPath(nomeDoArquivo)}");
    }
}
