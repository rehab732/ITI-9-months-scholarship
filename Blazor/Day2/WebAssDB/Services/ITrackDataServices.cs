using TranieeLibrary;

namespace WebAssDB.Services
{
    public interface ITrackDataServices
    {
        Task<IEnumerable<Track>> GetAllTracks();
        Task<Track> GetTraccckDetails(int trackId);
        Task AddTreniee(Track track);
        Task UpdateTreniee(Track track);

        Task DeleteTreniee(int trackId);

    }
}
