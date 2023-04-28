using TranieeLibrary;
using System.Net.Http.Json;
namespace WebAssDB.Services
{
    public class TrenieeDataServices : ITrenieeDataServices
    {
        public HttpClient HttpClient { get; }

        public TrenieeDataServices(HttpClient httpClient) {
            HttpClient = httpClient;
        }


        public async Task AddTreniee(Treniee treniee)
        {
             await HttpClient.PostAsJsonAsync<Treniee>("/api/Treniees",treniee);

        }

        public async Task DeleteTreniee(int trenieeId)
        {
             await HttpClient.DeleteAsync("/api/Treniees"+trenieeId);

        }

        public async Task<IEnumerable<Treniee>> GetAllTreniees()
        {
            return await HttpClient.GetFromJsonAsync<IEnumerable<Treniee>>("/api/Treniees");
        }

        public async Task<Treniee> GetTrenieeDetails(int trenieeId)
        {
            return await HttpClient.GetFromJsonAsync<Treniee>("/api/Treniees"+trenieeId);

        }

        public async Task UpdateTreniee(Treniee treniee)
        {
             await HttpClient.PutAsJsonAsync<Treniee>("/api/Treniees"+treniee.TraineeId,treniee);

        }
    }
}
