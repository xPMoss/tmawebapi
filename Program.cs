using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Text.Json;
using System.Net;

namespace WebAPIClient
{
    class Program
    {
        private static readonly WebClient webClient = new WebClient();
        private static readonly HttpClient httpClient = new HttpClient();

        static async Task Main(string[] args)
        {
            //Movie movie = await GetMovieByID(10);
            //Console.WriteLine(movie.genres[0].name);
            //await GetTopRatedMovies();

            await GetTopRatedMovies();
            await Search("Zombie");
        }

    /*
        private static async Task ProcessTMDB()
        {
            //var json = webClient.DownloadString("https://api.themoviedb.org/3/movie/550?api_key=837510eb0be61188d342d8c49173bb6e");
            // Now parse with JSON.Net
            var json = await httpClient.GetStringAsync("https://api.themoviedb.org/3/movie/550?api_key=837510eb0be61188d342d8c49173bb6e");

            Movie movie = JsonSerializer.Deserialize<Movie>(json);

        }
*/

        private static async Task Search(string str)
        {
            string url = "https://api.themoviedb.org/3/search/movie?";
            url += "api_key=837510eb0be61188d342d8c49173bb6e";
            url += "&query=" + str;
            url += "&adult=false";

            var json = await httpClient.GetStreamAsync(url);

            SearchResult searchResult = await JsonSerializer.DeserializeAsync<SearchResult>(json);

            for (int i = 0; i < searchResult.results.Count; i++)
            {
                Console.WriteLine(searchResult.results[i].original_title);
                Console.WriteLine(searchResult.results[i].vote_average);
                
            }

            
            //Console.WriteLine(movies);

 
        }

        private static async Task GetTopRatedMovies()
        {
            //var json = webClient.DownloadString("https://api.themoviedb.org/3/movie/550?api_key=837510eb0be61188d342d8c49173bb6e");
            var json = await httpClient.GetStreamAsync("https://api.themoviedb.org/3/movie/top_rated?api_key=837510eb0be61188d342d8c49173bb6e");

            TopRatedMovies topRatedMovies = await JsonSerializer.DeserializeAsync<TopRatedMovies>(json);

            for (int i = 0; i < topRatedMovies.results.Count; i++)
            {
                Console.WriteLine(topRatedMovies.results[i].original_title);
                Console.WriteLine(topRatedMovies.results[i].vote_average);
                
            }

            
            //Console.WriteLine(movies);

 
        }

        private static async Task<Movie> GetMovieByID(int id)
        {
            //var json = webClient.DownloadString("https://api.themoviedb.org/3/movie/550?api_key=837510eb0be61188d342d8c49173bb6e");
            // Now parse with JSON.Net
            var json = await httpClient.GetStreamAsync("https://api.themoviedb.org/3/movie/" + id + "?api_key=837510eb0be61188d342d8c49173bb6e");

            Movie movie = await JsonSerializer.DeserializeAsync<Movie>(json);

            return movie;
            //Console.WriteLine(movies);

        }
        /*
        Search:
        https://api.themoviedb.org/3/search/movie?api_key=837510eb0be61188d342d8c49173bb6e&query=zombie

        Top Rated:
        https://api.themoviedb.org/3/movie/top_rated?api_key=837510eb0be61188d342d8c49173bb6e

        Image:
        https://image.tmdb.org/t/p/w500//rr7E0NoGKxvbkb89eR1GwfoYjpA.jpg

        Get provider:
        https://api.themoviedb.org/3/movie/550/watch/providers?api_key=837510eb0be61188d342d8c49173bb6e

        Trending:
        https://api.themoviedb.org/3/trending/movie/week?api_key=<<api_key>>
        https://api.themoviedb.org/3/trending/day/week?api_key=<<api_key>>

        */
        /*
        private static async Task ProcessRepositories()
        {
            var streamTask = httpClient.GetStreamAsync("https://api.github.com/orgs/dotnet/repos");
            var repositories = await JsonSerializer.DeserializeAsync<List<Repository>>(await streamTask);

            foreach (var repo in repositories){
                Console.WriteLine(repo.Name);
                //Console.WriteLine(repo.Description);

            }

        }
        */

    }


}
