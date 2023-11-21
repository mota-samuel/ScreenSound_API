using System.Text.Json.Serialization;

namespace ScreenSound_API.Modelos;

internal class Musica
{
    [JsonPropertyName("song")]//referenciando atributo que representa um metadado para a propriedade nome
    public string? Nome { get; set; }
    [JsonPropertyName("artist")]
    public string? Artista { get; set; }
    [JsonPropertyName("duration_ms")]
    public int? Duracao { get; set; }
    [JsonPropertyName("genre")]
    public string? Genero { get; set; }
    [JsonPropertyName("year")]
    public string? Ano { get; set; }
    [JsonPropertyName("key")]
    public int Key { get; set; }
    public string Tom {
        get
        {
            return notas[Key];
        }
    }
    private List<string> notas= new List<string> { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B"};

    public void ExibirDetalhesDaMusica() 
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Musica: {Nome}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Duracao: {Duracao/1000}");
        Console.WriteLine($"Genero: {Genero}");
        Console.WriteLine($"Tom: {Tom}");
    }
}
