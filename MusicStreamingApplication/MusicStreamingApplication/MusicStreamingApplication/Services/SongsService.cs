using MusicStreamingApplication.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MusicStreamingApplication.Services
{
    public class SongsService
    {
        private const string SongsApi = "https:7000/api/songs";
        public async Task<List<Songs>> GetAllSongs(int pageNumber, int pageSize)
        {
            HttpClient httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync($"{SongsApi}?pageNumer={ pageNumber}&pageSize={ pageSize}");

            return JsonConvert.DeserializeObject<List<Songs>>(json);
        }


        public async Task<List<Songs>> SearchSongs(string searchSongQuery)
        {
            HttpClient httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("https:7000/api/songs/SearchSongs?SearchSongQuery=" + searchSongQuery);

            return JsonConvert.DeserializeObject<List<Songs>>(json);
        }
    }
}
