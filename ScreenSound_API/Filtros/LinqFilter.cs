namespace ScreenSound_API.Filtros;

using System.Dynamic;
using System.Linq;
using ScreenSound_API.Modelos;

internal class LinqFilter
{
    public static void FiltrarGenerosMusicais(List<Musica>musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach(var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }

       
    }

    public static void FiltrarArtistaPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistaPorGenero = musicas.Where(musicas => musicas.Genero!.Contains(genero)).Select(musicas => musicas.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo os artistas por genero musical  >>>> {genero}");
        foreach (var artista in artistaPorGenero)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarMusicaPorArtista(List<Musica>musicas, string artista) 
    {
        var musicaPorArtista = musicas.Where(musicas => musicas.Artista!.Equals(artista)).ToList();
        //var musicaPorArtista = musicas.Where(musicas => musicas.Artista!.Contains(artista)).Select(musicas => musicas.Nome).Distinct().ToList();
        Console.WriteLine($"Musicas do Artista >>>{artista}<<<");
        foreach (var musica in musicaPorArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }

    public static void FiltrarMusicasDoAno(List<Musica>musicas,string ano)
    {
        var musicasDoAno = musicas.Where(musicas => musicas.Ano!.Equals(ano)).Distinct().ToList();
        Console.WriteLine($"Musicas do Ano : {ano}");
        foreach(var musica in musicasDoAno)
        {
            Console.WriteLine($"- {musica.Nome} do artista {musica.Artista}");
        }
    }

    public static void FiltrarMusicasPorTom(List<Musica>musicas, string nota)
    {
        var musicasTonalidade = musicas.Where(musicas => musicas.Tom.Equals(nota)).Select(musicas => musicas.Nome).Distinct().ToList();
        Console.WriteLine($"\n Musicas na tonalidade de {nota}");
        foreach(var musica in musicasTonalidade)
        {
            Console.WriteLine($"-- {musica}");
        }
    }
}
