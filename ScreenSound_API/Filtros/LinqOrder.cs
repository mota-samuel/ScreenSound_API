namespace ScreenSound_API.Filtros;
using ScreenSound_API.Modelos;
using System.ComponentModel;

internal class LinqOrder
{
    public static void ExibirListaDeArtista(List<Musica>musicas)
    {
        var artistaOrdenados = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine("Lista de Artistas Ordenados");
        foreach(var artista in artistaOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }
    }

   
}
