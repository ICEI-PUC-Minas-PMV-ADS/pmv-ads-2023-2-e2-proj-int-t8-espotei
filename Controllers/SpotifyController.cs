using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Espotei.Models;

namespace Espotei.Controllers
{
    [Route("espotei/spotify")]
    [ApiController]
    public class SpotifyController : ControllerBase
    {
        private readonly HttpClient _httpClient;
        private const string SpotifyApiBase = "https://api.spotify.com/v1/";
        private const string clientSecret = "CLIENT_SECRET";

        public SpotifyController()
        {
            _httpClient = new HttpClient();
        }

        [HttpGet("topTracks/{clientID}")]
        public async Task<ActionResult<string>> GetTopTracks(string clientID)
        {
            try
            {
                string endpoint = $"me/top/tracks?limit=5";
                string auth = Convert.ToBase64String(Encoding.UTF8.GetBytes(clientID + ":" + clientSecret));

                var request = new HttpRequestMessage(HttpMethod.Get, SpotifyApiBase + endpoint);
                request.Headers.Authorization = new AuthenticationHeaderValue("Basic", auth);

                var response = await _httpClient.SendAsync(request);

                response.EnsureSuccessStatusCode();

                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("criar-playlist/{clientID}")]
        public async Task<ActionResult<string>> CreatePlaylist([FromBody] string[] trackIds, string clientID)
        {
            try
            {
                string userId = "";
                string playlistName = "TOP TRACKS";
                string endpoint = $"users/{userId}/playlists";
                dynamic requestObject = new System.Dynamic.ExpandoObject();
                requestObject.name = playlistName;
                requestObject.isPublic = false; // campo nomeado "public" é palavra reservada no C#

                var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(requestObject), Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync(SpotifyApiBase + endpoint, content);

                if (response.IsSuccessStatusCode)
                {
                    string playlistResponse = await response.Content.ReadAsStringAsync();
                    JObject playlistData = JObject.Parse(playlistResponse);
                    string playlistId = playlistData["id"].ToString();

                    endpoint = $"playlists/{playlistId}/tracks";
                    var trackRequestObject = new
                    {
                        uris = trackIds,
                    };

                    content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(trackRequestObject), Encoding.UTF8, "application/json");
                    response = await _httpClient.PostAsync(SpotifyApiBase + endpoint, content);

                    if (response.IsSuccessStatusCode)
                    {
                        return Ok($"Playlist created with tracks: {string.Join(", ", trackIds)}");
                    }
                    else
                    {
                        return BadRequest("Failed to create the playlist.");
                    }
                }
                else
                {
                    return BadRequest("Failed to add tracks to the playlist.");
                }            
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}