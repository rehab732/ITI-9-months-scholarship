using System.Net.Http.Json;
using TranieeLibrary;

namespace WebAssDB.Services
{

    public class TrackDataServices : ITrackDataServices
    {

        public HttpClient HttpClient { get; }

        public TrackDataServices(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        public async Task AddTreniee(Track track)
        {
            await HttpClient.PostAsJsonAsync<Track>("/api/Tracks", track);

        }

        public async Task DeleteTreniee(int trackId)
        {
            await HttpClient.DeleteAsync("/api/Tracks" + trackId);

        }

        public async Task<IEnumerable<Track>> GetAllTracks()
        {
            return await HttpClient.GetFromJsonAsync<IEnumerable<Track>>("/api/Tracks");

        }

        public async Task<Track> GetTraccckDetails(int trackId)
        {
            return await HttpClient.GetFromJsonAsync<Track>("/api/Tracks" + trackId);

        }

        public async Task UpdateTreniee(Track track)
        {
            await HttpClient.PutAsJsonAsync<Track>("/api/Tracks" + track.TrackId, track);

        }
    }
}
