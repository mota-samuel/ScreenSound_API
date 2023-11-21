using ScreenSound_API.Filtros;
using ScreenSound_API.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient()) //biblioteca que cria uma conexao(cliente) com o servidor, por padrao e sempre declarada desta forma
{
    try
    {
        /*como no arquivo json as respostas estao declaradas como string foi declarado uma variavel do tipo string
     para armazenar a resposta enviada pelo servidor*/
        /*a funcao AWAIT e devido ser uma execucao asincrona*/
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        // A deserializacao permite o Csharp manipilar as informacoes continas em um Json
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        musicas[1].ExibirDetalhesDaMusica();
        //Console.WriteLine(resposta);
        // LinqFilter.FiltrarGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtista(musicas);
        //LinqFilter.FiltrarArtistaPorGeneroMusical(musicas, "rock");
        //LinqFilter.FiltrarMusicaPorArtista(musicas, "Billie Eilish");
        //LinqFilter.FiltrarMusicasDoAno(musicas, "2018");

        //var musicasPreferidasMinha = new Favoritos("Samuel");
        //musicasPreferidasMinha.AdicionarMusicasFavoritas(musicas[1]);
        //musicasPreferidasMinha.AdicionarMusicasFavoritas(musicas[5]);
        //musicasPreferidasMinha.AdicionarMusicasFavoritas(musicas[145]);
        //musicasPreferidasMinha.AdicionarMusicasFavoritas(musicas[200]);
        //musicasPreferidasMinha.AdicionarMusicasFavoritas(musicas[52]);

        //musicasPreferidasMinha.ExibirMusicasFavoritas();

        //var musicasPreferidasX = new Favoritos("Samuel");
        //musicasPreferidasX.AdicionarMusicasFavoritas(musicas[9]);
        //musicasPreferidasX.AdicionarMusicasFavoritas(musicas[14]);
        //musicasPreferidasX.AdicionarMusicasFavoritas(musicas[212]);
        //musicasPreferidasX.AdicionarMusicasFavoritas(musicas[300]);
        //musicasPreferidasX.AdicionarMusicasFavoritas(musicas[720]);

        //musicasPreferidasX.ExibirMusicasFavoritas();

        // musicasPreferidasMinha.GerarArquivoJson();
        LinqFilter.FiltrarMusicasPorTom(musicas, "F#");
    }
    catch (Exception ex)//exessao|erro 
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
    
}
