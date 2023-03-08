using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace WebAPIClient
{
    public class Movie
    {
        [JsonPropertyName("adult")]
        public bool adult { get; set; }
        
        [JsonPropertyName("backdrop_path")]
        public string backdrop_path { get; set; }

        [JsonPropertyName("belongs_to_collection")]
        public string belongs_to_collection { get; set; }

        [JsonPropertyName("budget")]
        public int budget { get; set; }

        [JsonPropertyName("genres")]
        public List<Genre> genres { get; set; }


        //public string[] Errors { get; set; }
        //genres (id, name)

        public string homepage { get; set; }

        //id (int)
        //imdb_id (int)
        //original_language

        public string original_title { get; set; }
        public string overview { get; set; }
        
        //popularity (int)

        public string poster_path { get; set; }

        //production_companies <List>(id, logo_path, name, origin_country) 
        //production_countries <List>(iso_3166_1, name) 
        //release_date (date)
        //revenue (int)
        //runtime (int)
        //spoken_languages <List>(english_name, iso_639_1, name) 
        //status (string)
        //tagline (string)
        //title (string)
        //video (bool)

        [JsonPropertyName("vote_average")]
        public float vote_average { get; set; }

        //vote_average (float)
        //vote_count (int)

        /*
        {
            "adult":false,
            "backdrop_path":"/rr7E0NoGKxvbkb89eR1GwfoYjpA.jpg",
            "belongs_to_collection":null,
            "budget":63000000,
            "genres":[{
                "id":18,
                "name":"Drama"
                }],
            "homepage":"http://www.foxmovies.com/movies/fight-club",
            "id":550,
            "imdb_id":"tt0137523",
            "original_language":"en",
            "original_title":"Fight Club",
            "overview":"A ticking-time-bomb insomniac and a slippery soap salesman channel primal male aggression into a shocking new form of therapy. Their concept catches on, with underground \"fight clubs\" forming in every town, until an eccentric gets in the way and ignites an out-of-control spiral toward oblivion.",
            "popularity":45.329,
            "poster_path":"/pB8BM7pdSp6B6Ih7QZ4DrQ3PmJK.jpg",
            "production_companies"
                [{
                    "id":508,"logo_path":"/7PzJdsLGlR7oW4J0J5Xcd0pHGRg.png",
                    "name":"Regency Enterprises",
                    "origin_country":"US"
                    },
                    {
                    "id":711,"logo_path":"/tEiIH5QesdheJmDAqQwvtN60727.png",
                    "name":"Fox 2000 Pictures",
                    "origin_country":"US"
                    },
                    {
                        "id":20555,
                        "logo_path":"/hD8yEGUBlHOcfHYbujp71vD8gZp.png",
                        "name":"Taurus Film",
                        "origin_country":"DE"},
                    {
                        "id":54051,"logo_path":null,
                        "name":"Atman Entertainment",
                        "origin_country":""
                    },
                    {
                        "id":54052,"logo_path":null,
                        "name":"Knickerbocker Films",
                        "origin_country":"US"
                    },
                    {
                        "id":25,"logo_path":"/qZCc1lty5FzX30aOCVRBLzaVmcp.png",
                        "name":"20th Century Fox","origin_country":"US"
                    },
                    {
                        "id":4700,"logo_path":"/A32wmjrs9Psf4zw0uaixF0GXfxq.png",
                        "name":"The Linson Company"
                        ,"origin_country":"US"
                }],
        "production_countries":
            [{
                "iso_3166_1":"DE",
                "name":"Germany"
                },
                {
                "iso_3166_1":"US",
                "name":"United States of America"
            }],
        "release_date":"1999-10-15",
        "revenue":100853753,
        "runtime":139,
        "spoken_languages":
            [{
                "english_name":"English",
                "iso_639_1":"en",
                "name":"English"
            }],
        "status":"Released",
        "tagline":"Mischief. Mayhem. Soap.",
        "title":"Fight Club",
        "video":false,
        "vote_average":8.4,
        "vote_count":22184
        }
        */

    }

    public class Genre
    {
        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("name")]
        public string name { get; set; }


    }


    public class TopRatedMovies
    {
        [JsonPropertyName("page")]
        public int page { get; set; }

        [JsonPropertyName("results")]
        public List<Movie> results { get; set; }


    }

    public class SearchResult
    {
        [JsonPropertyName("page")]
        public int page { get; set; }

        [JsonPropertyName("results")]
        public List<Movie> results { get; set; }


    }



}