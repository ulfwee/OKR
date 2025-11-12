using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

public class AnimeResponse
{
    public List<Anime> data { get; set; } = new();
}

public class Anime
{
    public int mal_id { get; set; }
    public string title { get; set; } = string.Empty;
    public string title_japanese { get; set; } = string.Empty;
    public string type { get; set; } = string.Empty;
    public int? episodes { get; set; }
    public double? score { get; set; }
    public string url { get; set; } = string.Empty;
}

class Program
{
    static readonly HttpClient client = new HttpClient();

    static async Task Main()
    {
        try
        {
            Console.WriteLine("Запит до Jikan API...");
            using HttpResponseMessage response = await client.GetAsync("https://api.jikan.moe/v4/anime?q=naruto");
            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();
            Console.WriteLine("\nRaw JSON:");
            Console.WriteLine(json.Substring(0, Math.Min(400, json.Length)) + "...\n");

            AnimeResponse? result = JsonSerializer.Deserialize<AnimeResponse>(json);

            if (result != null && result.data.Count > 0)
            {
                Console.WriteLine("Розпарсені дані (перші 3 результати):\n");

                for (int i = 0; i < Math.Min(3, result.data.Count); i++)
                {
                    var anime = result.data[i];
                    Console.WriteLine($"Назва: {anime.title}");
                    Console.WriteLine($"Японська назва: {anime.title_japanese}");
                    Console.WriteLine($"Тип: {anime.type}");
                    Console.WriteLine($"Епізодів: {anime.episodes}");
                    Console.WriteLine($"Оцінка: {anime.score}");
                    Console.WriteLine($"URL: {anime.url}");
                    Console.WriteLine(new string('-', 60));
                }
            }
            else
            {
                Console.WriteLine("Не вдалося розпарсити JSON або немає результатів.");
            }
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine("\nПомилка запиту!");
            Console.WriteLine("Повідомлення: " + e.Message);
        }
    }
}
